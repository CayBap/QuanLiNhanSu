using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVu
    {

        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public double HeSoPhuCap { get; set; }
        public ChucVu() { }
        public ChucVu(string ma, string ten, double hspc)
        {
            MaChucVu = ma;
            TenChucVu = ten;
            HeSoPhuCap = hspc;
        }
    }
}
