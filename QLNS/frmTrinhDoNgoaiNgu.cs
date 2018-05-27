using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'QLNSDataSet.ReportTDNN' table. You can move, or remove it, as needed.
            this.ReportTDNNTableAdapter.Fill(this.QLNSDataSet.ReportTDNN);
            this.CenterToParent();
            this.reportViewer1.RefreshReport();
        }
    }
}
