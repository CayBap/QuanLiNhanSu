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
    public class QuaTrinhCongTacBUL
    {
        QuaTrinhCongTacDAL Qt = new QuaTrinhCongTacDAL();

        public DataTable DSQuaTrinhCongTacBUL()
        {
            return Qt.DSQuaTrinhCongTacDAL();
        }

        public DataTable searchBUL(string ma)
        { return Qt.SearchDAL(ma); }
        public string searchtenBUL(string ma)
        { return Qt.searchtenDAL(ma); }
    }
}
