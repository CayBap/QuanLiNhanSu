using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;
namespace QLNS.QLNhanVienChucVu
{
    public partial class frmSuaNhanVienChucVu : Form
    {
        public frmSuaNhanVienChucVu()
        {
            InitializeComponent();
        }
        public static NhanVienChucVu nv = null;
        private void frmSuaNhanVienChucVu_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
        void LoadForm()
        {
            if (nv != null)
            {
                txtMaNhanVien.Text = nv.MaNhanVien;
                txtMaChucVu.Text = nv.MaChucVu;
                dtpTuNgay.Value = nv.TuNgay;
                dtpDenNgay.Value = nv.DenNgay;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nv.DenNgay = dtpDenNgay.Value;
            bool check = new NhanVienChucVuBUL().SuaNhanVienChucVu(nv);
            if (check == true)
            {
                MessageBox.Show("Cập nhập nhân viên chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhập thông tin chức vụ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaChucVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
