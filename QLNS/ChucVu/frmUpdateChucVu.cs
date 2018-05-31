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
namespace QLNS.ChucVu
{
    public partial class frmUpdateChucVu : Form
    {
        DTO.ChucVu cv = new DTO.ChucVu();
        public frmUpdateChucVu(DTO.ChucVu cv)
        {
            InitializeComponent();
            this.cv = cv;
        }
        ChucVuBUL CVBUL = new ChucVuBUL();
        private void btnHienThi_Click(object sender, EventArgs e)
        {
      
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text != "" && txtTenCV.Text!="" &&txtHSPC.Text!="")
            {
                lblthongbao.Text = "";
                double n = 0;
                if (double.TryParse(txtHSPC.Text, out n))
                {
                    lblthongbao.Text = "";
                 
                        CVBUL.UpdateBUL(txtMaCV.Text, txtTenCV.Text, Convert.ToDouble(txtHSPC.Text));
             
               
                }
                else
                {
                    lblthongbao.Text = "hspc phải là số";
                }
               

            }
            else
            {
                lblthongbao.Text = "Mã phòng ban không được để trống";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateChucVu_Load(object sender, EventArgs e)
        {
            txtMaCV.Text = cv.MaChucVu;
            txtTenCV.Text = cv.TenChucVu;
            txtHSPC.Text = cv.HeSoPhuCap.ToString();
        }
    }
}
