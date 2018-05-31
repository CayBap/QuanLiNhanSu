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
using QLNS.QLQuatrinhCongTac;

namespace QLNS
{
    public partial class ucQuanLiCongTac : UserControl
    {
        public ucQuanLiCongTac()
        {
            InitializeComponent();
        }
        public static string maTimKiem;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new add().ShowDialog();
            LoadDS();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblma_Click(object sender, EventArgs e)
        {

        }

        private void dgvQLCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucQuanLiCongTac_Load(object sender, EventArgs e)
        {
            LoadDS();
            if (txtma.Text != null)
            {
                txtma.Text = maTimKiem;
                SetData();
            }
        }
        QuaTrinhCongTacBUL qtct = new QuaTrinhCongTacBUL();
        private void LoadDS()
        {
            DataTable dttb = qtct.DSQuaTrinhCongTacBUL();
            dgvQLCT.Rows.Clear();
            for (int i = 0; i <dttb.Rows.Count; i++)
            {
                dgvQLCT.Rows.Add();
                dgvQLCT.Rows[i].Cells[0].Value = dttb.Rows[i][0].ToString();
                dgvQLCT.Rows[i].Cells[1].Value = dttb.Rows[i][1].ToString();
                dgvQLCT.Rows[i].Cells[2].Value = Convert.ToDateTime(dttb.Rows[i][2].ToString()).ToShortDateString();
                dgvQLCT.Rows[i].Cells[3].Value = Convert.ToDateTime(dttb.Rows[i][3].ToString()).ToShortDateString();
                dgvQLCT.Rows[i].Cells[4].Value = dttb.Rows[i][4].ToString();
                dgvQLCT.Rows[i].Cells[5].Value = dttb.Rows[i][5].ToString();
            }
        }
        void SetData()
        {
            dgvQLCT.Rows.Clear();
            if (txtma.Text != "")
            {
                lblthongbao.Text = "";
                DataTable dttb = qtct.searchBUL(txtma.Text);

                for (int i = 0; i < dttb.Rows.Count; i++)
                {
                    dgvQLCT.Rows.Add();
                    dgvQLCT.Rows[i].Cells[0].Value = dttb.Rows[i][0].ToString();
                    dgvQLCT.Rows[i].Cells[1].Value = dttb.Rows[i][1].ToString();
                    dgvQLCT.Rows[i].Cells[2].Value = Convert.ToDateTime(dttb.Rows[i][2].ToString()).ToShortDateString();
                    dgvQLCT.Rows[i].Cells[3].Value = Convert.ToDateTime(dttb.Rows[i][3].ToString()).ToShortDateString();
                    dgvQLCT.Rows[i].Cells[4].Value = dttb.Rows[i][4].ToString();
                    dgvQLCT.Rows[i].Cells[5].Value = dttb.Rows[i][5].ToString();
                }
            }
            else
            {
                LoadDS();
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            dgvQLCT.Rows.Clear();
            if (txtma.Text != "")
            {
                lblthongbao.Text = "";
                DataTable dttb = qtct.searchBUL(txtma.Text);
                
                for (int i = 0; i < dttb.Rows.Count; i++)
                {
                    dgvQLCT.Rows.Add();
                    dgvQLCT.Rows[i].Cells[0].Value = dttb.Rows[i][0].ToString();
                    dgvQLCT.Rows[i].Cells[1].Value = dttb.Rows[i][1].ToString();
                    dgvQLCT.Rows[i].Cells[2].Value = Convert.ToDateTime(dttb.Rows[i][2].ToString()).ToShortDateString();
                    dgvQLCT.Rows[i].Cells[3].Value = Convert.ToDateTime(dttb.Rows[i][3].ToString()).ToShortDateString();
                    dgvQLCT.Rows[i].Cells[4].Value = dttb.Rows[i][4].ToString();
                    dgvQLCT.Rows[i].Cells[5].Value = dttb.Rows[i][5].ToString();
                }
            }
            else
            {
                LoadDS();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            QuaTrinhCongTac QTCTDTO = qtct.searchMaAndDayBUL(dgvQLCT.CurrentRow.Cells[0].Value.ToString(),Convert.ToDateTime(dgvQLCT.CurrentRow.Cells[2].Value));
           
                DialogResult dlr = MessageBox.Show("bạn chắc chắn muốn xóa\n "
                    + "Mã: " + QTCTDTO.MaNV +"\t Từ ngày: " + QTCTDTO.TuNgay.ToShortDateString() + "\t Đến Ngày: "
                    + QTCTDTO.DenNgay.ToShortDateString() + " \t Nơi Công Tác: " + QTCTDTO.NoiCongTac + "\t Chức Vụ: " + QTCTDTO.ChucVu

                    , "Thông Báo", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    qtct.deleteBUL(QTCTDTO.MaNV,QTCTDTO.TuNgay);
                }
                else
                { }
          
            LoadDS();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            QuaTrinhCongTac QTCTDTO = qtct.searchMaAndDayBUL(dgvQLCT.CurrentRow.Cells[0].Value.ToString(), Convert.ToDateTime(dgvQLCT.CurrentRow.Cells[2].Value));
            new frmupdate(QTCTDTO).ShowDialog();
            btnsearch_Click(sender, e);
        }

        private void lblthongbao_Click(object sender, EventArgs e)
        {

        }

        private void lblten_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btnAdd.Size = new Size(40, 40);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.Size = new Size(30, 30);
        }

        private void btnUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            btnUpdate.Size = new Size(40, 40);
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.Size = new Size(30, 30);
        }

        private void btnDelete_MouseMove(object sender, MouseEventArgs e)
        {
            btnDelete.Size = new Size(40, 40);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.Size = new Size(30, 30);
        }
    }
}
