namespace QLNS
{
    partial class frmTrinhDoNgoaiNgu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReportTDNNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLNSDataSet = new QLNS.QLNSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportTDNNTableAdapter = new QLNS.QLNSDataSetTableAdapters.ReportTDNNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTDNNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportTDNNBindingSource
            // 
            this.ReportTDNNBindingSource.DataMember = "ReportTDNN";
            this.ReportTDNNBindingSource.DataSource = this.QLNSDataSet;
            // 
            // QLNSDataSet
            // 
            this.QLNSDataSet.DataSetName = "QLNSDataSet";
            this.QLNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReportTDNNBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNS.rpTrinhDoNgoaiNgu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(926, 605);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportTDNNTableAdapter
            // 
            this.ReportTDNNTableAdapter.ClearBeforeFill = true;
            // 
            // frmTrinhDoNgoaiNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 605);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTrinhDoNgoaiNgu";
            this.Text = "Báo cáo trình độ ngoại ngữ";
            this.Load += new System.EventHandler(this.frmTrinhDoNgoaiNgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportTDNNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportTDNNBindingSource;
        private QLNSDataSet QLNSDataSet;
        private QLNSDataSetTableAdapters.ReportTDNNTableAdapter ReportTDNNTableAdapter;
    }
}