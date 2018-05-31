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

        public bool addBUL(string ma, DateTime tungay, DateTime denngay, string noicongtac, string chucvu)
        {
           return Qt.addDAL(ma, tungay, denngay, noicongtac, chucvu);
        }

        public void deleteBUL(string ma, DateTime tungay)
        {

            Qt.deleteDAL(ma, tungay);
        }
        public QuaTrinhCongTac searchMaAndDayBUL(string ma, DateTime tungay)
        {
            return Qt.searchMaAndDayDAL(ma, tungay);
        }

        public void updateBUL(string ma, DateTime tungay, DateTime denngay, string noicongtac, string chucvu)
        {
            Qt.updateDAL(ma, tungay, denngay, noicongtac, chucvu);
        }
    }
}
