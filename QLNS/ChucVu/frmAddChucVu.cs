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
    public partial class frmAddChucVu : Form
    {
        public frmAddChucVu()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ChucVuBUL CVBUL = new ChucVuBUL();
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtMaCV.Text != "" && txtTenCV.Text != ""&&txtHSPC.Text!="")
            {
                lblthongbao.Text = "";
                double n = 0;
                if (double.TryParse(txtHSPC.Text,out n))
                {
                    lblthongbao.Text = "";
                    CVBUL.AddBUL(txtMaCV.Text, txtTenCV.Text, Convert.ToDouble(txtHSPC.Text));
                }
                else
                {
                    lblthongbao.Text = "hspc phải là số";
                }
            }
            else
            {
                lblthongbao.Text = "Không được để trống";
            }
        }
    }
}
