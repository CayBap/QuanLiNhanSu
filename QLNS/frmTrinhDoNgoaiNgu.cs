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

namespace QLNS
{
    public partial class frmTrinhDoNgoaiNgu : Form
    {
        public frmTrinhDoNgoaiNgu()
        {
            InitializeComponent();
        }

        private void frmTrinhDoNgoaiNgu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet1.NgoaiNgu' table. You can move, or remove it, as needed.
            this.ngoaiNguTableAdapter.Fill(this.qLNSDataSet1.NgoaiNgu);
            // TODO: This line of code loads data into the 'QLNSDataSet.ReportTDNN' table. You can move, or remove it, as needed.
            this.ReportTDNNTableAdapter.Fill(this.QLNSDataSet.ReportTDNN);
            this.CenterToParent();
            this.reportViewer1.RefreshReport();
            ReportParameter rp = new ReportParameter("NgoaiNgu");
            rp.Values.Add(comboBox1.SelectedValue.ToString());
            reportViewer1.LocalReport.SetParameters(rp);
            reportViewer1.RefreshReport();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("A", "A");
            dic.Add("B", "B");
            dic.Add("C", "C");
            dic.Add("D", "D");
            comboBox2.DataSource = dic.ToList();
            comboBox2.SelectedIndex = 0;
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportParameter rp = new ReportParameter("NgoaiNgu");
            rp.Values.Add(comboBox1.SelectedValue.ToString());
            reportViewer1.LocalReport.SetParameters(rp);


            ReportParameter rp1 = new ReportParameter("TrinhDo",comboBox2.SelectedValue.ToString(),true);
       //     rp1.Values.Add("A");
            reportViewer1.LocalReport.SetParameters(rp1);
            reportViewer1.RefreshReport();
        }
    }
}
