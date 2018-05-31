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

namespace QLNS.QLTrinhDoNgoaiNgu
{
    public partial class frmAddTDNN : Form
    {
        public frmAddTDNN()
        {
            InitializeComponent();
        }

        private void frmAddTDNN_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            cbTrinhDo.SelectedItem = 0;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtmaNV.Text!="" )
            {
                TrinhDoNgoaiNgu el = new TrinhDoNgoaiNgu(txtmaNV.Text.ToString(),cbxNgoaiNgu.SelectedItem.ToString(),cbTrinhDo.SelectedItem.ToString());
                bool check = new TrinhDoNgoaiNguBUL().addTDCM(el);
                if (check == true)
                {
                   
                    this.Close();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại :(", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lblThongBao.Text = "Vui lòng điền đầy đủ các trường!";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
