using CapaDomain;
using CapaEntity;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class FrmUpdateSpecialty : Form
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
        protected void NotifyUpdate()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        public FrmUpdateSpecialty(FrmSpecialties specialties)
        {
            InitializeComponent();
        }
        public bool UpdateData()
        {
            try
            {
                if (procedures.VerifyTextBoxs(this))
                {
                    specialty.Id = Convert.ToInt32(txtId.Text);
                    specialty.Name = txtName.Text; // Asume que hay un campo de texto para el año

                    // Parsea la fecha y hora

                    specialties.UpdateSpecialty(specialty);

                    MessageBox.Show("La especialidad se actualizó exitósamente", "Actualizar Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Focus();
                    NotifyUpdate();
                    return true;
                }
                else
                {
                    return false;
                }


            }

            catch (Exception ex)
            {

                MessageBox.Show($"La especialidad no se actualizó por: {ex.Message + " --" + ex.StackTrace}", "Actualizar Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUpdateSpecialty_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               btnUpdate.Focus();
                e.Handled = true;
            }
        }
    }
}
