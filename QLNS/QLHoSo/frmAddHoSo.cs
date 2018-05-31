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

namespace QLNS.QLHoSo
{
    public partial class frmAddHoSo : Form
    {
        public frmAddHoSo()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtmaNV.Text != "" && txtHoDem.Text != "" && txtTen.Text != "" && txtSoDT.Text != "" && txtEmail.Text != "")
            {
                string sex = null;
                if (rdNam.Checked)
                {
                    sex = "Nam";
                }
                else if (rdNu.Checked)
                { 
                    sex = "Nữ";
                }
                else { sex = "Nam"; }
                HoSoDTO file = new HoSoDTO(txtmaNV.Text.ToString(), txtHoDem.Text.ToString(), txtTen.Text.ToString(), Convert.ToDateTime(dtpngaySinh.Value), sex, txtSoDT.Text.ToString(), txtEmail.Text.ToString(), Convert.ToDateTime(dtpngayTD.Value), cbxPhongBan.SelectedValue.ToString());
                bool check = new HoSoBUL().addHoSo(file);
                if (check == true)
                {
                    this.Close();
                    MessageBox.Show("Thêm Hồ Sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm hồ sơ thất bại :(", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                lblThongBao.Text = "Vui lòng điền hết các trường!";
            }
        }

        void SetCombobox()
        {
            List<PhongBanDTO> list = new HoSoBUL().getPhongBan();
            cbxPhongBan.DataSource = list;
            cbxPhongBan.DisplayMember = "tenPB";
            cbxPhongBan.ValueMember = "maPB";
            cbxPhongBan.SelectedIndex = 0;
        }
        private void frmAddHoSo_Load(object sender, EventArgs e)
        {
            //rdNam.AutoCheck;
            this.CenterToParent();
            rdNam.Checked = true;
            // them du lieu vao combobox
            SetCombobox();

        }
    }
}
