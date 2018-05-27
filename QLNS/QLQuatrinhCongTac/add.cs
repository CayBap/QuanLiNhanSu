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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void frmQLQTCT_Load(object sender, EventArgs e)
        {
                 }
        QuaTrinhCongTacBUL QTCT = new QuaTrinhCongTacBUL();
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                QTCT.addBUL(txtMaNV.Text, dtpTuNgay.Value, dtpDenNgay.Value, txtNoiCongTac.Text, txtChucVu.Text);
                MessageBox.Show("thêm thành công", "Kết Quả");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã nhân viên không có trong hồ sơ", "Thông Báo");
            }



        }
    }
}
