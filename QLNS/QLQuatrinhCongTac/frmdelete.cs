using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
namespace QLNS.QLQuatrinhCongTac
{
    public partial class frmdelete : Form
    {
        public frmdelete()
        {
            InitializeComponent();
        }
        QuaTrinhCongTacBUL QTCT = new QuaTrinhCongTacBUL();
        QuaTrinhCongTac QTCTDTO;
        private void btnxoa_Click(object sender, EventArgs e)
        {
            QTCTDTO = QTCT.searchMaAndDayBUL(txtMaNV.Text, dtpTuNgay.Value);
            if (QTCTDTO != null)
            {
                dtpDenNgay.Value =QTCTDTO.DenNgay;
                txtNoiCongTac.Text = QTCTDTO.NoiCongTac.ToString();
                txtChucVu.Text = QTCTDTO.ChucVu.ToString();
                DialogResult dlr = MessageBox.Show("bạn chắc chắn muốn xóa", "hỏi", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    QTCT.deleteBUL(txtMaNV.Text, dtpTuNgay.Value);
                }
                else
                { }
            }
            else
            {
                MessageBox.Show("ma hoac tu ngay khong dung");
            }
           

                
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNoiCongTac_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
