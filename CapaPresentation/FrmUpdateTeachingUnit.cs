﻿using CapaDomain;
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
    public partial class FrmUpdateTeachingUnit : Form
    {
        CDo_Procedures procedures = new CDo_Procedures();
        CDo_TeachingUnits teachingUnits = new CDo_TeachingUnits();
        CE_TeachingUnit teachingUnit = new CE_TeachingUnit();
        CDo_Specialties specialties = new CDo_Specialties();
        
        List<CE_Specialty> listSpecialties;
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
        public FrmUpdateTeachingUnit(FrmTeachingUnits frmTeachingUnits)
        {

            InitializeComponent();
            LoadCbxSpecialties();
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
                // Reemplazar la base de datos en el directorio de Release
                procedures.ReplaceDatabase(releaseDirectory);

                MessageBox.Show("Respaldo realizado con éxito.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el respaldo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmUpdateTeachingUnit_Load(object sender, EventArgs e)
        {
            cBxSpecialties.Focus();
        }
        public void UpdateData()
        {
            try
            {
                if (procedures.VerifyTextBoxs(this))
                {
                    teachingUnit.Id = Convert.ToInt32(txtId.Text);
                    teachingUnit.Number = Convert.ToInt32(txtNumber.Text);
                    teachingUnit.Name = txtName.Text;
                    teachingUnit.Credit = txtCredit.Text;
                    teachingUnit.Hours = Convert.ToInt32(txtHours.Text);
                    teachingUnit.Conditions = txtName.Text;
                    foreach (var specialty in listSpecialties)
                    {
                        if (cBxSpecialties.Text == specialty.Name)
                        {
                            teachingUnit.SpecialtyId = specialty.Id;
                        }

                    }

                    teachingUnits.UpdateTeachingUnit(teachingUnit);

                    MessageBox.Show("La unidad didáctica se actualizó exitósamente", "Actualizar Unidad Didáctica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumber.Focus();
                    NotifyUpdate();
      
                }
                else
                {
               
                }


            }

            catch (Exception ex)
            {

                MessageBox.Show($"La unidad didáctica no fue actualizado por: {ex.Message + " --" + ex.StackTrace}", "Actualizar Unidad Didáctica", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            }
        }
        public void LoadCbxSpecialties(string selectedSpecialtyName = null)
        {
            // Cargar la lista de especialidades
            listSpecialties = specialties.LoadListSpecialties();
            cBxSpecialties.DataSource = listSpecialties;
            cBxSpecialties.DisplayMember = "Name";

            // Si se proporciona un nombre de especialidad seleccionada
            if (!string.IsNullOrEmpty(selectedSpecialtyName))
            {
                // Buscar la especialidad en la lista
                var selectedSpecialty = listSpecialties.FirstOrDefault(s => s.Name == selectedSpecialtyName);

                // Si se encuentra la especialidad, establecerla como seleccionada
                if (selectedSpecialty != null)
                {
                    cBxSpecialties.SelectedItem = selectedSpecialty;
                }
            }
        }

        private void cBxSpecialties_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNumber.Focus();
                e.Handled = true;
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtName.Focus();
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCredit.Focus();
                e.Handled = true;
            }
        }

        private void txtCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtHours.Focus();
                e.Handled = true;
            }
        }

        private void txtHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtConditions.Focus();
                e.Handled = true;
            }
        }

        private void txtConditions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnUpdate.Focus();
                e.Handled = true;
            }
        }
    }
}
