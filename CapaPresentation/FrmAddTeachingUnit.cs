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
using System.IO;
using CapaEntity;


namespace CapaPresentation
{
    public partial class FrmAddTeachingUnit : Form
    {
        CDo_Procedures procedures = new CDo_Procedures();
        CDo_TeachingUnits teachingUnits = new CDo_TeachingUnits();
        CE_TeachingUnit teachingUnit = new CE_TeachingUnit();
        CDo_Specialties specialties = new CDo_Specialties();
        List<CE_Specialty> listSpecialties;
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
        public FrmAddTeachingUnit()
        {
            InitializeComponent();
        }
        public bool SaveData()
        {
            try
            {
                if (procedures.VerifyTextBoxs(this))
                {

                    teachingUnit.Number =Convert.ToInt32(txtNumber.Text);
                    teachingUnit.Name = txtName.Text;
                    teachingUnit.Credit = txtCredit.Text;
                    teachingUnit.Hours =Convert.ToInt32( txtHours.Text);
                    teachingUnit.Conditions = txtConditions.Text;
                    foreach(var specialty in listSpecialties)
                    {
                        if (cBxSpecialties.Text == specialty.Name)
                        {
                            teachingUnit.SpecialtyId = specialty.Id;
                        }

                    }

                    teachingUnits.AddTeachingUnit(teachingUnit);

                    MessageBox.Show("La unidad didáctica se agregó exitósamente", "Agregar Unidad Didáctica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Focus();
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

                MessageBox.Show($"La unidad didáctica no fue agregado por: {ex.Message + " --" + ex.StackTrace}", "Agregar Unidad Didáctica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
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

        private void FrmAddTeachingUnit_Load(object sender, EventArgs e)
        {
            LoadCbxSpecialties();
            cBxSpecialties.Focus();
        }
        private void LoadCbxSpecialties()
        {
            listSpecialties = specialties.LoadListSpecialties();
            cBxSpecialties.DataSource = listSpecialties;
            cBxSpecialties.DisplayMember = "Name";

        }

        private void cBxSpecialties_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNumber.Focus();
                e.Handled = true;
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtName.Focus();
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCredit.Focus();
                e.Handled = true;
            }
        }

        private void txtCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtHours.Focus();
                e.Handled = true;
            }
        }

        private void txtHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtConditions.Focus();
                e.Handled = true;
            }
        }

        private void txtConditions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSave.Focus();
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
