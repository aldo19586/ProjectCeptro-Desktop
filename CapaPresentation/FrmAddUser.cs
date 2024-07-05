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
    public partial class FrmAddUser : Form
    {
        CDo_Procedures procedures = new CDo_Procedures();
        User user = new User();
        CDo_Users users = new CDo_Users();
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
        public FrmAddUser()
        {
            InitializeComponent();
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

                    user.Name = txtName.Text; // Asume que hay un campo de texto para el año
                    user.SurNames=txtSurtName.Text;
                    user.UserName =txtUser.Text;
                    user.Pass =txtPass.Text;
                    user.Rol= cBxRol.Text;
                    user.State = cBxState.Text;
                    // Parsea la fecha y hora
                   
                    users.AddUser(user);
               
                    MessageBox.Show("El usuario se agregó exitósamente", "Agregar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show($"El usuario no fue agregado por: {ex.Message + " --" + ex.StackTrace}", "Agregar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cBxState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSurtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtSurtName.Focus();
                e.Handled = true;
            }
        }

        private void txtSurtName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtUser.Focus();
                e.Handled = true;
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPass.Focus();
                e.Handled = true;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cBxRol.Focus();
                e.Handled = true;
            }
        }

        private void cBxRol_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cBxState.Focus();
                e.Handled = true;
            }
        }

        private void cBxState_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSave.Focus();
                e.Handled = true;
            }
        }
    }
}
