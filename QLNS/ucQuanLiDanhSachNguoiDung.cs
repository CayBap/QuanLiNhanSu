using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;
using QLNS.QLNguoiDung;
namespace QLNS
{
    public partial class ucQuanLiDanhSachNguoiDung : UserControl
    {
        public ucQuanLiDanhSachNguoiDung()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btnAdd.Size = new Size(40, 40);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.Size = new Size(30, 30);
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.Size = new Size(30, 30);
        }

        private void btnUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            btnUpdate.Size = new Size(40, 40);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.Size = new Size(30, 30);
        }

        private void btnDelete_MouseMove(object sender, MouseEventArgs e)
        {
            btnDelete.Size = new Size(40, 40);
        }

        private void ucQuanLiDanhSachNguoiDung_Load(object sender, EventArgs e)
        {
            LoadDS();
        }
        void LoadDS()
        {
            List < User > list = new UserBUL().GetUsers();
            if (list != null)
            {
                dtgDSUser.Rows.Clear();
                for(int i = 0; i < list.Count; i++)
                {
                    dtgDSUser.Rows.Add();
                    dtgDSUser.Rows[i].Cells[0].Value = (i + 1);
                    dtgDSUser.Rows[i].Cells[1].Value = list[i].LastName;
                    dtgDSUser.Rows[i].Cells[2].Value = list[i].FirstName;
                    dtgDSUser.Rows[i].Cells[3].Value = list[i].UserName;
                    dtgDSUser.Rows[i].Cells[4].Value = list[i].dateTime.ToShortDateString();
                    dtgDSUser.Rows[i].Cells[5].Value = list[i].Role=="admin"?"Quản trị":"Người dùng";
                    dtgDSUser.Rows[i].Cells[6].Value = list[i].ID;
                    if (list[i].Role == "admin")
                    {
                        dtgDSUser.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmAddUser().ShowDialog();
            LoadDS();
        }

        private void dtgDSUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
