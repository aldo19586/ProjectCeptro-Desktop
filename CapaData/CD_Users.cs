using CapaEntity;
using CapaEntity.Cache;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    public class CD_Users
    {
        CD_Connection dataBaseConnection;
        SQLiteCommand sqliteCommand;
        public void AddUser(User user)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "INSERT INTO Users (Name, SurNames, UserName, Pass, Rol, State) VALUES (@Name, @SurNames, @UserName, @Pass, @Rol, @State)";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@Name", user.Name);
                    sqliteCommand.Parameters.AddWithValue("@SurNames", user.SurNames);
                    sqliteCommand.Parameters.AddWithValue("@UserName", user.UserName);
                    sqliteCommand.Parameters.AddWithValue("@Pass", user.Pass);
                    sqliteCommand.Parameters.AddWithValue("@Rol",user.Rol);
                    sqliteCommand.Parameters.AddWithValue("@State", user.State);
         
                    sqliteCommand.ExecuteNonQuery();
                }
            }
        }
        public void UpdateUser(User user)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "UPDATE Users SET Name = @Name, SurNames = @SurNames, UserName = @UserName, Pass = @Pass, Rol = @Rol, State = @State WHERE ID = @ID";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@ID", user.Id);
                    sqliteCommand.Parameters.AddWithValue("@Name", user.Name);
                    sqliteCommand.Parameters.AddWithValue("@SurNames", user.SurNames);
                    sqliteCommand.Parameters.AddWithValue("@UserName", user.UserName);
                    sqliteCommand.Parameters.AddWithValue("@Pass", user.Pass);
                    sqliteCommand.Parameters.AddWithValue("@Rol", user.Rol);
                    sqliteCommand.Parameters.AddWithValue("@State", user.State);

                    sqliteCommand.ExecuteNonQuery();
                }
            }
        }
        public void DeleteUser(int userId)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "DELETE  FROM Users WHERE ID = @ID";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@ID", userId);

                    sqliteCommand.ExecuteNonQuery();
                }
            }
        }
        public List<User> LoadListUsers()
        {

            List<User> users = new List<User>();
            string query = "SELECT ID,Name, SurNames, UserName, Pass, Rol, State FROM Users";
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    using (SQLiteDataReader reader = sqliteCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User();

                            if (reader.HasRows)
                            {
                                user.Id = reader.GetOrdinal("ID") != -1 ? Convert.ToInt32(reader["ID"]) : 0;
                                user.Name = reader.GetOrdinal("Name") != -1 ? reader["Name"].ToString() : string.Empty;
                                user.SurNames = reader.GetOrdinal("SurNames") != -1 ? reader["SurNames"].ToString() : string.Empty;
                                user.UserName= reader.GetOrdinal("UserName") != -1 ? reader["UserName"].ToString() : string.Empty;
                                user.Pass = reader.GetOrdinal("Pass") != -1 ? reader["Pass"].ToString() : string.Empty;
                                user.Rol= reader.GetOrdinal("Rol") != -1 ? reader["Rol"].ToString() : string.Empty;
                                user.State = reader.GetOrdinal("State") != -1 ? reader["State"].ToString() : string.Empty;


                            }

                            users.Add(user);
                        }
                        reader.Close();
                    }
                }
            }

            return users;
        }
        public bool Login(string username, string password)
        {
            using (CD_Connection dataBaseConnection = new CD_Connection())
            {
                string query = "SELECT Id, Name, SurNames, UserName, Pass, Rol, State FROM Users WHERE UserName = @UserName AND Pass = @Pass AND State=@State";
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(query, dataBaseConnection.Connection))
                {
                    sqliteCommand.Parameters.AddWithValue("@UserName", username);
                    sqliteCommand.Parameters.AddWithValue("@Pass", password);
                    sqliteCommand.Parameters.AddWithValue("@State","Activo");

                    using (SQLiteDataReader reader = sqliteCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            InformationUser.Id = reader.GetInt32(0);
                            InformationUser.Name = reader.GetString(1);
                            InformationUser.SurNames = reader.GetString(2);
                            InformationUser.UserName = reader.GetString(3);
                            InformationUser.Pass = reader.GetString(4);
                            InformationUser.Rol = reader.GetString(5);
                            InformationUser.State = reader.GetString(6);
                            return true;
                        }
                        else
                        {
                            return false; // No se encontró el usuario o las credenciales son incorrectas
                        }
                    }
                }
            }
        }
        
        
    }
}
