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
    public class TrinhDoChuyenMonBUL
    {
        TrinhDoChuyenMonDAL TDCMDAL = new TrinhDoChuyenMonDAL();

      
        public DataTable DSTrinhDoChuyenMon()
        {
            return TDCMDAL.DanhSachDAL();
        }
        public DataTable GetNganh()
        {
            DataTable dt = new TrinhDoChuyenMonDAL().GetTable("SELECT nganh FROM dbo.TrinhDoChuyenMon GROUP BY Nganh");
            return dt;
        }
        public DataTable GetTrinhDo()
        {
            DataTable dt = new TrinhDoChuyenMonDAL().GetTable("SELECT TrinhDo FROM dbo.TrinhDoChuyenMon GROUP BY TrinhDo");
            return dt;
        }
        TrinhDoChuyenMonDAL file = new TrinhDoChuyenMonDAL();

        public DataTable DSTDCM()
        {
            return file.DSTrinhDoCM();
        }
        // func seach
        public DataTable findTDCM(string ma)
        {
            TrinhDoChuyenMonDAL a = new TrinhDoChuyenMonDAL();
            return a.searchTDCM(ma);
        }
        // func add
        public bool addTDCM(TrinhDoChuyenMonDTO qual)
        {

            return new TrinhDoChuyenMonDAL().addTDCM(qual);
        }
        //get a Qual
        public TrinhDoChuyenMonDTO getATDCM(string ma)
        {
            TrinhDoChuyenMonDAL a = new TrinhDoChuyenMonDAL();
            TrinhDoChuyenMonDTO q = a.getATDCM(ma);
            return q;
        }
        // func update
        public bool updateTDCM(TrinhDoChuyenMonDTO f)
        {
            return new TrinhDoChuyenMonDAL().updateTDCM(f);

        }
        //func delete
        public bool deleteTCDM(string ma,string nganh)
        {
            return new TrinhDoChuyenMonDAL().deleteTDCM(ma,nganh);
        }
    }
}
