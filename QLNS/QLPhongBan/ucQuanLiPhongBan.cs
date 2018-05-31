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
using QLNS.QLPhongBan;

namespace QLNS
{
    public partial class ucQuanLiPhongBan : UserControl
    {
        public ucQuanLiPhongBan()
        {
            InitializeComponent();
        }
        PhongBanBUL PBBUL = new PhongBanBUL();
        private void ucQuanLiPhongBan_Load(object sender, EventArgs e)
        {
            LoadDs();
        }

        private void LoadDs()
        {
            dgvQuanLiPhongBan.DataSource = PBBUL.GetDSBUL();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmAddPB().ShowDialog();
            LoadDs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(dgvQuanLiPhongBan.CurrentRow.Cells[0].Value.ToString());
            PhongBan pb = PBBUL.GetPB(dgvQuanLiPhongBan.CurrentRow.Cells[0].Value.ToString());
           // MessageBox.Show("ma" + pb.MaPhongBan);
            lblthongbao.Text = "";
            if (pb != null)
            {

                DialogResult dl = MessageBox.Show("bạn có chắc chắn muốn xóa phòng ban \n" +
                    " mã: "
                    + pb.MaPhongBan.Trim() + "\t Tên:" + pb.TenPhongBan + "\t ngày:" + pb.NgayThanhLap.ToShortDateString()
                        , "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl == DialogResult.Yes)
                {
                    PBBUL.DeleteBUL(pb.MaPhongBan);
                }
            }
            else
            {
                MessageBox.Show("mã phòng ban không tồn tại");
            }
            LoadDs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PhongBan pb = PBBUL.GetPB(dgvQuanLiPhongBan.CurrentRow.Cells[0].Value.ToString());
            new frmUpdatePb(pb).ShowDialog();
            btnsearch_Click(sender, e);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtma.Text !="")
            {
                List<PhongBan> l = new List<PhongBan>();
                l.Add(PBBUL.GetPB(txtma.Text));

                dgvQuanLiPhongBan.DataSource = l;
            }
            else
            {
                LoadDs();
            }
        }
    }
}
