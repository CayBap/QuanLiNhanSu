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
    public class ChucVuDAL
    {

        public DataTable GetChucVuDAL(SqlCommand cmd)
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

        public ChucVu GetCVDAL(SqlCommand cmd)
        {
            ChucVu cv = null;
            Connection.Open_connect();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cv = new ChucVu(dr["MaChucVu"].ToString(), dr["TenChucVu"].ToString(), Convert.ToDouble(dr["HeSoPhuCap"]));
                }
            }
            catch 
            { }
            Connection.Close_connect();
            return cv;
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
                MessageBox.Show("Ma không đúng hoặc đã tồn tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Hand);

            }
            Connection.Close_connect();
        }
    }
}
