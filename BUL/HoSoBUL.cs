using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUL
{
    public class HoSoBUL
    {
        HoSoDAL file = new HoSoDAL();

        public DataTable DSHoSoBUL()
        {
            return file.DSHoSoDAL();
        }
        public DataTable searchHoSo(string ma) {
            return file.searchHoSo(ma);
        }
        public bool addHoSo(HoSoDTO hs) {
            bool check = file.addHoSo(hs);
            return check;
        }
        //fun update
        public bool updateHoSo(HoSoDTO f) {
            bool check = file.updateHoSo(f);
            return check;
        }
        // fun delete 
        public bool deleteHoSo(string ma) {
            bool check = file.deleteHoSo(ma);
            return check;
        }
        // fun get phong ban
        public List<PhongBanDTO> getPhongBan() {
            return new HoSoDAL().getPhongBan();
        }

        public HoSoDTO getDataChange(string ma) {
           
           HoSoDTO a = new HoSoDTO();
           a = new HoSoDAL().getaFile(ma);
           return a;
        }
    }
}
