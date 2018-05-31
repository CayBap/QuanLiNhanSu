using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBan
    {
        public string MaPhongBan { get; set; }
        public string  TenPhongBan { get; set; }
        public DateTime NgayThanhLap { get; set; }
        public PhongBan() { }
        public PhongBan(string ma, string ten, DateTime ngay)
        {
            MaPhongBan = ma;
            TenPhongBan = ten;
            NgayThanhLap = ngay;
        }
    }
}
