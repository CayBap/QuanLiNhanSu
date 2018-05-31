using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrinhDoChuyenMonDTO
    {
        public string MaNhanVien { get; set; }
        public string Nganh { get; set; }
        public string TrinhDo { get; set; }
        public string LoaiHinhDaoTao { get; set; }
        public string TruongDaoTao { get; set; }
        public TrinhDoChuyenMonDTO () { }
        public TrinhDoChuyenMonDTO(string ma, string nganh, string trinhdo, string loaihinhdaotao, string trdaotao) {
            this.MaNhanVien = ma;
            this.Nganh = nganh;
            this.TrinhDo = trinhdo;
            this.LoaiHinhDaoTao = loaihinhdaotao;
            this.TruongDaoTao = trdaotao;
        
        }

    }
}
