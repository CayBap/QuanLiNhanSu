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
namespace QLNS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim()!=""&&txtPassword.Text.Trim()!="")
            {
                User user = new UserBUL().GetUserLogin(txtUserName.Text, txtPassword.Text);
                if (user != null)
                {
                    this.Hide();
                    frmMain.user = user;
                    new frmMain().Show();
                }
                else
                {
                    lblThongBao.Text = "Tài khoản hoặc mật khẩu không chính xác";
                }
            }
            else
            {
                lblThongBao.Text = "Tài khoản hoặc mật khẩu rỗng.";
            }
        }

        private void lblThongBao_Click(object sender, EventArgs e)
        {

        }

        private void chkForgetPass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
