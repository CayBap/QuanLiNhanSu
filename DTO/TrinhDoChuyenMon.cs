using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class TrinhDoChuyenMon
    {
        public string MaNV { get; set; }
        public string Nganh { get; set; }
        public string TrinhDo { get; set; }
        public string LoaiHinhDaoTao { get; set; }
        public string TruongDaoTao { get; set; }

        public TrinhDoChuyenMon() { }
        public TrinhDoChuyenMon(string ma, string nganh, string TrinhDo, string loaihinhdaotao
            , string truong)
        {
            MaNV = ma;
            Nganh = nganh;
            this.TrinhDo = TrinhDo;
            LoaiHinhDaoTao = loaihinhdaotao;
            TruongDaoTao = truong;
        }
    }
}
