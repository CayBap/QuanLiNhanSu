using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class UserDAL
    {
        SqlConnection conn = null;
        public User GetUserLogin(string UserName, string Password)
        {
            User user = null;
            try
            {
                string conStr = ConfigurationManager.ConnectionStrings["conStr"].ToString();
                conn = new SqlConnection(conStr);
                conn.Open();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT*FROM dbo.[User] WHERE UserName = '" + UserName + "' AND Password =  '" + Password + "'", conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                user = new User()
                {
                    ID = (int)dt.Rows[0][0],
                    UserName = dt.Rows[0][1].ToString(),
                    Password = dt.Rows[0][2].ToString(),
                    FirstName = dt.Rows[0][3].ToString(),
                    LastName = dt.Rows[0][4].ToString(),
                    dateTime = DateTime.Parse(dt.Rows[0][5].ToString()),
                    Role = dt.Rows[0][6].ToString()
                };
                conn.Close();
            }
            catch
            {
                user = null;
            }
            return user;

        }
        public User UpdateUser(string ID, string FirstName, string LastName, DateTime BirthDate, string Role)
        {
            User user = null;
            try
            {
                string conStr = ConfigurationManager.ConnectionStrings["conStr"].ToString();
                conn = new SqlConnection(conStr);
                conn.Open();
                SqlCommand cm = new SqlCommand("UPDATE dbo.[User] SET FirstName = N'" + FirstName + "',LastName = N'" + LastName + "',BirthDate ='" + BirthDate + "',Role ='" + Role + "'", conn);
                cm.ExecuteNonQuery();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT*FROM dbo.[User] WHERE ID = '" + ID + "'", conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                user = new User()
                {
                    ID = (int)dt.Rows[0][0],
                    UserName = dt.Rows[0][1].ToString(),
                    Password = dt.Rows[0][2].ToString(),
                    FirstName = dt.Rows[0][3].ToString(),
                    LastName = dt.Rows[0][4].ToString(),
                    dateTime = DateTime.Parse(dt.Rows[0][5].ToString()),
                    Role = dt.Rows[0][6].ToString()
                };
                conn.Close();
            }
            catch
            {
                user = null;
            }
            return user;
        }
        public List<User> GetUsers()
        {
            List<User> list = null;
            try
            {
                list = new List<User>();
                string conStr = ConfigurationManager.ConnectionStrings["conStr"].ToString();
                conn = new SqlConnection(conStr);
                conn.Open();
                SqlCommand cm = new SqlCommand("SELECT*FROM dbo.[User]", conn);
                SqlDataReader rd = cm.ExecuteReader();
                while (rd.Read())
                {
                    User user = new User()
                    {
                        ID = rd.GetInt32(0),
                        UserName = rd.GetString(1),
                        Password = rd.GetString(2),
                        FirstName = rd.GetString(3),
                        LastName = rd.GetString(4),
                        dateTime = rd.GetDateTime(5),
                        Role = rd.GetString(6)
                    };
                    list.Add(user);
                }
                conn.Close();
            }
            catch
            {
                list = null;
            }
            return list;
        }
        public bool AddUser(User user)
        {
            //try
            //{
                string conStr = ConfigurationManager.ConnectionStrings["conStr"].ToString();
                conn = new SqlConnection(conStr);
                conn.Open();
                SqlCommand cm = new SqlCommand("INSERT INTO dbo.[User] VALUES(@tk,@mk,@fn,@ln,@bd,@role)", conn);
                cm.Parameters.AddWithValue("tk", user.UserName);
                cm.Parameters.AddWithValue("mk", user.Password);
                cm.Parameters.AddWithValue("fn", user.FirstName);
                cm.Parameters.AddWithValue("ln", user.LastName);
                cm.Parameters.AddWithValue("bd", user.dateTime);
                cm.Parameters.AddWithValue("role", user.Role);
                cm.ExecuteNonQuery();
            //}
            //catch
            //{
            //    return false;
            //}
            return true;
        }
    }
}
