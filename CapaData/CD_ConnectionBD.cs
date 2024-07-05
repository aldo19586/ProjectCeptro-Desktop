using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CapaData
{
    public class CD_Connection : IDisposable
    {
        private readonly SQLiteConnection _connection;
        private bool _disposed = false;

        public CD_Connection()
        {
            // Leer la ruta base desde App.config
            string databasePath = ConfigurationManager.AppSettings["DatabasePath"];
            string appDataPath = Environment.ExpandEnvironmentVariables(databasePath);

            // Asegurarse de que el directorio exista
            string directoryPath = Path.GetDirectoryName(appDataPath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Copiar la base de datos solo si no existe
            if (!File.Exists(appDataPath))
            {
                string sourcePath = Path.Combine(Application.StartupPath, "databaseCeptro.db");
                File.Copy(sourcePath, appDataPath);
            }
           
            string connectionString = $"Data Source={appDataPath};Version=3;";
           
            _connection = new SQLiteConnection(connectionString);
        }

        public SQLiteConnection Connection
        {
            get
            {
                try
                {
                    if (_connection.State == ConnectionState.Closed)
                        _connection.Open();
                }
                catch (Exception ex)
                {
                    // Aquí puedes manejar el error, por ejemplo, registrando los detalles del mismo
                    MessageBox.Show("Error al abrir la conexión: " + ex.Message);
                    throw; // Opcional: Volver a lanzar la excepción para manejarla en otro nivel
                }
                return _connection;
            }
        }

        public void Close()
        {
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_connection != null)
                    {
                        if (_connection.State == ConnectionState.Open)
                            _connection.Close();
                        _connection.Dispose();
                    }
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}