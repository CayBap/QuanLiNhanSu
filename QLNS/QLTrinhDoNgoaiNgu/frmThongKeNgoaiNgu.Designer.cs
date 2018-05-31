namespace QLNS.QLTrinhDoNgoaiNgu
{
    partial class frmThongKeNgoaiNgu
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
            this.reportTDNNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sourceReport = new QLNS.SourceReport();
            this.reportTDNNTableAdapter = new QLNS.SourceReportTableAdapters.ReportTDNNTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ngoaiNguBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ngoaiNguTableAdapter = new QLNS.SourceReportTableAdapters.NgoaiNguTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportTDNNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceReport)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngoaiNguBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportTDNNBindingSource
            // 
            this.reportTDNNBindingSource.DataMember = "ReportTDNN";
            this.reportTDNNBindingSource.DataSource = this.sourceReport;
            // 
            // sourceReport
            // 
            this.sourceReport.DataSetName = "SourceReport";
            this.sourceReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportTDNNTableAdapter
            // 
            this.reportTDNNTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 66);
            this.panel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(276, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ngoaiNguBindingSource, "NgoaiNgu", true));
            this.comboBox1.DataSource = this.ngoaiNguBindingSource;
            this.comboBox1.DisplayMember = "NgoaiNgu";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(491, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "NgoaiNgu";
            // 
            // ngoaiNguBindingSource
            // 
            this.ngoaiNguBindingSource.DataMember = "NgoaiNgu";
            this.ngoaiNguBindingSource.DataSource = this.sourceReport;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(633, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trình độ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngôn ngữ:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportTDNNBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNS.QLTrinhDoNgoaiNgu.rpThongKeNgoaiNgu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 66);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(976, 492);
            this.reportViewer1.TabIndex = 1;
            // 
            // ngoaiNguTableAdapter
            // 
            this.ngoaiNguTableAdapter.ClearBeforeFill = true;
            // 
            // frmThongKeNgoaiNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 558);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmThongKeNgoaiNgu";
            this.Text = "Thống kê trình độ ngoại ngữ";
            this.Load += new System.EventHandler(this.frmThongKeNgoaiNgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportTDNNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngoaiNguBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SourceReport sourceReport;
        private System.Windows.Forms.BindingSource reportTDNNBindingSource;
        private SourceReportTableAdapters.ReportTDNNTableAdapter reportTDNNTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource ngoaiNguBindingSource;
        private SourceReportTableAdapters.NgoaiNguTableAdapter ngoaiNguTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}