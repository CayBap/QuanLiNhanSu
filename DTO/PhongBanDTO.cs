using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBanDTO
    {
        public string maPB { get; set; }
        public string tenPB { get; set; }
        public DateTime ngayTL { get; set; }
        public PhongBanDTO() { }
        public PhongBanDTO(string ma, string ten, DateTime ngtl) {
            this.maPB = ma;
            this.tenPB = ten;
            this.ngayTL = ngtl;
        }
    }
}
