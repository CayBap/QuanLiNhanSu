namespace QLNS.QLNhanVienChucVu
{
    partial class frmSuaNhanVienChucVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(127, 30);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(207, 21);
            this.txtMaNhanVien.TabIndex = 0;
            this.txtMaNhanVien.TextChanged += new System.EventHandler(this.txtMaNhanVien_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã chức vụ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Enabled = false;
            this.txtMaChucVu.Location = new System.Drawing.Point(127, 74);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(207, 21);
            this.txtMaChucVu.TabIndex = 1;
            this.txtMaChucVu.TextChanged += new System.EventHandler(this.txtMaChucVu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Từ ngày :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đến ngày:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Enabled = false;
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(127, 117);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(207, 21);
            this.dtpTuNgay.TabIndex = 2;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(127, 159);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(207, 21);
            this.dtpDenNgay.TabIndex = 3;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.BackColor = System.Drawing.Color.Red;
            this.btnCapNhap.FlatAppearance.BorderSize = 0;
            this.btnCapNhap.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCapNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCapNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCapNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhap.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCapNhap.Location = new System.Drawing.Point(77, 209);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhap.TabIndex = 4;
            this.btnCapNhap.Text = "Cập nhập";
            this.btnCapNhap.UseVisualStyleBackColor = false;
            this.btnCapNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Green;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnHuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuy.Location = new System.Drawing.Point(219, 209);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmSuaNhanVienChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(369, 265);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnCapNhap);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaChucVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSuaNhanVienChucVu";
            this.Text = "Cập nhập thông tin nhân viên chức vụ";
            this.Load += new System.EventHandler(this.frmSuaNhanVienChucVu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.Button btnHuy;
    }
}