using CapaEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    public class CD_Tuition
    {
        CD_Connection dataBaseConnection;
        SQLiteCommand sqliteCommand;
        public void AddTuition(CE_Tuition Tuition)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "INSERT INTO Tuition (NameCetpro,CodeModular,Department,Province,District,Dre,ManagementType,SchoolPeriod,ClassPeriod,InformativeLevel,StudyPlanType,Dni,NamesLastNames,SpecialtyId,AcademicPeriod,Module) VALUES (@NameCetpro,@CodeModular,@Department,@Province,@District,@Dre,@ManagementType,@SchoolPeriod,@ClassPeriod,@InformativeLevel,@StudyPlanType,@Dni,@NamesLastNames,@SpecialtyId,@AcademicPeriod,@Module)";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@NameCetpro", Tuition.NameCetpro);
                    sqliteCommand.Parameters.AddWithValue("@CodeModular", Tuition.CodeModular);
                    sqliteCommand.Parameters.AddWithValue("@Department", Tuition.Department);
                    sqliteCommand.Parameters.AddWithValue("@Province", Tuition.Province);
                    sqliteCommand.Parameters.AddWithValue("@District", Tuition.District);
                    sqliteCommand.Parameters.AddWithValue("@Dre", Tuition.Dre);
                    sqliteCommand.Parameters.AddWithValue("@ManagementType", Tuition.ManagementType);
                    sqliteCommand.Parameters.AddWithValue("@SchoolPeriod", Tuition.SchoolPeriod);
                    sqliteCommand.Parameters.AddWithValue("@ClassPeriod", Tuition.ClassPeriod);
                    sqliteCommand.Parameters.AddWithValue("@InformativeLevel", Tuition.InformativeLevel);
                    sqliteCommand.Parameters.AddWithValue("@StudyPlanType", Tuition.StudyPlanType);
                    sqliteCommand.Parameters.AddWithValue("@Dni", Tuition.Dni);
                    sqliteCommand.Parameters.AddWithValue("@NamesLastNames", Tuition.NamesLastNames);
                    sqliteCommand.Parameters.AddWithValue("@SpecialtyId", Tuition.SpecialtyId);
                    sqliteCommand.Parameters.AddWithValue("@AcademicPeriod", Tuition.AcademicPeriod);
                    sqliteCommand.Parameters.AddWithValue("@Module", Tuition.AcademicPeriod);
                    sqliteCommand.ExecuteNonQuery();
                }
            }
        }
        public void UpdateTuition(CE_Tuition Tuition)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "UPDATE Tuition SET NameCetpro = @NameCetpro, CodeModular = @CodeModular, Department = @Department, Province = @Province, District = @District, Dre = @Dre, ManagementType = @ManagementType, SchoolPeriod = @SchoolPeriod, ClassPeriod = @ClassPeriod, InformativeLevel = @InformativeLevel, StudyPlanType = @StudyPlanType, Dni = @Dni, NamesLastNames = @NamesLastNames, SpecialtyId= @SpecialtyId, AcademicPeriod=@AcademicPeriod ,Module=@Module WHERE Id = @Id";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@Id", Tuition.Id);
                    sqliteCommand.Parameters.AddWithValue("@NameCetpro", Tuition.NameCetpro);
                    sqliteCommand.Parameters.AddWithValue("@CodeModular", Tuition.CodeModular);
                    sqliteCommand.Parameters.AddWithValue("@Department", Tuition.Department);
                    sqliteCommand.Parameters.AddWithValue("@Province", Tuition.Province);
                    sqliteCommand.Parameters.AddWithValue("@District", Tuition.District);
                    sqliteCommand.Parameters.AddWithValue("@Dre", Tuition.Dre);
                    sqliteCommand.Parameters.AddWithValue("@ManagementType", Tuition.ManagementType);
                    sqliteCommand.Parameters.AddWithValue("@SchoolPeriod", Tuition.SchoolPeriod);
                    sqliteCommand.Parameters.AddWithValue("@ClassPeriod", Tuition.ClassPeriod);
                    sqliteCommand.Parameters.AddWithValue("@InformativeLevel", Tuition.InformativeLevel);
                    sqliteCommand.Parameters.AddWithValue("@StudyPlanType", Tuition.StudyPlanType);
                    sqliteCommand.Parameters.AddWithValue("@Dni", Tuition.Dni);
                    sqliteCommand.Parameters.AddWithValue("@NamesLastNames", Tuition.NamesLastNames);
                    sqliteCommand.Parameters.AddWithValue("@SpecialtyId", Tuition.SpecialtyId);
                    sqliteCommand.Parameters.AddWithValue("@AcademicPeriod", Tuition.AcademicPeriod);
                    sqliteCommand.Parameters.AddWithValue("@Module", Tuition.AcademicPeriod);
                    sqliteCommand.ExecuteNonQuery();
             
                }
            }
        }
        public void DeleteTuition(int TuitionId)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "DELETE  FROM Tuition WHERE Id = @Id";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@Id", TuitionId);
                    sqliteCommand.ExecuteNonQuery();
                }
            }
        }
        public DataTable SearchTuition(string buscar)
        {
            DataTable dataTable = new DataTable("SearchTuition");
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "SELECT * FROM Tuition WHERE Dni LIKE @Buscar OR NamesLastNames LIKE @Buscar";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@Buscar", "%"+buscar + "%");

                    // Usar un SQLiteDataAdapter para llenar el DataTable
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqliteCommand))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable; // Devuelve el DataTable lleno de resultados
        }
        public List<CE_Tuition> LoadListTuitions()
        {

            List<CE_Tuition> tuitionList = new List<CE_Tuition>();

            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "SELECT Id,NameCetpro,CodeModular,Department,Province,District,Dre,ManagementType,SchoolPeriod,ClassPeriod,InformativeLevel,StudyPlanType,Dni,NamesLastNames,SpecialtyId,AcademicPeriod,Module FROM Tuition";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    using (SQLiteDataReader reader = sqliteCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CE_Tuition tuition = new CE_Tuition
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                NameCetpro = reader["NameCetpro"].ToString(),
                                CodeModular = reader["CodeModular"].ToString(),
                                Department = reader["Department"].ToString(),
                                Province = reader["Province"].ToString(),
                                District = reader["District"].ToString(),
                                Dre = reader["Dre"].ToString(),
                                ManagementType = reader["ManagementType"].ToString(),
                                SchoolPeriod = reader["SchoolPeriod"].ToString(),
                                ClassPeriod = reader["ClassPeriod"].ToString(),
                                InformativeLevel = reader["InformativeLevel"].ToString(),
                                StudyPlanType = reader["StudyPlanType"].ToString(),
                                Dni = reader["Dni"].ToString(),
                                NamesLastNames = reader["NamesLastNames"].ToString(),
                                SpecialtyId = Convert.ToInt32(reader["SpecialtyId"]),
                                AcademicPeriod = reader["AcademicPeriod"].ToString(),
                                Module = reader["Module"].ToString()
                            };

                            tuitionList.Add(tuition);
                        }
                    }
                }
            }

            return tuitionList;
        }

    }

}
