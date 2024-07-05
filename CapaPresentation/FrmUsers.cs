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
    public partial class FrmUsers : Form
    {
        CDo_Users users = new CDo_Users();
        CDo_Procedures procedures = new CDo_Procedures();

        public FrmUsers()
        {
            InitializeComponent();
        }

     

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {

            dataGridViewUsers.DataSource = users.LoadListUsers();
            dataGridViewUsers.ClearSelection();
            dataGridViewUsers.Columns[0].Visible= false;
            dataGridViewUsers.Columns[1].HeaderText= "Nombres";
            dataGridViewUsers.Columns[2].HeaderText = "Apellidos";
            dataGridViewUsers.Columns[3].HeaderText = "Usuario";
            dataGridViewUsers.Columns[4].HeaderText = "Contraseña";
            dataGridViewUsers.Columns[5].HeaderText = "Rol";
            dataGridViewUsers.Columns[6].HeaderText = "Estado";

            dataGridViewUsers.Columns["Name"].Width = 127;

        }
        private void AdUser_UpdateEventHandler(object sender, FrmAddUser.UpdateEventArgs args)
        {
            LoadUsers();
        }
        private void UpUser_UpdateEventHandler(object sender, FrmUpdateUser.UpdateEventArgs args)
        {
            LoadUsers();

        }
        private void btnAddUserDialog_Click(object sender, EventArgs e)
        {
            FrmAddUser adduser = new FrmAddUser();
            adduser.UpdateEventHandler += AdUser_UpdateEventHandler;
            adduser.ShowDialog();
        }
        private void btnUpdateUserDialog_Click(object sender, EventArgs e)
        {
    





            if (dataGridViewUsers.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para actualizar.", "Actualizar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridViewUsers.SelectedRows == null)
                {
                    MessageBox.Show("Por favor, seleccione un registro para actualizar.", "Actualizar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {

                        FrmUpdateUser existingInstance = Application.OpenForms.OfType<FrmUpdateUser>().FirstOrDefault();
                        if (existingInstance != null)
                        {
                            existingInstance.BringToFront(); // Traer la instancia existente al frente
                        }
                        else
                        {
                            FrmUpdateUser UpdateUser= new FrmUpdateUser(this);
                            UpdateUser.UpdateEventHandler += UpUser_UpdateEventHandler;
                            UpdateUser.txtId.Text = dataGridViewUsers.SelectedRows[0].Cells[0].Value.ToString();
                            UpdateUser.txtName.Text = dataGridViewUsers.SelectedRows[0].Cells[1].Value.ToString();
                            UpdateUser.txtSurtName.Text = dataGridViewUsers.SelectedRows[0].Cells[2].Value.ToString();
                            UpdateUser.txtUser.Text = dataGridViewUsers.SelectedRows[0].Cells[3].Value.ToString();
                            UpdateUser.txtPass.Text = dataGridViewUsers.SelectedRows[0].Cells[4].Value.ToString();
                            UpdateUser.cBxRol.Text = dataGridViewUsers.SelectedRows[0].Cells[5].Value.ToString();
                            UpdateUser.cBxState.Text = dataGridViewUsers.SelectedRows[0].Cells[6].Value.ToString();
                            UpdateUser.ShowDialog();
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Debe seleccionar algun registro para actualizar." + ex.Message + ex.StackTrace, "Actualizar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                }
            }

        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar.", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridViewUsers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar algun registro para eliminar.", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    DialogResult result = MessageBox.Show("Esta seguro que desea eliminar al usuario", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var idUser = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells[0].Value.ToString());

                        users.DeleteUser(idUser);
                        LoadUsers();
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
    }
}
