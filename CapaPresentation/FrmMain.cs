using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CapaDomain;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using HtmlAgilityPack;
using System.Diagnostics;
using CapaEntity;
using CapaEntity.Cache;
using System.Security.Cryptography;
using CapaData;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using System.Threading;
using Google.Apis.Drive.v3.Data;
using System.Runtime.InteropServices;
using System.Configuration;
using DinkToPdf;
using iTextSharp.text.html.simpleparser;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using TheArtOfDev.HtmlRenderer.PdfSharp;


namespace CapaPresentation
{
    public partial class FrmMain : Form
    {
        CDo_Procedures procedures = new CDo_Procedures();
        CDo_Students students = new CDo_Students();
        CDo_Ceptro ceptro = new CDo_Ceptro();
        Ceptro objCeptro;
        List<Student> listCeptro;
        CDo_Tuition tuitions = new CDo_Tuition();
        List<CE_Tuition> listTuition;
        CE_Tuition tuition;
        List<SpecialtyXteachingUnit> listSpecialtyXteachingUnits;
        List<CE_Specialty> listSpecialties;
        List<CE_TeachingUnit> listTeachingUnits;
        CDo_Specialties specialties = new CDo_Specialties();
        CDo_TeachingUnits teachingUnits = new CDo_TeachingUnits();
        byte[] dniPdf;

        FrmSincronic loadingForm = new FrmSincronic();


        public FrmMain()
        {
            InitializeComponent();
    
            CustomizeDesing();
      


        }
       
        
        private void DeleteTokenFile()
        {
           
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            string credPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "token.json");

            // Eliminar la carpeta de token si existe
            if (System.IO.Directory.Exists(credPath))
            {
                try
                {
                    System.IO.Directory.Delete(credPath, true); // Eliminar la carpeta y su contenido
                    //MessageBox.Show("TOKEN ELIMINADO CORRECTAMENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la carpeta de token: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Close();
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }

        private async Task DownloadAndReplaceLocalDatabaseFileAsync()
        {

            UserCredential credential;
                string exePath = AppDomain.CurrentDomain.BaseDirectory;

                // Obtener la ruta del proyecto base
                string projectPath = Directory.GetParent(exePath).Parent.Parent.FullName;

                // Ruta donde se descargará el archivo desde Google Drive
                string downloadFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "databaseCeptro.db");

                // Ruta donde se copiará el archivo descargado localmente
                string localFilePath = ConfigurationManager.AppSettings["DatabasePath"]; // Obtener la ruta desde App.config
                string appDataPath = Environment.ExpandEnvironmentVariables(localFilePath);

                string credentialsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "credencialesCetpro.json");

                // Cargar credenciales
                using (var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read))
                {
                    string credPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "token.json");
                    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true));
                }

                // Inicializar el servicio de Google Drive
                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                // Buscar archivos cuyo nombre sea 'databaseCeptro.db' en la carpeta específica y ordenar por fecha de modificación descendente
                var listRequest = service.Files.List();
                listRequest.Q = $"name = 'databaseCeptro.db' and '{folderId}' in parents";
                listRequest.Spaces = "drive";
                listRequest.Fields = "files(id, name, modifiedTime)";
                listRequest.OrderBy = "modifiedTime desc";
                listRequest.PageSize = 1;

                var files = await listRequest.ExecuteAsync();

                if (files.Files.Count > 0)
                {
                    var file = files.Files[0];
                    var request = service.Files.Get(file.Id);

                    // Eliminar el archivo local existente si ya existe
                    if (System.IO.File.Exists(appDataPath))
                    {
                        try
                        {
                            System.IO.File.Delete(appDataPath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el archivo local: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Descargar el archivo desde Google Drive
                    using (var memoryStream = new MemoryStream())
                    {
                        await request.DownloadAsync(memoryStream);
                        using (var fileStream = new FileStream(downloadFilePath, FileMode.Create, FileAccess.Write))
                        {
                            memoryStream.WriteTo(fileStream);
                        }
                    }

                    // Copiar el archivo descargado al directorio local
                    try
                    {
                        System.IO.File.Copy(downloadFilePath, appDataPath);
                        loadingForm.Close();
                        
                        MessageBox.Show($"Se sincronizó correctamente", "Operación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Restablecer el cursor al modo predeterminado

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al copiar el archivo localmente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo no se encontró en la carpeta de Google Drive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

               
        }
        private async Task DownloadLatestDatabaseFileFromDriveAsync()
        {
           
            UserCredential credential;
            string exePath = AppDomain.CurrentDomain.BaseDirectory;

            // Obtener la ruta del proyecto base
            string projectPath = Directory.GetParent(exePath).Parent.Parent.FullName;

            // Construir la ruta completa del archivo que deseas descargar
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "databaseCeptro.db");

            string credentialsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "credencialesCetpro.json");

            // Cargar credenciales
            using (var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read))
            {
                string credPath = Path.Combine(projectPath, "token.json");
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true));
            }

            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Buscar archivos cuyo nombre sea 'databaseCeptro.db' en la carpeta específica y ordenar por fecha de modificación descendente
            var listRequest = service.Files.List();
            listRequest.Q = $"name = 'databaseCeptro.db' and '{folderId}' in parents";
            listRequest.Spaces = "drive";
            listRequest.Fields = "files(id, name, modifiedTime)";
            listRequest.OrderBy = "modifiedTime desc";
            listRequest.PageSize = 1;

            var files = await listRequest.ExecuteAsync();

            if (files.Files.Count > 0)
            {
                var file = files.Files[0];
                var request = service.Files.Get(file.Id);

                // Eliminar el archivo existente localmente si ya existe
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }

                // Descargar el archivo
                using (var memoryStream = new MemoryStream())
                {
                    await request.DownloadAsync(memoryStream);
                    using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        memoryStream.WriteTo(fileStream);
                    }
                }

                // Mostrar un mensaje con el nombre del archivo y la fecha de modificación
                //MessageBox.Show($"Archivo descargado: {file.Name}\nÚltima modificación: {file.ModifiedTime}", "Operación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El archivo no se encontró en la carpeta de Google Drive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
          
            if (InformationUser.Rol == "Director")
            {

            }else if (InformationUser.Rol == "Docente")
            {

                btnSpecialties.Enabled = false;
                btnTeachingUnit.Enabled = false;
                btnInfoUsers.Enabled = false;

            }
            else if (InformationUser.Rol == "Auxiliar")
            {


                btnSpecialties.Enabled = false;
                btnTeachingUnit.Enabled = false;
                btnInfoUsers.Enabled = false;
            }
            LoadCeptro();
            LoadStudents();

            // Ajustar el tamaño del formulario para que coincida con la pantalla del monitor
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.MinimumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);


            // Permitir cambiar el tamaño del formulario
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Crear y mostrar el cuadro de mensaje
            DialogResult result = MessageBox.Show("¿Desea sincronizar con Drive?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Evaluar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                loadingForm.Show();
                loadingForm.Refresh(); // Asegúrate de que el formulario se renderice correctamente
                DownloadLatestDatabaseFileFromDriveAsync();
                DownloadAndReplaceLocalDatabaseFileAsync();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Estarás trabajando localmente.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            



        }
        private void LoadCeptro()
        {
            objCeptro = ceptro.LoadListCeptro();
            listTuition = tuitions.LoadListTuitions();
            listSpecialties = specialties.LoadListSpecialties();
            listSpecialtyXteachingUnits = procedures.LoadListSpecialtyXteachingUnit();

            
     
        }
        private void cargarUsuario()
        {
            txtName.Text = InformationUser.UserName;
            txtRol.Text = InformationUser.Rol;
  
        }
        private void LoadStudents()
        {
            listCeptro= students.LoadStudents();
            cargarUsuario();
        }
        private void CustomizeDesing()
        {
            panelCetpro.Visible = false;
            panelStudent.Visible = false;
            panelUser.Visible = false;
            panelMatricula.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelCetpro.Visible == true)
            {
                panelCetpro.Visible = false;
            }
            if (panelStudent.Visible == true)
            {
                panelStudent.Visible = false;
            }
            if(panelUser.Visible == true)
            {
                panelUser.Visible = false;
            }
            if (panelMatricula.Visible == true)
            {
                panelMatricula.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void StudentsForm_FormClosed(object sender, EventArgs e)
        {
            LoadStudents(); // Recargar los datos del gráfico cuando se cierra FrmSales
        }
        private void CeptroForm_FormClosed(object sender, EventArgs e)
        {
            LoadCeptro(); // Recargar los datos del gráfico cuando se cierra FrmSales
        }
        private void TuitionForm_FormClosed(object sender, EventArgs e)
        {
            LoadCeptro(); // Recargar los datos del gráfico cuando se cierra FrmSales
           
        }
        private void btnShowReport_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Ingrese el dni porfavor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtener el contenido HTML desde los recursos
            string paginahtml_texto = Properties.Resources.plantilla;
            paginahtml_texto = paginahtml_texto.Replace("@NombreCetpro", objCeptro.Name);
            paginahtml_texto = paginahtml_texto.Replace("@CodigoModular", objCeptro.CodeModular);
            paginahtml_texto = paginahtml_texto.Replace("@TipoGestion", objCeptro.ManagementType);
            paginahtml_texto = paginahtml_texto.Replace("@Ugel", objCeptro.Ugel);
            paginahtml_texto = paginahtml_texto.Replace("@ResolucionAuth", objCeptro.ResolutionAuth);
            paginahtml_texto = paginahtml_texto.Replace("@PrestaServicio", objCeptro.PlaceService);
            paginahtml_texto = paginahtml_texto.Replace("@Departamento", objCeptro.Departament);
            paginahtml_texto = paginahtml_texto.Replace("@Provincia", objCeptro.Province);
            paginahtml_texto = paginahtml_texto.Replace("@Email", objCeptro.Email);
   
            paginahtml_texto = paginahtml_texto.Replace("@ResolucionProgram", objCeptro.ResolutionAuthProgram);
            paginahtml_texto = paginahtml_texto.Replace("@Distrito", objCeptro.District);
            paginahtml_texto = paginahtml_texto.Replace("@Telefono", objCeptro.Phone);
            paginahtml_texto = paginahtml_texto.Replace("@Direccion", objCeptro.Direction);
            paginahtml_texto = paginahtml_texto.Replace("@PaginaWeb", objCeptro.PageWeb);
    
            paginahtml_texto = paginahtml_texto.Replace("@cetpro", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources","cetpropgn.png"));
            paginahtml_texto = paginahtml_texto.Replace("@logo", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "imagenti.png"));

            bool studentFound = false;
            foreach (var student in listCeptro)
            {
                if (txtDni.Text == student.Dni)
                {
                    studentFound = true;

                    paginahtml_texto = paginahtml_texto.Replace("@Año", student.Year);
                    paginahtml_texto = paginahtml_texto.Replace("@CodigoInscripcion", student.RegistrationCode);
                    paginahtml_texto = paginahtml_texto.Replace("@Paterno", student.FirstSurtname);
                    paginahtml_texto = paginahtml_texto.Replace("@Materno", student.SecondSurtname);
                    paginahtml_texto = paginahtml_texto.Replace("@Name", student.FirstName);
                    paginahtml_texto = paginahtml_texto.Replace("@Sexo", student.Sex);
                    paginahtml_texto = paginahtml_texto.Replace("@FechaNac", student.DateBirth.ToString());
                    paginahtml_texto = paginahtml_texto.Replace("@Edad", student.Age.ToString());
                    paginahtml_texto = paginahtml_texto.Replace("@DocIdent", student.Dni);
                    paginahtml_texto = paginahtml_texto.Replace("@Pais", student.Country);
                    paginahtml_texto = paginahtml_texto.Replace("@LugarNac", student.PlaceBirth);
                    paginahtml_texto = paginahtml_texto.Replace("@DistrictStudent", student.District);
                    paginahtml_texto = paginahtml_texto.Replace("@ProvinceStudent", student.Province);
                    paginahtml_texto = paginahtml_texto.Replace("@Region", student.Region);
                    paginahtml_texto = paginahtml_texto.Replace("@EstadoCivil", student.CivilStatus);
                    paginahtml_texto = paginahtml_texto.Replace("@TelefonStudent", student.Phone);
                    paginahtml_texto = paginahtml_texto.Replace("@Correo", student.Email);

                    paginahtml_texto = paginahtml_texto.Replace("@NumEmergencia", student.NumberContactEmergency);
                    paginahtml_texto = paginahtml_texto.Replace("@GradoEstudios", student.DegreeAchieved);
                    paginahtml_texto = paginahtml_texto.Replace("@CargaFamiliar", student.FamilyBurden);
                    paginahtml_texto = paginahtml_texto.Replace("@NumPersonas", student.NumberPeopleCharge.ToString());

                    paginahtml_texto = paginahtml_texto.Replace("@Internet", student.InternetHome);
                    paginahtml_texto = paginahtml_texto.Replace("@TipoOperador", student.PhoneOperator);
                    paginahtml_texto = paginahtml_texto.Replace("@EquiposTecn", student.TeamTechnology);

                    paginahtml_texto = paginahtml_texto.Replace("@Discapacidad", student.Disability);
                    paginahtml_texto = paginahtml_texto.Replace("@TipoDiscapacidad", student.TypeDisability);
                    paginahtml_texto = paginahtml_texto.Replace("@Lengua", student.NativeLenguage);
                    paginahtml_texto = paginahtml_texto.Replace("@Domicilio", student.Home);
                    paginahtml_texto = paginahtml_texto.Replace("@Trabaja", student.Work);
                    paginahtml_texto = paginahtml_texto.Replace("@PuestoTrabajo", student.WorkPosition);
                    foreach (var tuition in listTuition)
                    {
                        if(student.Dni == tuition.Dni)
                        {
                            paginahtml_texto = paginahtml_texto.Replace("@Nivel", tuition.InformativeLevel);
                            paginahtml_texto = paginahtml_texto.Replace("@LugarFecha", student.PlaceDate);
                            foreach (var specialty in listSpecialties)
                            {
                                if(tuition.SpecialtyId == specialty.Id)
                                {
                                    paginahtml_texto = paginahtml_texto.Replace("@ProgramaEstudios", specialty.Name);
                                }
                            }
                            }
                            
                    }
                   

                    try
                    {
                        // Validar el HTML utilizando HtmlAgilityPack
                        var doc = new HtmlAgilityPack.HtmlDocument();
                        doc.LoadHtml(paginahtml_texto);

                        // Verificar si hay errores de sintaxis en el HTML
                        if (doc.ParseErrors != null && doc.ParseErrors.Any())
                        {
                            foreach (var error in doc.ParseErrors)
                            {
                                Console.WriteLine($"Error en línea {error.Line}: {error.Reason}");
                            }

                            MessageBox.Show("El HTML contiene errores. No se puede abrir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Crear un archivo temporal para guardar el PDF
                        string tempFilePath = Path.GetTempFileName();
                        string pdfFilePath = Path.ChangeExtension(tempFilePath, ".pdf");

                        // Convertir el HTML a PDF
                        PdfSharp.Pdf.PdfDocument pdf = PdfGenerator.GeneratePdf(paginahtml_texto, PdfSharp.PageSize.A4);
                        pdf.Save(pdfFilePath);

                        // Abrir el archivo PDF en Google Chrome
                        Process.Start("chrome.exe", pdfFilePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Se produjo un error al abrir el HTML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Salir del bucle una vez que se encuentra el estudiante
                    break;
                }
            }

            if (!studentFound)
            {
                MessageBox.Show("No se pudo encontrar el Dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnShowDni_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el dni porfavor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var student in listCeptro)
                {
                    if (txtDni.Text == student.Dni)
                    {
                        dniPdf = student.PhotoDni;
                        break; // Stop the loop once the student is found
                    }
                    
                }

                if (dniPdf != null)
                {
                    ShowPdf(dniPdf);
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el Dni ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowPdf(byte[] pdfData)
        {
            // Guardar los bytes en un archivo temporal
            string tempFilePath = Path.GetTempFileName() + ".pdf";
            System.IO.File.WriteAllBytes(tempFilePath, pdfData);

            // Abrir el archivo PDF utilizando el lector de PDF predeterminado del sistema
            System.Diagnostics.Process.Start(tempFilePath);
        }

        private void ceptroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmCeptro frmCeptro = new FrmCeptro();
            frmCeptro.FormClosed += CeptroForm_FormClosed;
            frmCeptro.ShowDialog();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudent frmStudent = new FrmStudent();
            frmStudent.FormClosed += StudentsForm_FormClosed;
            frmStudent.ShowDialog();
        }

        private void btnInfoCetpro_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCetpro);
        }

        private void btnCetpro_Click(object sender, EventArgs e)
        {
            FrmCeptro frmCeptro = new FrmCeptro();
            frmCeptro.FormClosed += CeptroForm_FormClosed;
            frmCeptro.ShowDialog();
            HideSubMenu();
        }

        private void btnInfoStudent_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelStudent);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            FrmStudent frmStudent = new FrmStudent();
            frmStudent.FormClosed += StudentsForm_FormClosed;
            frmStudent.ShowDialog();
            HideSubMenu();
        }

        private async void btnSaveBackup_Click(object sender, EventArgs e)
        {
           

          await UploadDatabaseFileToDriveAsync();
            /*try
            {
                // Ruta del directorio de Release
                string releaseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
                //MessageBox.Show(releaseDirectory);
                // Reemplazar la base de datos en el directorio de Release
                procedures.ReplaceDatabase(releaseDirectory);

                MessageBox.Show("Respaldo realizado con éxito.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el respaldo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        static string[] Scopes = { DriveService.Scope.DriveFile };
        static string ApplicationName = "My Drive Uploader";

        // Especifica el ID de la carpeta de destino en Google Drive
        static string folderId = "1uWJRx4dDhe2rrVprEaCv2i9ZRj7sGyB3";
        private async Task UploadDatabaseFileToDriveAsync()
        {
            using (var loadingForm = new FrmLoading())
            {
                loadingForm.Show();
                loadingForm.Refresh(); // Asegúrate de que el formulario se renderice correctamente

                UserCredential credential;
                string exePath = AppDomain.CurrentDomain.BaseDirectory;

                // Obtener la ruta del proyecto base
                string projectPath = Directory.GetParent(exePath).Parent.Parent.FullName;

                // Construir la ruta completa del archivo que deseas subir
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "databaseCeptro.db");

                // Verificar si el archivo existe
                if (!System.IO.File.Exists(filePath))
                {
                    MessageBox.Show("La base de datos no se encontró en la carpeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar si el archivo está en uso
                if (IsFileLocked(filePath))
                {
                    MessageBox.Show("El archivo está siendo utilizado por otro proceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string credentialsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "credencialesCetpro.json");

                // Cargar credenciales
                using (var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read))
                {
                    string credPath = Path.Combine(projectPath, "token.json");
                    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true));
                }

                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                // Buscar archivos cuyo nombre contenga 'databaseCeptro' en la carpeta específica
                var listRequest = service.Files.List();
                listRequest.Q = $"name contains 'databaseCeptro' and '{folderId}' in parents";
                listRequest.Spaces = "drive";
                listRequest.Fields = "nextPageToken, files(id, name)";
                listRequest.PageSize = 10;

                FileList files = null;
                bool found = false;
                do
                {
                    files = await listRequest.ExecuteAsync();
                    if (files.Files.Count > 0)
                    {
                        foreach (var file in files.Files)
                        {
                            if (file.Name.StartsWith("databaseCeptro", StringComparison.OrdinalIgnoreCase))
                            {
                                // Eliminar el archivo existente
                                await service.Files.Delete(file.Id).ExecuteAsync();
                                found = true;
                            }
                        }
                    }
                    listRequest.PageToken = files.NextPageToken;
                } while (!string.IsNullOrEmpty(listRequest.PageToken));

                if (found)
                {
                   // AutoClosingMessageBox.Show("Subiendo Archivo..", "Proceso", 3000); // 3000 milisegundos = 3 segundos
                }

                // Subir el nuevo archivo
                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = "databaseCeptro.db",
                    Parents = new List<string> { folderId }
                };

                try
                {
                    using (var uploadStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        var request = service.Files.Create(fileMetadata, uploadStream, GetMimeType(filePath));
                        request.Fields = "id";
                        await request.UploadAsync();

                        var file = request.ResponseBody;

                        // Asignar permisos (ejemplo: permisos de lectura para cualquier persona)
                        var permission = new Google.Apis.Drive.v3.Data.Permission()
                        {
                            Role = "reader",
                            Type = "anyone"
                        };
                        await service.Permissions.Create(permission, file.Id).ExecuteAsync();
                        loadingForm.Close();

                        MessageBox.Show("El archivo se ha subido correctamente a Google Drive.", "Operación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al subir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
            }

            
        }

        // Método para verificar si un archivo está bloqueado
        private static bool IsFileLocked(string filePath)
        {
            FileStream stream = null;

            try
            {
                stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                stream?.Close();
            }

            return false;
        }

        // Método para obtener el tipo MIME del archivo
        private static string GetMimeType(string fileName)
        {
            string mimeType = "application/unknown";
            string ext = Path.GetExtension(fileName).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
            if (regKey != null && regKey.GetValue("Content Type") != null)
            {
                mimeType = regKey.GetValue("Content Type").ToString();
            }
            return mimeType;
        }
        public static class AutoClosingMessageBox
        {
            private const int WM_CLOSE = 0x0010;

            [DllImport("user32.dll", SetLastError = true)]
            private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

            public static void Show(string text, string caption, int timeout)
            {
                var timer = new System.Windows.Forms.Timer();
                timer.Interval = timeout;
                timer.Tick += (s, e) =>
                {
                    timer.Stop();
                    var mbWnd = FindWindow("#32770", caption); // class name for MessageBox
                    if (mbWnd != IntPtr.Zero)
                    {
                        SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                    }
                };

                timer.Start();
                MessageBox.Show(text, caption);
            }
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmUsers frmUsers = new FrmUsers();
            frmUsers.ShowDialog();
        }

        private void btnInfoMatricula_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMatricula);
        }

        private void btnInfoUsers_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelUser);
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            FrmTuition frmTuition = new FrmTuition();
            frmTuition.FormClosed += TuitionForm_FormClosed;
            frmTuition.ShowDialog();
        }

      
        private void btnSpecialties_Click(object sender, EventArgs e)
        {
            FrmSpecialties frmSpecialties = new FrmSpecialties();
            frmSpecialties.ShowDialog();

        }

        private void btnTeachingUnit_Click(object sender, EventArgs e)
        {
            FrmTeachingUnits frmTeachingUnits = new FrmTeachingUnits();
            frmTeachingUnits.ShowDialog();  
        }

        private void btnTuition_Click(object sender, EventArgs e)
            
        {
            LoadCeptro();
            if (txtDni.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el dni porfavor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Obtener el contenido HTML desde los recursos
                string paginahtml_texto = Properties.Resources.plantillaMatricula;
                paginahtml_texto = paginahtml_texto.Replace("@NombreCetpro", objCeptro.Name);
                paginahtml_texto = paginahtml_texto.Replace("@CodigoModular", objCeptro.CodeModular);
                paginahtml_texto = paginahtml_texto.Replace("@TipoGestion", objCeptro.ManagementType);
                paginahtml_texto = paginahtml_texto.Replace("@Departamento", objCeptro.Departament);
                paginahtml_texto = paginahtml_texto.Replace("@Provincia", objCeptro.Province);
                paginahtml_texto = paginahtml_texto.Replace("@Distrito", objCeptro.District);
                paginahtml_texto = paginahtml_texto.Replace("@cetpro", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "cetpropgn.png"));
                paginahtml_texto = paginahtml_texto.Replace("@logo", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "imagenti.png"));

                bool studentFound = false;
                foreach (var tuition in listTuition)
                {
                    if (txtDni.Text == tuition.Dni)
                    {
                        studentFound = true;

                        paginahtml_texto = paginahtml_texto.Replace("@PeriodoLectivo", tuition.SchoolPeriod);
                        paginahtml_texto = paginahtml_texto.Replace("@Modulo", tuition.Module);
                        paginahtml_texto = paginahtml_texto.Replace("@PeriodoClases", tuition.ClassPeriod);
                        paginahtml_texto = paginahtml_texto.Replace("@NivelFormativo", tuition.InformativeLevel);
                        paginahtml_texto = paginahtml_texto.Replace("@PeriodoAcademico", tuition.AcademicPeriod);
                        paginahtml_texto = paginahtml_texto.Replace("@TipoPlan", tuition.StudyPlanType);
                        paginahtml_texto = paginahtml_texto.Replace("@NumDoc", tuition.Dni);
                        paginahtml_texto = paginahtml_texto.Replace("@ApeNombres", tuition.NamesLastNames);
                        paginahtml_texto = paginahtml_texto.Replace("@Dre", tuition.Dre);

                        var placeholders = new Dictionary<string, string[]>
                            {
                                { "1", new[] { "@Unid1", "@Credit1", "@Hora1", "@Condi1" } },
                                { "2", new[] { "@Unid2", "@Credit2", "@Hora2", "@Condi2" } },
                                { "3", new[] { "@Unid3", "@Credit3", "@Hora3", "@Condi3" } },
                                { "4", new[] { "@Unid4", "@Credit4", "@Hora4", "@Condi4" } },
                                { "5", new[] { "@Unid5", "@Credit5", "@Hora5", "@Condi5" } },
                                { "6", new[] { "@Unid6", "@Credit6", "@Hora6", "@Condi6" } },
                                { "7", new[] { "@Unid7", "@Credit7", "@Hora7", "@Condi7" } },
                            };

                        foreach (var specialty in listSpecialties)
                        {
                            if (specialty.Id == tuition.SpecialtyId)
                            {
                                paginahtml_texto = paginahtml_texto.Replace("@ProgramaEstudios", specialty.Name);

                                foreach (var placeholder in placeholders)
                                {
                                    var specialtyXteachingUnit = listSpecialtyXteachingUnits
                                        .FirstOrDefault(sxu => sxu.SpecialtyId == specialty.Id && sxu.Number == placeholder.Key);

                                    if (specialtyXteachingUnit != null)
                                    {
                                        paginahtml_texto = paginahtml_texto.Replace(placeholder.Value[0], specialtyXteachingUnit.Name);
                                        paginahtml_texto = paginahtml_texto.Replace(placeholder.Value[1], specialtyXteachingUnit.Credit);
                                        paginahtml_texto = paginahtml_texto.Replace(placeholder.Value[2], specialtyXteachingUnit.Hours);
                                        paginahtml_texto = paginahtml_texto.Replace(placeholder.Value[3], specialtyXteachingUnit.Conditions);
                                    }
                                    else
                                    {
                                        paginahtml_texto = paginahtml_texto.Replace(placeholder.Value[0], " ");
                                        paginahtml_texto = paginahtml_texto.Replace(placeholder.Value[1], " ");
                                        paginahtml_texto = paginahtml_texto.Replace(placeholder.Value[2], " ");
                                        paginahtml_texto = paginahtml_texto.Replace(placeholder.Value[3], " ");
                                    }
                                }
                            }
                        }


                        try
                        {
                            // Validar el HTML utilizando HtmlAgilityPack
                            var doc = new HtmlAgilityPack.HtmlDocument();
                            doc.LoadHtml(paginahtml_texto);

                            // Verificar si hay errores de sintaxis en el HTML
                            if (doc.ParseErrors != null && doc.ParseErrors.Any())
                            {
                                foreach (var error in doc.ParseErrors)
                                {
                                    Console.WriteLine($"Error en línea {error.Line}: {error.Reason}");
                                }

                                MessageBox.Show("El HTML contiene errores. No se puede abrir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Crear un archivo temporal para guardar el PDF
                            string tempFilePath = Path.GetTempFileName();
                            string pdfFilePath = Path.ChangeExtension(tempFilePath, ".pdf");

                            // Configurar el tamaño de la página y la orientación a horizontal
                            var config = new PdfGenerateConfig
                            {
                                PageOrientation = PdfSharp.PageOrientation.Landscape,
                                PageSize = PdfSharp.PageSize.A4
                            };

                            // Convertir el HTML a PDF
                            PdfSharp.Pdf.PdfDocument pdf = PdfGenerator.GeneratePdf(paginahtml_texto, config);
                            pdf.Save(pdfFilePath);

                            // Abrir el archivo PDF en Google Chrome
                            Process.Start("chrome.exe", pdfFilePath);
                        

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Se produjo un error al abrir el HTML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Salir del bucle una vez que el estudiante es encontrado
                        break;
                    }
                }

                if (!studentFound)
                {
                    MessageBox.Show("No se pudo encontrar el Dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            
        }
    }
}
