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
namespace QLNS.QLPhongBan
{
    public partial class frmAddPB : Form
    {
        public frmAddPB()
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
            if (txtMaPB.Text != "" && txtTenPB.Text != "")
            {
                lblthongbao.Text = "";
             
                    PBBUL.AddBUL(txtMaPB.Text, txtTenPB.Text, dtpNgayTL.Value);
        
           
            }
            else
            {
                lblthongbao.Text = "Không được để trống";
            }
        }
    }
}
