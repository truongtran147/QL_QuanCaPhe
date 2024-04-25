namespace GUI
{
    partial class frmDSBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKhuVuc = new System.Windows.Forms.DataGridView();
            this.makvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.khuvucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new GUI.DataSet1();
            this.khuvucTableAdapter = new GUI.DataSet1TableAdapters.khuvucTableAdapter();
            this.btnThemKV = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreshKV = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuuKV = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenKV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenKV = new System.Windows.Forms.Label();
            this.btnOK = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnCancel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.dgvBan = new System.Windows.Forms.DataGridView();
            this.mabanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenbanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makvDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.banBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banTableAdapter = new GUI.DataSet1TableAdapters.banTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboKhuVuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnOKBan = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtTenBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancelBan = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuuBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreshBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemBan = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhuVuc
            // 
            this.dgvKhuVuc.AllowUserToAddRows = false;
            this.dgvKhuVuc.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhuVuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhuVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhuVuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makvDataGridViewTextBoxColumn,
            this.tenkvDataGridViewTextBoxColumn,
            this.btnXoa,
            this.btnSua});
            this.dgvKhuVuc.DataSource = this.khuvucBindingSource;
            this.dgvKhuVuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvKhuVuc.Location = new System.Drawing.Point(40, 59);
            this.dgvKhuVuc.Name = "dgvKhuVuc";
            this.dgvKhuVuc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvKhuVuc.RowHeadersVisible = false;
            this.dgvKhuVuc.RowHeadersWidth = 35;
            this.dgvKhuVuc.RowTemplate.Height = 24;
            this.dgvKhuVuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhuVuc.Size = new System.Drawing.Size(358, 378);
            this.dgvKhuVuc.TabIndex = 1;
            this.dgvKhuVuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvKhuVuc.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating);
            // 
            // makvDataGridViewTextBoxColumn
            // 
            this.makvDataGridViewTextBoxColumn.DataPropertyName = "makv";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.makvDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.makvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.makvDataGridViewTextBoxColumn.Name = "makvDataGridViewTextBoxColumn";
            this.makvDataGridViewTextBoxColumn.ReadOnly = true;
            this.makvDataGridViewTextBoxColumn.Width = 60;
            // 
            // tenkvDataGridViewTextBoxColumn
            // 
            this.tenkvDataGridViewTextBoxColumn.DataPropertyName = "tenkv";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenkvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.tenkvDataGridViewTextBoxColumn.HeaderText = "Tên KV";
            this.tenkvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenkvDataGridViewTextBoxColumn.Name = "tenkvDataGridViewTextBoxColumn";
            this.tenkvDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenkvDataGridViewTextBoxColumn.Width = 115;
            // 
            // btnXoa
            // 
            this.btnXoa.HeaderText = "Xóa";
            this.btnXoa.MinimumWidth = 6;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseColumnTextForButtonValue = true;
            this.btnXoa.Width = 45;
            // 
            // btnSua
            // 
            this.btnSua.HeaderText = "Sửa";
            this.btnSua.MinimumWidth = 6;
            this.btnSua.Name = "btnSua";
            this.btnSua.Text = "Sửa";
            this.btnSua.UseColumnTextForButtonValue = true;
            this.btnSua.Width = 45;
            // 
            // khuvucBindingSource
            // 
            this.khuvucBindingSource.DataMember = "khuvuc";
            this.khuvucBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khuvucTableAdapter
            // 
            this.khuvucTableAdapter.ClearBeforeFill = true;
            // 
            // btnThemKV
            // 
            this.btnThemKV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemKV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemKV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemKV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemKV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemKV.ForeColor = System.Drawing.Color.White;
            this.btnThemKV.Location = new System.Drawing.Point(169, 456);
            this.btnThemKV.Name = "btnThemKV";
            this.btnThemKV.Size = new System.Drawing.Size(100, 45);
            this.btnThemKV.TabIndex = 2;
            this.btnThemKV.Text = "Thêm KV";
            this.btnThemKV.Click += new System.EventHandler(this.btnThemKV_Click);
            // 
            // btnRefreshKV
            // 
            this.btnRefreshKV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshKV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshKV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshKV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshKV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshKV.ForeColor = System.Drawing.Color.White;
            this.btnRefreshKV.Location = new System.Drawing.Point(40, 456);
            this.btnRefreshKV.Name = "btnRefreshKV";
            this.btnRefreshKV.Size = new System.Drawing.Size(100, 45);
            this.btnRefreshKV.TabIndex = 3;
            this.btnRefreshKV.Text = "Làm mới";
            this.btnRefreshKV.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLuuKV
            // 
            this.btnLuuKV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuKV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuKV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuKV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuKV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuuKV.ForeColor = System.Drawing.Color.White;
            this.btnLuuKV.Location = new System.Drawing.Point(298, 456);
            this.btnLuuKV.Name = "btnLuuKV";
            this.btnLuuKV.Size = new System.Drawing.Size(100, 45);
            this.btnLuuKV.TabIndex = 4;
            this.btnLuuKV.Text = "Lưu";
            this.btnLuuKV.Click += new System.EventHandler(this.btnLuuKV_Click);
            // 
            // txtTenKV
            // 
            this.txtTenKV.BorderRadius = 10;
            this.txtTenKV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKV.DefaultText = "";
            this.txtTenKV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKV.Location = new System.Drawing.Point(100, 2);
            this.txtTenKV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKV.Name = "txtTenKV";
            this.txtTenKV.PasswordChar = '\0';
            this.txtTenKV.PlaceholderText = "";
            this.txtTenKV.SelectedText = "";
            this.txtTenKV.Size = new System.Drawing.Size(161, 34);
            this.txtTenKV.TabIndex = 5;
            // 
            // lblTenKV
            // 
            this.lblTenKV.AutoSize = true;
            this.lblTenKV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKV.Location = new System.Drawing.Point(3, 10);
            this.lblTenKV.Name = "lblTenKV";
            this.lblTenKV.Size = new System.Drawing.Size(91, 20);
            this.lblTenKV.TabIndex = 6;
            this.lblTenKV.Text = "Tên khu vực";
            // 
            // btnOK
            // 
            this.btnOK.BorderThickness = 1;
            this.btnOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOK.FillColor = System.Drawing.Color.Transparent;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOK.Location = new System.Drawing.Point(272, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnOK.Size = new System.Drawing.Size(40, 35);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "✔";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(318, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCancel.Size = new System.Drawing.Size(40, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "✘";
            this.btnCancel.TextOffset = new System.Drawing.Point(1, -1);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhuVuc.Location = new System.Drawing.Point(35, 28);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(101, 31);
            this.lblKhuVuc.TabIndex = 12;
            this.lblKhuVuc.Text = "Khu vực";
            // 
            // dgvBan
            // 
            this.dgvBan.AllowUserToAddRows = false;
            this.dgvBan.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mabanDataGridViewTextBoxColumn,
            this.tenbanDataGridViewTextBoxColumn,
            this.makvDataGridViewTextBoxColumn1,
            this.trangthaiDataGridViewTextBoxColumn,
            this.Column1,
            this.update});
            this.dgvBan.DataSource = this.banBindingSource;
            this.dgvBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvBan.Location = new System.Drawing.Point(441, 59);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBan.RowHeadersVisible = false;
            this.dgvBan.RowHeadersWidth = 35;
            this.dgvBan.RowTemplate.Height = 24;
            this.dgvBan.Size = new System.Drawing.Size(756, 378);
            this.dgvBan.TabIndex = 13;
            this.dgvBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBan_CellContentClick);
            // 
            // mabanDataGridViewTextBoxColumn
            // 
            this.mabanDataGridViewTextBoxColumn.DataPropertyName = "maban";
            this.mabanDataGridViewTextBoxColumn.HeaderText = "maban";
            this.mabanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mabanDataGridViewTextBoxColumn.Name = "mabanDataGridViewTextBoxColumn";
            this.mabanDataGridViewTextBoxColumn.ReadOnly = true;
            this.mabanDataGridViewTextBoxColumn.Width = 70;
            // 
            // tenbanDataGridViewTextBoxColumn
            // 
            this.tenbanDataGridViewTextBoxColumn.DataPropertyName = "tenban";
            this.tenbanDataGridViewTextBoxColumn.HeaderText = "tenban";
            this.tenbanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenbanDataGridViewTextBoxColumn.Name = "tenbanDataGridViewTextBoxColumn";
            this.tenbanDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenbanDataGridViewTextBoxColumn.Width = 125;
            // 
            // makvDataGridViewTextBoxColumn1
            // 
            this.makvDataGridViewTextBoxColumn1.DataPropertyName = "makv";
            this.makvDataGridViewTextBoxColumn1.HeaderText = "makv";
            this.makvDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.makvDataGridViewTextBoxColumn1.Name = "makvDataGridViewTextBoxColumn1";
            this.makvDataGridViewTextBoxColumn1.ReadOnly = true;
            this.makvDataGridViewTextBoxColumn1.Width = 125;
            // 
            // trangthaiDataGridViewTextBoxColumn
            // 
            this.trangthaiDataGridViewTextBoxColumn.DataPropertyName = "trangthai";
            this.trangthaiDataGridViewTextBoxColumn.HeaderText = "trangthai";
            this.trangthaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangthaiDataGridViewTextBoxColumn.Name = "trangthaiDataGridViewTextBoxColumn";
            this.trangthaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.trangthaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Xóa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Text = "Xóa";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 50;
            // 
            // update
            // 
            this.update.HeaderText = "Sửa";
            this.update.MinimumWidth = 6;
            this.update.Name = "update";
            this.update.Text = "Sửa";
            this.update.UseColumnTextForButtonValue = true;
            this.update.Width = 50;
            // 
            // banBindingSource
            // 
            this.banBindingSource.DataMember = "ban";
            this.banBindingSource.DataSource = this.dataSet1;
            // 
            // banTableAdapter
            // 
            this.banTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTenKV);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtTenKV);
            this.panel1.Location = new System.Drawing.Point(40, 507);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 40);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboKhuVuc);
            this.panel2.Controls.Add(this.btnOKBan);
            this.panel2.Controls.Add(this.txtTenBan);
            this.panel2.Controls.Add(this.btnCancelBan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(434, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 40);
            this.panel2.TabIndex = 15;
            this.panel2.Visible = false;
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.BackColor = System.Drawing.Color.Transparent;
            this.cboKhuVuc.BorderRadius = 5;
            this.cboKhuVuc.DataSource = this.khuvucBindingSource;
            this.cboKhuVuc.DisplayMember = "tenkv";
            this.cboKhuVuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhuVuc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKhuVuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKhuVuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKhuVuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboKhuVuc.ItemHeight = 24;
            this.cboKhuVuc.Location = new System.Drawing.Point(462, 2);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(201, 30);
            this.cboKhuVuc.TabIndex = 9;
            this.cboKhuVuc.ValueMember = "makv";
            // 
            // btnOKBan
            // 
            this.btnOKBan.BorderThickness = 1;
            this.btnOKBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOKBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOKBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOKBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOKBan.FillColor = System.Drawing.Color.Transparent;
            this.btnOKBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOKBan.Location = new System.Drawing.Point(678, 1);
            this.btnOKBan.Name = "btnOKBan";
            this.btnOKBan.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnOKBan.Size = new System.Drawing.Size(40, 35);
            this.btnOKBan.TabIndex = 12;
            this.btnOKBan.Text = "✔";
            this.btnOKBan.Click += new System.EventHandler(this.btnOKBan_Click);
            // 
            // txtTenBan
            // 
            this.txtTenBan.BorderRadius = 10;
            this.txtTenBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenBan.DefaultText = "";
            this.txtTenBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenBan.Location = new System.Drawing.Point(191, 2);
            this.txtTenBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.PasswordChar = '\0';
            this.txtTenBan.PlaceholderText = "";
            this.txtTenBan.SelectedText = "";
            this.txtTenBan.Size = new System.Drawing.Size(161, 34);
            this.txtTenBan.TabIndex = 7;
            // 
            // btnCancelBan
            // 
            this.btnCancelBan.BorderThickness = 1;
            this.btnCancelBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelBan.FillColor = System.Drawing.Color.Transparent;
            this.btnCancelBan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelBan.Location = new System.Drawing.Point(724, 1);
            this.btnCancelBan.Name = "btnCancelBan";
            this.btnCancelBan.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCancelBan.Size = new System.Drawing.Size(40, 35);
            this.btnCancelBan.TabIndex = 13;
            this.btnCancelBan.Text = "✘";
            this.btnCancelBan.TextOffset = new System.Drawing.Point(1, -1);
            this.btnCancelBan.Click += new System.EventHandler(this.btnCancelBan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Khu vực";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên bàn";
            // 
            // btnLuuBan
            // 
            this.btnLuuBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuuBan.ForeColor = System.Drawing.Color.White;
            this.btnLuuBan.Location = new System.Drawing.Point(1097, 456);
            this.btnLuuBan.Name = "btnLuuBan";
            this.btnLuuBan.Size = new System.Drawing.Size(100, 45);
            this.btnLuuBan.TabIndex = 18;
            this.btnLuuBan.Text = "Lưu";
            this.btnLuuBan.Click += new System.EventHandler(this.btnLuuBan_Click);
            // 
            // btnRefreshBan
            // 
            this.btnRefreshBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshBan.ForeColor = System.Drawing.Color.White;
            this.btnRefreshBan.Location = new System.Drawing.Point(839, 456);
            this.btnRefreshBan.Name = "btnRefreshBan";
            this.btnRefreshBan.Size = new System.Drawing.Size(100, 45);
            this.btnRefreshBan.TabIndex = 17;
            this.btnRefreshBan.Text = "Làm mới";
            this.btnRefreshBan.Click += new System.EventHandler(this.btnRefreshBan_Click);
            // 
            // btnThemBan
            // 
            this.btnThemBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemBan.ForeColor = System.Drawing.Color.White;
            this.btnThemBan.Location = new System.Drawing.Point(968, 456);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(100, 45);
            this.btnThemBan.TabIndex = 16;
            this.btnThemBan.Text = "Thêm bàn";
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Bàn";
            // 
            // frmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 715);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLuuBan);
            this.Controls.Add(this.btnRefreshBan);
            this.Controls.Add(this.btnThemBan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBan);
            this.Controls.Add(this.lblKhuVuc);
            this.Controls.Add(this.btnLuuKV);
            this.Controls.Add(this.btnRefreshKV);
            this.Controls.Add(this.btnThemKV);
            this.Controls.Add(this.dgvKhuVuc);
            this.Name = "frmMatHang";
            this.Text = "frmMatHang";
            this.Load += new System.EventHandler(this.frmMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKhuVuc;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource khuvucBindingSource;
        private DataSet1TableAdapters.khuvucTableAdapter khuvucTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnThemKV;
        private Guna.UI2.WinForms.Guna2Button btnRefreshKV;
        private Guna.UI2.WinForms.Guna2Button btnLuuKV;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKV;
        private System.Windows.Forms.Label lblTenKV;
        private Guna.UI2.WinForms.Guna2CircleButton btnOK;
        private Guna.UI2.WinForms.Guna2CircleButton btnCancel;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.DataGridView dgvBan;
        private System.Windows.Forms.BindingSource banBindingSource;
        private DataSet1TableAdapters.banTableAdapter banTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cboKhuVuc;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenBan;
        private Guna.UI2.WinForms.Guna2Button btnLuuBan;
        private Guna.UI2.WinForms.Guna2Button btnRefreshBan;
        private Guna.UI2.WinForms.Guna2Button btnThemBan;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton btnOKBan;
        private Guna.UI2.WinForms.Guna2CircleButton btnCancelBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn makvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
        private System.Windows.Forms.DataGridViewButtonColumn btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenbanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makvDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn update;
    }
}