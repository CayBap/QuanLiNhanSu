using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
using QLNS.QLNhanVienChucVu;
namespace QLNS
{
    public partial class ucQuanLiNhanVienChucVu : UserControl
    {
        public ucQuanLiNhanVienChucVu()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            LoadDS();
        }
        void LoadDS()
        {
            List<NhanVienChucVu> list = new NhanVienChucVuBUL().GetListNhanVienChucVu();
            if (list != null)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = (i + 1);
                    dataGridView1.Rows[i].Cells[1].Value = list[i].MaNhanVien;
                    dataGridView1.Rows[i].Cells[2].Value = list[i].MaChucVu;
                    dataGridView1.Rows[i].Cells[3].Value = list[i].TuNgay.ToShortDateString();
                    dataGridView1.Rows[i].Cells[4].Value = list[i].DenNgay.ToShortDateString();
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmAddNhanVienChucVu().ShowDialog();
            LoadDS();
        }

        private void btnAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btnAdd.Size = new Size(40, 40);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.Size = new Size(30, 30);
        }

        private void btnUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            btnUpdate.Size = new Size(40, 40);
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.Size = new Size(30, 30);
        }

        private void btnDelete_MouseMove(object sender, MouseEventArgs e)
        {
            btnDelete.Size = new Size(40, 40);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.Size = new Size(30, 30);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != null)
            {
                List<NhanVienChucVu> list = new NhanVienChucVuBUL().GetListNhanVienChucVu();
                string ma = txtTimKiem.Text;
                list = list.Where(s => s.MaNhanVien.Trim() == ma).ToList();
                dataGridView1.Rows.Clear();
                if (list != null)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = (i + 1);
                        dataGridView1.Rows[i].Cells[1].Value = list[i].MaNhanVien;
                        dataGridView1.Rows[i].Cells[2].Value = list[i].MaChucVu;
                        dataGridView1.Rows[i].Cells[3].Value = list[i].TuNgay.ToShortDateString();
                        dataGridView1.Rows[i].Cells[4].Value = list[i].DenNgay.ToShortDateString();
                    }
                }
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTimKiem.Text != null)
                {
                    List<NhanVienChucVu> list = new NhanVienChucVuBUL().GetListNhanVienChucVu();
                    string ma = txtTimKiem.Text;
                    list = list.Where(s => s.MaNhanVien.Trim() == ma).ToList();
                    dataGridView1.Rows.Clear();
                    if (list != null)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells[0].Value = (i + 1);
                            dataGridView1.Rows[i].Cells[1].Value = list[i].MaNhanVien;
                            dataGridView1.Rows[i].Cells[2].Value = list[i].MaChucVu;
                            dataGridView1.Rows[i].Cells[3].Value = list[i].TuNgay.ToShortDateString();
                            dataGridView1.Rows[i].Cells[4].Value = list[i].DenNgay.ToShortDateString();
                        }
                    }
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Bạn có muốn xóa Chức vụ - Phòng ban?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(ds == DialogResult.OK)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value != null)
                {
                    NhanVienChucVu nv = new NhanVienChucVu()
                    {
                        MaNhanVien = dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                        MaChucVu = dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                        TuNgay = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()),
                        DenNgay = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString())
                    };
                    bool check = new NhanVienChucVuBUL().XoaNhanVienChucVu(nv);
                    if (check == true)
                    {
                        MessageBox.Show("Xóa chức vụ nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDS();
                    }
                    else
                    {
                        MessageBox.Show("Xóa chức vụ nhàn viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.CurrentRow.Cells[0] != null)
                {
                    NhanVienChucVu nv = new NhanVienChucVu()
                    {
                        MaNhanVien = dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                        MaChucVu = dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                        TuNgay = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()),
                        DenNgay = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString())
                    };
                    frmSuaNhanVienChucVu.nv = nv;
                    new frmSuaNhanVienChucVu().ShowDialog();

                    LoadDS();
                }
            }
            catch
            {

            }
        }
    }
}
