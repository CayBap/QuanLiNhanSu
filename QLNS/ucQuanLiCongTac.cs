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
        }
        QuaTrinhCongTacBUL qtct = new QuaTrinhCongTacBUL();
        private void LoadDS()
        {
            dgvQLCT.DataSource = qtct.DSQuaTrinhCongTacBUL();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dgvQLCT.DataSource = qtct.searchBUL(txtma.Text);
            lblten.Text = qtct.searchtenBUL(txtma.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new frmdelete().ShowDialog();
            LoadDS();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new frmupdate().ShowDialog();
            LoadDS();
        }
    }
}
