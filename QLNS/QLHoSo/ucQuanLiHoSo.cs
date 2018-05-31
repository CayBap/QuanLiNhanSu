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
using QLNS.QLHoSo;
namespace QLNS
{
    public partial class ucQuanLiHoSo : UserControl
    {
        public ucQuanLiHoSo()
        {
            InitializeComponent();
        }

        public static string maTimKiem = "";
        private void ucQuanLiHoSo_Load(object sender, EventArgs e)
        {
            loadData();
            if (dgvHoSo.CurrentRow.Cells[0].Value != null)
            {
                frmMain.MaHoSo = dgvHoSo.CurrentRow.Cells[0].Value.ToString();
            }
            
        }

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


        private void button1_Click(object sender, EventArgs e)
        {

        }
       
        public void loadData()
        {
            lbtb.Text = "";
            HoSoBUL file = new HoSoBUL();
            //MessageBox.Show(file.DSHoSoBUL().Rows.Count.ToString());
            //dgvHoSo.DataSource = file.DSHoSoBUL().;
            //dgvHoSo.Columns[0].ValueType=file.DSHoSoBUL().Columns[0];
            dgvHoSo.Rows.Clear();
            for (int i = 0; i < file.DSHoSoBUL().Rows.Count; i++)
            {
                dgvHoSo.Rows.Add();
                if (i == 0)
                {
                    dgvHoSo.Rows[0].Selected = true;
                }
                //MessageBox.Show(file.DSHoSoBUL().Rows[i][0].ToString());
                
                 dgvHoSo.Rows[i].Cells[0].Value = file.DSHoSoBUL().Rows[i][0];
                 dgvHoSo.Rows[i].Cells[1].Value = file.DSHoSoBUL().Rows[i][1];
                 dgvHoSo.Rows[i].Cells[2].Value = file.DSHoSoBUL().Rows[i][2];
                 dgvHoSo.Rows[i].Cells[3].Value = DateTime.Parse(file.DSHoSoBUL().Rows[i][3].ToString()).ToShortDateString();
                 dgvHoSo.Rows[i].Cells[4].Value = file.DSHoSoBUL().Rows[i][4];
                 dgvHoSo.Rows[i].Cells[5].Value = file.DSHoSoBUL().Rows[i][5];
                 dgvHoSo.Rows[i].Cells[6].Value = file.DSHoSoBUL().Rows[i][6];
                 dgvHoSo.Rows[i].Cells[7].Value = DateTime.Parse(file.DSHoSoBUL().Rows[i][7].ToString()).ToShortDateString();
                 dgvHoSo.Rows[i].Cells[8].Value = file.DSHoSoBUL().Rows[i][8];
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            new frmAddHoSo().ShowDialog();
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //HoSoBUL h = new HoSoBUL();
            ////h.getDataChange("M01");
            //MessageBox.Show(h.getDataChange("M01").hoDem.ToString());

            if (txtSeach.Text != "")
            {
               
                maTimKiem = txtSeach.Text.ToString();
                HoSoBUL file = new HoSoBUL();
                
                dgvHoSo.Rows.Clear();
                DataTable dt = file.searchHoSo(maTimKiem);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    
                    dgvHoSo.Rows.Add();
                    dgvHoSo.Rows[i].Cells[0].Value = dt.Rows[i][0];
                    dgvHoSo.Rows[i].Cells[1].Value =dt.Rows[i][1];
                    dgvHoSo.Rows[i].Cells[2].Value = dt.Rows[i][2];
                    dgvHoSo.Rows[i].Cells[3].Value = dt.Rows[i][3];
                    dgvHoSo.Rows[i].Cells[4].Value = dt.Rows[i][4];
                    dgvHoSo.Rows[i].Cells[5].Value = dt.Rows[i][5];
                    dgvHoSo.Rows[i].Cells[6].Value = dt.Rows[i][6];
                    dgvHoSo.Rows[i].Cells[7].Value = dt.Rows[i][7];
                    dgvHoSo.Rows[i].Cells[8].Value = dt.Rows[i][8];
                    //dgvHoSo.Rows.Clear();
                }
            }
            else
            {
                lbtb.Text = "";
                lbtb.Text = "Vui lòng điền mã Nhân Viên cần tìm.";
                loadData();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public string getMaNhanVien() { 
            string a ="";
            if(dgvHoSo.SelectedRows.Count!=0){
                DataGridViewRow row = this.dgvHoSo.SelectedRows[0];
                a = row.Cells["Column1"].Value.ToString();
            }
            return a;
           
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show();

            
                maTimKiem = getMaNhanVien().ToString();
                //MessageBox.Show(maTimKiem);
                if (maTimKiem!="")
                {
                    
                    DialogResult cond = MessageBox.Show("Bạn có muốn sửa Hồ Sơ này không?", "Thông báo", MessageBoxButtons.YesNo);
                    if (cond == DialogResult.Yes)
                    {
                         new frmChangeHoSo().ShowDialog();
                        loadData();

                    }
                }
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa  không?", "Xác Nhận!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (rs == DialogResult.OK)
                    {
                        string ma = getMaNhanVien().ToString();
                        bool a = new HoSoBUL().deleteHoSo(ma);
                        if (a == true)
                        {
                            txtSeach.Text = "";
                            MessageBox.Show("Xóa Hồ Sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HoSoBUL file = new HoSoBUL();
                            
                            loadData();
                        }
                        else
                        {
                            MessageBox.Show("Xóa hồ sơ thất bại :(", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                       
                    }
                }
                
            
            catch
            {
                MessageBox.Show("Xóa hồ sơ thất bại :(", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            //loadData();
        }

        private void dgvHoSo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHoSo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHoSo.CurrentRow.Cells[0].Value != null)
            {
                string id = dgvHoSo.CurrentRow.Cells[0].Value.ToString();
                frmMain.MaHoSo = id;
            }
        }
    }
}
