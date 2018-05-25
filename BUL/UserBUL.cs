using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class UserBUL
    {
        public User GetUserLogin(string UserName,string Password)
        {
            return new UserDAL().GetUserLogin( UserName, Password);
        }   
        public User UpdateUser(string ID, string FirstName, string LastName, DateTime BirthDate, string Role)
        {
           return new UserDAL().UpdateUser(ID, FirstName, LastName, BirthDate, Role);
        }
        public List<User> GetUsers()
        {
            return new UserDAL().GetUsers();
        }
        public bool AddUser(User user)
        {
            UserDAL bul = new UserDAL();
            bool check = bul.AddUser(user);
            return check;
        }
        public bool UpdateUser(User user)
        {
            return new UserDAL().UpdateUser(user);
        }
        public bool DeleteUser(int ID)
        {
            return new UserDAL().DeleteUser(ID);
        }
        public User GetUserByID(int id)
        {
            return new UserDAL().GetUserByID(id);
        }
    }
}
