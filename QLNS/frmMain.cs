using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;
namespace QLNS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static User user = null;
        private void quảnLíThôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            LoadData();
        }
        void LoadData()
        {
            if (user != null)
            {
                label1.Text = user.LastName + " " + user.FirstName;
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ucQuanLiThongTinCaNhan.user = user;
            ucQuanLiThongTinCaNhan uc = new ucQuanLiThongTinCaNhan();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void giúpĐỡToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucQuanLiHoSo uc = new ucQuanLiHoSo();
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucQuanLiCongTac uc = new ucQuanLiCongTac();
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void quảnLíNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucQuanLiDanhSachNguoiDung uc = new ucQuanLiDanhSachNguoiDung();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
