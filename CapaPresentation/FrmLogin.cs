using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDomain;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace CapaPresentation
{
    public partial class FrmLogin : Form
    {
        CDo_Users users = new CDo_Users();  
        public FrmLogin()
        {
            InitializeComponent();
        
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mostrar el formulario de login
            FrmLogin login = new FrmLogin();
            login.Show();
            // No cancelar el cierre del formulario principal
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Debe completar el campo Usuario ", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Debe completar el campo Passsword ", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (users.Login(txtUser.Text, txtPass.Text) == true)
                {
                    FrmMain principal = new FrmMain();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectas ", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser.Clear();
                    txtPass.Clear();
                    txtUser.Focus();
                }
            }
           
        }
  

        
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                //Application.Exit();
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            txtPass.PasswordChar = '*';
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
                btnLogin.Focus();
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
