using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BUL
{
    public class ChucVuBUL
    {

        ChucVuDAL CVDAL = new ChucVuDAL();
        public DataTable GetDSBUL()
        {
            string sqlcmd = "select * from ChucVu";
            SqlCommand cmd = new SqlCommand(sqlcmd, Connection.connect());
            return CVDAL.GetChucVuDAL(cmd);

        }

        public ChucVu GetCV(string ma)
        {
            string sqlcmd = "select * from ChucVu where MaChucVu='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sqlcmd, Connection.connect());
            return CVDAL.GetCVDAL(cmd);
        }

        public void AddBUL(string ma, string ten, double hspc)
        {
            string sqlcmd = "insert into ChucVu values(@ma,@ten,@hspc)";
            SqlCommand cmd = new SqlCommand(sqlcmd, Connection.connect());
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.Parameters.AddWithValue("ten", ten);
            cmd.Parameters.AddWithValue("hspc", hspc);
            CVDAL.updateDAL(cmd);
        }

        public void UpdateBUL(string ma, string ten, double hspc)
        {
            string sqlcmd = "update ChucVu set TenChucVu = @ten, HeSoPhuCap=@hspc where MaChucVu = @ma";
            SqlCommand cmd = new SqlCommand(sqlcmd, Connection.connect());
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.Parameters.AddWithValue("ten", ten);
            cmd.Parameters.AddWithValue("hspc", hspc);
            CVDAL.updateDAL(cmd);
        }

        public void DeleteBUL(string ma)
        {
            string sqlcmd = "delete ChucVu where MaChucVu=@ma";
            SqlCommand cmd = new SqlCommand(sqlcmd, Connection.connect());
            cmd.Parameters.AddWithValue("ma", ma);
            CVDAL.updateDAL(cmd);
        }
    }
}
