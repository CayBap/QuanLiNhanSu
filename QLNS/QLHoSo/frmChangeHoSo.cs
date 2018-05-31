using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.QLHoSo;
using DTO;
using BUL;

namespace QLNS.QLHoSo
{
    public partial class frmChangeHoSo : Form
    {
        public frmChangeHoSo()
        {
            InitializeComponent();
        }
        string id = ucQuanLiHoSo.maTimKiem;
            
         
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(id);
            if (txtmaNV.Text != "" && txtHoDem.Text != "" && txtTen.Text != "" && txtSoDT.Text != "" && txtEmail.Text != "")
            {
                string sex = null;
                if (rdNam.Checked)
                {
                    sex = "Nam";
                }
                else if (rdNu.Checked) { sex = "Nữ"; }
                else { sex = "Nam"; }
                HoSoDTO file = new HoSoDTO(txtmaNV.Text.ToString(), txtHoDem.Text.ToString(), txtTen.Text.ToString(), Convert.ToDateTime(dtpngaySinh.Value), sex, txtSoDT.Text.ToString(), txtEmail.Text.ToString(), Convert.ToDateTime(dtpngayTD.Value), getMaPB());
                // call fun change ho so
                bool check = new HoSoBUL().updateHoSo(file);
                if (check == true)
                {
                    MessageBox.Show("Sửa Hồ Sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa hồ sơ thất bại :(", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            else
            {
                lblThongBao.Text = "";
                lblThongBao.Text = "Vui lòng điền hết các trường!";
            }
        }
        // fun doi ten phong sang ma tu combobox
        public string getMaPB()
        {
            string ma = null;
            HoSoBUL file = new HoSoBUL();
            List<PhongBanDTO> list = file.getPhongBan();
            var item = cbxPhongBan.GetItemText(this.cbxPhongBan.SelectedItem);
            for (int i = 0; i < list.Count; i++)
            {
                if (item.ToString() == list[i].tenPB.ToString())
                {
                    ma = list[i].maPB.ToString();
                }
            }
            return ma;
        }
        private void frmChangeHoSo_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            HoSoBUL file = new HoSoBUL();
            List<PhongBanDTO> list = file.getPhongBan();
          
          
            string id = ucQuanLiHoSo.maTimKiem;

            //MessageBox.Show(id);
            HoSoBUL a = new HoSoBUL();
            HoSoDTO hs = a.getDataChange(id);
            if (hs != null)
            {
                txtmaNV.Text = id; txtmaNV.Enabled = false;
                txtHoDem.Text = hs.hoDem.ToString();
                txtTen.Text = hs.Ten.ToString();
                dtpngaySinh.Value = Convert.ToDateTime(hs.ngaySinh);
                if (hs.gioiTinh.ToString() == "Nam") { rdNam.Checked = true; rdNu.Checked = false; }
                else if (hs.gioiTinh.ToString() == "Nữ") { rdNu.Checked = true; rdNam.Checked = false; }
                txtSoDT.Text = hs.soDT.ToString();
                txtEmail.Text = hs.Email.ToString();
                dtpngayTD.Value = Convert.ToDateTime(hs.ngayTD);
            }
            cbxPhongBan.DataSource = list;
            cbxPhongBan.DisplayMember = "tenPB";
            cbxPhongBan.ValueMember = "maPB";
            cbxPhongBan.SelectedValue = hs.maPB;
            ////txtmaPB.Items.Add(hs.maPB.ToString());

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
