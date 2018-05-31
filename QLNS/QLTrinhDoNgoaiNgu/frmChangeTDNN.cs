using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.QLTrinhDoChuyenMon;
using DTO;
using BUL;
namespace QLNS.QLTrinhDoNgoaiNgu
{
    public partial class frmChangeTDNN : Form
    {
        public frmChangeTDNN()
        {
            InitializeComponent();
        }

        private void frmChangeTDNN_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            string ma = ucQuanLiTrinhDoNgoaiNgu.maTimKiem.ToString();
            TrinhDoNgoaiNgu a = new TrinhDoNgoaiNguBUL().getATDCM(ma);
            txtmaNV.Text = a.MaNhanVien.ToString(); txtmaNV.Enabled = false;
            txtNgoaiNgu.Text = a.NgoaiNgu.ToString(); txtNgoaiNgu.Enabled = false;
            cbTrinhDo.SelectedItem = a.TrinhDo;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtmaNV.Text!="" || txtNgoaiNgu.Text!="")
            {
                TrinhDoNgoaiNgu a = new TrinhDoNgoaiNgu(txtmaNV.Text.ToString(), txtNgoaiNgu.Text.ToString(), cbTrinhDo.SelectedItem.ToString());
                bool check = new TrinhDoNgoaiNguBUL().updateTDNN(a);
                if (check)
                {
                    this.Close();
                    MessageBox.Show("Thêm thành công", "Thông Báo!");

                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo!");
                }
            }
            else
            {
                lblThongBao.Text = "Vui lòng điền đầy đủ các trường.";
            }
        }
    }
}
