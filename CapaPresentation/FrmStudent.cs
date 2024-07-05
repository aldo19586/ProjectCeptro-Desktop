using CapaDomain;
using CapaEntity;
using CapaEntity.Cache;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using ClosedXML.Excel;
using Microsoft.Office.Interop.Excel;

namespace CapaPresentation
{
    public partial class FrmStudent : Form
    {
        CDo_Students students = new CDo_Students();
        List<Student> listStudents;
        public event EventHandler StudentsFormClosed;
        CDo_Procedures procedures = new CDo_Procedures();
        public FrmStudent()
        {
            InitializeComponent();

            dataGridViewStudents.CellClick += new DataGridViewCellEventHandler(dataGridViewStudents_CellClick);


            //dataGridViewStudents.Columns[32].HeaderText = "Nombres";

            //dataGridViewUsers.Columns["Name"].Width = 127;
        }

        private void btnAddStudentDialog_Click(object sender, EventArgs e)
        {

            FrmAddStudent frmAddStudent = new FrmAddStudent();
            frmAddStudent.UpdateEventHandler += AdStud_UpdateEventHandler;
            frmAddStudent.ShowDialog();
        }
        private void AdStud_UpdateEventHandler(object sender, FrmAddStudent.UpdateEventArgs args)
        {
            LoadStudents();
        }
        private void UpStud_UpdateEventHandler(object sender, FrmUpdateStudent.UpdateEventArgs args)
        {
            LoadStudents();

        }
        private void LoadStudents()
        {

            dataGridViewStudents.DataSource = students.LoadStudents();
            dataGridViewStudents.ClearSelection();
            dataGridViewStudents.Columns[0].Visible = false;
            dataGridViewStudents.Columns[1].Visible = false;
            dataGridViewStudents.Columns[6].Visible = false;
            dataGridViewStudents.Columns[7].Visible = false;

            dataGridViewStudents.Columns[11].Visible = false;

            dataGridViewStudents.Columns[15].Visible = false;
            dataGridViewStudents.Columns[16].Visible = false;

            dataGridViewStudents.Columns[18].Visible = false;
            dataGridViewStudents.Columns[10].Visible = false;


            dataGridViewStudents.Columns[21].Visible = false;
            dataGridViewStudents.Columns[22].Visible = false;
            dataGridViewStudents.Columns[23].Visible = false;
            dataGridViewStudents.Columns[24].Visible = false;
            dataGridViewStudents.Columns[25].Visible = false;
            dataGridViewStudents.Columns[26].Visible = false;
            dataGridViewStudents.Columns[27].Visible = false;
            dataGridViewStudents.Columns[28].Visible = false;
            dataGridViewStudents.Columns[29].Visible = false;
            dataGridViewStudents.Columns[30].Visible = false;
            dataGridViewStudents.Columns[31].Visible = false;
            dataGridViewStudents.Columns[32].Visible = false;
            dataGridViewStudents.Columns[33].Visible = false;
            dataGridViewStudents.Columns[34].Visible = false;

            dataGridViewStudents.Columns[2].HeaderText = "Cod. Inscripcion";
            dataGridViewStudents.Columns[3].HeaderText = "A. Paterno";
            dataGridViewStudents.Columns[4].HeaderText = "A. Materno";
            dataGridViewStudents.Columns[5].HeaderText = "Nombres";
            dataGridViewStudents.Columns[8].HeaderText = "Dni";
            dataGridViewStudents.Columns[9].HeaderText = "Edad";
            dataGridViewStudents.Columns[12].HeaderText = "Distrito";
            dataGridViewStudents.Columns[13].HeaderText = "Provincia";
            dataGridViewStudents.Columns[14].HeaderText = "Region";
            dataGridViewStudents.Columns[17].HeaderText = "Puesto de Trabajo";
            dataGridViewStudents.Columns[19].HeaderText = "Telefono";
            dataGridViewStudents.Columns[20].HeaderText = "Correo Electrónico";


            listStudents = students.LoadStudents();
            // Ocultar la columna "photodni"
            dataGridViewStudents.Columns["PhotoDni"].Visible = false;


            dataGridViewStudents.Columns["WorkPosition"].Width = 130;
            dataGridViewStudents.Columns["FirstName"].Width = 150;
            dataGridViewStudents.Columns["Email"].Width = 160;

        }
        private void AddColumnButtonDataGrid()
        {
            // Agregar una columna de botón al DataGridView
            DataGridViewButtonColumn viewPdfButtonColumn = new DataGridViewButtonColumn();
            viewPdfButtonColumn.Name = "ViewPdf";
            viewPdfButtonColumn.HeaderText = "Dni";
            viewPdfButtonColumn.Text = "Ver";
            viewPdfButtonColumn.UseColumnTextForButtonValue = true;
            dataGridViewStudents.Columns.Add(viewPdfButtonColumn);

        }


        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*// Verificar si la celda clickeada es de la columna de botones
            if (e.ColumnIndex == dataGridViewStudents.Columns["ViewPdf"].Index && e.RowIndex >= 0)
            {
                // Obtener los datos en formato byte del PDF desde la celda correspondiente
                byte[] pdfData = (byte[])dataGridViewStudents.Rows[e.RowIndex].Cells["PhotoDni"].Value;

                // Guardar los bytes en un archivo temporal
                string tempFilePath = Path.GetTempFileName() + ".pdf";
                File.WriteAllBytes(tempFilePath, pdfData);

                // Abrir el archivo PDF utilizando el lector de PDF predeterminado del sistema
                System.Diagnostics.Process.Start(tempFilePath);
            }*/
        }


        private void btnUpdateStudentDialog_Click(object sender, EventArgs e)
        {



            if (dataGridViewStudents.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para actualizar.", "Actualizar Categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridViewStudents.SelectedRows == null)
                {
                    MessageBox.Show("Por favor, seleccione un registro para actualizar.", "Actualizar Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {

                        FrmUpdateStudent existingInstance = System.Windows.Forms.Application.OpenForms.OfType<FrmUpdateStudent>().FirstOrDefault();
                        if (existingInstance != null)
                        {
                            existingInstance.BringToFront(); // Traer la instancia existente al frente
                        }
                        else
                        {
                            FrmUpdateStudent UpdateStudent = new FrmUpdateStudent(this);
                            UpdateStudent.UpdateEventHandler += UpStud_UpdateEventHandler;
                            UpdateStudent.txtId.Text = dataGridViewStudents.SelectedRows[0].Cells[0].Value.ToString();
                            UpdateStudent.txtYear.Text = dataGridViewStudents.SelectedRows[0].Cells[1].Value.ToString();
                            UpdateStudent.txtRegistrationCode.Text = dataGridViewStudents.SelectedRows[0].Cells[2].Value.ToString();
                            UpdateStudent.txtFirstSurtName.Text = dataGridViewStudents.SelectedRows[0].Cells[3].Value.ToString();
                            UpdateStudent.txtSecondName.Text = dataGridViewStudents.SelectedRows[0].Cells[4].Value.ToString();
                            UpdateStudent.txtFirstName.Text = dataGridViewStudents.SelectedRows[0].Cells[5].Value.ToString();

                            if (dataGridViewStudents.SelectedRows[0].Cells[6].Value.ToString() == "Masculino")
                            {
                                UpdateStudent.rBtnMasculino.Checked = true;

                            }
                            else if (dataGridViewStudents.SelectedRows[0].Cells[6].Value.ToString() == "Femenino")
                            {
                                UpdateStudent.rBtnFemenino.Checked = true;
                            }
                            else if (dataGridViewStudents.SelectedRows[0].Cells[6].Value.ToString() == "Otros")
                            {
                                UpdateStudent.rBtnOtros.Checked = true;
                            }

                            // Obtén el valor de la celda como cadena
                            string dateString = dataGridViewStudents.SelectedRows[0].Cells[7].Value.ToString();

                            // Intenta convertir la cadena en un objeto DateTime
                            if (DateTime.TryParse(dateString, out DateTime dateValue))
                            {
                                // Si la conversión es exitosa, asigna la fecha al DateTimePicker
                                UpdateStudent.txtDateBirth.Value = dateValue;
                            }
                            else
                            {
                                // Si la conversión falla, maneja el error apropiadamente
                                MessageBox.Show("El valor de la fecha no es válido.");
                            } // Asegúrate de que 'dateTimePicker' sea el nombre correcto de tu control DateTimePicker

                            UpdateStudent.txtDni.Text = dataGridViewStudents.SelectedRows[0].Cells[8].Value.ToString();
                            UpdateStudent.txtAge.Text = dataGridViewStudents.SelectedRows[0].Cells[9].Value.ToString();
                            UpdateStudent.txtCountry.Text = dataGridViewStudents.SelectedRows[0].Cells[10].Value.ToString();
                            UpdateStudent.txtPlaceBirth.Text = dataGridViewStudents.SelectedRows[0].Cells[11].Value.ToString();
                            UpdateStudent.txtDistrict.Text = dataGridViewStudents.SelectedRows[0].Cells[12].Value.ToString();
                            UpdateStudent.txtProvince.Text = dataGridViewStudents.SelectedRows[0].Cells[13].Value.ToString();
                            UpdateStudent.txtRegion.Text = dataGridViewStudents.SelectedRows[0].Cells[14].Value.ToString();
                            UpdateStudent.txtHome.Text = dataGridViewStudents.SelectedRows[0].Cells[15].Value.ToString();

                            if (dataGridViewStudents.SelectedRows[0].Cells[16].Value.ToString() == "Si")
                            {
                                UpdateStudent.rBtnWorkYes.Checked = true;

                            }
                            else if (dataGridViewStudents.SelectedRows[0].Cells[16].Value.ToString() == "No")
                            {
                                UpdateStudent.rBtnWorkNot.Checked = true;
                            }



                            UpdateStudent.txtWorkPosition.Text = dataGridViewStudents.SelectedRows[0].Cells[17].Value.ToString();
                            UpdateStudent.txtCivilStatus.Text = dataGridViewStudents.SelectedRows[0].Cells[18].Value.ToString();
                            UpdateStudent.txtPhone.Text = dataGridViewStudents.SelectedRows[0].Cells[19].Value.ToString();
                            UpdateStudent.txtEmail.Text = dataGridViewStudents.SelectedRows[0].Cells[20].Value.ToString();
                            UpdateStudent.txtNumberEmergency.Text = dataGridViewStudents.SelectedRows[0].Cells[21].Value.ToString();
                            UpdateStudent.txtDegreeAchieved.Text = dataGridViewStudents.SelectedRows[0].Cells[22].Value.ToString();

                            if (dataGridViewStudents.SelectedRows[0].Cells[23].Value.ToString() == "Si")
                            {
                                UpdateStudent.rBtnFamilyBurdenYes.Checked = true;

                            }
                            else if (dataGridViewStudents.SelectedRows[0].Cells[23].Value.ToString() == "No")
                            {
                                UpdateStudent.rBtnFamilyBurdenNot.Checked = true;
                            }
                            UpdateStudent.txtNumberFamilyBurden.Text = dataGridViewStudents.SelectedRows[0].Cells[24].Value.ToString();
                            UpdateStudent.txtPhoneOperator.Text = dataGridViewStudents.SelectedRows[0].Cells[25].Value.ToString();


                            string value = dataGridViewStudents.SelectedRows[0].Cells[26].Value.ToString();

                            // Verifica la presencia de cada palabra clave
                            if (value.Contains("PC"))
                            {
                                UpdateStudent.checkBoxPc.Checked = true;
                            }

                            if (value.Contains("Laptop"))
                            {
                                UpdateStudent.checkBoxLaptop.Checked = true;
                            }

                            if (value.Contains("Celular"))
                            {
                                UpdateStudent.checkBoxCelular.Checked = true;
                            }

                            if (dataGridViewStudents.SelectedRows[0].Cells[27].Value.ToString() == "Si")
                            {
                                UpdateStudent.rBtnInternetYes.Checked = true;

                            }
                            else if (dataGridViewStudents.SelectedRows[0].Cells[27].Value.ToString() == "No")
                            {
                                UpdateStudent.rBtnInternetNot.Checked = true;
                            }
                            if (dataGridViewStudents.SelectedRows[0].Cells[28].Value.ToString() == "Si")
                            {
                                UpdateStudent.rBtnDesabilityYes.Checked = true;

                            }
                            else if (dataGridViewStudents.SelectedRows[0].Cells[28].Value.ToString() == "No")
                            {
                                UpdateStudent.rBtnDesabilityNot.Checked = true;
                            }
                            UpdateStudent.txtNativeLenguaje.Text = dataGridViewStudents.SelectedRows[0].Cells[30].Value.ToString();
                            // Obtén el valor como un array de bytes (BLOB)

                            // Verificar si el valor en la celda es nulo o vacío antes de convertirlo
                            string cellValue = dataGridViewStudents.SelectedRows[0].Cells[0].Value.ToString();
                            if (!string.IsNullOrEmpty(cellValue) && int.TryParse(cellValue, out int studentId))
                            {
                                foreach (Student student in listStudents)
                                {
                                    if (student.Id == studentId)
                                    {
                                        UpdateStudent.pdfPhoto = student.PhotoDni;
                                        UpdateStudent.lblLoadedDni.Text = student.FileNamePdf;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("El valor de la ID no es válido.", "Actualizar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            UpdateStudent.txtDepartament.Text = dataGridViewStudents.SelectedRows[0].Cells[33].Value.ToString();
                            UpdateStudent.txtPlaceDate.Text = dataGridViewStudents.SelectedRows[0].Cells[34].Value.ToString();






                            UpdateStudent.Show();
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Debe seleccionar algun registro para actualizar." + ex.Message + ex.StackTrace, "Actualizar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                }
            }







        }

        private void btnRemoveStudentDialog_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar.", "Eliminar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridViewStudents.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar algun registro para eliminar.", "Eliminar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    DialogResult result = MessageBox.Show("Esta seguro que desea eliminar al estudiante?", "Eliminar Estudiante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var idStudent = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells[0].Value.ToString());

                        students.DeleteStudent(idStudent);
                        LoadStudents();
                        MessageBox.Show("Se eliminó correctamente al estudiante", "Eliminar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }


                }
            }
            try
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
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {

            if (InformationUser.Rol == "Director")
            {

            }
            else if (InformationUser.Rol == "Docente")
            {
                btnAddStudentDialog.Enabled = false;
                btnUpdateStudentDialog.Enabled = false;
                btnRemoveStudentDialog.Enabled = false;



            }
            else if (InformationUser.Rol == "Auxiliar")
            {
                btnAddStudentDialog.Enabled = false;
                btnUpdateStudentDialog.Enabled = false;
                btnRemoveStudentDialog.Enabled = false;

            }
            LoadStudents();
            //AddColumnButtonDataGrid();
            // Ajustar el tamaño del formulario para que coincida con la pantalla del monitor
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.MinimumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);


            // Permitir cambiar el tamaño del formulario
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        public void Search()
        {
            try
            {
                if (comboBoxTypeSearch.Text == "Codigo" || comboBoxTypeSearch.Text == "Dni" || comboBoxTypeSearch.Text == "Nombres" || comboBoxTypeSearch.Text == "Apellidos")
                {
                    dataGridViewStudents.DataSource = students.SearchStudent(txtSearchStudent.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El studiante no fue encontrado por: " + ex.Message, "Buscar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            StudentsFormClosed?.Invoke(this, EventArgs.Empty);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            var listStudent = students.LoadStudents();
            ExportStudentsToExcel(listStudent);

        }
        public void ExportStudentsToExcel(List<Student> students)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Students");

                // Adding headers
                worksheet.Cells[1, 1].Value = "ID";
                worksheet.Cells[1, 2].Value = "Year";
                worksheet.Cells[1, 3].Value = "RegistrationCode";
                worksheet.Cells[1, 4].Value = "FirstSurtname";
                worksheet.Cells[1, 5].Value = "SecondSurtname";
                worksheet.Cells[1, 6].Value = "FirstName";
                worksheet.Cells[1, 7].Value = "Sex";
                worksheet.Cells[1, 8].Value = "DateBirth";
                worksheet.Cells[1, 9].Value = "Dni";
                worksheet.Cells[1, 10].Value = "Age";
                worksheet.Cells[1, 11].Value = "Country";
                worksheet.Cells[1, 12].Value = "PlaceBirth";
                worksheet.Cells[1, 13].Value = "District";
                worksheet.Cells[1, 14].Value = "Province";
                worksheet.Cells[1, 15].Value = "Region";
                worksheet.Cells[1, 16].Value = "Home";
                worksheet.Cells[1, 17].Value = "Work";
                worksheet.Cells[1, 18].Value = "WorkPosition";
                worksheet.Cells[1, 19].Value = "CivilStatus";
                worksheet.Cells[1, 20].Value = "Phone";
                worksheet.Cells[1, 21].Value = "Email";
                worksheet.Cells[1, 22].Value = "NumberContactEmergency";
                worksheet.Cells[1, 23].Value = "DegreeAchieved";
                worksheet.Cells[1, 24].Value = "FamilyBurden";
                worksheet.Cells[1, 25].Value = "NumberPeopleCharge";
                worksheet.Cells[1, 26].Value = "PhoneOperator";
                worksheet.Cells[1, 27].Value = "TeamTechnology";
                worksheet.Cells[1, 28].Value = "InternetHome";
                worksheet.Cells[1, 29].Value = "Disability";
                worksheet.Cells[1, 30].Value = "TypeDisability";
                worksheet.Cells[1, 31].Value = "NativeLenguaje";
                worksheet.Cells[1, 32].Value = "PhotoDni";
                worksheet.Cells[1, 33].Value = "FileNamePdf";
                worksheet.Cells[1, 34].Value = "Department";

                // Adding data
                int row = 2;
                foreach (var student in students)
                {
                    worksheet.Cells[row, 1].Value = student.Id;
                    worksheet.Cells[row, 2].Value = student.Year;
                    worksheet.Cells[row, 3].Value = student.RegistrationCode;
                    worksheet.Cells[row, 4].Value = student.FirstSurtname;
                    worksheet.Cells[row, 5].Value = student.SecondSurtname;
                    worksheet.Cells[row, 6].Value = student.FirstName;
                    worksheet.Cells[row, 7].Value = student.Sex;
                    worksheet.Cells[row, 8].Value = student.DateBirth;
                    worksheet.Cells[row, 9].Value = student.Dni;
                    worksheet.Cells[row, 10].Value = student.Age;
                    worksheet.Cells[row, 11].Value = student.Country;
                    worksheet.Cells[row, 12].Value = student.PlaceBirth;
                    worksheet.Cells[row, 13].Value = student.District;
                    worksheet.Cells[row, 14].Value = student.Province;
                    worksheet.Cells[row, 15].Value = student.Region;
                    worksheet.Cells[row, 16].Value = student.Home;
                    worksheet.Cells[row, 17].Value = student.Work;
                    worksheet.Cells[row, 18].Value = student.WorkPosition;
                    worksheet.Cells[row, 19].Value = student.CivilStatus;
                    worksheet.Cells[row, 20].Value = student.Phone;
                    worksheet.Cells[row, 21].Value = student.Email;
                    worksheet.Cells[row, 22].Value = student.NumberContactEmergency;
                    worksheet.Cells[row, 23].Value = student.DegreeAchieved;
                    worksheet.Cells[row, 24].Value = student.FamilyBurden;
                    worksheet.Cells[row, 25].Value = student.NumberPeopleCharge;
                    worksheet.Cells[row, 26].Value = student.PhoneOperator;
                    worksheet.Cells[row, 27].Value = student.TeamTechnology;
                    worksheet.Cells[row, 28].Value = student.InternetHome;
                    worksheet.Cells[row, 29].Value = student.Disability;
                    worksheet.Cells[row, 30].Value = student.TypeDisability;
                    worksheet.Cells[row, 31].Value = student.NativeLenguage;
                    // Verificar si hay un archivo PDF para adjuntar
                    if (student.PhotoDni != null && student.PhotoDni.Length > 0)
                    {
                        string pdfFileName = $"PhotoDni_{student.FirstSurtname+" "+student.FirstSurtname}.pdf"; // Nombre del archivo PDF
                        string pdfFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources",pdfFileName); ; // Ruta donde se guarda el archivo PDF (ajustar según tu implementación)
                                                                                                                             // Verificar si el archivo ya existe y eliminarlo si es necesario
                        if (File.Exists(pdfFilePath))
                        {
                            File.Delete(pdfFilePath); // Eliminar el archivo existente
                        }
                        // Guardar el archivo PDF en la ruta especificada
                        File.WriteAllBytes(pdfFilePath, student.PhotoDni);

                        // Establecer el valor de la celda con el nombre del archivo PDF
                        worksheet.Cells[row, 32].Value = pdfFileName; // Ajusta la columna según donde desees poner el nombre del archivo

                        // Agregar un hipervínculo en la celda para abrir el PDF
                        var cell = worksheet.Cells[row, 32];
                        cell.Hyperlink = new ExcelHyperLink(new Uri(pdfFilePath, UriKind.RelativeOrAbsolute).AbsoluteUri)
                        {
                            Display = "Abrir PDF" // Texto visible para el hipervínculo
                        };

                        // Opcional: Ajustar el estilo del hipervínculo
                        cell.Style.Font.UnderLine = true;
                        cell.Style.Font.Color.SetColor(Color.Blue);

                    }
                    worksheet.Cells[row, 33].Value = student.FileNamePdf;
                    worksheet.Cells[row, 34].Value = student.Departament;

                    row++;
                }

                // Autofit columns
                worksheet.Cells.AutoFitColumns();

                // Open Excel
                MemoryStream stream = new MemoryStream();
                package.SaveAs(stream);
                stream.Position = 0;

                // Open Excel application
                using (var excelPackage = new ExcelPackage(stream))
                {
                    var newFile = new FileInfo(@"students.xlsx");
                    excelPackage.SaveAs(newFile);
                    System.Diagnostics.Process.Start(newFile.ToString());
                }
            }
        }
      
     
    }
}
