using CapaData;
using CapaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
    public class CDo_Users
    {
        CD_Users objUser = new CD_Users();
        public void AddUser(User user)
        {
            objUser.AddUser(user);
        }
        public void UpdateUser(User user)
        {objUser.UpdateUser(user);
        }
        public void DeleteUser(int userId)
        {
            objUser.DeleteUser(userId);
        }
        public List<User> LoadListUsers()
        {
            return objUser.LoadListUsers();
        }
        public bool Login(string username, string password)
        {return objUser.Login(username, password);
        }
    }
}
