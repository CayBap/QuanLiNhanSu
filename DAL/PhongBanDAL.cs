using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DAL
{
    public class PhongBanDAL
    {
        public DataTable GetPhongBanDAL(SqlCommand cmd)
        {

            DataTable tb = new DataTable();
            try
            {
                Connection.Open_connect();
                SqlDataAdapter sqldat = new SqlDataAdapter(cmd);
                sqldat.Fill(tb);
            }
            catch  { }
            Connection.Close_connect();

            return tb;
        }

        public PhongBan GetPBDAL(SqlCommand cmd)
        {
            PhongBan pb=null;
            Connection.Open_connect();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pb = new PhongBan(dr["MaPhongBan"].ToString(), dr["TenPhongBan"].ToString(), Convert.ToDateTime(dr["NgayThanhLap"]));
                }
            }
            catch 
            { }
            Connection.Close_connect();
            return pb;
        }

        public void updateDAL(SqlCommand cmd)
        {
            Connection.Open_connect();
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật Thành Công","Kết Quả",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Mã không đúng hoặc đã tồn tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Hand);

            }
            Connection.Close_connect();
        }

     

    }
}
