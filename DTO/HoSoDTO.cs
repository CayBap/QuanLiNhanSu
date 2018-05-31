using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoSoDTO
    {
        public string maNV { get; set; }
        public string hoDem { get; set; }
        public string Ten { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string soDT { get; set; }
        public string Email { get; set; }
        public DateTime ngayTD { get; set; }
        public string maPB { get; set; }

        public HoSoDTO() { }
        public HoSoDTO(string ma, string ho, string ten, DateTime ns,string gt, string sdt, string mail, DateTime ngtd, string mpb) {
            this.maNV = ma;
            this.hoDem = ho;
            this.Ten = ten;
            this.ngaySinh = ns;
            this.gioiTinh = gt;
            this.soDT = sdt;
            this.Email = mail;
            this.ngayTD = ngtd;
            this.maPB = mpb;
        
        }
    }
}
