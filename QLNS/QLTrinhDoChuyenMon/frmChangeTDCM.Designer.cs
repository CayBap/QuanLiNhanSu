namespace QLNS.QLTrinhDoChuyenMon
{
    partial class frmChangeTDCM
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
            this.cbTrinhDo = new System.Windows.Forms.ComboBox();
            this.cbLoaiHinhDaoTao = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTruongDaoTao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNganh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbTrinhDo
            // 
            this.cbTrinhDo.FormattingEnabled = true;
            this.cbTrinhDo.Items.AddRange(new object[] {
            "Trung Cấp",
            "Cao Đẳng",
            "Đại Học",
            "Thạc Sĩ",
            "Tiến Sĩ"});
            this.cbTrinhDo.Location = new System.Drawing.Point(185, 126);
            this.cbTrinhDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTrinhDo.Name = "cbTrinhDo";
            this.cbTrinhDo.Size = new System.Drawing.Size(261, 24);
            this.cbTrinhDo.TabIndex = 0;
            // 
            // cbLoaiHinhDaoTao
            // 
            this.cbLoaiHinhDaoTao.FormattingEnabled = true;
            this.cbLoaiHinhDaoTao.Items.AddRange(new object[] {
            "Chính Quy",
            "Vừa Học Vừa Làm",
            "Liên Thông"});
            this.cbLoaiHinhDaoTao.Location = new System.Drawing.Point(185, 172);
            this.cbLoaiHinhDaoTao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLoaiHinhDaoTao.Name = "cbLoaiHinhDaoTao";
            this.cbLoaiHinhDaoTao.Size = new System.Drawing.Size(261, 24);
            this.cbLoaiHinhDaoTao.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 61;
            this.label8.Text = "Trường Đào Tạo:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(301, 319);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(139, 319);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblThongBao.Location = new System.Drawing.Point(188, 277);
            this.lblThongBao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 17);
            this.lblThongBao.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Loại Hình Đào Tạo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Trình Độ:";
            // 
            // txtTruongDaoTao
            // 
            this.txtTruongDaoTao.Location = new System.Drawing.Point(185, 219);
            this.txtTruongDaoTao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTruongDaoTao.Name = "txtTruongDaoTao";
            this.txtTruongDaoTao.Size = new System.Drawing.Size(261, 22);
            this.txtTruongDaoTao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Ngành: ";
            // 
            // txtmaNV
            // 
            this.txtmaNV.Location = new System.Drawing.Point(185, 34);
            this.txtmaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(261, 22);
            this.txtmaNV.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // txtNganh
            // 
            this.txtNganh.Location = new System.Drawing.Point(185, 80);
            this.txtNganh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNganh.Name = "txtNganh";
            this.txtNganh.Size = new System.Drawing.Size(261, 22);
            this.txtNganh.TabIndex = 65;
            // 
            // frmChangeTDCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 375);
            this.Controls.Add(this.txtNganh);
            this.Controls.Add(this.cbTrinhDo);
            this.Controls.Add(this.cbLoaiHinhDaoTao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTruongDaoTao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmaNV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChangeTDCM";
            this.Text = "Sửa Thông Tin Trình Độ Chuyên Môn";
            this.Load += new System.EventHandler(this.frmChangeTDCM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTrinhDo;
        private System.Windows.Forms.ComboBox cbLoaiHinhDaoTao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTruongDaoTao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNganh;
    }
}