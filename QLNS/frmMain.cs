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
using QLNS.QLTrinhDoNgoaiNgu;
using QLNS.QLTrinhDoChuyenMon;
using QLNS.GiupDo;

namespace QLNS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static User user = null;
        public static string MaHoSo = null;
        private void quảnLíThôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucQuanLiThongTinCaNhan.user = user;
            ucQuanLiThongTinCaNhan uc = new ucQuanLiThongTinCaNhan();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
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
            this.Hide();
            new frmLogin().Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

     

        private void quảnLíNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Role.Trim() == "admin")
            {
                ucQuanLiDanhSachNguoiDung uc = new ucQuanLiDanhSachNguoiDung();
                uc.Dock = DockStyle.Fill;
                panel3.Controls.Clear();
                panel3.Controls.Add(uc);
            }
            else
            {
                MessageBox.Show("Chức năng này chỉ dành cho người quản trị hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

      

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trìnhĐộNgoạiNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmThongKeNgoaiNgu().ShowDialog();
        }

        private void trìnhĐộChuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmThongKeTrinhDoChuyenMon().ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SetMau(btn1, btn2, btn3, btn4, btn5, btn6, btn7);  
            ucQuanLiHoSo uc = new ucQuanLiHoSo();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);

        }
          private void button5_Click(object sender, EventArgs e)
        {
            SetMau(btn5, btn2, btn3, btn4, btn1, btn6, btn7);
            if (MaHoSo != null)
            {
                ucQuanLiNhanVienChucVu.maTimKiem = MaHoSo;
            }
            MaHoSo = null;
            ucQuanLiNhanVienChucVu uc = new ucQuanLiNhanVienChucVu();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void btnQuanLiTrinhDoNgoaiNgu_Click(object sender, EventArgs e)
        {
            SetMau(btn3, btn2, btn1, btn4, btn5, btn6, btn7);
            if (MaHoSo != null)
            {
                ucQuanLiTrinhDoNgoaiNgu.maTimKiem = MaHoSo;
            }
            MaHoSo = null;
            ucQuanLiTrinhDoNgoaiNgu uc = new ucQuanLiTrinhDoNgoaiNgu();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SetMau(btn4, btn2, btn3, btn1, btn5, btn6, btn7);
            if (MaHoSo != null)
            {
                ucQuanLiCongTac.maTimKiem = MaHoSo;
            }
            MaHoSo = null;
            ucQuanLiCongTac uc = new ucQuanLiCongTac();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }
        private void btnQuanLiTrinhDoChuyenMon_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(MaHoSo);
            SetMau(btn2, btn1, btn3, btn4, btn5, btn6, btn7);
            if (MaHoSo != null)
            {
                ucQuanLiTrinhDoChuyenMon.maTimKiem = MaHoSo;
            }
            MaHoSo = null;
            ucQuanLiTrinhDoChuyenMon uc = new ucQuanLiTrinhDoChuyenMon();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SetMau(btn6, btn2, btn3, btn4, btn5, btn1, btn7);
            ucQuanLiPhongBan uc = new ucQuanLiPhongBan();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetMau(btn7, btn2, btn3, btn4, btn5, btn6, btn1);
            ucQLChucVu uc = new ucQLChucVu();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }
        void SetMau(Button choise,Button b1,Button b2,Button b3,Button b4,Button b5,Button b6)
        {
            choise.BackColor = Color.DarkTurquoise;
            b1.BackColor = Color.Teal;
            b2.BackColor = Color.Teal;
            b3.BackColor = Color.Teal;
            b4.BackColor = Color.Teal;
            b5.BackColor = Color.Teal;
            b6.BackColor = Color.Teal;
        }

        void SetAll(Button choise, Button b1, Button b2, Button b3, Button b4, Button b5, Button b6)
        {
            choise.BackColor = Color.Teal;
            b1.BackColor = Color.Teal;
            b2.BackColor = Color.Teal;
            b3.BackColor = Color.Teal;
            b4.BackColor = Color.Teal;
            b5.BackColor = Color.Teal;
            b6.BackColor = Color.Teal;
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            ucIntro uc = new ucIntro();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
            SetAll(btn1, btn2, btn3, btn4, btn5, btn6, btn7);
        }

        private void thôngTinỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucThongTinUngDung uc = new ucThongTinUngDung();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void đóngGópÝKiếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucDongGopYKien uc = new ucDongGopYKien();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void thôngTinNhàPhátTriểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucThongTinNhaPhatTrien uc = new ucThongTinNhaPhatTrien();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNguoiDung.frmChangePass.user = user;
            QLNguoiDung.frmChangePass changePass = new QLNguoiDung.frmChangePass();
            changePass.ShowDialog();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QLHoSo.frmInHoSo().ShowDialog();
        }
    }
}
