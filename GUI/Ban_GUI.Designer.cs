namespace GUI
{
    partial class Ban_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.background = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.overlay = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Transparent;
            this.background.BorderColor = System.Drawing.Color.DimGray;
            this.background.BorderRadius = 5;
            this.background.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.background.Cursor = System.Windows.Forms.Cursors.Hand;
            this.background.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.background.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.background.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.background.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.FillColor = System.Drawing.Color.LightCyan;
            this.background.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.background.ForeColor = System.Drawing.Color.White;
            this.background.Image = global::GUI.Properties.Resources.table;
            this.background.ImageSize = new System.Drawing.Size(45, 45);
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 5, 5, 5);
            this.background.Size = new System.Drawing.Size(102, 83);
            this.background.TabIndex = 2;
            this.background.UseTransparentBackground = true;
            this.background.CheckedChanged += new System.EventHandler(this.overlay_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // overlay
            // 
            this.overlay.BackColor = System.Drawing.Color.Transparent;
            this.overlay.BorderColor = System.Drawing.Color.DimGray;
            this.overlay.BorderRadius = 5;
            this.overlay.BorderThickness = 1;
            this.overlay.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.overlay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.overlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.overlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.overlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.overlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.overlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.overlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlay.FillColor = System.Drawing.Color.Transparent;
            this.overlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.overlay.ForeColor = System.Drawing.Color.White;
            this.overlay.Location = new System.Drawing.Point(0, 0);
            this.overlay.Name = "overlay";
            this.overlay.Size = new System.Drawing.Size(102, 83);
            this.overlay.TabIndex = 4;
            this.overlay.UseTransparentBackground = true;
            // 
            // Ban_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.overlay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.Name = "Ban_GUI";
            this.Size = new System.Drawing.Size(102, 83);
            this.Load += new System.EventHandler(this.Ban_GUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button background;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button overlay;
    }
}
