using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
using QLNS.ChucVu;
namespace QLNS
{
    public partial class ucQLChucVu : UserControl
    {
        public ucQLChucVu()
        {
            InitializeComponent();
        }

        ChucVuBUL CVBUL = new ChucVuBUL();
        private void loadDS()
        {
            dgvDSChucVu.DataSource = CVBUL.GetDSBUL();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmAddChucVu().ShowDialog();
            loadDS();
        }
        private void ucQLChucVu_Load(object sender, EventArgs e)
        {
            loadDS();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DTO.ChucVu cv = CVBUL.GetCV(dgvDSChucVu.CurrentRow.Cells[0].Value.ToString());
            new frmUpdateChucVu(cv).ShowDialog();
            btnsearch_Click(sender, e);


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
         
                DTO.ChucVu cv = CVBUL.GetCV(dgvDSChucVu.CurrentRow.Cells[0].Value.ToString());
                lblthongbao.Text = "";
                if (cv != null)
                {
             
                    DialogResult dl = MessageBox.Show("bạn có chắc chắn muốn xóa \n"
                        +"Mã chức vụ: "+cv.MaChucVu.Trim()+ "\tTên: "+cv.TenChucVu+"\tHSPC: "+ cv.HeSoPhuCap, "hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dl == DialogResult.Yes)
                    {
                        CVBUL.DeleteBUL(cv.MaChucVu);
                    }
                }
                else
                {
                    MessageBox.Show("mã phòng ban không tồn tại");
                }

            loadDS();
        }
        
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if(txtma.Text!="")
            {
                List<DTO.ChucVu> l = new List<DTO.ChucVu>();
                l.Add(CVBUL.GetCV(txtma.Text));
                dgvDSChucVu.DataSource = l;
            }
            else
            {
                loadDS();
            }
        }
    }
}
