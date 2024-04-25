namespace GUI
{
    partial class Form1
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
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.containerOder = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDonBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnInHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGiam = new System.Windows.Forms.Label();
            this.txtGiam = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTongTT = new System.Windows.Forms.Label();
            this.containerCTHD = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.containerBan = new System.Windows.Forms.FlowLayoutPanel();
            this.cboKhuVuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLoaiMH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblLoaiMH = new System.Windows.Forms.Label();
            this.btnChuyenBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnGopBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuyOder = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaoHD = new Guna.UI2.WinForms.Guna2Button();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // containerOder
            // 
            this.containerOder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerOder.AutoScroll = true;
            this.containerOder.BackColor = System.Drawing.Color.White;
            this.containerOder.Location = new System.Drawing.Point(1, 4);
            this.containerOder.Name = "containerOder";
            this.containerOder.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.containerOder.Size = new System.Drawing.Size(696, 519);
            this.containerOder.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDonBan);
            this.panel1.Controls.Add(this.btnInHD);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblGiam);
            this.panel1.Controls.Add(this.txtGiam);
            this.panel1.Controls.Add(this.lblTongTT);
            this.panel1.Location = new System.Drawing.Point(688, 590);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 115);
            this.panel1.TabIndex = 13;
            // 
            // btnDonBan
            // 
            this.btnDonBan.BorderRadius = 2;
            this.btnDonBan.BorderThickness = 1;
            this.btnDonBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDonBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDonBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDonBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDonBan.Enabled = false;
            this.btnDonBan.FillColor = System.Drawing.Color.White;
            this.btnDonBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDonBan.ForeColor = System.Drawing.Color.Black;
            this.btnDonBan.Image = global::GUI.Properties.Resources.clean;
            this.btnDonBan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDonBan.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnDonBan.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDonBan.Location = new System.Drawing.Point(549, 19);
            this.btnDonBan.Name = "btnDonBan";
            this.btnDonBan.Size = new System.Drawing.Size(114, 77);
            this.btnDonBan.TabIndex = 40;
            this.btnDonBan.Text = "       Dọn         bàn";
            this.btnDonBan.TextOffset = new System.Drawing.Point(16, 0);
            this.btnDonBan.Click += new System.EventHandler(this.btnDonBan_Click);
            // 
            // btnInHD
            // 
            this.btnInHD.BorderRadius = 2;
            this.btnInHD.BorderThickness = 1;
            this.btnInHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInHD.Enabled = false;
            this.btnInHD.FillColor = System.Drawing.Color.White;
            this.btnInHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnInHD.ForeColor = System.Drawing.Color.Black;
            this.btnInHD.Image = global::GUI.Properties.Resources.pos_terminal;
            this.btnInHD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInHD.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnInHD.ImageSize = new System.Drawing.Size(40, 40);
            this.btnInHD.Location = new System.Drawing.Point(427, 19);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(114, 77);
            this.btnInHD.TabIndex = 39;
            this.btnInHD.Text = "        Xuất       bill";
            this.btnInHD.TextOffset = new System.Drawing.Point(14, 0);
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderRadius = 2;
            this.btnThanhToan.BorderThickness = 1;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.FillColor = System.Drawing.Color.White;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Image = global::GUI.Properties.Resources.pay_per_click;
            this.btnThanhToan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThanhToan.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnThanhToan.ImageSize = new System.Drawing.Size(40, 40);
            this.btnThanhToan.Location = new System.Drawing.Point(307, 19);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(114, 77);
            this.btnThanhToan.TabIndex = 38;
            this.btnThanhToan.Text = "  Thanh toán";
            this.btnThanhToan.TextOffset = new System.Drawing.Point(17, 0);
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tổng TT";
            // 
            // lblGiam
            // 
            this.lblGiam.AutoSize = true;
            this.lblGiam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiam.Location = new System.Drawing.Point(15, 25);
            this.lblGiam.Name = "lblGiam";
            this.lblGiam.Size = new System.Drawing.Size(82, 23);
            this.lblGiam.TabIndex = 36;
            this.lblGiam.Text = "Giá giảm";
            // 
            // txtGiam
            // 
            this.txtGiam.BorderColor = System.Drawing.Color.Gray;
            this.txtGiam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiam.DefaultText = "";
            this.txtGiam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiam.FillColor = System.Drawing.SystemColors.Info;
            this.txtGiam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiam.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtGiam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiam.Location = new System.Drawing.Point(108, 19);
            this.txtGiam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiam.Name = "txtGiam";
            this.txtGiam.PasswordChar = '\0';
            this.txtGiam.PlaceholderText = "0";
            this.txtGiam.SelectedText = "";
            this.txtGiam.Size = new System.Drawing.Size(173, 32);
            this.txtGiam.TabIndex = 35;
            this.txtGiam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGiam.TextChanged += new System.EventHandler(this.txtGiam_TextChanged);
            this.txtGiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiam_KeyPress);
            // 
            // lblTongTT
            // 
            this.lblTongTT.BackColor = System.Drawing.SystemColors.Info;
            this.lblTongTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTongTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTT.ForeColor = System.Drawing.Color.Green;
            this.lblTongTT.Location = new System.Drawing.Point(108, 62);
            this.lblTongTT.Name = "lblTongTT";
            this.lblTongTT.Size = new System.Drawing.Size(172, 34);
            this.lblTongTT.TabIndex = 34;
            this.lblTongTT.Text = "0";
            this.lblTongTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // containerCTHD
            // 
            this.containerCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerCTHD.AutoScroll = true;
            this.containerCTHD.Location = new System.Drawing.Point(-1, 30);
            this.containerCTHD.Name = "containerCTHD";
            this.containerCTHD.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.containerCTHD.Size = new System.Drawing.Size(664, 265);
            this.containerCTHD.TabIndex = 14;
            // 
            // lblBan
            // 
            this.lblBan.AutoSize = true;
            this.lblBan.BackColor = System.Drawing.Color.White;
            this.lblBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBan.Location = new System.Drawing.Point(12, 29);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(118, 33);
            this.lblBan.TabIndex = 15;
            this.lblBan.Text = "Chọn bàn";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "                          Tên món                                    SL          " +
    "             Giá                 Thành tiên                                     " +
    "       ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.containerCTHD);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 292);
            this.panel2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(688, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 33);
            this.label2.TabIndex = 20;
            this.label2.Text = "Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "Order";
            // 
            // containerBan
            // 
            this.containerBan.AutoScroll = true;
            this.containerBan.BackColor = System.Drawing.Color.White;
            this.containerBan.Location = new System.Drawing.Point(13, 65);
            this.containerBan.Name = "containerBan";
            this.containerBan.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.containerBan.Size = new System.Drawing.Size(664, 287);
            this.containerBan.TabIndex = 12;
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.BackColor = System.Drawing.Color.Transparent;
            this.cboKhuVuc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboKhuVuc.BorderRadius = 2;
            this.cboKhuVuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhuVuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cboKhuVuc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKhuVuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKhuVuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.cboKhuVuc.ForeColor = System.Drawing.Color.White;
            this.cboKhuVuc.ItemHeight = 20;
            this.cboKhuVuc.Location = new System.Drawing.Point(531, 27);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.cboKhuVuc.Size = new System.Drawing.Size(147, 26);
            this.cboKhuVuc.TabIndex = 22;
            this.cboKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cboKhuVuc_SelectedIndexChanged);
            // 
            // btnLoaiMH
            // 
            this.btnLoaiMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoaiMH.BackColor = System.Drawing.Color.Transparent;
            this.btnLoaiMH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoaiMH.BorderRadius = 2;
            this.btnLoaiMH.BorderThickness = 0;
            this.btnLoaiMH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.btnLoaiMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btnLoaiMH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoaiMH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLoaiMH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLoaiMH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLoaiMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.btnLoaiMH.ItemHeight = 20;
            this.btnLoaiMH.Location = new System.Drawing.Point(1238, 29);
            this.btnLoaiMH.Name = "btnLoaiMH";
            this.btnLoaiMH.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.btnLoaiMH.Size = new System.Drawing.Size(147, 26);
            this.btnLoaiMH.TabIndex = 23;
            // 
            // lblLoaiMH
            // 
            this.lblLoaiMH.AutoSize = true;
            this.lblLoaiMH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiMH.Location = new System.Drawing.Point(1194, 38);
            this.lblLoaiMH.Name = "lblLoaiMH";
            this.lblLoaiMH.Size = new System.Drawing.Size(38, 20);
            this.lblLoaiMH.TabIndex = 26;
            this.lblLoaiMH.Text = "Loại";
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.BackColor = System.Drawing.Color.Transparent;
            this.btnChuyenBan.BorderRadius = 2;
            this.btnChuyenBan.BorderThickness = 1;
            this.btnChuyenBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuyenBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyenBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyenBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChuyenBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChuyenBan.Enabled = false;
            this.btnChuyenBan.FillColor = System.Drawing.Color.White;
            this.btnChuyenBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChuyenBan.ForeColor = System.Drawing.Color.Black;
            this.btnChuyenBan.Image = global::GUI.Properties.Resources.transfer_table;
            this.btnChuyenBan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChuyenBan.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnChuyenBan.ImageSize = new System.Drawing.Size(25, 25);
            this.btnChuyenBan.Location = new System.Drawing.Point(204, 361);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(114, 46);
            this.btnChuyenBan.TabIndex = 25;
            this.btnChuyenBan.Text = " Chuyển bàn";
            this.btnChuyenBan.TextOffset = new System.Drawing.Point(13, 0);
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // btnGopBan
            // 
            this.btnGopBan.BorderRadius = 2;
            this.btnGopBan.BorderThickness = 1;
            this.btnGopBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGopBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGopBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGopBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGopBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGopBan.Enabled = false;
            this.btnGopBan.FillColor = System.Drawing.Color.White;
            this.btnGopBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGopBan.ForeColor = System.Drawing.Color.Black;
            this.btnGopBan.Image = global::GUI.Properties.Resources.combine_table;
            this.btnGopBan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGopBan.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnGopBan.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGopBan.Location = new System.Drawing.Point(324, 361);
            this.btnGopBan.Name = "btnGopBan";
            this.btnGopBan.Size = new System.Drawing.Size(114, 46);
            this.btnGopBan.TabIndex = 24;
            this.btnGopBan.Text = "       Gộp         bàn";
            this.btnGopBan.TextOffset = new System.Drawing.Point(14, 0);
            this.btnGopBan.Click += new System.EventHandler(this.btnGopBan_Click);
            // 
            // btnHuyOder
            // 
            this.btnHuyOder.BorderRadius = 2;
            this.btnHuyOder.BorderThickness = 1;
            this.btnHuyOder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyOder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyOder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyOder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuyOder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuyOder.Enabled = false;
            this.btnHuyOder.FillColor = System.Drawing.Color.White;
            this.btnHuyOder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuyOder.ForeColor = System.Drawing.Color.Black;
            this.btnHuyOder.Image = global::GUI.Properties.Resources.cancel;
            this.btnHuyOder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHuyOder.Location = new System.Drawing.Point(444, 361);
            this.btnHuyOder.Name = "btnHuyOder";
            this.btnHuyOder.Size = new System.Drawing.Size(114, 46);
            this.btnHuyOder.TabIndex = 17;
            this.btnHuyOder.Text = "     Hủy      Oder";
            this.btnHuyOder.TextOffset = new System.Drawing.Point(13, 0);
            this.btnHuyOder.Click += new System.EventHandler(this.btnHuyOder_Click);
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.BorderRadius = 2;
            this.btnTaoHD.BorderThickness = 1;
            this.btnTaoHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaoHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaoHD.Enabled = false;
            this.btnTaoHD.FillColor = System.Drawing.Color.White;
            this.btnTaoHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTaoHD.ForeColor = System.Drawing.Color.Black;
            this.btnTaoHD.Image = global::GUI.Properties.Resources.edit;
            this.btnTaoHD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTaoHD.ImageSize = new System.Drawing.Size(24, 24);
            this.btnTaoHD.Location = new System.Drawing.Point(564, 361);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(114, 46);
            this.btnTaoHD.TabIndex = 16;
            this.btnTaoHD.Text = "        Gọi           món";
            this.btnTaoHD.TextOffset = new System.Drawing.Point(7, 0);
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhuVuc.Location = new System.Drawing.Point(460, 34);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(66, 20);
            this.lblKhuVuc.TabIndex = 26;
            this.lblKhuVuc.Text = "Khu vực";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 60);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Size = new System.Drawing.Size(666, 295);
            this.guna2Panel1.TabIndex = 29;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.containerOder);
            this.guna2Panel2.Location = new System.Drawing.Point(688, 60);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel2.Size = new System.Drawing.Size(699, 524);
            this.guna2Panel2.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1397, 715);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.lblLoaiMH);
            this.Controls.Add(this.lblKhuVuc);
            this.Controls.Add(this.btnChuyenBan);
            this.Controls.Add(this.btnGopBan);
            this.Controls.Add(this.btnLoaiMH);
            this.Controls.Add(this.cboKhuVuc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnHuyOder);
            this.Controls.Add(this.btnTaoHD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.containerBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblBan);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.FlowLayoutPanel containerOder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel containerCTHD;
        private System.Windows.Forms.Label lblBan;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnTaoHD;
        private Guna.UI2.WinForms.Guna2Button btnHuyOder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTongTT;
        private Guna.UI2.WinForms.Guna2TextBox txtGiam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGiam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel containerBan;
        private Guna.UI2.WinForms.Guna2ComboBox cboKhuVuc;
        private Guna.UI2.WinForms.Guna2ComboBox btnLoaiMH;
        private Guna.UI2.WinForms.Guna2Button btnGopBan;
        private Guna.UI2.WinForms.Guna2Button btnChuyenBan;
        private System.Windows.Forms.Label lblLoaiMH;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnInHD;
        private Guna.UI2.WinForms.Guna2Button btnDonBan;
        private System.Windows.Forms.Label lblKhuVuc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}

