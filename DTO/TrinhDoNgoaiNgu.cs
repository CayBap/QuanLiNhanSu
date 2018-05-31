using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrinhDoNgoaiNgu
    {
        public string  MaNhanVien{ get; set;}
        public string  NgoaiNgu{ get; set;}
        public string  TrinhDo{ get; set;}

        public TrinhDoNgoaiNgu (){}
        public TrinhDoNgoaiNgu(string ma, string ngng, string trinhdo)
        {
            this.MaNhanVien = ma;
            this.NgoaiNgu = ngng;
            this.TrinhDo = trinhdo;
        }
    }
}
