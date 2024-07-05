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
using System.IO;

namespace CapaPresentation
{
    public partial class FrmUpdateTuition : Form
    {
        CDo_Procedures procedures = new CDo_Procedures();
        CE_Tuition tuition = new CE_Tuition();
        CDo_Tuition tuitions = new CDo_Tuition();
        CDo_Specialties specialties = new CDo_Specialties();
        CDo_Ceptro ceptros = new CDo_Ceptro();
        Ceptro ceptro = new Ceptro();

        List<CE_Specialty> listSpecialties;
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void NotifyUpdate()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        public FrmUpdateTuition(FrmTuition tuition)
        {
            InitializeComponent();
            LoadCbxSpecialties();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
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
        private void UpdateData()
        {
            try
            {
                if (procedures.VerifyTextBoxs(this))
                {
                    tuition.Id =Convert.ToInt32(txtId.Text) ;
                    tuition.NameCetpro = ceptro.Name;
                    tuition.CodeModular = ceptro.CodeModular;
                    tuition.Department = ceptro.Departament;
                    tuition.Province = ceptro.Province;
                    tuition.District = ceptro.District;
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

                    tuitions.UpdateTuition(tuition);

                    MessageBox.Show("La matricula se actualizó exitósamente", "Actualizar Matricula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDni.Focus();
                    NotifyUpdate();

                }
                else
                {
 
                }


            }

            catch (Exception ex)
            {

                MessageBox.Show($"La matricula no fue actualizado por: {ex.Message + " --" + ex.StackTrace}", "Actualizar Matricula", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            }
        }
        private void FrmUpdateTuition_Load(object sender, EventArgs e)
        {
            ceptro = ceptros.LoadListCeptro();
            txtDni.Focus();
       
        }
        public void LoadCbxSpecialties(string selectedSpecialtyName = null)
        {
            // Cargar la lista de especialidades
            listSpecialties = specialties.LoadListSpecialties();
            cBxSpecialties.DataSource = listSpecialties;
            cBxSpecialties.DisplayMember = "Name";

            // Si se proporciona un nombre de especialidad seleccionada
            if (!string.IsNullOrEmpty(selectedSpecialtyName))
            {
                // Buscar la especialidad en la lista
                var selectedSpecialty = listSpecialties.FirstOrDefault(s => s.Name == selectedSpecialtyName);

                // Si se encuentra la especialidad, establecerla como seleccionada
                if (selectedSpecialty != null)
                {
                    cBxSpecialties.SelectedItem = selectedSpecialty;
                }
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
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
                btnUpdate.Focus();
                e.Handled = true;
            }
        }
    }
}
