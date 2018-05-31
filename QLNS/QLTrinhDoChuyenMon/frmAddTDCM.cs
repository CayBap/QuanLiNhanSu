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

namespace QLNS.QLTrinhDoChuyenMon
{
    public partial class frmAddTDCM : Form
    {
        public frmAddTDCM()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtmaNV.Text != "" || txtTruongDaoTao.Text != "")
            {
                TrinhDoChuyenMonDTO td = new TrinhDoChuyenMonDTO(txtmaNV.Text.ToString(), cbNganh.SelectedItem.ToString(), cbTrinhDo.SelectedItem.ToString(), cbLoaiHinhDaoTao.SelectedItem.ToString(), txtTruongDaoTao.Text.ToString());
                //MessageBox.Show(td.Nganh.ToString());
                bool check = new TrinhDoChuyenMonBUL().addTDCM(td);
                if (check == true)
                {
                    this.Close();
                    MessageBox.Show("Thêm Trình độ chuyên môn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm Trình độ chuyên môn thất bại :(", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lblThongBao.Text = "Vui lòng điền đầy đủ các trường!";
            }
            //MessageBox.Show(cbTrinhDo.SelectedItem.ToString());
            
        }
        //public string getNganh() {
        //    string a = "";
        //    foreach (object item in cbNganh.CheckedItems)
        //    {
        //        a += item.ToString()+" ";
        //    }
        //    return a;
        //}
        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmAddTDCM_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            cbLoaiHinhDaoTao.SelectedIndex = 0;
            cbTrinhDo.SelectedIndex = 0;
            cbNganh.SelectedIndex = 0;
        }
    }
}
