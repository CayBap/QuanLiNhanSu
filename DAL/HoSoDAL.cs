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
    public class HoSoDAL
    {
        public DataTable DSHoSoDAL()
        {
            
            DataTable dt = new DataTable();
            try
            {
                Connection.Open_connect();
                string query = "select HoSo.MaNhanVien,HoSo.HoDem,HoSo.Ten,HoSo.NgaySinh,HoSo.GioiTinh,HoSo.SoDT,HoSo.Email,HoSo.NgayTuyenDung,HoSo.MaPhongBan from HoSo inner join PhongBan on HoSo.MaPhongBan=PhongBan.MaPhongBan";
                SqlDataAdapter da = new SqlDataAdapter(query, Connection.connect());
                da.Fill(dt);
                Connection.Close_connect();
            }
            catch
            { }
            return dt;
        }

        // fun tim kiem 
        public DataTable searchHoSo(string ma)
        {
            Connection.Open_connect();
            string query = "select MaNhanVien,HoDem,Ten,NgaySinh,GioiTinh,SoDT,Email,NgayTuyenDung,HoSo.MaPhongBan from HoSo inner join PhongBan on HoSo.MaPhongBan=PhongBan.MaPhongBan where MaNhanVien='" + ma + "'";
            DataTable dt = new DataTable();
            try
            {

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
        //public HoSoDTO searchHoSo(string ma) {
        //    HoSoDTO file = null;
        //    Connection.Open_connect();
        //    SqlCommand cmd = new SqlCommand("select MaNhanVien,HoDem,Ten,GioiTinh,NgaySinh,SoDT,Email,NgayTuyenDung,HoSo.MaPhongBan from HoSo inner join PhongBan on HoSo.MaPhongBan=PhongBan.MaPhongBan where MaNhanVien='" + ma + "'",Connection.connect());
        //    SqlDataReader rd = cmd.ExecuteReader();
        //    while (rd.Read())
        //    {
        //        file = new HoSoDTO(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetDateTime(4), rd.GetString(5), rd.GetString(6), rd.GetDateTime(7), rd.GetString(8));

                
        //    }
        //    return file;
        //}
        public List<HoSoDTO> listFile() {

            List<HoSoDTO> list = null;
            try
            {
                list = new List<HoSoDTO>();
                Connection.Open_connect();
                SqlCommand cm = new SqlCommand("select MaNhanVien,HoDem,Ten,NgaySinh,GioiTinh,SoDT,Email,NgayTuyenDung,HoSo.MaPhongBan from HoSo inner join PhongBan on HoSo.MaPhongBan=PhongBan.MaPhongBan", Connection.connect());
                SqlDataReader rd = cm.ExecuteReader();
                while (rd.Read())
                {
                    HoSoDTO user = new HoSoDTO(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetDateTime(3),rd.GetString(4), rd.GetString(5), rd.GetString(6), rd.GetDateTime(7), rd.GetString(8));
                    
                    list.Add(user);
                }
               
            }
            catch
            {
                Connection.Close_connect();
                list = null;
            }
            Connection.Close_connect();
            return list;
        }
        // fun add HoSo

        public bool addHoSo(HoSoDTO f)
        {
            try
            {
            Connection.Open_connect();
            SqlCommand cm = new SqlCommand("INSERT INTO dbo.[HoSo] VALUES(@ma,@ho,@ten,@ns,@gt,@sdt,@mail,@ntd,@mapb)", Connection.connect());
            cm.Parameters.AddWithValue("ma",f.maNV);
            cm.Parameters.AddWithValue("ho", f.hoDem);
            cm.Parameters.AddWithValue("ten",f.Ten );
            cm.Parameters.AddWithValue("ns", f.ngaySinh);
            cm.Parameters.AddWithValue("gt",f.gioiTinh);
            cm.Parameters.AddWithValue("sdt",f.soDT);
            cm.Parameters.AddWithValue("mail",f.Email);
            cm.Parameters.AddWithValue("ntd", f.ngayTD);
            cm.Parameters.AddWithValue("mapb",f.maPB);

            cm.ExecuteNonQuery();
            
            }
            catch
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại trong hệ thống, vui lòng nhập mã khác", "Thông báo");
                Connection.Close_connect();
                return false;
            }
            Connection.Close_connect();
            return true;
        }
        // fun lay data do ra combobox
        public List<PhongBanDTO> getPhongBan() {
            List<PhongBanDTO> list = null;
            try
            {
                list = new List<PhongBanDTO>();
                Connection.Open_connect();
                SqlCommand cm = new SqlCommand("SELECT*FROM dbo.[PhongBan]", Connection.connect());
                SqlDataReader rd = cm.ExecuteReader();
                while (rd.Read())
                {
                    PhongBanDTO pb = new PhongBanDTO(rd.GetString(0), rd.GetString(1), rd.GetDateTime(2));
                    list.Add(pb);
                }
               
            }
            catch
            {
                Connection.Close_connect();
                list = null;
            }
            Connection.Close_connect();
            return list;
        }
        // ham lay du lieu de do ra form sua
        public HoSoDTO getaFile(string ma) {
            Connection.Creat_connect();
            HoSoDTO file = null;

            try
            {
                 
                Connection.Open_connect();
                SqlDataAdapter ad = new SqlDataAdapter("select MaNhanVien,HoDem,Ten,NgaySinh,GioiTinh,SoDT,Email,NgayTuyenDung,HoSo.MaPhongBan from HoSo inner join PhongBan on HoSo.MaPhongBan=PhongBan.MaPhongBan where MaNhanVien='" + ma + "'", Connection.connect());
                DataTable dt = new DataTable();
                ad.Fill(dt);
                
                file = new HoSoDTO(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), DateTime.Parse(dt.Rows[0][3].ToString()), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(),
                    dt.Rows[0][6].ToString(), DateTime.Parse(dt.Rows[0][7].ToString()), dt.Rows[0][8].ToString());

               
            }
            catch
            {
               // file = null;
                Connection.Close_connect();
            }
            Connection.Close_connect();
            return file;

           
        }
        // fun update hoso
        public bool updateHoSo(HoSoDTO f)
        {
            bool check = false;
            Connection.Open_connect();
            try
            {
                SqlCommand cm = new SqlCommand("UPDATE HoSo set MaNhanVien = @ma, HoDem = @ho, Ten= @ten, NgaySinh=@ns, GioiTinh = @gt, SoDT = @sdt, Email = @mail, NgayTuyenDung= @ntd, MaPhongBan=@mapb where MaNhanVien = @ma", Connection.connect());
                cm.Parameters.AddWithValue("ma", f.maNV);
                cm.Parameters.AddWithValue("ho", f.hoDem);
                cm.Parameters.AddWithValue("ten", f.Ten);
                cm.Parameters.AddWithValue("ns", f.ngaySinh);
                cm.Parameters.AddWithValue("gt", f.gioiTinh);
                cm.Parameters.AddWithValue("sdt", f.soDT);
                cm.Parameters.AddWithValue("mail", f.Email);
                cm.Parameters.AddWithValue("ntd", f.ngayTD);
                cm.Parameters.AddWithValue("mapb", f.maPB);
                cm.ExecuteNonQuery();
                check = true;
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn phòng ban!","Lỗi!");
                Connection.Close_connect();
                check = false;
            }
            Connection.Close_connect();
            return check;
        }
        // fun delete a File
        public bool deleteHoSo(string ma)
        {
            bool check = false;
            try
            {
                Connection.Open_connect();
                SqlCommand cmd = new SqlCommand("delete from HoSo Where MaNhanVien = @ma", Connection.connect());
                cmd.Parameters.AddWithValue("ma", ma);
                cmd.ExecuteNonQuery();
                check = true;

            }
            catch
            {
                MessageBox.Show("Mã này không tồn tại trong hệ thống!","Lỗi");
                Connection.Close_connect();
                check = false;
            }
            Connection.Close_connect();
            return check;
        }
        
        
    }
}
