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
    public class TrinhDoNgoaiNguDAL
    {
        // func getTabele list TDNN
        public DataTable DSTrinhDoNN()
        {
            Connection.Open_connect();
            DataTable dt = new DataTable();
            try
            {

                string query = @"select TrinhDoNgoaiNgu.MaNhanVien,HoSo.HoDem,HoSo.Ten,TrinhDoNgoaiNgu.NgoaiNgu,TrinhDoNgoaiNgu.TrinhDo from TrinhDoNgoaiNgu inner join HoSo on TrinhDoNgoaiNgu.MaNhanVien=HoSo.MaNhanVien";
                SqlDataAdapter da = new SqlDataAdapter(query, Connection.connect());
                da.Fill(dt);


            }
            catch
            {
                MessageBox.Show("Lỗi gì đấy chả biết ahihi!","Thông Báo!");
                Connection.Close_connect();
            }

            Connection.Close_connect();
            return dt;

        }
        // func search ()

        public DataTable searchTDNN(string ma)
        {
            Connection.Open_connect();
            string query = "select TrinhDoNgoaiNgu.MaNhanVien,HoSo.HoDem,HoSo.Ten,TrinhDoNgoaiNgu.NgoaiNgu,TrinhDoNgoaiNgu.TrinhDo from TrinhDoNgoaiNgu inner join HoSo on TrinhDoNgoaiNgu.MaNhanVien=HoSo.MaNhanVien where TrinhDoNgoaiNgu.MaNhanVien='" + ma + "'";
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
        public bool addTDNN(TrinhDoNgoaiNgu f)
        {
            Connection.Open_connect();
            try
            {

                SqlCommand cm = new SqlCommand("INSERT INTO TrinhDoNgoaiNgu VALUES(@ma,@ngoaingu,@trinhdo) ", Connection.connect());
                cm.Parameters.AddWithValue("ma", f.MaNhanVien);
                cm.Parameters.AddWithValue("ngoaingu", f.NgoaiNgu);
                cm.Parameters.AddWithValue("trinhdo", f.TrinhDo);
                
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
        public bool updateTDNN(TrinhDoNgoaiNgu f)
        {
            bool check = false;
            Connection.Open_connect();
            try
            {
                SqlCommand cm = new SqlCommand("UPDATE TrinhDoNgoaiNgu set MaNhanVien = @ma, NgoaiNgu = @ngoaingu, TrinhDo= @trinhdo where MaNhanVien = @ma and NgoaiNgu =  @ngoaingu", Connection.connect());
                cm.Parameters.AddWithValue("ma", f.MaNhanVien);
                cm.Parameters.AddWithValue("ngoaingu", f.NgoaiNgu);
                cm.Parameters.AddWithValue("trinhdo", f.TrinhDo);
                
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

        //// func get a TDNN
        public TrinhDoNgoaiNgu getATDNN(string ma)
        {
            Connection.Open_connect();
            TrinhDoNgoaiNgu qual = null;
            try
            {
                SqlCommand cmd = new SqlCommand("select TrinhDoNgoaiNgu.MaNhanVien,TrinhDoNgoaiNgu.NgoaiNgu,TrinhDoNgoaiNgu.TrinhDo from TrinhDoNgoaiNgu where TrinhDoNgoaiNgu.MaNhanVien = @ma", Connection.connect());
                cmd.Parameters.AddWithValue("ma", ma);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    qual = new TrinhDoNgoaiNgu(rd.GetString(0), rd.GetString(1), rd.GetString(2));

                }
            }
            catch
            {
                //MessageBox.Show("Mã Nhân Viên Không Tồn Tại.","Lỗi!");
                Connection.Close_connect();
            }
            
            Connection.Close_connect();
            return qual;
        }
        //func Delete Qual
        public bool deleteTDNN(string ma,string ngoaingu)
        {
            bool check = false;
            try
            {
                Connection.Open_connect();
                SqlCommand cmd = new SqlCommand("delete from TrinhDoNgoaiNgu Where MaNhanVien = @ma and NgoaiNgu =  @ngoaingu", Connection.connect());
                cmd.Parameters.AddWithValue("ma", ma);
                cmd.Parameters.AddWithValue("ngoaingu", ngoaingu);
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
        // end
    }
}
