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
using System.IO;

namespace CapaPresentation
{
    public partial class FrmSpecialties : Form
    {
     CDo_Procedures procedures = new CDo_Procedures();
        CDo_Specialties specialties = new CDo_Specialties();
        public FrmSpecialties()
        {
            InitializeComponent();
        }

        private void btnAddSpecialtyDialog_Click(object sender, EventArgs e)
        {
            FrmAddSpecialty frmAddSpecialty = new FrmAddSpecialty();
            frmAddSpecialty.UpdateEventHandler += AdSpec_UpdateEventHandler;
            frmAddSpecialty.ShowDialog();
        }

        private void btnUpdateSpecialtyDialog_Click(object sender, EventArgs e)
        {
            if (dataGridViewSpecialties.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para actualizar.", "Actualizar Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridViewSpecialties.SelectedRows == null)
                {
                    MessageBox.Show("Por favor, seleccione un registro para actualizar.", "Actualizar Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {

                        FrmUpdateSpecialty existingInstance = Application.OpenForms.OfType<FrmUpdateSpecialty>().FirstOrDefault();
                        if (existingInstance != null)
                        {
                            existingInstance.BringToFront(); // Traer la instancia existente al frente
                        }
                        else
                        {
                            FrmUpdateSpecialty UpdateSpecialty = new FrmUpdateSpecialty(this);
                            UpdateSpecialty.UpdateEventHandler += UpSpec_UpdateEventHandler;
                            UpdateSpecialty.txtId.Text = dataGridViewSpecialties.SelectedRows[0].Cells[0].Value.ToString();
                            UpdateSpecialty.txtName.Text = dataGridViewSpecialties.SelectedRows[0].Cells[1].Value.ToString();
                            UpdateSpecialty.ShowDialog();
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Debe seleccionar algun registro para actualizar." + ex.Message + ex.StackTrace, "Actualizar Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                }
            }
        }

        private void btnRemoveSpecialty_Click(object sender, EventArgs e)
        {
            if (dataGridViewSpecialties.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar.", "Eliminar Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridViewSpecialties.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar algun registro para eliminar.", "Eliminar Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    DialogResult result = MessageBox.Show("Esta seguro que desea eliminar la especialidad", "Eliminar Especialiad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var idSpecialty = Convert.ToInt32(dataGridViewSpecialties.SelectedRows[0].Cells[0].Value.ToString());

                        specialties.DeleteSpecialty(idSpecialty);
                        LoadSpecialties();
                        MessageBox.Show("Se eliminó correctamente la especialidad", "Eliminar Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


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

        private void FrmSpecialties_Load(object sender, EventArgs e)
        {
            LoadSpecialties();
        }
        private void LoadSpecialties()
        {

            dataGridViewSpecialties.DataSource = specialties.LoadListSpecialties();
            dataGridViewSpecialties.ClearSelection();

            dataGridViewSpecialties.Columns[0].Visible = false;
            dataGridViewSpecialties.Columns[1].HeaderText = "Descripcion";
            dataGridViewSpecialties.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSpecialties.Columns["Name"].Width = 530;
            


        }
        private void AdSpec_UpdateEventHandler(object sender, FrmAddSpecialty.UpdateEventArgs args)
        {
            LoadSpecialties();
        }
        private void UpSpec_UpdateEventHandler(object sender, FrmUpdateSpecialty.UpdateEventArgs args)
        {
            LoadSpecialties();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
