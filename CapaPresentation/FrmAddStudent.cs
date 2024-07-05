using CapaEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDomain;
using CapaEntity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SQLite;
using System.IO;

namespace CapaPresentation
{
    public partial class FrmAddStudent : Form
    {
        CDo_Procedures procedures = new CDo_Procedures();
        Student objStudent = new Student();
        CDo_Students students = new CDo_Students();
        private string valorSexo;
        private string valorWork;
        private string valorDesability;
        private string valorFamilyBurden;
        private string valorInternet;
        private string dispositivosSeleccionados;
        byte[] pdfBytes;
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void NotifyAdd()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        public FrmAddStudent()
        {
            InitializeComponent();
            InitializeEventHandlers();
            txtWorkPosition.Enabled = false;
            txtTypeDesability.Enabled = false;
            txtNumberFamilyBurden.Enabled = false;
        }

      
        private void InitializeEventHandlers()
        {
            this.rBtnMasculino.CheckedChanged += new System.EventHandler(this.radioButtonSex_CheckedChanged);
            this.rBtnFemenino.CheckedChanged += new System.EventHandler(this.radioButtonSex_CheckedChanged);
            this.rBtnOtros.CheckedChanged += new System.EventHandler(this.radioButtonSex_CheckedChanged);

            this.rBtnWorkYes.CheckedChanged += new System.EventHandler(this.radioButtonWork_CheckedChanged);
            this.rBtnWorkNot.CheckedChanged += new System.EventHandler(this.radioButtonWork_CheckedChanged);


            this.rBtnDesabilityYes.CheckedChanged += new System.EventHandler(this.radioButtonDesability_CheckedChanged);
            this.rBtnDesabilityNot.CheckedChanged += new System.EventHandler(this.radioButtonDesability_CheckedChanged);

            this.rBtnFamilyBurdenYes.CheckedChanged += new System.EventHandler(this.radioButtonFamilyBurden_CheckedChanged);
            this.rBtnFamilyBurdenNot.CheckedChanged += new System.EventHandler(this.radioButtonFamilyBurden_CheckedChanged);

            this.rBtnInternetYes.CheckedChanged += new System.EventHandler(this.radioButtonInternet_CheckedChanged);
            this.rBtnInternetNot.CheckedChanged += new System.EventHandler(this.radioButtonInternet_CheckedChanged);

            this.checkBoxPc.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.checkBoxLaptop.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.checkBoxCelular.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);


        }
        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
            // Establecer el enfoque en el control txtRegistrationCode
            txtRegistrationCode.Focus();

            // Ajustar el tamaño del formulario para que coincida con la pantalla del monitor
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Permitir cambiar el tamaño del formulario
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Ajustar para maximizar automáticamente
            this.WindowState = FormWindowState.Maximized;


        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
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

       
        public bool SaveData()
        {
            try
            {
                if (procedures.VerifyTextBoxs(this))
               {
                  
                    objStudent.Year = txtYear.Text; // Asume que hay un campo de texto para el año
                    objStudent.RegistrationCode = txtRegistrationCode.Text;
                    objStudent.FirstSurtname = txtFirstSurtName.Text;
                    objStudent.SecondSurtname = txtSecondName.Text;
                    objStudent.FirstName = txtFirstName.Text;
                    objStudent.Sex = valorSexo;
                    // Parsea la fecha y hora
                    DateTime dateTime = DateTime.Parse(txtDateBirth.Text);

                    // Asigna solo la parte de la fecha (omite la hora)
                    objStudent.DateBirth = dateTime.Date;
                    objStudent.Dni = txtDni.Text;
                    objStudent.Age = Convert.ToInt32(txtAge.Text);
                    objStudent.Country = txtCountry.Text;
                    objStudent.PlaceBirth = txtPlaceBirth.Text;
                    objStudent.District = txtDistrict.Text;
                    objStudent.Province = txtProvince.Text;
                    objStudent.Region = txtRegion.Text;
                    objStudent.Home = txtHome.Text;
                    objStudent.Work = valorWork; // Asume que hay un campo de texto para el trabajo que devuelve "true" o "false"
                    objStudent.WorkPosition = txtWorkPosition.Text;
                    objStudent.CivilStatus = txtCivilStatus.Text;
                    objStudent.Phone = txtPhone.Text;
                    objStudent.Email = txtEmail.Text;
                    objStudent.NumberContactEmergency = txtNumberEmergency.Text;
                    objStudent.DegreeAchieved = txtDegreeAchieved.Text;
                    objStudent.FamilyBurden = valorFamilyBurden; // Asume que hay un campo de texto para la carga familiar que devuelve "true" o "false"
                    objStudent.NumberPeopleCharge = int.Parse(txtNumberFamilyBurden.Text);
                    objStudent.PhoneOperator = txtPhoneOperator.Text;
                    objStudent.TeamTechnology = dispositivosSeleccionados;
                    objStudent.InternetHome = valorInternet; // Asume que hay un campo de texto para el internet en casa que devuelve "true" o "false"
                    objStudent.Disability = valorDesability; // Asume que hay un campo de texto para la discapacidad que devuelve "true" o "false"
                    objStudent.TypeDisability = txtTypeDesability.Text;
                    objStudent.NativeLenguage = txtNativeLenguaje.Text;
                    objStudent.PhotoDni= pdfBytes;
                    objStudent.FileNamePdf = lblLoadedDni.Text;
                    objStudent.PlaceDate = txtPlaceDate.Text;
                    students.AddStudent(objStudent);
                    //students.AddStudentPart2(objStudent);
                    MessageBox.Show("El estudiando se agregó exitósamente", "Agregar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRegistrationCode.Focus();
                    NotifyAdd();
                    this.Hide();
                    // Crear y mostrar el cuadro de mensaje
                    DialogResult result = MessageBox.Show("¿Desea matricular a "+objStudent.FirstSurtname +" "+ objStudent.SecondSurtname + " " + objStudent.FirstName+"?", "Matrícula", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Evaluar la respuesta del usuario
                    if (result == DialogResult.Yes)
                    {
                        FrmAddTuition frmAddTuition = new FrmAddTuition();
                        frmAddTuition.txtDni.Text = objStudent.Dni.ToString();
                        frmAddTuition.txtNamesLastNames.Text = objStudent.FirstSurtname + " " + objStudent.SecondSurtname + " " + objStudent.FirstName;
                        frmAddTuition.ShowDialog();
                    }
                    else if (result == DialogResult.No)
                    {
                       // MessageBox.Show("Estarás trabajando localmente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return true;
               }
              else
               {
                    return false;
               }
                

            }

            catch (Exception ex)
            {

                MessageBox.Show($"El estudiante no fue agregado por: {ex.Message + " --" + ex.StackTrace}", "Agregar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void radioButtonSex_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMasculino.Checked)
            {
                valorSexo = "Masculino";
            }
            else if (rBtnFemenino.Checked)
            {
                valorSexo = "Femenino";
            }
            else if (rBtnOtros.Checked)
            {
                valorSexo = "Otros";
            }
        }
        private void radioButtonWork_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnWorkYes.Checked)
            {
                valorWork = "Si";
                txtWorkPosition.Enabled = true;

            }
            else if (rBtnWorkNot.Checked)
            {
                valorWork = "No";
                txtWorkPosition.Enabled = false;
            
            }
            
        }
        private void radioButtonDesability_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnDesabilityYes.Checked)
            {
                valorDesability= "Si";
                txtTypeDesability.Enabled = true;
            }
            else if (rBtnDesabilityNot.Checked)
            {
                valorDesability= "No";
                txtTypeDesability.Enabled= false;
            }

        }
        private void radioButtonFamilyBurden_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnFamilyBurdenYes.Checked)
            {
                valorFamilyBurden = "Si";
                txtNumberFamilyBurden.Enabled = true;
            }
            else if (rBtnFamilyBurdenNot.Checked)
            {
                valorFamilyBurden = "No";
                txtNumberFamilyBurden.Enabled =false;
            }

        }

        private void radioButtonInternet_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnInternetYes.Checked)
            {
                valorInternet = "Si";
            }
            else if (rBtnInternetNot.Checked)
            {
                valorInternet = "No";
            }

        }


        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            dispositivosSeleccionados = "";
            if (checkBoxPc.Checked)
            {
                dispositivosSeleccionados += "PC/";
            }
            if (checkBoxLaptop.Checked)
            {
                dispositivosSeleccionados += "Laptop/";
            }
            if (checkBoxCelular.Checked)
            {
                dispositivosSeleccionados += "Celular/";
            }

            // Eliminar la última barra si existe
            if (dispositivosSeleccionados.EndsWith("/"))
            {
                dispositivosSeleccionados = dispositivosSeleccionados.TrimEnd('/');
            }
        }
        private void rBtnMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtnFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtnOtros_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtnWorkYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtnWorkNot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtnInternetYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtnInternetNot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtnFamilyBurdenYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtnDesabilityYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtnDesabilityNot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxLaptop_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCelular_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLoadPhotoDni_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Paso 2: Leer el archivo en un arreglo de bytes
                string filePath = openFileDialog.FileName;
                pdfBytes = File.ReadAllBytes(filePath);
                string fileName = Path.GetFileName(filePath);
                lblLoadedDni.Text = fileName;


            }
        }

        private void txtPhoneOperator_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtRegistrationCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtYear.Focus();
                e.Handled = true;
            }
        }
        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtFirstSurtName.Focus();
                e.Handled = true;
            }
        }
        private void txtFirstSurtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtSecondName.Focus();
                e.Handled = true;
            }
        }

        private void txtSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtFirstName.Focus();
                e.Handled = true;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDateBirth.Focus();
                e.Handled = true;
            }
        }

        private void txtDateBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                rBtnMasculino.Focus();
                e.Handled = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtAge.Focus();
                e.Handled = true;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPhone.Focus();
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtHome.Focus();
                e.Handled = true;
            }
        }

        private void txtHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCivilStatus.Focus();
                e.Handled = true;
            }
        }

        private void txtCivilStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPlaceBirth.Focus();
                e.Handled = true;
            }
        }

        private void txtPlaceBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDistrict.Focus();
                e.Handled = true;
            }
        }

        private void txtDistrict_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtProvince.Focus();
                e.Handled = true;
            }
        }

        private void txtProvince_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDepartament.Focus();
                e.Handled = true;
            }
        }

        private void txtDepartament_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCountry.Focus();
                e.Handled = true;
            }
        }

        private void txtCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRegion.Focus();
                e.Handled = true;
            }
        }

        private void txtRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                rBtnWorkYes.Focus();
                e.Handled = true;
            }
        }

        private void txtWorkPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                rBtnDesabilityYes.Focus();
                e.Handled = true;
            }
        }

        private void txtTypeDesability_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtEmail.Focus();
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNumberEmergency.Focus();
                e.Handled = true;
            }
        }

        private void txtNumberEmergency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDegreeAchieved.Focus();
                e.Handled = true;
            }
        }

        private void txtDegreeAchieved_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                rBtnFamilyBurdenYes.Focus();
                e.Handled = true;
            }
        }

        private void txtNumberFamilyBurden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                rBtnInternetYes.Focus();
                e.Handled = true;
            }
        }

        private void txtPhoneOperator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                checkBoxPc.Focus();
                e.Handled = true;
            }
        }

        private void txtNativeLenguaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnLoadPhotoDni.Focus();
                e.Handled = true;
            }
        }

        private void btnLoadPhotoDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSave.Focus();
                e.Handled = true;
            }
        }

        private void rBtnMasculino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                rBtnFemenino.Focus();
                e.Handled = true;
            }
        }

        private void rBtnFemenino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                rBtnOtros.Focus();
                e.Handled = true;
            }
        }

        private void rBtnOtros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDni.Focus();
                e.Handled = true;
            }
        }

        private void rBtnWorkYes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               rBtnWorkNot.Focus();
                e.Handled = true;
            }
        }

        private void rBtnWorkNot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                rBtnDesabilityYes.Focus();
                e.Handled = true;
            }
        }

        private void rBtnDesabilityYes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                rBtnDesabilityNot.Focus();
                e.Handled = true;
            }
        }

        private void rBtnDesabilityNot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtEmail.Focus();
                e.Handled = true;
            }
        }

        private void rBtnFamilyBurdenYes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                rBtnFamilyBurdenNot.Focus();
                e.Handled = true;
            }
        }

        private void rBtnFamilyBurdenNot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                rBtnInternetYes.Focus();
                e.Handled = true;
            }
        }

        private void rBtnInternetYes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                rBtnInternetNot.Focus();
                e.Handled = true;
            }
        }

        private void rBtnInternetNot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPhoneOperator.Focus();
                e.Handled = true;
            }
        }

        private void checkBoxPc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                checkBoxLaptop.Focus();
                e.Handled = true;
            }
        }

        private void checkBoxLaptop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                checkBoxCelular.Focus();
                e.Handled = true;
            }

        }

        private void checkBoxCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNativeLenguaje.Focus();
                e.Handled = true;
            }
        }

        private void txtDateBirth_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = txtDateBirth.Value;
            DateTime fechaActual = DateTime.Now;

            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Ajustar la edad si aún no ha cumplido años en este año
            if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
            {
                edad--;
            }

            // Mostrar la edad en el TextBox
            txtAge.Text = edad.ToString();
        }
    }
}
