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
using QLNS.QLTrinhDoChuyenMon;

namespace QLNS
{
    public partial class ucQuanLiTrinhDoChuyenMon : UserControl
    {
        public ucQuanLiTrinhDoChuyenMon()
        {
            InitializeComponent();
        
        }
        public static string maTimKiem = null;
        public static string Nganh = "";
       

        private void btnAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btnAdd.Size = new Size(40, 40);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.Size = new Size(30, 30);
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.Size = new Size(30, 30);
        }

        private void btnUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            btnUpdate.Size = new Size(40, 40);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.Size = new Size(30, 30);
        }

        private void btnDelete_MouseMove(object sender, MouseEventArgs e)
        {
            btnDelete.Size = new Size(40, 40);
        }
        public void loadData() {
            TrinhDoChuyenMonBUL file = new TrinhDoChuyenMonBUL();
            //MessageBox.Show(file.DSTDCM().Rows.ToString());
            dgvTrinhdocm.Rows.Clear();
            for (int i = 0; i < file.DSTDCM().Rows.Count; i++)
            {
                //MessageBox.Show(file.DSHoSoBUL().Rows[i][0].ToString());
                dgvTrinhdocm.Rows.Add();
                dgvTrinhdocm.Rows[i].Cells[0].Value = file.DSTDCM().Rows[i][0];
                dgvTrinhdocm.Rows[i].Cells[1].Value = file.DSTDCM().Rows[i][1];
                dgvTrinhdocm.Rows[i].Cells[2].Value = file.DSTDCM().Rows[i][2];
                dgvTrinhdocm.Rows[i].Cells[3].Value = file.DSTDCM().Rows[i][3];
                dgvTrinhdocm.Rows[i].Cells[4].Value = file.DSTDCM().Rows[i][4];
                dgvTrinhdocm.Rows[i].Cells[5].Value = file.DSTDCM().Rows[i][5];
                dgvTrinhdocm.Rows[i].Cells[6].Value = file.DSTDCM().Rows[i][6];
               
            }
        }
        private void ucQuanLiTrinhDoChuyenMon_Load(object sender, EventArgs e)
        {
            loadData();
            txtSeach.Text = maTimKiem;
            if (txtSeach.Text != null)
            {
                txtSeach.Text = maTimKiem;
                SetData();
                maTimKiem = null;
            }
        }
        public string getMaNhanVien()
        {
            string a = "";
            if (dgvTrinhdocm.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dgvTrinhdocm.SelectedRows[0];
                a = row.Cells["Column1"].Value.ToString();
            }
            return a;

        }

        public string getNganh()
        {
            string a = "";
            if (dgvTrinhdocm.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dgvTrinhdocm.SelectedRows[0];
                a = row.Cells["Column4"].Value.ToString();
            }
            return a;

        }
        void SetData()
        {
            if (txtSeach.Text != "")
            {
                string ma = txtSeach.Text.ToString();
                TrinhDoChuyenMonBUL file = new TrinhDoChuyenMonBUL();
                maTimKiem = txtSeach.Text.ToString();
                dgvTrinhdocm.Rows.Clear();
                DataTable dt = file.findTDCM(ma);
                //MessageBox.Show(dt.Rows[0][0].ToString());

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //MessageBox.Show(file.DSHoSoBUL().Rows[i][0].ToString());
                    dgvTrinhdocm.Rows.Add();
                    dgvTrinhdocm.Rows[i].Cells[0].Value = dt.Rows[i][0];
                    dgvTrinhdocm.Rows[i].Cells[1].Value = dt.Rows[i][1];
                    dgvTrinhdocm.Rows[i].Cells[2].Value = dt.Rows[i][2];
                    dgvTrinhdocm.Rows[i].Cells[3].Value = dt.Rows[i][3];
                    dgvTrinhdocm.Rows[i].Cells[4].Value = dt.Rows[i][4];
                    dgvTrinhdocm.Rows[i].Cells[5].Value = dt.Rows[i][5];
                    dgvTrinhdocm.Rows[i].Cells[6].Value = dt.Rows[i][6];


                }
            }
            else
            {
                lbtb.Text = "Vui lòng điền mã cần tìm.";
                loadData();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSeach.Text!="")
            {
                string ma = txtSeach.Text.ToString();
            TrinhDoChuyenMonBUL file = new TrinhDoChuyenMonBUL();
            maTimKiem = txtSeach.Text.ToString();
            dgvTrinhdocm.Rows.Clear();
            DataTable dt = file.findTDCM(ma);
            //MessageBox.Show(dt.Rows[0][0].ToString());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //MessageBox.Show(file.DSHoSoBUL().Rows[i][0].ToString());
                dgvTrinhdocm.Rows.Add();
                dgvTrinhdocm.Rows[i].Cells[0].Value = dt.Rows[i][0];
                dgvTrinhdocm.Rows[i].Cells[1].Value = dt.Rows[i][1];
                dgvTrinhdocm.Rows[i].Cells[2].Value = dt.Rows[i][2];
                dgvTrinhdocm.Rows[i].Cells[3].Value = dt.Rows[i][3];
                dgvTrinhdocm.Rows[i].Cells[4].Value = dt.Rows[i][4];
                dgvTrinhdocm.Rows[i].Cells[5].Value = dt.Rows[i][5];
                dgvTrinhdocm.Rows[i].Cells[6].Value = dt.Rows[i][6];


            }
            }
            else
            {
                lbtb.Text = "Vui lòng điền mã cần tìm.";
                loadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmAddTDCM().ShowDialog();
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
                maTimKiem = getMaNhanVien().ToString();
                Nganh = getNganh();
                
                if (maTimKiem!="")
                {
                    DialogResult cond = MessageBox.Show("Bạn có muốn sửa Hồ Sơ này không?", "Thông báo", MessageBoxButtons.YesNo);
                    if (cond == DialogResult.Yes)
                    {
                        new frmChangeTDCM().ShowDialog();
                        loadData();
                    }
                }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
                
                DialogResult cond = MessageBox.Show("Bạn có chắc chắn xóa Nhân Viên này không?", "Thông báo!", MessageBoxButtons.YesNo);
                if (cond == DialogResult.Yes)
                {
                    bool check = new TrinhDoChuyenMonBUL().deleteTCDM(getMaNhanVien(),getNganh());
                    if (check == true)
                    {
                        loadData();
                        MessageBox.Show("Xóa Nhân Viên Thành Công", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa Nhân Viên Thất bại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }

            

        }
    }
}
