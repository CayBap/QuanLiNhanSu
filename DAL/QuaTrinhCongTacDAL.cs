using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace DAL
{
    public class QuaTrinhCongTacDAL
    {
        public DataTable DSQuaTrinhCongTacDAL()
        {
            string sqlcmd = "select QuyTrinhCongTac.MaNhanVien, Ten,TuNgay,DenNgay," +
                "NoiCongTac,ChucVu from QuyTrinhCongTac inner join HoSo  " +
                "on QuyTrinhCongTac.MaNhanVien=HoSo.MaNhanVien";
            DataTable dt=new DataTable();
            try
            {
                Connection.Open_connect();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd, Connection.connect());
                sda.Fill(dt);
                Connection.Close_connect();
            }
            catch (Exception ex)
            { }
            return dt;
        }

        public DataTable SearchDAL(string ma)
        {
            string sqlcmd = "select QuyTrinhCongTac.MaNhanVien, Ten,TuNgay,DenNgay," +
                "NoiCongTac,ChucVu from QuyTrinhCongTac inner join HoSo  " +
                "on QuyTrinhCongTac.MaNhanVien=HoSo.MaNhanVien where MaNhanVien="+ma;
            DataTable dt = new DataTable();
            try
            {
                Connection.Open_connect();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd, Connection.connect());
                sda.Fill(dt);
                Connection.Close_connect();
            }
            catch (Exception ex)
            { }
            return dt;
        }
        public string searchtenDAL(string ma)
        {
            string ten="";
                try {
                Connection.Open_connect();
                string sqlcmd = "select QuyTrinhCongTac.MaNhanVien, Ten from QuyTrinhCongTac inner join HoSo  " +
            "on QuyTrinhCongTac.MaNhanVien=HoSo.MaNhanVien where MaNhanVien=" + ma;

                Connection.Close_connect();
            }
                catch (Exception ex)
                {
                }
            return ten;
        }
    }
}
