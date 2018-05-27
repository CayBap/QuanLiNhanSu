namespace QLNS.QLQuatrinhCongTac
{
    partial class frmdelete
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
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoiCongTac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(131, 104);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(197, 22);
            this.dtpTuNgay.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 37;
            this.label4.Tag = "";
            this.label4.Text = "Từ Ngày";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(131, 59);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(197, 22);
            this.txtMaNV.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mã NV";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(232, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 23);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Green;
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Location = new System.Drawing.Point(83, 287);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(65, 23);
            this.btnxoa.TabIndex = 34;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(131, 142);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(197, 22);
            this.dtpDenNgay.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 42;
            this.label6.Tag = "";
            this.label6.Text = "Đến Ngày";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(131, 229);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(197, 22);
            this.txtChucVu.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Chức Vụ";
            // 
            // txtNoiCongTac
            // 
            this.txtNoiCongTac.Location = new System.Drawing.Point(131, 186);
            this.txtNoiCongTac.Name = "txtNoiCongTac";
            this.txtNoiCongTac.Size = new System.Drawing.Size(197, 22);
            this.txtNoiCongTac.TabIndex = 44;
            this.txtNoiCongTac.TextChanged += new System.EventHandler(this.txtNoiCongTac_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nơi Công Tác";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmdelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 396);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNoiCongTac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnxoa);
            this.Name = "frmdelete";
            this.Text = "frmdelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoiCongTac;
        private System.Windows.Forms.Label label2;
    }
}