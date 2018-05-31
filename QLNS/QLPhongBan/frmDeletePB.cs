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
namespace QLNS.QLPhongBan
{
    public partial class frmDeletePB : Form
    {
        public frmDeletePB()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        PhongBanBUL PBBUL = new PhongBanBUL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text != "")
            {
                PhongBan pb = PBBUL.GetPB(txtMaPB.Text);
                lblthongbao.Text = "";
                if (pb != null)
                {
                    txtTenPB.Text = pb.TenPhongBan;
                    dtpNgayTL.Value = pb.NgayThanhLap;
                    DialogResult dl = MessageBox.Show("bạn có chắc chắn muốn xóa", "hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dl == DialogResult.Yes)
                    {
                        PBBUL.DeleteBUL(txtMaPB.Text);
                    }
                }
                else
                {
                    MessageBox.Show("mã phòng ban không tồn tại");
                }


            }
            else
            {
                lblthongbao.Text = "mã Không được để trống";
            }
        }
    }
}
