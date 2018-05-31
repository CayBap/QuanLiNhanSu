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
        public User GetUserLogin(string UserName, string Password)
        {
            User user = null;
           
            try
            {
                Connection.Creat_connect();
                Connection.Open_connect();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM [User] WHERE UserName = '" + UserName + "' AND Password =  '" + Password + "'", Connection.connect());
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
                Connection.Close_connect();
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
                Connection.Open_connect();
                SqlCommand cm = new SqlCommand("UPDATE dbo.[User] SET FirstName = N'" + FirstName + "',LastName = N'" + LastName + "',BirthDate ='" + BirthDate + "',Role ='" + Role + "'",Connection.connect());
                cm.ExecuteNonQuery();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT*FROM dbo.[User] WHERE ID = '" + ID + "'", Connection.connect());
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
                Connection.Close_connect();
            }
            catch
            {
                Connection.Close_connect();
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
                Connection.Open_connect();
                SqlCommand cm = new SqlCommand("SELECT*FROM dbo.[User]",Connection.connect());
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
                Connection.Close_connect();
            }
            catch
            {
                list = null;
            }
            Connection.Close_connect();
            return list;
        }
        public bool AddUser(User user)
        {
            try
            {
                Connection.Open_connect();
                 SqlCommand cm = new SqlCommand("INSERT INTO dbo.[User] VALUES(@tk,@mk,@fn,@ln,@bd,@role)", Connection.connect());
                cm.Parameters.AddWithValue("tk", user.UserName);
                cm.Parameters.AddWithValue("mk", user.Password);
                cm.Parameters.AddWithValue("fn", user.FirstName);
                cm.Parameters.AddWithValue("ln", user.LastName);
                cm.Parameters.AddWithValue("bd", user.dateTime);
                cm.Parameters.AddWithValue("role", user.Role);
                cm.ExecuteNonQuery();
                Connection.Close_connect();
            }
            catch
            {
                Connection.Close_connect();
                return false;
            }
            return true;
        }
        public bool UpdateUser(User user)
        {
            try
            {
                Connection.Open_connect();
                SqlCommand cm = new SqlCommand("UPDATE dbo.[User] SET LastName = '"+user.LastName+"',FirstName  = '"+user.FirstName+"', BirthDate = '"+user.dateTime+"',Role = '"+user.Role+"' where ID = "+user.ID, Connection.connect());
                cm.ExecuteNonQuery();
                Connection.Close_connect();
                return true;
            }
            catch
            {
                Connection.Close_connect();
                return false;
            }
        }
        public bool DeleteUser(int ID)
        {
            try
            {
                Connection.Open_connect();
                SqlCommand cm = new SqlCommand("DELETE dbo.[User] WHERE ID  = " + ID,Connection.connect());
                cm.ExecuteNonQuery();
                Connection.Close_connect();
                return true;
            }
            catch
            {
                Connection.Close_connect();
                return false;
            }
        }

        public User GetUserByID(int id)
        {
           User user = null;
            try
            {
                Connection.Open_connect();
                SqlCommand cm = new SqlCommand("SELECT*FROM dbo.[User] where ID= "+id, Connection.connect());
                SqlDataReader rd = cm.ExecuteReader();
                while (rd.Read())
                {
                     user = new User()
                    {
                        ID = rd.GetInt32(0),
                        UserName = rd.GetString(1),
                        Password = rd.GetString(2),
                        FirstName = rd.GetString(3),
                        LastName = rd.GetString(4),
                        dateTime = rd.GetDateTime(5),
                        Role = rd.GetString(6)
                    };
                }
                Connection.Close_connect();
            }
            catch
            {
                Connection.Close_connect();
                user = null;
            }
            return user;
        }
        public DataTable Gettable(string sql)
        {
            Connection.Open_connect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, Connection.connect());
            DataTable dt = new DataTable();
            ad.Fill(dt);
            Connection.Close_connect();
            return dt;
        }
        public bool  ChangePass(User user)
        {
            
            //try
            //{
                Connection.Open_connect();
                SqlCommand cm = new SqlCommand("UPDATE dbo.[User] SET Password = '" + user.Password+"' WHERE ID =" + user.ID, Connection.connect());
                cm.ExecuteNonQuery();
            
                Connection.Close_connect();
            //}
            //catch
            //{
            //    Connection.Close_connect();
            //    return false;
            //}
            return  true;
        }
    }
}
