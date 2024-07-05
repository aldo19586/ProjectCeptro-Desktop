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

namespace CapaPresentation
{

    public partial class FrmStudentsView : Form
    {
        CDo_Students students = new CDo_Students();
        List<Student> listStudents;
        public FrmStudentsView()
        {
            InitializeComponent();
        }

        private void FrmStudentsView_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void LoadStudents()
        {

            dataGridViewStudents.DataSource = students.LoadStudents();
            dataGridViewStudents.ClearSelection();
            dataGridViewStudents.Columns[0].Visible = false;
            dataGridViewStudents.Columns[1].Visible = false;
            dataGridViewStudents.Columns[6].Visible = false;
            dataGridViewStudents.Columns[7].Visible = false;
            dataGridViewStudents.Columns[9].Visible = false;
            dataGridViewStudents.Columns[10].Visible = false;
            dataGridViewStudents.Columns[11].Visible = false;
            dataGridViewStudents.Columns[12].Visible = false;
            dataGridViewStudents.Columns[13].Visible = false;
            dataGridViewStudents.Columns[14].Visible = false;
            dataGridViewStudents.Columns[15].Visible = false;
            dataGridViewStudents.Columns[16].Visible = false;

            dataGridViewStudents.Columns[18].Visible = false;

            dataGridViewStudents.Columns[20].Visible = false;
            dataGridViewStudents.Columns[21].Visible = false;
            dataGridViewStudents.Columns[22].Visible = false;
            dataGridViewStudents.Columns[23].Visible = false;
            dataGridViewStudents.Columns[24].Visible = false;
            dataGridViewStudents.Columns[25].Visible = false;
            dataGridViewStudents.Columns[26].Visible = false;
            dataGridViewStudents.Columns[27].Visible = false;
            dataGridViewStudents.Columns[28].Visible = false;
            dataGridViewStudents.Columns[29].Visible = false;
            dataGridViewStudents.Columns[30].Visible = false;
            dataGridViewStudents.Columns[31].Visible = false;
            dataGridViewStudents.Columns[32].Visible = false;
            dataGridViewStudents.Columns[33].Visible = false;


            dataGridViewStudents.Columns[2].HeaderText = "Cod. Inscripcion";
            dataGridViewStudents.Columns[3].HeaderText = "A. Paterno";
            dataGridViewStudents.Columns[4].HeaderText = "A. Materno";
            dataGridViewStudents.Columns[5].HeaderText = "Nombres";
            dataGridViewStudents.Columns[8].HeaderText = "Dni";
            dataGridViewStudents.Columns[17].HeaderText = "Puesto";
            dataGridViewStudents.Columns[19].HeaderText = "Teléfono";

            listStudents = students.LoadStudents();
            // Ocultar la columna "photodni"
            dataGridViewStudents.Columns["PhotoDni"].Visible = false;


            dataGridViewStudents.Columns["WorkPosition"].Width = 130;
            dataGridViewStudents.Columns["FirstName"].Width = 150;

        }

        private void dataGridViewStudents_DoubleClick(object sender, EventArgs e)
        {

            if (dataGridViewStudents.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        public void Search()
        {
            try
            {
                if (comboBoxTypeSearch.Text == "Codigo" || comboBoxTypeSearch.Text == "Dni" || comboBoxTypeSearch.Text == "Nombres" || comboBoxTypeSearch.Text == "Apellidos")
                {
                    dataGridViewStudents.DataSource = students.SearchStudent(txtSearchStudent.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El studiante no fue encontrado por: " + ex.Message, "Buscar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
