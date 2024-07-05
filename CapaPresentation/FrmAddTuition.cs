using CapaDomain;
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
using System.Xml.Linq;
using System.IO;

namespace CapaPresentation
{
    public partial class FrmAddTuition : Form
    {
        CDo_Procedures procedures = new CDo_Procedures();

        CE_Tuition tuition= new CE_Tuition();
        CDo_Tuition tuitions = new CDo_Tuition();
        CDo_Ceptro ceptros = new CDo_Ceptro();
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        Ceptro ceptro;
        List<CE_Specialty> listSpecialties;
        CDo_Specialties specialties = new CDo_Specialties();
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void NotifyAdd()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        public FrmAddTuition()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAddTuition_Load(object sender, EventArgs e)
        {
            LoadCbxSpecialties();
            listSpecialties = specialties.LoadListSpecialties();
            ceptro = ceptros.LoadListCeptro();
            txtDni.Focus();
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
                    tuition.NameCetpro = ceptro.Name;
                    tuition.CodeModular = ceptro.CodeModular;
                    tuition.Department = ceptro.Departament;
                    tuition.Province = ceptro.Province;
                    tuition.District  = ceptro.District;
                    tuition.ManagementType = ceptro.ManagementType;
                    tuition.Dni = txtDni.Text;
                    tuition.NamesLastNames = txtNamesLastNames.Text;


                    foreach (var specialty in listSpecialties)
                    {
                        if (cBxSpecialties.Text == specialty.Name)
                        {
                            tuition.SpecialtyId = specialty.Id;
                        }
                    }

                        
                    tuition.SchoolPeriod = txtSchoolPeriod.Text;
                    tuition.ClassPeriod = txtClassPeriod.Text;
                    tuition.AcademicPeriod = txtAcademicPeriod.Text;
                    tuition.Module = txtModule.Text;
                    tuition.InformativeLevel = txtInformativeLevel.Text;
                    tuition.StudyPlanType = txtStudyPlanType.Text;
                    tuition.Dre = txtDre.Text;

                    // Parsea la fecha y hora

                    tuitions.AddTuition(tuition);

                    MessageBox.Show("La matricula se agregó exitósamente", "Agregar Matricula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDni.Focus();
                    NotifyAdd();
                    Close();
                    return true;
                }
                else
                {
                    return false;
                }


            }

            catch (Exception ex)
            {

                MessageBox.Show($"La matricula no fue agregado por: {ex.Message + " --" + ex.StackTrace}", "Agregar Matricula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        private void LoadCbxSpecialties()
        {
            listSpecialties = specialties.LoadListSpecialties();
            cBxSpecialties.DataSource = listSpecialties;
            cBxSpecialties.DisplayMember = "Name";

        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
    


            // Verificar si ya existe una instancia de FrmViewCategory abierta
            FrmStudentsView existingInstance = Application.OpenForms.OfType<FrmStudentsView>().FirstOrDefault();

            if (existingInstance != null)
            {
                // Si existe una instancia, traerla al frente
                existingInstance.BringToFront();
            }
            else
            {
                // Si no existe una instancia, crear una nueva
                using (FrmStudentsView StudentsView = new FrmStudentsView())
                {
                    StudentsView.ShowDialog(); // Mostrar el formulario como un cuadro de diálogo

                    if (StudentsView.DialogResult == DialogResult.OK)
                    {
                        try
                        {
                            // Asignar el valor seleccionado del DataGridView a txtProviders
                            txtDni.Text = StudentsView.dataGridViewStudents
                                .Rows[StudentsView.dataGridViewStudents.CurrentRow.Index]
                                .Cells[8].Value.ToString();
                            txtNamesLastNames.Text = StudentsView.dataGridViewStudents
                                .Rows[StudentsView.dataGridViewStudents.CurrentRow.Index]
                                .Cells[3].Value.ToString() + " "+ StudentsView.dataGridViewStudents
                                .Rows[StudentsView.dataGridViewStudents.CurrentRow.Index]
                                .Cells[4].Value.ToString()+ " "+ StudentsView.dataGridViewStudents
                                .Rows[StudentsView.dataGridViewStudents.CurrentRow.Index]
                                .Cells[5].Value.ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se seleccionó el estudiante debido a " + ex.Message, "Seleccionar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                }
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               btnSearchStudent.Focus();
                e.Handled = true;
            }
        }

        private void btnSearchStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNamesLastNames.Focus();
                e.Handled = true;
            }
        }

        private void txtNamesLastNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cBxSpecialties.Focus();
                e.Handled = true;
            }
        }

        private void cBxSpecialties_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtSchoolPeriod.Focus();
                e.Handled = true;
            }
        }

        private void txtSchoolPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtClassPeriod.Focus();
                e.Handled = true;
            }
        }

        private void txtClassPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtAcademicPeriod.Focus();
                e.Handled = true;
            }
        }

        private void txtAcademicPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtModule.Focus();
                e.Handled = true;
            }
        }

        private void txtModule_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtInformativeLevel.Focus();
                e.Handled = true;
            }
        }

        private void txtInformativeLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtStudyPlanType.Focus();
                e.Handled = true;
            }
        }

        private void txtStudyPlanType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDre.Focus();
                e.Handled = true;
            }
        }

        private void txtDre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSave.Focus();
                e.Handled = true;
            }
        }
    }
}
