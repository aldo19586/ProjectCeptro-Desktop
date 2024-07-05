using CapaEntity.Cache;
using CapaEntity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    public class CD_Specialties
    {
        CD_Connection dataBaseConnection;
        SQLiteCommand sqliteCommand;
        public void AddSpecialty(CE_Specialty specialty)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "INSERT INTO Specialties (Name) VALUES (@Name)";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@Name",specialty.Name);
                    sqliteCommand.ExecuteNonQuery();
                }
            }
        }
        public void UpdateSpecialty(CE_Specialty specialty)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "UPDATE Specialties SET Name = @Name WHERE Id = @Id";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@Id", specialty.Id);
                    sqliteCommand.Parameters.AddWithValue("@Name", specialty.Name);
                    sqliteCommand.ExecuteNonQuery();
                }
            }
        }
        public void DeleteSpecialty(int specialtyId)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "DELETE  FROM Specialties WHERE Id = @Id";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@Id", specialtyId);
                    sqliteCommand.ExecuteNonQuery();
                }
            }
        }
        public List<CE_Specialty> LoadListSpecialties()
        {

            List<CE_Specialty> specialties = new List<CE_Specialty>();
            string query = "SELECT Id,Name FROM Specialties";
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    using (SQLiteDataReader reader = sqliteCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CE_Specialty specialty = new CE_Specialty();

                            if (reader.HasRows)
                            {
                                specialty.Id = reader.GetOrdinal("Id") != -1 ? Convert.ToInt32(reader["Id"]) : 0;
                                specialty.Name = reader.GetOrdinal("Name") != -1 ? reader["Name"].ToString() : string.Empty;
                            }

                            specialties.Add(specialty);
                        }
                        reader.Close();
                    }
                }
            }

            return specialties;
        }
      
    }
}
