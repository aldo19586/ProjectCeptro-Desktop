using CapaDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using CapaEntity;
using CapaEntity.Cache;
namespace CapaPresentation
{
    public partial class FrmCeptro : Form
    {
        CDo_Procedures procedures = new CDo_Procedures();
        CDo_Ceptro ceptro = new CDo_Ceptro();
        Ceptro objCeptro = new Ceptro();
        Ceptro ceptroBD;
        public event EventHandler CeptroFormClosed;

        public FrmCeptro()
        {
            InitializeComponent();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            ceptroBD = ceptro.LoadListCeptro(); // Assuming LoadListCeptro returns a Ceptro object
        }

        private void FrmCeptro_Load(object sender, EventArgs e)
        {
            if (InformationUser.Rol == "Director")
            {

            }
            else if (InformationUser.Rol == "Docente")
            {
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;

         

            }
            else if (InformationUser.Rol == "Auxiliar")
            {
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;

            }
            txtNameCeptro.Focus();
            if (ceptroBD != null )
            {
                LoadData(); // Pass ceptroBD as an argument to LoadData
            }
            else
            {
                // La lista está vacía o es null
            }
           

            if (txtId.Text == string.Empty)
            {
 
            }
            else
            {

               
                btnSave.Visible = false;
                btnUpdate.Visible = true;
            }
            // Ajustar el tamaño del formulario para que coincida con la pantalla del monitor
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void LoadData()
        {
         
           
            txtId.Text =ceptroBD.Id.ToString();
            txtNameCeptro.Text = ceptroBD.Name;
            txtCodeModular.Text = ceptroBD.CodeModular;
            txtxManagementType.Text = ceptroBD.CodeModular;
            txtUgel.Text = ceptroBD.CodeModular;
            txtResolutionAuth.Text = ceptroBD.ResolutionAuth;
            txtResolutionAuthProgram.Text = ceptroBD.ResolutionAuthProgram;
            txtPlaceService.Text = ceptroBD.PlaceService;
            txtDistrict.Text = ceptroBD.District;
            txtDepartament.Text = ceptroBD.Departament;
            txtProvince.Text = ceptroBD.Province;
            txtPhone.Text = ceptroBD.Phone;
            txtEmail.Text = ceptroBD.Email;
            txtDirection.Text = ceptroBD.Direction;
            txtWebPage.Text = ceptroBD.PageWeb;



        }
        public bool SaveData()
        {
            try
            {
                if (procedures.VerifyTextBoxs(this))
                {
                    objCeptro.Name = txtNameCeptro.Text;
                    objCeptro.CodeModular = txtCodeModular.Text;
                    objCeptro.ManagementType = txtxManagementType.Text;
                    objCeptro.Ugel = txtUgel.Text;
                    objCeptro.ResolutionAuth = txtResolutionAuth.Text;
                    objCeptro.ResolutionAuthProgram = txtResolutionAuthProgram.Text;
                    objCeptro.PlaceService = txtPlaceService.Text;
                    objCeptro.District = txtDistrict.Text;
                    objCeptro.Departament = txtDepartament.Text;
                    objCeptro.Province = txtProvince.Text;
                    objCeptro.Direction = txtDirection.Text;
                    objCeptro.Phone = txtPhone.Text;
                    objCeptro.Email = txtEmail.Text;
                    objCeptro.PageWeb = txtWebPage.Text;
                    objCeptro.ProgramStudies = "null";
                    objCeptro.InformativeLevel = "null";
                }
                else
                {

                }

                    ceptro.AddCeptro(objCeptro);
                    MessageBox.Show("La institución se agregó exitósamente", "Agregar Cetpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNameCeptro.Focus();
                    return true;
                
            }

            catch (Exception ex)
            {

                MessageBox.Show($"La institucion no fue agregado por: {ex.Message + " --" + ex.StackTrace}", "Agregar Cetpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        public bool UpdateData()
        {
            try
            {
                procedures.VerifyTextBoxs(this);
             
                objCeptro.Id = int.Parse(txtId.Text); // Make sure to parse the Id as it's likely an integer
                objCeptro.Name = txtNameCeptro.Text;
                objCeptro.CodeModular = txtCodeModular.Text;
                objCeptro.ManagementType = txtxManagementType.Text;
                objCeptro.Ugel = txtUgel.Text;
                objCeptro.ResolutionAuth = txtResolutionAuth.Text;
                objCeptro.ResolutionAuthProgram = txtResolutionAuthProgram.Text;
                objCeptro.PlaceService = txtPlaceService.Text;
                objCeptro.District = txtDistrict.Text;
                objCeptro.Departament = txtDepartament.Text;
                objCeptro.Province = txtProvince.Text;
                objCeptro.Direction = txtDirection.Text;
                objCeptro.Phone = txtPhone.Text;
                objCeptro.Email = txtEmail.Text;
                objCeptro.PageWeb = txtWebPage.Text;
                objCeptro.ProgramStudies = "null";
                objCeptro.InformativeLevel = "null";

                ceptro.UpdateCeptro(objCeptro); // This is the method you need to implement in CDo_Ceptro
                MessageBox.Show("La institución se actualizó exitósamente", "Actualizar Cetpro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"La institucion no fue actualizada por: {ex.Message + " --" + ex.StackTrace}", "Actualizar Ceptpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
            try
            {
                // Ruta del directorio de Release
                string releaseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
                //MessageBox.Show(releaseDirectory);
               // MessageBox.Show(releaseDirectory);
                // Reemplazar la base de datos en el directorio de Release
                procedures.ReplaceDatabase(releaseDirectory);

                MessageBox.Show("Respaldo realizado con éxito.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el respaldo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCeptro_FormClosed(object sender, FormClosedEventArgs e)
        {
            CeptroFormClosed?.Invoke(this, EventArgs.Empty);
        }

        private void txtNameCeptro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtxManagementType.Focus();
                e.Handled = true;
            }
        }

        private void txtxManagementType_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPlaceService.Focus();
                e.Handled = true;
            }
        }

        private void txtPlaceService_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               txtDepartament.Focus();
                e.Handled = true;
            }
        }

        private void txtDepartament_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtEmail.Focus();
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCodeModular.Focus();
                e.Handled = true;
            }
        }

        private void txtCodeModular_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtResolutionAuthProgram.Focus();
                e.Handled = true;
            }
        }

        private void txtResolutionAuthProgram_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDistrict.Focus();
                e.Handled = true;
            }
        }

        private void txtDistrict_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPhone.Focus();
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtWebPage.Focus();
                e.Handled = true;
            }
        }

        private void txtWebPage_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtUgel.Focus();
                e.Handled = true;
            }
        }

        private void txtUgel_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtResolutionAuth.Focus();
                e.Handled = true;
            }
        }

        private void txtResolutionAuth_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtProvince.Focus();
                e.Handled = true;
            }
        }

        private void txtProvince_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDirection.Focus();
                e.Handled = true;
            }
        }

        private void txtDirection_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSave.Focus();
                e.Handled = true;
            }
        }

      
    }
}
