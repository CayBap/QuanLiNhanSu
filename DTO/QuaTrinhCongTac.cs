using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class QuaTrinhCongTac
    {
        public string MaNV { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public string NoiCongTac { get; set; }
        public string ChucVu { get; set;}

        public QuaTrinhCongTac() { }
        public QuaTrinhCongTac(string MaNV, DateTime TuNgay, DateTime DenNgay, string noicongtac, string chucvu)
        {
            this.MaNV = MaNV;
            this.TuNgay = TuNgay;
            this.DenNgay = DenNgay;
            this.NoiCongTac = noicongtac;
            this.ChucVu = chucvu;
        }

       
    }
}
