
using CapaEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapaData
{
    public class CD_Students
    {
        
        CD_Connection dataBaseConnection;
        SQLiteCommand sqliteCommand;
        DataTable dataTable;


        public void AddStudent(Student student)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "INSERT INTO Students (Year, RegistrationCode, FirstSurtname, SecondSurtname, FirstName, Sex, DateBirth, Dni, " +
                               "Age, Country, PlaceBirth, District, Province, Region, Home, Work, " +
                               "WorkPosition, CivilStatus, Phone, Email, NumberContactEmergency, DegreeAchieved, FamilyBurden, " +
                               "NumberPeopleCharge, PhoneOperator, TeamTechnology, InternetHome, Disability, TypeDisability, NativeLenguaje, PhotoDni, FileNamePdf,Department,PlaceDate) " +
                               "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?,?,?)";

                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@Year", student.Year);
                    sqliteCommand.Parameters.AddWithValue("@RegistrationCode", student.RegistrationCode);
                    sqliteCommand.Parameters.AddWithValue("@FirstSurtname", student.FirstSurtname);
                    sqliteCommand.Parameters.AddWithValue("@SecondSurtname", student.SecondSurtname);
                    sqliteCommand.Parameters.AddWithValue("@FirstName", student.FirstName);
                    sqliteCommand.Parameters.AddWithValue("@Sex", student.Sex);
                    sqliteCommand.Parameters.AddWithValue("@DateBirth", student.DateBirth);
                    sqliteCommand.Parameters.AddWithValue("@Dni", student.Dni);
                    sqliteCommand.Parameters.AddWithValue("@Age", student.Age);
                    sqliteCommand.Parameters.AddWithValue("@Country", student.Country);
                    sqliteCommand.Parameters.AddWithValue("@PlaceBirth", student.PlaceBirth);
                    sqliteCommand.Parameters.AddWithValue("@District", student.District);
                    sqliteCommand.Parameters.AddWithValue("@Province", student.Province);
                    sqliteCommand.Parameters.AddWithValue("@Region", student.Region);
                    sqliteCommand.Parameters.AddWithValue("@Home", student.Home);
                    sqliteCommand.Parameters.AddWithValue("@Work", student.Work);
                    sqliteCommand.Parameters.AddWithValue("@WorkPosition", student.WorkPosition);
                    sqliteCommand.Parameters.AddWithValue("@CivilStatus", student.CivilStatus);
                    sqliteCommand.Parameters.AddWithValue("@Phone", student.Phone);
                    sqliteCommand.Parameters.AddWithValue("@Email", student.Email);
                    sqliteCommand.Parameters.AddWithValue("@NumberContactEmergency", student.NumberContactEmergency);
                    sqliteCommand.Parameters.AddWithValue("@DegreeAchieved", student.DegreeAchieved);
                    sqliteCommand.Parameters.AddWithValue("@FamilyBurden", student.FamilyBurden);
                    sqliteCommand.Parameters.AddWithValue("@NumberPeopleCharge", student.NumberPeopleCharge);
                    sqliteCommand.Parameters.AddWithValue("@PhoneOperator", student.PhoneOperator);
                    sqliteCommand.Parameters.AddWithValue("@TeamTechnology", student.TeamTechnology);
                    sqliteCommand.Parameters.AddWithValue("@InternetHome", student.InternetHome);
                    sqliteCommand.Parameters.AddWithValue("@Disability", student.Disability);
                    sqliteCommand.Parameters.AddWithValue("@TypeDisability", student.TypeDisability);
                    sqliteCommand.Parameters.AddWithValue("@NativeLenguaje", student.NativeLenguage);
                    sqliteCommand.Parameters.AddWithValue("@PhotoDni", student.PhotoDni);
                    sqliteCommand.Parameters.AddWithValue("@FileNamePdf", student.FileNamePdf);
                    sqliteCommand.Parameters.AddWithValue("@Department", student.Departament);
                    sqliteCommand.Parameters.AddWithValue("@PlaceDate", student.PlaceDate);
                    sqliteCommand.ExecuteNonQuery();
                }
            }
        }
        
        public void UpdateStudent(Student student)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "UPDATE Students SET Year = @Year, RegistrationCode = @RegistrationCode, FirstSurtname = @FirstSurtname, SecondSurtname = @SecondSurtname, FirstName = @FirstName, Sex = @Sex, DateBirth = @DateBirth, Dni = @Dni, Age = @Age, Country = @Country, PlaceBirth = @PlaceBirth, District = @District, Province = @Province, Region = @Region, Home = @Home, Work = @Work, WorkPosition = @WorkPosition, CivilStatus = @CivilStatus, Phone = @Phone, Email = @Email, NumberContactEmergency = @NumberContactEmergency, DegreeAchieved = @DegreeAchieved, FamilyBurden = @FamilyBurden, NumberPeopleCharge = @NumberPeopleCharge, PhoneOperator = @PhoneOperator, TeamTechnology = @TeamTechnology, InternetHome = @InternetHome, Disability = @Disability, TypeDisability = @TypeDisability, NativeLenguaje = @NativeLenguaje, PhotoDni = @PhotoDni, FileNamePdf = @FileNamePdf , Department = @Department, PlaceDate = @PlaceDate WHERE ID = @ID";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                
                    sqliteCommand.Parameters.AddWithValue("@ID", student.Id);
                    sqliteCommand.Parameters.AddWithValue("@Year", student.Year);
                    sqliteCommand.Parameters.AddWithValue("@RegistrationCode", student.RegistrationCode);
                    sqliteCommand.Parameters.AddWithValue("@FirstSurtname", student.FirstSurtname);
                    sqliteCommand.Parameters.AddWithValue("@SecondSurtname", student.SecondSurtname);
                    sqliteCommand.Parameters.AddWithValue("@FirstName", student.FirstName);
                    sqliteCommand.Parameters.AddWithValue("@Sex", student.Sex);
                    sqliteCommand.Parameters.AddWithValue("@DateBirth", student.DateBirth);
                    sqliteCommand.Parameters.AddWithValue("@Dni", student.Dni);
                    sqliteCommand.Parameters.AddWithValue("@Age", student.Age);
                    sqliteCommand.Parameters.AddWithValue("@Country", student.Country);
                    sqliteCommand.Parameters.AddWithValue("@PlaceBirth", student.PlaceBirth);
                    sqliteCommand.Parameters.AddWithValue("@District", student.District);
                    sqliteCommand.Parameters.AddWithValue("@Province", student.Province);
                    sqliteCommand.Parameters.AddWithValue("@Region", student.Region);
                    sqliteCommand.Parameters.AddWithValue("@Home", student.Home);
                    sqliteCommand.Parameters.AddWithValue("@Work", student.Work);
                    sqliteCommand.Parameters.AddWithValue("@WorkPosition", student.WorkPosition);
                    sqliteCommand.Parameters.AddWithValue("@CivilStatus", student.CivilStatus);
                    sqliteCommand.Parameters.AddWithValue("@Phone", student.Phone);
                    sqliteCommand.Parameters.AddWithValue("@Email", student.Email);
                    sqliteCommand.Parameters.AddWithValue("@NumberContactEmergency", student.NumberContactEmergency);
                    sqliteCommand.Parameters.AddWithValue("@DegreeAchieved", student.DegreeAchieved);
                    sqliteCommand.Parameters.AddWithValue("@FamilyBurden", student.FamilyBurden);
                    sqliteCommand.Parameters.AddWithValue("@NumberPeopleCharge", student.NumberPeopleCharge);
                    sqliteCommand.Parameters.AddWithValue("@PhoneOperator", student.PhoneOperator);
                    sqliteCommand.Parameters.AddWithValue("@TeamTechnology", student.TeamTechnology);
                    sqliteCommand.Parameters.AddWithValue("@InternetHome", student.InternetHome);
                    sqliteCommand.Parameters.AddWithValue("@Disability", student.Disability);
                    sqliteCommand.Parameters.AddWithValue("@TypeDisability", student.TypeDisability);
                    sqliteCommand.Parameters.AddWithValue("@NativeLenguaje", student.NativeLenguage);
                    sqliteCommand.Parameters.AddWithValue("@PhotoDni", student.PhotoDni);
                    sqliteCommand.Parameters.AddWithValue("@FileNamePdf", student.FileNamePdf);
                    sqliteCommand.Parameters.AddWithValue("@Department", student.Departament);
                    sqliteCommand.Parameters.AddWithValue("@PlaceDate", student.PlaceDate);
                    sqliteCommand.ExecuteNonQuery();

                   
              
                }
            }
        }
        public void DeleteStudent(int studentId)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "DELETE  FROM Students WHERE ID = @ID";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@ID", studentId);

                    sqliteCommand.ExecuteNonQuery();
                }
            }
        }
        public DataTable SearchStudent(string buscar)
        {
            DataTable dataTable = new DataTable("SearchStudents");
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "SELECT * FROM Students WHERE RegistrationCode LIKE @Buscar OR Dni LIKE @Buscar OR FirstName LIKE @Buscar OR FirstSurtname LIKE @Buscar OR SecondSurtname LIKE @Buscar";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@Buscar", buscar + "%");

                    // Usar un SQLiteDataAdapter para llenar el DataTable
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqliteCommand))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable; // Devuelve el DataTable lleno de resultados
        }

        public List<Student> LoadStudents()
        {
            List<Student> students = new List<Student>();
            string query = "SELECT ID, Year, RegistrationCode, FirstSurtname, SecondSurtname, FirstName, Sex, DateBirth, Dni, Age, Country, PlaceBirth, District, Province, Region, Home, Work, WorkPosition, CivilStatus, Phone, Email, NumberContactEmergency, DegreeAchieved, FamilyBurden, NumberPeopleCharge, PhoneOperator, TeamTechnology, InternetHome, Disability, TypeDisability, NativeLenguaje, PhotoDni,FileNamePdf,Department,PlaceDate FROM Students";

            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    using (SQLiteDataReader reader = sqliteCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = new Student();

                            if (reader.HasRows)
                            {
                                student.Id = reader.GetOrdinal("ID") != -1 ? Convert.ToInt32(reader["ID"]) : 0;
                                student.Year = reader.GetOrdinal("Year") != -1 ? reader["Year"].ToString() : string.Empty;
                                student.RegistrationCode = reader.GetOrdinal("RegistrationCode") != -1 ? reader["RegistrationCode"].ToString() : string.Empty;
                                student.FirstSurtname = reader.GetOrdinal("FirstSurtname") != -1 ? reader["FirstSurtname"].ToString() : string.Empty;
                                student.SecondSurtname = reader.GetOrdinal("SecondSurtname") != -1 ? reader["SecondSurtname"].ToString() : string.Empty;
                                student.FirstName = reader.GetOrdinal("FirstName") != -1 ? reader["FirstName"].ToString() : string.Empty;
                                student.Sex = reader.GetOrdinal("Sex") != -1 ? reader["Sex"].ToString() : string.Empty;
                                student.DateBirth = reader.GetOrdinal("DateBirth") != -1 ? Convert.ToDateTime(reader["DateBirth"]) : DateTime.MinValue;
                                student.Dni = reader.GetOrdinal("Dni") != -1 ? reader["Dni"].ToString() : string.Empty;
                                student.Age = reader.GetOrdinal("Age") != -1 ? Convert.ToInt32(reader["Age"]) : 0;
                                student.Country = reader.GetOrdinal("Country") != -1 ? reader["Country"].ToString() : string.Empty;
                               
                                student.PlaceBirth = reader.GetOrdinal("PlaceBirth") != -1 ? reader["PlaceBirth"].ToString() : string.Empty;
                                student.District = reader.GetOrdinal("District") != -1 ? reader["District"].ToString() : string.Empty;
                                student.Province = reader.GetOrdinal("Province") != -1 ? reader["Province"].ToString() : string.Empty;
                                student.Region = reader.GetOrdinal("Region") != -1 ? reader["Region"].ToString() : string.Empty;
                                student.Home = reader.GetOrdinal("Home") != -1 ? reader["Home"].ToString() : string.Empty;
                                student.Work = reader.GetOrdinal("Work") != -1 ? reader["Work"].ToString() : string.Empty;
                                student.WorkPosition = reader.GetOrdinal("WorkPosition") != -1 ? reader["WorkPosition"].ToString() : string.Empty;
                                student.CivilStatus = reader.GetOrdinal("CivilStatus") != -1 ? reader["CivilStatus"].ToString() : string.Empty;
                                student.Phone = reader.GetOrdinal("Phone") != -1 ? reader["Phone"].ToString() : string.Empty;
                                student.Email = reader.GetOrdinal("Email") != -1 ? reader["Email"].ToString() : string.Empty;
                                student.NumberContactEmergency = reader.GetOrdinal("NumberContactEmergency") != -1 ? reader["NumberContactEmergency"].ToString() : string.Empty;
                                student.DegreeAchieved = reader.GetOrdinal("DegreeAchieved") != -1 ? reader["DegreeAchieved"].ToString() : string.Empty;
                                student.FamilyBurden = reader.GetOrdinal("FamilyBurden") != -1 ? reader["FamilyBurden"].ToString() : string.Empty;
                                student.NumberPeopleCharge = reader.GetOrdinal("NumberPeopleCharge") != -1 ? Convert.ToInt32(reader["NumberPeopleCharge"]) : 0;
                                student.PhoneOperator = reader.GetOrdinal("PhoneOperator") != -1 ? reader["PhoneOperator"].ToString() : string.Empty;
                                student.TeamTechnology = reader.GetOrdinal("TeamTechnology") != -1 ? reader["TeamTechnology"].ToString() : string.Empty;
                                student.InternetHome = reader.GetOrdinal("InternetHome") != -1 ? reader["InternetHome"].ToString() : string.Empty;
                                student.Disability = reader.GetOrdinal("Disability") != -1 ? reader["Disability"].ToString() : string.Empty;
                                student.TypeDisability = reader.GetOrdinal("TypeDisability") != -1 ? reader["TypeDisability"].ToString() : string.Empty;
                                student.NativeLenguage = reader.GetOrdinal("NativeLenguaje") != -1 ? reader["NativeLenguaje"].ToString() : string.Empty;
                                student.PhotoDni = reader.GetOrdinal("PhotoDni") != -1 ? (byte[])reader["PhotoDni"] : null;
                                student.FileNamePdf = reader.GetOrdinal("FileNamePdf") != -1 ? reader["FileNamePdf"].ToString() : string.Empty;
                                student.Departament = reader.GetOrdinal("Department") != -1 ? reader["Department"].ToString() : string.Empty;
                                student.PlaceDate= reader.GetOrdinal("PlaceDate") != -1 ? reader["PlaceDate"].ToString() : string.Empty;

                            }

                            students.Add(student);
                        }
                        reader.Close();
                    }
                }
            }

            return students;
        }
        

    }
}
