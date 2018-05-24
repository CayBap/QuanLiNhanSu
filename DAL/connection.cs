using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace DAL
{
    public class Connection
    {
        private  static SqlConnection conn;

        public  static SqlConnection connect()
        {
            return conn;
        }

        public static void Creat_connect()
        {
            string sqlcmd = ConfigurationManager.ConnectionStrings["conStr"].ToString();
            conn = new SqlConnection(sqlcmd);
        }
        public static void Close_connect()
        {
            conn.Close();
        }
        public static void Open_connect()
        {
            conn.Open();
        }

    }
}
