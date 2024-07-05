using CapaDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntity;
using System.IO;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace CapaPresentation
{
    public partial class FrmAddSpecialty : Form
    {

        CDo_Procedures procedures = new CDo_Procedures();
        CE_Specialty specialty = new CE_Specialty();
        CDo_Specialties specialties = new CDo_Specialties();
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
        public FrmAddSpecialty()
        {
            InitializeComponent();
        }
        public bool SaveData()
        {
            try
            {
                if (procedures.VerifyTextBoxs(this))
                {

                    specialty.Name = txtName.Text; // Asume que hay un campo de texto para el año
     
                    // Parsea la fecha y hora

                    specialties.AddSpecialty(specialty);

                    MessageBox.Show("La especialidad se agregó exitósamente", "Agregar Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show($"La especialidad no fue agregado por: {ex.Message + " --" + ex.StackTrace}", "Agregar Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAddSpecialty_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSave.Focus();
                e.Handled = true;
            }
        }
    }
}
