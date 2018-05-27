using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class NhanVienChucVuBUL
    {
        public List<NhanVienChucVu> GetListNhanVienChucVu()
        {
            return new NhanVienChucVuDAL().GetList();
        }
        public bool ThemNanVienChucVu(NhanVienChucVu nv)
        {
            string query = "INSERT INTO dbo.NhanVien_ChucVu VALUES('"+nv.MaNhanVien+"','"+nv.MaChucVu+"','"+nv.TuNgay+"','"+nv.DenNgay+"')";
            return new NhanVienChucVuDAL().ExnonQuery(query);
        }
        public bool SuaNhanVienChucVu(NhanVienChucVu nv)
        {
            string query = "UPDATE dbo.NhanVien_ChucVu SET DenNgay = '"+nv.DenNgay+"' WHERE MaNhanVien = '"+nv.MaNhanVien+"' AND MaChucVu = '"+nv.MaChucVu+"'";
            return new NhanVienChucVuDAL().ExnonQuery(query);
        }
        public bool XoaNhanVienChucVu(NhanVienChucVu nv)
        {
            string query = "DELETE dbo.NhanVien_ChucVu WHERE MaNhanVien  = '" + nv.MaNhanVien + "' AND MaChucVu = '" + nv.MaChucVu + "'  AND TuNgay = '" + nv.TuNgay + "'";
            return new NhanVienChucVuDAL().ExnonQuery(query);
        }
    }
}
