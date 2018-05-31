using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using Microsoft.Reporting.WinForms;
namespace QLNS.QLTrinhDoNgoaiNgu
{
    public partial class frmThongKeNgoaiNgu : Form
    {
        public frmThongKeNgoaiNgu()
        {
            InitializeComponent();
        }

        private void frmThongKeNgoaiNgu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            // TODO: This line of code loads data into the 'sourceReport.NgoaiNgu' table. You can move, or remove it, as needed.
            this.ngoaiNguTableAdapter.Fill(this.sourceReport.NgoaiNgu);
            
            // TODO: This line of code loads data into the 'sourceReport.ReportTDNN' table. You can move, or remove it, as needed.
            this.reportTDNNTableAdapter.Fill(this.sourceReport.ReportTDNN);
            this.reportViewer1.RefreshReport();
            SetCombo();
            SetData();
        }
        void SetCombo()
        {
            DataTable dt = new UserBUL().GetTabble("SELECT dbo.TrinhDoNgoaiNgu.TrinhDo FROM dbo.TrinhDoNgoaiNgu GROUP BY dbo.TrinhDoNgoaiNgu.TrinhDo");
            Dictionary<string, string> dic = new Dictionary<string, string>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dic.Add(dt.Rows[i][0].ToString(), dt.Rows[i][0].ToString());
            }
            comboBox2.DataSource = dic.ToList();
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
        }
        void SetData()
        {
            ReportParameter pr = new ReportParameter("NgoaiNgu",comboBox1.SelectedValue.ToString(),false);
            ReportParameter pr1 = new ReportParameter("TrinhDo", comboBox2.SelectedValue.ToString(), false);
            reportViewer1.LocalReport.SetParameters(pr);
            reportViewer1.LocalReport.SetParameters(pr1);
            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetData();
        }
    }
}
