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
    public partial class FrmTeachingUnits : Form
    {
        CDo_TeachingUnits teachingUnits= new CDo_TeachingUnits();
        List<CE_Specialty> listSpecialties;
        CDo_Specialties specialties = new CDo_Specialties();
        CDo_Procedures procedures = new CDo_Procedures();   
        public FrmTeachingUnits()
        {
            InitializeComponent();
        }
        private void LoadTeachingUnits()
        {

            dataGridViewUnits.DataSource = teachingUnits.LoadListTeachingUnits();
            dataGridViewUnits.ClearSelection();
            dataGridViewUnits.Columns[0].Visible = false;
            dataGridViewUnits.Columns[7].DisplayIndex = 2;
          
            dataGridViewUnits.Columns[1].HeaderText = "N°";
            dataGridViewUnits.Columns[2].HeaderText = "Descripcion";
            dataGridViewUnits.Columns[3].HeaderText = "Credito";
            dataGridViewUnits.Columns[4].HeaderText = "Horas";
            dataGridViewUnits.Columns[5].HeaderText = "Condicion";
            dataGridViewUnits.Columns[3].Visible = false;
            dataGridViewUnits.Columns[5].Visible = false;
            dataGridViewUnits.Columns[6].Visible = false;
            dataGridViewUnits.Columns[7].HeaderText = "Especialidad";

            dataGridViewUnits.Columns["SpecialtyName"].Width = 300;
            dataGridViewUnits.Columns["Name"].Width = 180;
            dataGridViewUnits.Columns["Number"].Width = 50;
            dataGridViewUnits.Columns["Hours"].Width = 50;
        }
        private void AdTeach_UpdateEventHandler(object sender, FrmAddTeachingUnit.UpdateEventArgs args)
        {
            LoadTeachingUnits();
        }
        private void UpTeach_UpdateEventHandler(object sender, FrmUpdateTeachingUnit.UpdateEventArgs args)
        {
            LoadTeachingUnits();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTeachingUnits_Load(object sender, EventArgs e)
        {
            LoadTeachingUnits();
            listSpecialties = specialties.LoadListSpecialties();
        }

        private void btnAddUnitsDialog_Click(object sender, EventArgs e)
        {
            FrmAddTeachingUnit frmAddTeachingUnit = new FrmAddTeachingUnit();
            frmAddTeachingUnit.UpdateEventHandler += AdTeach_UpdateEventHandler;
            frmAddTeachingUnit.ShowDialog();
        }

        private void btnUpdateUnitsDialog_Click(object sender, EventArgs e)
        {

            if (dataGridViewUnits.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para actualizar.", "Actualizar Unidad Didáctica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridViewUnits.SelectedRows == null)
                {
                    MessageBox.Show("Por favor, seleccione un registro para actualizar.", "Actualizar Unidad Didactica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        FrmUpdateTeachingUnit existingInstance = Application.OpenForms.OfType<FrmUpdateTeachingUnit>().FirstOrDefault();
                        if (existingInstance != null)
                        {
                            existingInstance.BringToFront(); // Traer la instancia existente al frente
                        }
                        else
                        {
                            FrmUpdateTeachingUnit UpdateTeachingUnit = new FrmUpdateTeachingUnit(this);
                            UpdateTeachingUnit.UpdateEventHandler += UpTeach_UpdateEventHandler;
                            UpdateTeachingUnit.txtId.Text = dataGridViewUnits.SelectedRows[0].Cells[0].Value.ToString();
                            UpdateTeachingUnit.txtNumber.Text = dataGridViewUnits.SelectedRows[0].Cells[1].Value.ToString();
                            UpdateTeachingUnit.txtName.Text = dataGridViewUnits.SelectedRows[0].Cells[2].Value.ToString();
                            UpdateTeachingUnit.txtCredit.Text = dataGridViewUnits.SelectedRows[0].Cells[3].Value.ToString();
                            UpdateTeachingUnit.txtHours.Text = dataGridViewUnits.SelectedRows[0].Cells[4].Value.ToString();
                            UpdateTeachingUnit.txtConditions.Text = dataGridViewUnits.SelectedRows[0].Cells[5].Value.ToString();

                            // Obtener el nombre de la especialidad para seleccionar en el ComboBox
                            string specialtyName = "";
                            foreach (var item in listSpecialties)
                            {
                                if (item.Id == Convert.ToInt32(dataGridViewUnits.SelectedRows[0].Cells[6].Value.ToString()))
                                {
                                    specialtyName = item.Name;
                                    break;
                                }
                            }

                            // Llamar al método LoadCbxSpecialties en el formulario secundario pasando el nombre de la especialidad
                            UpdateTeachingUnit.LoadCbxSpecialties(specialtyName);

                            UpdateTeachingUnit.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Debe seleccionar algun registro para actualizar." + ex.Message + ex.StackTrace, "Actualizar Unidad Didáctica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnRemoveUnits_Click(object sender, EventArgs e)
        {
            if (dataGridViewUnits.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar.", "Eliminar Unidad Didáctica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridViewUnits.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar algun registro para eliminar.", "Eliminar Unidad Didáctica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    DialogResult result = MessageBox.Show("Esta seguro que desea eliminar la unidad didáctica", "Eliminar Unidad Didáctica", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var idUnit = Convert.ToInt32(dataGridViewUnits.SelectedRows[0].Cells[0].Value.ToString());

                        teachingUnits.DeleteTeachingUnit(idUnit);
                        LoadTeachingUnits();
                        MessageBox.Show("Se eliminó correctamente la unidad didáctica", "Eliminar Unidad Didáctica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


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
    }
}
