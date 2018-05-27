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
    public partial class frmupdate : Form
    {
        public frmupdate()
        {
            InitializeComponent();
        }

        private void frmupdate_Load(object sender, EventArgs e)
        {

        }
        QuaTrinhCongTacBUL QTCTBUL = new QuaTrinhCongTacBUL();
        QuaTrinhCongTac QTCT = new QuaTrinhCongTac();
        private void btnsearch_Click(object sender, EventArgs e)
        {
            QTCT = QTCTBUL.searchMaAndDayBUL(txtMaNV.Text, dtpTuNgay.Value);
            if (QTCT != null)
            {
                dtpDenNgay.Value = QTCT.DenNgay;
                txtNoiCongTac.Text = QTCT.NoiCongTac.ToString();
                txtChucVu.Text = QTCT.ChucVu.ToString();
            }
            else
            {
                MessageBox.Show("ma hoac tu ngay khong dung");
            }
        }
        
        private void btnupdate_Click(object sender, EventArgs e)
        {
            QTCT = QTCTBUL.searchMaAndDayBUL(txtMaNV.Text, dtpTuNgay.Value);
            if (QTCT != null)
            {
        
                DialogResult dlr = MessageBox.Show("bạn chắc chắn muốn sửa thông tin", "hỏi", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    QTCTBUL.updateBUL(txtMaNV.Text,dtpTuNgay.Value,dtpDenNgay.Value,txtNoiCongTac.Text,
                        txtChucVu.Text);
                }
                else
                { }
            }
            else
            {
                MessageBox.Show("ma hoac tu ngay khong dung");
            }

        }
    }
}
