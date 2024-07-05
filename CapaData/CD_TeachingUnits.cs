using CapaEntity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    public class CD_TeachingUnits
    {

        CD_Connection dataBaseConnection;
        SQLiteCommand sqliteCommand;
        public void AddTeachingUnit(CE_TeachingUnit teachingUnit)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "INSERT INTO TeachingUnits (Number,Name,Credit,Hours,Conditions,SpecialtyId) VALUES (@Number,@Name,@Credit,@Hours,@Conditions,@SpecialtyId)";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@Number", teachingUnit.Number);
                    sqliteCommand.Parameters.AddWithValue("@Name", teachingUnit.Name);
                    sqliteCommand.Parameters.AddWithValue("@Credit", teachingUnit.Credit);
                    sqliteCommand.Parameters.AddWithValue("@Hours", teachingUnit.Hours);
                    sqliteCommand.Parameters.AddWithValue("@Conditions", teachingUnit.Conditions);
                    sqliteCommand.Parameters.AddWithValue("@SpecialtyId", teachingUnit.SpecialtyId);
                    sqliteCommand.ExecuteNonQuery();
                }
            }
        }
        public void UpdateTeachingUnit(CE_TeachingUnit teachingUnit)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "UPDATE TeachingUnits SET Number=@Number,Name = @Name,Credit=@Credit, Hours=@Hours, Conditions=@Conditions, SpecialtyId=@SpecialtyId WHERE Id = @Id";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@Id", teachingUnit.Id);
                    sqliteCommand.Parameters.AddWithValue("@Number", teachingUnit.Number);
                    sqliteCommand.Parameters.AddWithValue("@Name", teachingUnit.Name);
                    sqliteCommand.Parameters.AddWithValue("@Credit", teachingUnit.Credit);
                    sqliteCommand.Parameters.AddWithValue("@Hours", teachingUnit.Hours);
                    sqliteCommand.Parameters.AddWithValue("@Conditions", teachingUnit.Conditions);
                    sqliteCommand.Parameters.AddWithValue("@SpecialtyId", teachingUnit.SpecialtyId);
                    sqliteCommand.ExecuteNonQuery();
                }
            }
        }
        public void DeleteTeachingUnit(int teachingUnitId)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "DELETE  FROM TeachingUnits  WHERE Id = @Id";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@Id", teachingUnitId);
                    sqliteCommand.ExecuteNonQuery();
                }
            }
        }
        public List<CE_TeachingUnit2> LoadListTeachingUnits()
        {

            List<CE_TeachingUnit2> teachingUnits = new List<CE_TeachingUnit2>();
            string query = "SELECT TeachingUnits.Id,TeachingUnits.Number,TeachingUnits.Name,TeachingUnits.Credit,TeachingUnits.Hours,TeachingUnits.Conditions,TeachingUnits.SpecialtyId,Specialties.Name AS SpecialtyName   FROM TeachingUnits\r\nINNER JOIN Specialties ON TeachingUnits.SpecialtyId = Specialties.Id";
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    using (SQLiteDataReader reader = sqliteCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           CE_TeachingUnit2 teachingUnit = new CE_TeachingUnit2();

                            if (reader.HasRows)
                            {
                                teachingUnit.Id = reader.GetOrdinal("Id") != -1 ? Convert.ToInt32(reader["ID"]) : 0;
                                teachingUnit.Number = Convert.ToInt32(reader.GetOrdinal("Number") != -1 ? reader["Number"].ToString() : string.Empty);
                                teachingUnit.Name = reader.GetOrdinal("Name") != -1 ? reader["Name"].ToString() : string.Empty;
                                teachingUnit.Credit = reader.GetOrdinal("Credit") != -1 ? reader["Credit"].ToString() : string.Empty;
                                teachingUnit.Hours = Convert.ToInt32(reader.GetOrdinal("Hours") != -1 ? reader["Hours"].ToString() : string.Empty);
                                teachingUnit.Conditions = reader.GetOrdinal("Conditions") != -1 ? reader["Conditions"].ToString() : string.Empty;
                                teachingUnit.SpecialtyId = Convert.ToInt32(reader.GetOrdinal("SpecialtyId") != -1 ? reader["SpecialtyId"].ToString() : string.Empty);
                                teachingUnit.SpecialtyName = reader.GetOrdinal("SpecialtyName") != -1 ? reader["SpecialtyName"].ToString() : string.Empty;
                            }

                            teachingUnits.Add(teachingUnit);
                        }
                        reader.Close();
                    }
                }
            }

            return teachingUnits;
        }

    }

}
