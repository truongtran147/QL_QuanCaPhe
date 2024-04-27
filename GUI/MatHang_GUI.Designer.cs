namespace GUI
{
    partial class MatHang_GUI
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
            this.picAnhMH = new System.Windows.Forms.PictureBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.RichTextBox();
            this.overlay = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMH)).BeginInit();
            this.SuspendLayout();
            // 
            // picAnhMH
            // 
            this.picAnhMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAnhMH.Location = new System.Drawing.Point(1, 1);
            this.picAnhMH.Name = "picAnhMH";
            this.picAnhMH.Size = new System.Drawing.Size(159, 159);
            this.picAnhMH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhMH.TabIndex = 0;
            this.picAnhMH.TabStop = false;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDonGia.Location = new System.Drawing.Point(1, 1);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(94, 17);
            this.lblDonGia.TabIndex = 2;
            this.lblDonGia.Text = "Đây là giá bán";
            // 
            // txtTenMH
            // 
            this.txtTenMH.BackColor = System.Drawing.Color.White;
            this.txtTenMH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTenMH.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMH.ForeColor = System.Drawing.Color.Green;
            this.txtTenMH.Location = new System.Drawing.Point(0, 132);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.ReadOnly = true;
            this.txtTenMH.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtTenMH.Size = new System.Drawing.Size(162, 40);
            this.txtTenMH.TabIndex = 6;
            this.txtTenMH.Text = "Đây là tên mặt hàng trong quán";
            this.txtTenMH.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTenMH_MouseDown);
            // 
            // overlay
            // 
            this.overlay.BackColor = System.Drawing.Color.Transparent;
            this.overlay.BorderRadius = 5;
            this.overlay.BorderThickness = 1;
            this.overlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.overlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.overlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.overlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.overlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlay.FillColor = System.Drawing.Color.Transparent;
            this.overlay.FocusedColor = System.Drawing.Color.White;
            this.overlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.overlay.ForeColor = System.Drawing.Color.White;
            this.overlay.Location = new System.Drawing.Point(0, 0);
            this.overlay.Name = "overlay";
            this.overlay.ShadowDecoration.Depth = 20;
            this.overlay.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.overlay.Size = new System.Drawing.Size(161, 172);
            this.overlay.TabIndex = 7;
            this.overlay.UseTransparentBackground = true;
            // 
            // MatHang_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.overlay);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.picAnhMH);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MatHang_GUI";
            this.Size = new System.Drawing.Size(161, 172);
            this.Load += new System.EventHandler(this.MatHang_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAnhMH;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.RichTextBox txtTenMH;
        private Guna.UI2.WinForms.Guna2Button overlay;
    }
}
