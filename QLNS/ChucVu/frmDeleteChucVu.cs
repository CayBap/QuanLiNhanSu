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
namespace QLNS.ChucVu
{
    public partial class frmDeleteChucVu : Form
    {
        public frmDeleteChucVu()
        {
            InitializeComponent();
        }

        ChucVuBUL CVBUL = new ChucVuBUL();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text != "")
            {
                DTO.ChucVu cv= CVBUL.GetCV(txtMaCV.Text);
                lblthongbao.Text = "";
                if (cv != null)
                {
                    txtTenCV.Text = cv.TenChucVu;
                    txtHSPC.Text = cv.HeSoPhuCap.ToString();
                    DialogResult dl = MessageBox.Show("bạn có chắc chắn muốn xóa", "hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dl == DialogResult.Yes)
                    {
                        CVBUL.DeleteBUL(txtMaCV.Text);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
