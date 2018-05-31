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
    public class PhongBanBUL
    {
        PhongBanDAL PBDAL = new PhongBanDAL();
        public DataTable GetDSBUL()
        {
            string sqlcmd = "select * from PhongBan";
            SqlCommand cmd = new SqlCommand(sqlcmd, Connection.connect());
            return PBDAL.GetPhongBanDAL(cmd);

        }

        public PhongBan GetPB(string ma)
        {
            string sqlcmd = "select * from PhongBan where MaPhongBan='"+ma+"'";
            SqlCommand cmd = new SqlCommand(sqlcmd, Connection.connect());
            return PBDAL.GetPBDAL(cmd);
        }

        public void AddBUL(string ma, string ten, DateTime ngay)
        {
            string sqlcmd = "insert into PhongBan values(@ma,@ten,@ngay)";
            SqlCommand cmd = new SqlCommand(sqlcmd, Connection.connect());
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.Parameters.AddWithValue("ten", ten);
            cmd.Parameters.AddWithValue("ngay", ngay);
            PBDAL.updateDAL(cmd);
        }

        public void UpdateBUL(string ma, string ten, DateTime ngay)
        {
            string sqlcmd = "update PhongBan set TenPhongBan = @ten, NgayThanhLap = @ngay where MaPhongBan = @ma";
            SqlCommand cmd = new SqlCommand(sqlcmd, Connection.connect());
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.Parameters.AddWithValue("ten", ten);
            cmd.Parameters.AddWithValue("ngay", ngay);
            PBDAL.updateDAL(cmd);
        }

        public void DeleteBUL(string ma)
        {
            string sqlcmd = "delete PhongBan where MaPhongBan=@ma";
            SqlCommand cmd = new SqlCommand(sqlcmd, Connection.connect());
            cmd.Parameters.AddWithValue("ma", ma);
            PBDAL.updateDAL(cmd);
        }
    }
}
