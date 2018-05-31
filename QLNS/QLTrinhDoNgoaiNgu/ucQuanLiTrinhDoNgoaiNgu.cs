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
using QLNS.QLTrinhDoNgoaiNgu;

namespace QLNS
{
    public partial class ucQuanLiTrinhDoNgoaiNgu : UserControl
    {
        public ucQuanLiTrinhDoNgoaiNgu()
        {
            InitializeComponent();
        }

        public static string maTimKiem = "";
        public static string NgoaiNgu = "";

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
            TrinhDoNgoaiNguBUL file = new TrinhDoNgoaiNguBUL();
            //MessageBox.Show(file.DSTDCM().Rows.ToString());
            lbtb.Text = "";
            dgvNN.Rows.Clear();
            //MessageBox.Show(file.DSTDNN().Rows[0][0].ToString());
            for (int i = 0; i < file.DSTDNN().Rows.Count; i++)
            {
                //MessageBox.Show(file.DSTDNN().Rows[i][0].ToString());
                dgvNN.Rows.Add();
                dgvNN.Rows[i].Cells[0].Value = file.DSTDNN().Rows[i][0];
                dgvNN.Rows[i].Cells[1].Value = file.DSTDNN().Rows[i][1];
                dgvNN.Rows[i].Cells[2].Value = file.DSTDNN().Rows[i][2];
                dgvNN.Rows[i].Cells[3].Value = file.DSTDNN().Rows[i][3];
                dgvNN.Rows[i].Cells[4].Value = file.DSTDNN().Rows[i][4];

            }
        }
        private void ucQuanLiTrinhDoNgoaiNgu_Load(object sender, EventArgs e)
        {
            loadData();
            txtSeach.Text = maTimKiem;
            SetData();
        }
        public string getMaNhanVien()
        {
            string a = "";
            if (dgvNN.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dgvNN.SelectedRows[0];
                a = row.Cells["Column1"].Value.ToString();
            }
            return a;

        }
        public string getNgoaiNgu()
        {
            string a = "";
            if (dgvNN.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dgvNN.SelectedRows[0];
                a = row.Cells["Column4"].Value.ToString();
            }
            return a;

        }
        void SetData()
        {
            if (txtSeach.Text != "")
            {
                //List<HoSoDTO> list = new List<HoSoDTO>();
                //list = list.Where(s => s.maNV == txtSeach.Text).ToList();
                maTimKiem = txtSeach.Text.ToString();
                TrinhDoNgoaiNguBUL file = new TrinhDoNgoaiNguBUL();

                dgvNN.Rows.Clear();
                DataTable dt = file.searchTDNN(maTimKiem);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //MessageBox.Show(file.DSHoSoBUL().Rows[i][0].ToString());

                    dgvNN.Rows.Add();
                    dgvNN.Rows[i].Cells[0].Value = dt.Rows[i][0];
                    dgvNN.Rows[i].Cells[1].Value = dt.Rows[i][1];
                    dgvNN.Rows[i].Cells[2].Value = dt.Rows[i][2];
                    dgvNN.Rows[i].Cells[3].Value = dt.Rows[i][3];
                    dgvNN.Rows[i].Cells[4].Value = dt.Rows[i][4];

                }
            }
            else
            {
                lbtb.Text = "";
                lbtb.Text = "Vui lòng điền mã Nhân Viên cần tìm.";
                loadData();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSeach.Text != "")
            {
                //List<HoSoDTO> list = new List<HoSoDTO>();
                //list = list.Where(s => s.maNV == txtSeach.Text).ToList();
                maTimKiem = txtSeach.Text.ToString();
                TrinhDoNgoaiNguBUL file = new TrinhDoNgoaiNguBUL();

                dgvNN.Rows.Clear();
                DataTable dt = file.searchTDNN(maTimKiem);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //MessageBox.Show(file.DSHoSoBUL().Rows[i][0].ToString());

                    dgvNN.Rows.Add();
                    dgvNN.Rows[i].Cells[0].Value = dt.Rows[i][0];
                    dgvNN.Rows[i].Cells[1].Value = dt.Rows[i][1];
                    dgvNN.Rows[i].Cells[2].Value = dt.Rows[i][2];
                    dgvNN.Rows[i].Cells[3].Value = dt.Rows[i][3];
                    dgvNN.Rows[i].Cells[4].Value = dt.Rows[i][4];
                    
                }
            }
            else
            {
                lbtb.Text = "";
                lbtb.Text = "Vui lòng điền mã Nhân Viên cần tìm.";
                loadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmAddTDNN().ShowDialog();
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             maTimKiem = getMaNhanVien();
            NgoaiNgu = getNgoaiNgu();
             if (maTimKiem!="")
             {
                 new frmChangeTDNN().ShowDialog();
                 loadData();
                 
             }

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (getMaNhanVien()!="")
            {
                DialogResult ds = MessageBox.Show("Bạn có muốn xóa trình độ  ngoại ngữ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
              if(ds == DialogResult.Yes)
                {
                    bool check = new TrinhDoNgoaiNguBUL().deleteTDNN(getMaNhanVien(), getNgoaiNgu());
                    if (check)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
                
           
        }
    }
}
