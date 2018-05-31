namespace QLNS.GiupDo
{
    partial class ucThongTinUngDung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGioiThieu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtGioiThieu
            // 
            this.txtGioiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGioiThieu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiThieu.Location = new System.Drawing.Point(0, 0);
            this.txtGioiThieu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGioiThieu.Multiline = true;
            this.txtGioiThieu.Name = "txtGioiThieu";
            this.txtGioiThieu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGioiThieu.Size = new System.Drawing.Size(150, 150);
            this.txtGioiThieu.TabIndex = 1;
            this.txtGioiThieu.TextChanged += new System.EventHandler(this.txtGioiThieu_TextChanged);
            // 
            // ucThongTinUngDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtGioiThieu);
            this.Name = "ucThongTinUngDung";
            this.Load += new System.EventHandler(this.ucThongTinUngDung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGioiThieu;
    }
}
