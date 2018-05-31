namespace QLNS.TT_ứng_dụng
{
    partial class TTUDng
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
            this.txtGioiThieu.Multiline = true;
            this.txtGioiThieu.Name = "txtGioiThieu";
            this.txtGioiThieu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGioiThieu.Size = new System.Drawing.Size(804, 571);
            this.txtGioiThieu.TabIndex = 0;
            this.txtGioiThieu.TextChanged += new System.EventHandler(this.txtGioiThieu_TextChanged);
            // 
            // TTUDng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.txtGioiThieu);
            this.Name = "TTUDng";
            this.Size = new System.Drawing.Size(804, 571);
            this.Load += new System.EventHandler(this.TTUDng_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGioiThieu;
    }
}
