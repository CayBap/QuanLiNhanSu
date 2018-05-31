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
    public class TrinhDoNgoaiNguBUL
    {
        TrinhDoNgoaiNguDAL El = new TrinhDoNgoaiNguDAL();

        public DataTable DSTDNN()
        {
            return El.DSTrinhDoNN();
        }
        // func seach
        public DataTable searchTDNN(string ma)
        {
            TrinhDoNgoaiNguDAL a = new TrinhDoNgoaiNguDAL();
            return a.searchTDNN(ma);
        }
        // func add
        public bool addTDCM(TrinhDoNgoaiNgu qual)
        {

            return new TrinhDoNgoaiNguDAL().addTDNN(qual);
        }
        //get a EL
        public TrinhDoNgoaiNgu getATDCM(string ma)
        {
            TrinhDoNgoaiNguDAL a = new TrinhDoNgoaiNguDAL();
            TrinhDoNgoaiNgu q = a.getATDNN(ma);
            return q;
        }
        public bool updateTDNN(TrinhDoNgoaiNgu f)
        {
            return new TrinhDoNgoaiNguDAL().updateTDNN(f);

        }
        public bool deleteTDNN(string ma,string ngoaingu)
        {
            return new TrinhDoNgoaiNguDAL().deleteTDNN(ma,ngoaingu);

        }
    }
}
