using CapaEntity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaData
{
    public class CD_Procedures
    {
       public bool VerifyControls(Form form)
        {
            bool isAllControlsComplete = true;

            // Itera a través de todos los controles en el formulario
            foreach (Control xCtrl in form.Controls)
            {
                        // Verifica si el control actual es un TextBox
                        if (xCtrl is TextBox textBox)
                        {
                            // Verifica si el TextBox tiene un nombre específico que quieras excluir de la validación
                            if (textBox.Name != "txtWorkPosition" || textBox.Name != "txtTypeDesability" || textBox.Name != "txtNumberFamilyBurden")
                            {
                        
                            }
                            else
                            {
                                // Si no es uno de los excluidos, verifica si está vacío
                                if (string.IsNullOrWhiteSpace(textBox.Text))
                                {
                                    // Si está vacío, muestra un MessageBox y marca que no todos los controles están completos
                                    MessageBox.Show("Completar todos los campos por favor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    isAllControlsComplete = false;
                                    return isAllControlsComplete; // Retorna false inmediatamente si encuentra un control incompleto
                                }
                            }
                        }
                        // Verifica si el control actual es un RadioButton
                        else if (xCtrl is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)xCtrl;
                    // Verifica si el RadioButton está seleccionado, asumiendo que al menos uno debe estar seleccionado
                    if (!radioButton.Checked && radioButton.Parent.Controls.OfType<RadioButton>().All(rb => !rb.Checked))
                    {
                        MessageBox.Show("Selecciona una opción para: " + radioButton.Name, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isAllControlsComplete = false;
                        return isAllControlsComplete; // Retorna false inmediatamente si no se ha seleccionado ninguna opción
                    }
                }
                // Verifica si el control actual es un CheckBox
                else if (xCtrl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)xCtrl;
                    // Aquí puedes verificar si necesitas que el CheckBox esté marcado o no según tu lógica de validación
                    // Por ejemplo, si al menos uno debe estar marcado:
                    if (!checkBox.Checked && form.Controls.OfType<CheckBox>().All(cb => !cb.Checked))
                    {
                        MessageBox.Show("Marca al menos una opción para: " + checkBox.Name, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isAllControlsComplete = false;
                        return isAllControlsComplete; // Retorna false inmediatamente si no se ha marcado ninguna opción
                    }
                }
            }
            return isAllControlsComplete;
        }
        public  void ReplaceDatabase(string debugDirectory)
        {
            try
            {
                // Verificar si el directorio de Debug existe
                if (!Directory.Exists(debugDirectory))
                {
                    MessageBox.Show("El directorio de Debug no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ruta del archivo de base de datos actual
                string databasePath = ConfigurationManager.AppSettings["DatabasePath"];
                string appDataPath = Environment.ExpandEnvironmentVariables(databasePath);

                // Verificar si la base de datos actual existe
                if (!File.Exists(appDataPath))
                {
                    throw new FileNotFoundException("La base de datos especificada no se encontró.", appDataPath);
                }

                // Ruta del archivo de base de datos en la carpeta de Debug
                string debugDatabasePath = Path.Combine(debugDirectory, "databaseCeptro.db");

                // Verificar si el archivo de destino está en uso
                if (IsFileLocked(debugDatabasePath))
                {
                    throw new IOException("El archivo está siendo utilizado por otro proceso.");
                }

                // Reemplazar la base de datos en la carpeta de Debug
                File.Copy(appDataPath, debugDatabasePath, true);

              
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"Error al copiar la base de datos: El archivo está siendo utilizado por otro proceso.\n{ioEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al copiar la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Función para verificar si un archivo está bloqueado
        private bool IsFileLocked(string filePath)
        {
            try
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                return true;
            }
            return false;
        }
        public List<SpecialtyXteachingUnit> LoadListSpecialtyXteachingUnit()
        {

            List<SpecialtyXteachingUnit> listSpecialtyXteachingUnit = new List<SpecialtyXteachingUnit>();

            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "SELECT\r\n    tu.SpecialtyId,\r\n    tu.Number,\r\n    tu.Name,\r\n    tu.Credit,\r\n    tu.Hours,\r\n    tu.Conditions\r\nFROM TeachingUnits AS tu\r\nINNER JOIN Specialties AS s ON tu.SpecialtyId = s.Id";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    using (SQLiteDataReader reader = sqliteCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SpecialtyXteachingUnit specialtyXteachingUnit = new SpecialtyXteachingUnit
                            {
                
                                SpecialtyId = Convert.ToInt32(reader["SpecialtyId"].ToString()),
                                Number = reader["Number"].ToString(),
                                Name = reader["Name"].ToString(),
                                Credit = reader["Credit"].ToString(),
                                Hours = reader["Hours"].ToString(),
                                Conditions = reader["Conditions"].ToString()

                            };

                            listSpecialtyXteachingUnit.Add(specialtyXteachingUnit);
                        }
                    }
                }
            }

            return listSpecialtyXteachingUnit;
        }

    }




}
