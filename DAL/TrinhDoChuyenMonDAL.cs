using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class TrinhDoChuyenMonDAL
    {
      
        public DataTable DanhSachDAL()
        {
            Connection.Open_connect();
            DataTable dt = new DataTable();
            string sqlcmd = "select TrinhDoChuyenMon.MaNhanVien, HoSo.Ten,TrinhDoChuyenMon.Nganh,TrinhDoChuyenMon.TrinhDo,TrinhDoChuyenMon.TruongDaoTao " +
                "from TrinhDoChuyenMon inner join HoSo on TrinhDoChuyenMon.MaNhanVien = HoSo.MaNhanVien ";
            SqlCommand cmd = new SqlCommand(sqlcmd, Connection.connect());
            SqlDataAdapter sqldta = new SqlDataAdapter(cmd);
            sqldta.Fill(dt);
            Connection.Close_connect();
            return dt;
        }
        public DataTable GetTable(string sql)
        {
            Connection.Open_connect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, Connection.connect());
            DataTable dt = new DataTable();
            ad.Fill(dt);
            Connection.Close_connect();
            return dt;
        }
        public DataTable DSTrinhDoCM()
        {
            Connection.Open_connect();
            DataTable dt = new DataTable();
            try
            {

                string query = @"select TrinhDoChuyenMon.MaNhanVien,HoSo.HoDem,HoSo.Ten,TrinhDoChuyenMon.Nganh,TrinhDoChuyenMon.TrinhDo,TrinhDoChuyenMon.LoaiHinhDaoTao,TrinhDoChuyenMon.TruongDaoTao from TrinhDoChuyenMon inner join HoSo on TrinhDoChuyenMon.MaNhanVien=HoSo.MaNhanVien";
                SqlDataAdapter da = new SqlDataAdapter(query, Connection.connect());
                da.Fill(dt);


            }
            catch
            {
                Connection.Close_connect();
            }

            Connection.Close_connect();
            return dt;

        }
        // func seach 
        public DataTable searchTDCM(string ma)
        {
            Connection.Open_connect();
            string query = "select TrinhDoChuyenMon.MaNhanVien,HoSo.HoDem,HoSo.Ten,TrinhDoChuyenMon.Nganh,TrinhDoChuyenMon.TrinhDo,TrinhDoChuyenMon.LoaiHinhDaoTao,TrinhDoChuyenMon.TruongDaoTao from TrinhDoChuyenMon inner join HoSo on TrinhDoChuyenMon.MaNhanVien=HoSo.MaNhanVien where TrinhDoChuyenMon.MaNhanVien='" + ma + "'";
            DataTable dt = new DataTable();
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(query, Connection.connect());
                da.Fill(dt);

            }
            catch
            {
                MessageBox.Show("Mã Nhân Viên này không tồn tại trong hệ thống", "Lỗi!");
                Connection.Close_connect();
            }
            Connection.Close_connect();
            return dt;
        }
        // func add
        public bool addTDCM(TrinhDoChuyenMonDTO f)
        {
            Connection.Open_connect();
            try
            {

                SqlCommand cm = new SqlCommand("INSERT INTO TrinhDoChuyenMon VALUES(@ma,@nganh,@trinhdo,@loaihinhdaotao,@truongdaotao) ", Connection.connect());
                cm.Parameters.AddWithValue("ma", f.MaNhanVien);
                cm.Parameters.AddWithValue("nganh", f.Nganh);
                cm.Parameters.AddWithValue("trinhdo", f.TrinhDo);
                cm.Parameters.AddWithValue("loaihinhdaotao", f.LoaiHinhDaoTao);
                cm.Parameters.AddWithValue("truongdaotao", f.TruongDaoTao);
                cm.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Mã Nhân Không tồn tại trong hệ thống Hồ Sơ Nhân Viên", "Lỗi!");
                Connection.Close_connect();
                return false;
            }
            Connection.Close_connect();
            return true;
        }
        // func update TrinhDoChuyenMon
        public bool updateTDCM(TrinhDoChuyenMonDTO f)
        {
            bool check = false;
            Connection.Open_connect();
            try
            {
                SqlCommand cm = new SqlCommand("UPDATE TrinhDoChuyenMon set MaNhanVien = @ma, Nganh = @nganh, TrinhDo= @trinhdo, LoaiHinhDaoTao=@loaihinhdaotao, TruongDaoTao = @tdt where MaNhanVien = @ma and Nganh = @nganh", Connection.connect());
                cm.Parameters.AddWithValue("ma", f.MaNhanVien);
                cm.Parameters.AddWithValue("nganh", f.Nganh);
                cm.Parameters.AddWithValue("trinhdo", f.TrinhDo);
                cm.Parameters.AddWithValue("loaihinhdaotao", f.LoaiHinhDaoTao);
                cm.Parameters.AddWithValue("tdt", f.TruongDaoTao);
                cm.ExecuteNonQuery();
                check = true;
            }
            catch
            {
                MessageBox.Show("Mã Nhân Viên này không tồn tại trong hệ thống.", "Lỗi!");
                Connection.Close_connect();
                check = false;
            }
            Connection.Close_connect();
            return check;
        }
        // func get a Qual
        public TrinhDoChuyenMonDTO getATDCM(string ma)
        {
            Connection.Open_connect();
            TrinhDoChuyenMonDTO qual = null;
            try
            {
                SqlCommand cmd = new SqlCommand("select TrinhDoChuyenMon.MaNhanVien,TrinhDoChuyenMon.Nganh,TrinhDoChuyenMon.TrinhDo,TrinhDoChuyenMon.LoaiHinhDaoTao,TrinhDoChuyenMon.TruongDaoTao from TrinhDoChuyenMon where TrinhDoChuyenMon.MaNhanVien = @ma", Connection.connect());
                cmd.Parameters.AddWithValue("ma", ma);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    qual = new TrinhDoChuyenMonDTO(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4));

                }
            }
            catch
            {
                //MessageBox.Show("Mã Nhân Viên Không Tồn Tại.","Lỗi!");
                Connection.Close_connect();
            }
            //MessageBox.Show(qual.TrinhDo.ToString());
            Connection.Close_connect();
            return qual;
        }

        //func Delete Qual
        public bool deleteTDCM(string ma,string nganh)
        {
            bool check = false;
            try
            {
                Connection.Open_connect();
                SqlCommand cmd = new SqlCommand("delete from TrinhDoChuyenMon Where MaNhanVien = @ma and Nganh = @nganh", Connection.connect());
                cmd.Parameters.AddWithValue("ma", ma);
                cmd.Parameters.AddWithValue("nganh", nganh);
                cmd.ExecuteNonQuery();
                check = true;

            }
            catch
            {
                MessageBox.Show("Mã này không tồn tại trong hệ thống!", "Lỗi");
                Connection.Close_connect();
                check = false;
            }
            Connection.Close_connect();
            return check;
        }
    }
}
