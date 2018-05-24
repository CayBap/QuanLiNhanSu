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
using QLNS.Helper;
namespace QLNS.QLNguoiDung
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRePass.Text!=""&&txtUserName.Text!=""&&txtPass.Text!=""&&txtName.Text!=""&&txtLastName.Text!="")
            {
                if (txtPass.Text == txtRePass.Text)
                {
                    User user = new User()
                    {
                        UserName = txtUserName.Text,
                        FirstName = txtName.Text,
                        LastName = txtLastName.Text,
                        Password = new Bcrypt().HashPass(txtPass.Text),
                        Role = rdoAdmin.Checked == true ? "admin" : "user",
                        dateTime = dtpNgaySinh.Value
                    };
                    bool check = new UserBUL().AddUser(user);
                    if (check == true)
                    {
                        MessageBox.Show("Thông báo", "Thêm người dùng thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thông báo", "Thêm người dùng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
                else
                {
                    lblThongBao.Text = "Mật khẩu không trùng";
                    txtPass.Text = "";
                    txtRePass.Text = "";
                }
            }
            else
            {
                lblThongBao.Text = "Một trường đang trống";
            }
        }
    }
}
