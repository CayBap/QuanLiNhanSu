namespace QLNS.QLNhanVienChucVu
{
    partial class frmAddNhanVienChucVu
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Green;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuy.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuy.Location = new System.Drawing.Point(243, 207);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(101, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(151, 157);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(207, 21);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(151, 115);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(207, 21);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đến ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Từ ngày :";
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Location = new System.Drawing.Point(151, 72);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(207, 21);
            this.txtMaChucVu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã chức vụ";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(151, 28);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(207, 21);
            this.txtMaNhanVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã nhân viên:";
            // 
            // frmAddNhanVienChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(409, 264);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaChucVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmAddNhanVienChucVu";
            this.Text = "Thêm mới nhân viên chức vụ";
            this.Load += new System.EventHandler(this.frmAddNhanVienChucVu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label1;
    }
}