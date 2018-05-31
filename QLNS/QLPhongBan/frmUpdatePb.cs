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
namespace QLNS.QLPhongBan
{
    public partial class frmUpdatePb : Form
    {
        PhongBan pb = new PhongBan();
        public frmUpdatePb(PhongBan pb)
        {
            InitializeComponent();
            this.pb = pb;
        }
        PhongBanBUL PBBUL = new PhongBanBUL();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text != "")
            {
               
           
                        PBBUL.UpdateBUL(txtMaPB.Text,txtTenPB.Text,dtpNgayTL.Value);
       
          

            } else
            {
                lblthongbao.Text = "Mã phòng ban không được để trống";
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
          
        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdatePb_Load(object sender, EventArgs e)
        {
            txtMaPB.Text = pb.MaPhongBan;
            txtTenPB.Text = pb.TenPhongBan;
            dtpNgayTL.Value = pb.NgayThanhLap;
        }
    }
}
