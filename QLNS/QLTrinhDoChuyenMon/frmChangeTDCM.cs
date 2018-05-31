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


namespace QLNS.QLTrinhDoChuyenMon
{
    public partial class frmChangeTDCM : Form
    {
        public frmChangeTDCM()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangeTDCM_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            string a = ucQuanLiTrinhDoChuyenMon.maTimKiem;
            TrinhDoChuyenMonDTO t = new TrinhDoChuyenMonBUL().getATDCM(a);
            txtmaNV.Text = t.MaNhanVien.ToString();
            txtmaNV.Enabled = false;
            txtNganh.Text = t.Nganh.ToString();
            txtNganh.Enabled = false;
            txtTruongDaoTao.Text = t.TruongDaoTao.ToString();
            cbLoaiHinhDaoTao.SelectedIndex = 0;
            cbTrinhDo.SelectedIndex = 0;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtmaNV.Text != "" || txtNganh.Text != "" || txtTruongDaoTao.Text != "")
            {
                TrinhDoChuyenMonDTO qual = new TrinhDoChuyenMonDTO(txtmaNV.Text.ToString(), txtNganh.Text.ToString(), cbTrinhDo.SelectedItem.ToString(), cbLoaiHinhDaoTao.SelectedItem.ToString(), txtTruongDaoTao.Text.ToString());
                bool check = new TrinhDoChuyenMonBUL().updateTDCM(qual);
                if (check == true)
                {
                    //this.Close();
                    MessageBox.Show("Update thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update thất bại :(", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lblThongBao.Text = "Vui lòng không bỏ trống trường nào.";
            }
            //MessageBox.Show(txtmaNV.Text.ToString());
        }
    }
}
