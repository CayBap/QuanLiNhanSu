using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BUL;
namespace QLNS.QLHoSo
{
    public partial class frmInHoSo : Form
    {
        public frmInHoSo()
        {
            InitializeComponent();
        }

        private void frmInHoSo_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            //this.reportViewer1.RefreshReport();
        }
        void SetData()
        {
            DataTable dt = new HoSoBUL().searchHoSo(textBox1.Text);

            ReportParameter pr = new ReportParameter("MaNhanVien", dt.Rows[0][0].ToString(), false);
            ReportParameter pr1 = new ReportParameter("HoDem", dt.Rows[0][1].ToString(), false);
            ReportParameter pr2 = new ReportParameter("Ten", dt.Rows[0][2].ToString(), false);
            ReportParameter pr3 = new ReportParameter("NgaySinh",DateTime.Parse(dt.Rows[0][3].ToString()).ToShortDateString(), false);
            ReportParameter pr4 = new ReportParameter("GioiTinh", dt.Rows[0][4].ToString(), false);
            ReportParameter pr5 = new ReportParameter("SoDT", dt.Rows[0][5].ToString(), false);
            ReportParameter pr6 = new ReportParameter("Email", dt.Rows[0][6].ToString(), false);
            ReportParameter pr7 = new ReportParameter("NgayTuyenDung", dt.Rows[0][7].ToString(), false);
            ReportParameter pr8 = new ReportParameter("MaPhongBan", dt.Rows[0][8].ToString(), false);
            reportViewer1.LocalReport.SetParameters(pr);
            reportViewer1.LocalReport.SetParameters(pr1);
            reportViewer1.LocalReport.SetParameters(pr2);
            reportViewer1.LocalReport.SetParameters(pr3);
            reportViewer1.LocalReport.SetParameters(pr4);
            reportViewer1.LocalReport.SetParameters(pr5);
            reportViewer1.LocalReport.SetParameters(pr6);
            reportViewer1.LocalReport.SetParameters(pr7);
            reportViewer1.LocalReport.SetParameters(pr8);
            reportViewer1.RefreshReport();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SetData();
        }
    }
}
