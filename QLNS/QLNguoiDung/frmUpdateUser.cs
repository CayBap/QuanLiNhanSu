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
namespace QLNS.QLNguoiDung
{
    public partial class frmUpdateUser : Form
    {
        public frmUpdateUser()
        {
            InitializeComponent();
        }
        public static User user = null;
        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            LoadUser();

        }
        void LoadUser()
        {
            if (user != null)
            {
                txtUserName.Text = user.UserName;
                txtUserName.Enabled = false;
                txtName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                dtpNgaySinh.Value = user.dateTime;
                if (user.Role == "admin")
                {
                    rdoAdmin.Checked = true;
                }
                if (user.Role == "user")
                {
                    rdoUser.Checked = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            user.LastName = txtLastName.Text;
            user.FirstName = txtName.Text;
            user.dateTime = dtpNgaySinh.Value;
            if (rdoUser.Checked == true)
            {
                user.Role = "user";
            }
            if (rdoAdmin.Checked == true)
            {
                user.Role = "admin";
            }
           bool check =  new UserBUL().UpdateUser(user);
            if (check == true)
            {
                MessageBox.Show("Cập nhập thông tin người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin người dùng thất bại!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
