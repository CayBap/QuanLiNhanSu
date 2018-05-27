using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class NhanVienChucVuDAL
    {
        public bool ExnonQuery(string query)
        {
            try
            {
                Connection.Open_connect();
                SqlCommand cm = new SqlCommand(query, Connection.connect());
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
        public List<NhanVienChucVu> GetList()
        {
            List<NhanVienChucVu> list = null;
            try
            {
                list = new List<NhanVienChucVu>();
                Connection.Open_connect();
                SqlCommand cm = new SqlCommand("SELECT*FROM dbo.NhanVien_ChucVu", Connection.connect());
                SqlDataReader rd = cm.ExecuteReader();
                while (rd.Read())
                {
                    NhanVienChucVu nvcv = new NhanVienChucVu()
                    {
                        MaNhanVien = rd.GetString(0),
                        MaChucVu = rd.GetString(1),
                        TuNgay = rd.GetDateTime(2),
                        DenNgay = rd.GetDateTime(3)
                    };
                    list.Add(nvcv);

                }
                Connection.Close_connect();
                return list;
            }
            catch
            {
                return null;
            }
        }
    }
}
