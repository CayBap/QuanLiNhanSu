using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class QuaTrinhCongTacDAL
    {
        public DataTable DSQuaTrinhCongTacDAL()
        {
            string sqlcmd = "select QuyTrinhCongTac.MaNhanVien, Ten,TuNgay,DenNgay," +
                "NoiCongTac,ChucVu from QuyTrinhCongTac inner join HoSo  " +
                "on QuyTrinhCongTac.MaNhanVien=HoSo.MaNhanVien";
            DataTable dt = new DataTable();
            try
            {
                Connection.Open_connect();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd, Connection.connect());
                sda.Fill(dt);
                
            }
            catch
            { }
            Connection.Close_connect();
            return dt;
        }

        public DataTable SearchDAL(string ma)
        {
            string sqlcmd = "select QuyTrinhCongTac.MaNhanVien, Ten,TuNgay,DenNgay," +
            "NoiCongTac,ChucVu from QuyTrinhCongTac inner join HoSo  " +
            "on QuyTrinhCongTac.MaNhanVien=HoSo.MaNhanVien where QuyTrinhCongTac.MaNhanVien='" + ma + "'";
            DataTable dt = new DataTable();
            Connection.Open_connect();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd, Connection.connect());
            sda.Fill(dt);
            Connection.Close_connect();
            return dt;
        }
        public string searchtenDAL(string ma)
        {
            string ten = "";

            Connection.Open_connect();
            string sqlcmd = "select QuyTrinhCongTac.MaNhanVien, Ten from QuyTrinhCongTac inner join HoSo  " +
        "on QuyTrinhCongTac.MaNhanVien=HoSo.MaNhanVien where QuyTrinhCongTac.MaNhanVien='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sqlcmd, Connection.connect());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ten = dr["Ten"].ToString();
            }
            Connection.Close_connect();
            return ten;
        }

        public bool addDAL(string ma, DateTime tungay, DateTime denngay, string noicongtac, string chucvu)
        {
            string sqlcmd = "insert into QuyTrinhCongTac values(@ma,@tungay,@denngay,@noicongtac,@chucvu)";
            Connection.Open_connect();
            try
            {
                SqlCommand cmd = new SqlCommand(sqlcmd, Connection.connect());
                cmd.Parameters.AddWithValue("ma", ma);
                cmd.Parameters.AddWithValue("tungay", tungay);
                cmd.Parameters.AddWithValue("denngay", denngay);
                cmd.Parameters.AddWithValue("noicongtac", noicongtac);
                cmd.Parameters.AddWithValue("chucvu", chucvu);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Connection.Close_connect();
                return false;
            }
            Connection.Close_connect();
            return true;
        }

        public void deleteDAL(string ma, DateTime tungay)
        {
            Connection.Open_connect();
            string sqlselect = "select QuyTrinhCongTac.MaNhanVien from QuyTrinhCongTac where QuyTrinhCongTac.MaNhanVien='" + ma + "' and TuNgay='" + tungay.Month + "-"
                + tungay.Day + "-" + tungay.Year + "'";
            SqlCommand sqlcmdsl = new SqlCommand(sqlselect, Connection.connect());
            SqlDataReader dr = sqlcmdsl.ExecuteReader();

            string manv = null;
            while (dr.Read())
            {
                manv = dr["MaNhanVien"].ToString();
            }
            Connection.Close_connect();
            Connection.Open_connect();
            if (manv != null)
            {
                string sqlcmd = "delete QuyTrinhCongTac where MaNhanVien='" + ma + "' and TuNgay='" + tungay.Month + "-"
                + tungay.Day + "-" + tungay.Year + "'";
                SqlCommand cmd = new SqlCommand(sqlcmd, Connection.connect());
                cmd.ExecuteNonQuery();
                MessageBox.Show("xóa thành công","Kết quả",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else {

                MessageBox.Show("mã hoặc từ ngày không đúng","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            Connection.Close_connect();
        }
        public QuaTrinhCongTac searchMaAndDayDAL(string ma,DateTime tungay)
        {
            QuaTrinhCongTac QTCT=null;
            Connection.Open_connect();
            string sqlselect = "select * from QuyTrinhCongTac where QuyTrinhCongTac.MaNhanVien='" + ma + "' and TuNgay='" + tungay.Month + "-"
                + tungay.Day + "-" + tungay.Year + "'";
            SqlCommand sqlcmdsl = new SqlCommand(sqlselect, Connection.connect());
            SqlDataReader dr = sqlcmdsl.ExecuteReader();
            while(dr.Read())
            {
                QTCT = new QuaTrinhCongTac(dr["MaNhanVien"].ToString(),Convert.ToDateTime(dr["TuNgay"].ToString()),
                    Convert.ToDateTime(dr["DenNgay"].ToString()), dr["NoiCongTac"].ToString(), dr["ChucVu"].ToString());
            }
            Connection.Close_connect();
            return QTCT;

        }

        public void updateDAL(string ma, DateTime tungay,DateTime denngay, string noicongtac,string chucvu)
        {

            Connection.Open_connect();
            string sqlselect = "select QuyTrinhCongTac.MaNhanVien from QuyTrinhCongTac where QuyTrinhCongTac.MaNhanVien='" + ma + "' and TuNgay='" + tungay.Month + "-"
                + tungay.Day + "-" + tungay.Year + "'";
            SqlCommand sqlcmdsl = new SqlCommand(sqlselect, Connection.connect());
            SqlDataReader dr = sqlcmdsl.ExecuteReader();

            string manv = null;
            while (dr.Read())
            {
                manv = dr["MaNhanVien"].ToString();
            }
            Connection.Close_connect();
            Connection.Open_connect();
            if (manv != null)
            {
                string sqlcmd = "update QuyTrinhCongTac  set DenNgay=@denngay,NoiCongTac=@noicongtac , ChucVu=@chucvu" +
                               " where QuyTrinhCongTac.MaNhanVien =@ma   and QuyTrinhCongTac.TuNgay='" + tungay.Month + "-"
                + tungay.Day + "-" + tungay.Year + "'";
               
                SqlCommand cmd = new SqlCommand(sqlcmd, Connection.connect());
                cmd.Parameters.AddWithValue("ma",ma);
              //  cmd.Parameters.AddWithValue("tungay",tungay);
                cmd.Parameters.AddWithValue("denngay",denngay);
                cmd.Parameters.AddWithValue("noicongtac", noicongtac);
                cmd.Parameters.AddWithValue("chucvu", chucvu);
                cmd.ExecuteNonQuery();
              
                Connection.Close_connect();
                MessageBox.Show("Cập nhật thành công","Kết Quả",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("mã hoặc từ ngày không đúng","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            Connection.Close_connect();
          
        }
    }

}
