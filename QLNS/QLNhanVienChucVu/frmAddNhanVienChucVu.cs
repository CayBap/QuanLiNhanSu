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
    public partial class frmAddNhanVienChucVu : Form
    {
        public frmAddNhanVienChucVu()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienChucVu nv = new NhanVienChucVu()
                {
                    MaNhanVien = txtMaNhanVien.Text,
                    MaChucVu = txtMaChucVu.Text,
                    TuNgay = dtpTuNgay.Value,
                    DenNgay = dtpDenNgay.Value
                };
                bool check  =  new NhanVienChucVuBUL().ThemNanVienChucVu(nv);
                if (check == true)
                {
                    MessageBox.Show("Thêm  nhân viên chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin chức vụ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Thêm mới nhân viên chức vụ không thành công!", "Thongo báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddNhanVienChucVu_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
