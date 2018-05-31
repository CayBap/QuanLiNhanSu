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
using Microsoft.Reporting.WinForms;

namespace QLNS.QLTrinhDoChuyenMon
{
    public partial class frmThongKeTrinhDoChuyenMon : Form
    {
        public frmThongKeTrinhDoChuyenMon()
        {
            InitializeComponent();
        }

        private void frmThongKeTrinhDoChuyenMon_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            // TODO: This line of code loads data into the 'sourceReport.Report2' table. You can move, or remove it, as needed.
            this.report2TableAdapter.Fill(this.sourceReport.Report2);
            reportViewer1.RefreshReport();
            LoadCombobox();
            SetData();
        }
        void LoadCombobox()
        {
            DataTable dt = new TrinhDoChuyenMonBUL().GetNganh();
            DataTable dt1 = new TrinhDoChuyenMonBUL().GetTrinhDo();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            Dictionary<string, string> dic2 = new Dictionary<string, string>();

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                dic.Add(dt.Rows[i][0].ToString(),dt.Rows[i][0].ToString());
            }
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                dic2.Add(dt1.Rows[i][0].ToString(), dt1.Rows[i][0].ToString());
            }
            comboBox1.DataSource = dic.ToList();
            comboBox1.ValueMember = "Key";
            comboBox1.DisplayMember = "Value";
            comboBox2.DataSource = dic2.ToList();
            comboBox2.ValueMember = "Key";
            comboBox2.DisplayMember = "Value";
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
          
        }
        void SetData()
        {
            ReportParameter pr = new ReportParameter("TrinhDo", comboBox2.SelectedValue.ToString(), false);
            ReportParameter pr1 = new ReportParameter("Nganh", comboBox1.SelectedValue.ToString(), false);
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
