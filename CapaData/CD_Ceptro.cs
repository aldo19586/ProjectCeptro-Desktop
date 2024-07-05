using System;
using System.Data;
using System.Data.SQLite; // Asegúrate de tener esta referencia
using CapaEntity;

namespace CapaData
{
    public class CD_Ceptro
    {
        CD_Connection dataBaseConnection;
        SQLiteCommand sqliteCommand;

        public void AddCeptro(Ceptro ceptro)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "INSERT INTO Ceptro (Name, CodeModular, ManagementType, Ugel, ResolutionAuth, District, Departament, Province, Direction, Phone, Email, PageWeb, ProgramStudies, InformativeLevel, ResolutionAuthProgram, PlaceService) VALUES (@Name, @CodeModular, @ManagementType, @Ugel, @ResolutionAuth, @District, @Departament, @Province, @Direction, @Phone, @Email, @PageWeb, @ProgramStudies, @InformativeLevel, @ResolutionAuthProgram, @PlaceService)";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@Name", ceptro.Name);
                    sqliteCommand.Parameters.AddWithValue("@CodeModular", ceptro.CodeModular);
                    sqliteCommand.Parameters.AddWithValue("@ManagementType", ceptro.ManagementType);
                    sqliteCommand.Parameters.AddWithValue("@Ugel", ceptro.Ugel);
                    sqliteCommand.Parameters.AddWithValue("@ResolutionAuth", ceptro.ResolutionAuth);
                    sqliteCommand.Parameters.AddWithValue("@ResolutionAuthProgram", ceptro.ResolutionAuthProgram);
                    sqliteCommand.Parameters.AddWithValue("@PlaceService", ceptro.PlaceService);
                    sqliteCommand.Parameters.AddWithValue("@District", ceptro.District);
                    sqliteCommand.Parameters.AddWithValue("@Departament", ceptro.Departament);
                    sqliteCommand.Parameters.AddWithValue("@Province", ceptro.Province);
                    sqliteCommand.Parameters.AddWithValue("@Direction", ceptro.Direction);
                    sqliteCommand.Parameters.AddWithValue("@Phone", ceptro.Phone);
                    sqliteCommand.Parameters.AddWithValue("@Email", ceptro.Email);
                    sqliteCommand.Parameters.AddWithValue("@PageWeb", ceptro.PageWeb);
                    sqliteCommand.Parameters.AddWithValue("@ProgramStudies", ceptro.ProgramStudies);
                    sqliteCommand.Parameters.AddWithValue("@InformativeLevel", ceptro.InformativeLevel);

                    sqliteCommand.ExecuteNonQuery();
                }
            }
        }
        public void UpdateCeptro(Ceptro ceptro)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "UPDATE Ceptro SET Name = @Name, CodeModular = @CodeModular, ManagementType = @ManagementType, Ugel = @Ugel, ResolutionAuth = @ResolutionAuth, ResolutionAuthProgram = @ResolutionAuthProgram, PlaceService = @PlaceService, District = @District, Departament = @Departament, Province = @Province, Direction = @Direction, Phone = @Phone, Email = @Email, PageWeb = @PageWeb, ProgramStudies = @ProgramStudies, InformativeLevel = @InformativeLevel WHERE ID = @ID";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@ID", ceptro.Id);
                    sqliteCommand.Parameters.AddWithValue("@Name", ceptro.Name);
                    sqliteCommand.Parameters.AddWithValue("@CodeModular", ceptro.CodeModular);
                    sqliteCommand.Parameters.AddWithValue("@ManagementType", ceptro.ManagementType);
                    sqliteCommand.Parameters.AddWithValue("@Ugel", ceptro.Ugel);
                    sqliteCommand.Parameters.AddWithValue("@ResolutionAuth", ceptro.ResolutionAuth);
                    sqliteCommand.Parameters.AddWithValue("@ResolutionAuthProgram", ceptro.ResolutionAuthProgram);
                    sqliteCommand.Parameters.AddWithValue("@PlaceService", ceptro.PlaceService);
                    sqliteCommand.Parameters.AddWithValue("@District", ceptro.District);
                    sqliteCommand.Parameters.AddWithValue("@Departament", ceptro.Departament);
                    sqliteCommand.Parameters.AddWithValue("@Province", ceptro.Province);
                    sqliteCommand.Parameters.AddWithValue("@Direction", ceptro.Direction);
                    sqliteCommand.Parameters.AddWithValue("@Phone", ceptro.Phone);
                    sqliteCommand.Parameters.AddWithValue("@Email", ceptro.Email);
                    sqliteCommand.Parameters.AddWithValue("@PageWeb", ceptro.PageWeb);
                    sqliteCommand.Parameters.AddWithValue("@ProgramStudies", ceptro.ProgramStudies);
                    sqliteCommand.Parameters.AddWithValue("@InformativeLevel", ceptro.InformativeLevel);

                    sqliteCommand.ExecuteNonQuery();
                }
            }
        }
        public Ceptro LoadListCeptro()
        {

            Ceptro ceptro = null;
            string query = "SELECT ID, Name, CodeModular, ManagementType, Ugel, ResolutionAuth, ResolutionAuthProgram, PlaceService, District, Departament, Province, Direction, Phone, Email, PageWeb, ProgramStudies, InformativeLevel FROM Ceptro LIMIT 1";
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    using (SQLiteDataReader reader = sqliteCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ceptro = new Ceptro()
                            {
                                Id = Convert.ToInt32(reader["ID"]),
                                Name = reader["Name"].ToString(),
                                CodeModular = reader["CodeModular"].ToString(),
                                ManagementType = reader["ManagementType"].ToString(),
                                Ugel = reader["Ugel"].ToString(),
                                ResolutionAuth = reader["ResolutionAuth"].ToString(),
                                ResolutionAuthProgram = reader["ResolutionAuthProgram"].ToString(),
                                PlaceService = reader["PlaceService"].ToString(),
                                District = reader["District"].ToString(),
                                Departament = reader["Departament"].ToString(),
                                Province = reader["Province"].ToString(),
                                Direction = reader["Direction"].ToString(),
                                Phone = reader["Phone"].ToString(),
                 
                                Email = reader["Email"].ToString(),
                                PageWeb = reader["PageWeb"].ToString(),
                                ProgramStudies = reader["ProgramStudies"].ToString(),
                                InformativeLevel = reader["InformativeLevel"].ToString()
                            };
                        }
                        reader.Close();
                    }
                }
                return ceptro;

            }
        }
    }
}
