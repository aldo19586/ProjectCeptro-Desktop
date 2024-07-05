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
using CapaEntity.Cache;

namespace CapaPresentation
{
    public partial class FrmTuition : Form
    {
        CDo_Tuition tuitions = new CDo_Tuition();
        List<CE_Specialty> listSpecialties;
        CDo_Specialties specialties = new CDo_Specialties();
        public event EventHandler TuitionFormClosed;
        CDo_Procedures procedures = new CDo_Procedures();   
        public FrmTuition()
        {
            InitializeComponent();
        }

        private void btnAddTuitionDialog_Click(object sender, EventArgs e)
        {
            FrmAddTuition frm = new FrmAddTuition();
            frm.UpdateEventHandler += AdTuit_UpdateEventHandler;
            frm.ShowDialog();
        }
        private void AdTuit_UpdateEventHandler(object sender, FrmAddTuition.UpdateEventArgs args)
        {
            LoadTuition();
        }
        private void UpTuit_UpdateEventHandler(object sender, FrmUpdateTuition.UpdateEventArgs args)
        {
            LoadTuition();
            

        }
        private void LoadTuition()
        {

            dataGridViewTuition.DataSource = tuitions.LoadListTuitions();
            dataGridViewTuition.ClearSelection();

            dataGridViewTuition.Columns[0].Visible = false;
           
            dataGridViewTuition.Columns[2].Visible = false;
            dataGridViewTuition.Columns[3].Visible = false;
            dataGridViewTuition.Columns[4].Visible = false;
            dataGridViewTuition.Columns[5].Visible = false;
            dataGridViewTuition.Columns[6].Visible = false;
            dataGridViewTuition.Columns[7].Visible = false;

            //dataGridViewUnits.Columns[7].DisplayIndex = 2;

            dataGridViewTuition.Columns[1].HeaderText = "Cetpro";
            dataGridViewTuition.Columns[2].HeaderText = "Codigo Modular";
            dataGridViewTuition.Columns[3].HeaderText = "Departamento";
            dataGridViewTuition.Columns[4].HeaderText = "Provincia";
            dataGridViewTuition.Columns[5].HeaderText = "Distrito";
            dataGridViewTuition.Columns[6].HeaderText = "Dre";
            dataGridViewTuition.Columns[7].HeaderText = "Tipo de Gestion";
            dataGridViewTuition.Columns[8].HeaderText = "Periodo Lectivo";
            dataGridViewTuition.Columns[9].HeaderText = "Periodo Clases";
            dataGridViewTuition.Columns[10].HeaderText = "Nivel Formativo";
            dataGridViewTuition.Columns[11].HeaderText = "Plan de Estudios";
            dataGridViewTuition.Columns[12].HeaderText = "Dni";
            dataGridViewTuition.Columns[13].HeaderText = "Apellidos y Nombres";
            dataGridViewTuition.Columns[14].HeaderText = "Especialidad";
            dataGridViewTuition.Columns[15].HeaderText = "Periodo Academico";
            dataGridViewTuition.Columns[16].HeaderText = "Modulo";

            dataGridViewTuition.Columns["NameCetpro"].Width = 200;
            dataGridViewTuition.Columns["NamesLastNames"].Width = 250;
            dataGridViewTuition.Columns["ClassPeriod"].Width = 200;
            //dataGridViewTuition.Columns["Name"].Width = 180;
            //dataGridViewTuition.Columns["Number"].Width = 50;
            //dataGridViewTuition.Columns["Hours"].Width = 50;

        }
        private void FrmTuition_Load(object sender, EventArgs e)
        {
            if (InformationUser.Rol == "Director")
            {

            }
            else if (InformationUser.Rol == "Docente")
            {
                btnAddTuitionDialog.Enabled = false;
                btnUpdateTuitionDialog.Enabled = false;
                btnRemoveTuition.Enabled = false;



            }
            else if (InformationUser.Rol == "Auxiliar")
            {
                btnAddTuitionDialog.Enabled = false;
                btnUpdateTuitionDialog.Enabled = false;
                btnRemoveTuition.Enabled = false;

            }
            LoadTuition();
            listSpecialties = specialties.LoadListSpecialties();
            // Ajustar el tamaño del formulario para que coincida con la pantalla del monitor
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.MinimumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);


            // Permitir cambiar el tamaño del formulario
            this.FormBorderStyle = FormBorderStyle.Sizable;


            
        }

        private void btnUpdateTuitionDialog_Click(object sender, EventArgs e)
        {
            if (dataGridViewTuition.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para actualizar.", "Actualizar Matricula", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridViewTuition.SelectedRows == null)
                {
                    MessageBox.Show("Por favor, seleccione un registro para actualizar.", "Actualizar Matricula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        FrmUpdateTuition existingInstance = Application.OpenForms.OfType<FrmUpdateTuition>().FirstOrDefault();
                        if (existingInstance != null)
                        {
                            existingInstance.BringToFront(); // Traer la instancia existente al frente
                        }
                        else
                        {
                            FrmUpdateTuition UpdateTuition = new FrmUpdateTuition(this);
                            UpdateTuition.UpdateEventHandler += UpTuit_UpdateEventHandler;
                            UpdateTuition.txtId.Text = dataGridViewTuition.SelectedRows[0].Cells[0].Value.ToString();
                            UpdateTuition.txtNamesLastNames.Text = dataGridViewTuition.SelectedRows[0].Cells[13].Value.ToString();
               
                            UpdateTuition.txtSchoolPeriod.Text = dataGridViewTuition.SelectedRows[0].Cells[8].Value.ToString();
                            UpdateTuition.txtClassPeriod.Text = dataGridViewTuition.SelectedRows[0].Cells[9].Value.ToString();
                            UpdateTuition.txtAcademicPeriod.Text = dataGridViewTuition.SelectedRows[0].Cells[15].Value.ToString();
                            UpdateTuition.txtModule.Text = dataGridViewTuition.SelectedRows[0].Cells[16].Value.ToString();
                            UpdateTuition.txtInformativeLevel.Text = dataGridViewTuition.SelectedRows[0].Cells[10].Value.ToString();
                            UpdateTuition.txtStudyPlanType.Text = dataGridViewTuition.SelectedRows[0].Cells[11].Value.ToString();
                            UpdateTuition.txtDre.Text = dataGridViewTuition.SelectedRows[0].Cells[6].Value.ToString();
                            UpdateTuition.txtDni.Text = dataGridViewTuition.SelectedRows[0].Cells[12].Value.ToString();

                            // Obtener el nombre de la especialidad para seleccionar en el ComboBox
                            string specialtyName = "";
                            foreach (var item in listSpecialties)
                            {
                                if (item.Id == Convert.ToInt32(dataGridViewTuition.SelectedRows[0].Cells[14].Value.ToString()))
                                {
                                    specialtyName = item.Name;
                                    break;
                                }
                            }

                            // Llamar al método LoadCbxSpecialties en el formulario secundario pasando el nombre de la especialidad
                            UpdateTuition.LoadCbxSpecialties(specialtyName);

                            UpdateTuition.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Debe seleccionar algun registro para actualizar." + ex.Message + ex.StackTrace, "Actualizar Matricula", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemoveTuition_Click(object sender, EventArgs e)
        {
            if (dataGridViewTuition.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar.", "Eliminar Matricula", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridViewTuition.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar algun registro para eliminar.", "Eliminar Matricula", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    DialogResult result = MessageBox.Show("Esta seguro que desea eliminar la matricula", "Eliminar Matricula", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var idTuition = Convert.ToInt32(dataGridViewTuition.SelectedRows[0].Cells[0].Value.ToString());

                        tuitions.DeleteTuition(idTuition);
                        LoadTuition();
                        MessageBox.Show("Se eliminó correctamente la matricula", "Eliminar Matricula", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


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

        private void txtSearchTuition_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTypeSearch.Text == "Dni" || comboBoxTypeSearch.Text == "Nombres" || comboBoxTypeSearch.Text == "Apellidos" )
                {
                    dataGridViewTuition.DataSource = tuitions.SearchTuition(txtSearchTuition.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El studiante no fue encontrado por: " + ex.Message, "Eliminar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBoxTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmTuition_FormClosed(object sender, FormClosedEventArgs e)
        {
            TuitionFormClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}
