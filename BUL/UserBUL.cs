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
            UserBUL bul = new UserBUL();
            bool check = bul.AddUser(user);
            return check;
        }
    }
}
