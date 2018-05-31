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
namespace QLNS
{
    public partial class ucQuanLiThongTinCaNhan : UserControl
    {
        public ucQuanLiThongTinCaNhan()
        {
            InitializeComponent();
        }
        public static User user = null;
        private void ucQuanLiThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadMyProfile();
        }
        void LoadMyProfile()
        {
            if (user != null)
            {
                txtID.Enabled = false;
                txtUserName.Enabled = false;
                txtID.Text = user.ID.ToString();
                txtFirstName.Text = user.FirstName.ToString();
                txtLastName.Text = user.LastName;
                txtUserName.Text = user.UserName;
                dtpBirthDate.Value = user.dateTime;
                if (user.Role == "user")
                {
                    radioButton1.Checked = false;
                }
                if (user.Role.Trim() == "admin")
                {
                    radioButton2.Checked = true;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Role = "";
            if (radioButton1.Checked == true)
            {
                Role = "user";
            }
            if(radioButton2.Checked == true)
            {
                Role = "admin";
            }
             User u =  new UserBUL().UpdateUser(txtID.Text,txtFirstName.Text, txtLastName.Text, dtpBirthDate.Value, Role);
            if (u != null)
            {
                frmMain.user = u;
                user = u;
                LoadMyProfile();
                lblThongBao.Text = "Cập nhập thông tin thành công .";
            }
            else
            {
                lblThongBao.Text = "Cập  nhập thông tin thất bại.";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
