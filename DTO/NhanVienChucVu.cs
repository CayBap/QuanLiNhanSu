using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class NhanVienChucVu
    {
        public string MaNhanVien { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public string MaChucVu { get; set;}

        public NhanVienChucVu() { }
        public NhanVienChucVu(string MaNV, DateTime TuNgay, DateTime DenNgay, string chucvu)
        {
            this.MaNhanVien = MaNV;
            this.TuNgay = TuNgay;
            this.DenNgay = DenNgay;
            this.MaChucVu = chucvu;
        }
    }
}
