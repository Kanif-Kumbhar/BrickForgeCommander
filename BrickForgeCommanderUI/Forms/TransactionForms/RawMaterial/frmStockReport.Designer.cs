namespace BrickForgeCommanderUI.Forms.TransactionForms.RawMaterial
{
    partial class frmStockReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRawMaterial = new System.Windows.Forms.DataGridView();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMaximize = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.clmSrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtStatus = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtName = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefesh = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.btnSearch = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.btnPrint = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnRefesh);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1372, 598);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.pbClose);
            this.flowLayoutPanel1.Controls.Add(this.pbMaximize);
            this.flowLayoutPanel1.Controls.Add(this.pbMinimize);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1229, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(143, 38);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(-1, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(323, 30);
            this.label11.TabIndex = 7;
            this.label11.Text = "Raw Material Stock Report";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Location = new System.Drawing.Point(12, 214);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1348, 372);
            this.panel6.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.dgvRawMaterial);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1323, 363);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Report";
            // 
            // dgvRawMaterial
            // 
            this.dgvRawMaterial.AllowUserToAddRows = false;
            this.dgvRawMaterial.AllowUserToResizeColumns = false;
            this.dgvRawMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvRawMaterial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRawMaterial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvRawMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSrNo,
            this.clmName,
            this.clmQuantity,
            this.clmCapacity,
            this.clmStatus,
            this.clmUnitPrice});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRawMaterial.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvRawMaterial.Location = new System.Drawing.Point(6, 36);
            this.dgvRawMaterial.Name = "dgvRawMaterial";
            this.dgvRawMaterial.RowHeadersVisible = false;
            this.dgvRawMaterial.RowHeadersWidth = 62;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            this.dgvRawMaterial.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvRawMaterial.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvRawMaterial.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMaterial.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRawMaterial.RowTemplate.Height = 40;
            this.dgvRawMaterial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRawMaterial.Size = new System.Drawing.Size(1311, 321);
            this.dgvRawMaterial.TabIndex = 7;
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(109, 10);
            this.pbClose.Margin = new System.Windows.Forms.Padding(10);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(24, 26);
            this.pbClose.TabIndex = 25;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbMaximize
            // 
            this.pbMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximize.Image")));
            this.pbMaximize.Location = new System.Drawing.Point(62, 10);
            this.pbMaximize.Margin = new System.Windows.Forms.Padding(10);
            this.pbMaximize.Name = "pbMaximize";
            this.pbMaximize.Size = new System.Drawing.Size(27, 26);
            this.pbMaximize.TabIndex = 24;
            this.pbMaximize.TabStop = false;
            this.pbMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimize.Image")));
            this.pbMinimize.Location = new System.Drawing.Point(20, 10);
            this.pbMinimize.Margin = new System.Windows.Forms.Padding(10);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(22, 26);
            this.pbMinimize.TabIndex = 23;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // clmSrNo
            // 
            this.clmSrNo.HeaderText = "Sr. No.";
            this.clmSrNo.MinimumWidth = 8;
            this.clmSrNo.Name = "clmSrNo";
            this.clmSrNo.ReadOnly = true;
            this.clmSrNo.Width = 130;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Material Name";
            this.clmName.MinimumWidth = 8;
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 305;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Stock Available";
            this.clmQuantity.MinimumWidth = 8;
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            this.clmQuantity.Width = 260;
            // 
            // clmCapacity
            // 
            this.clmCapacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCapacity.HeaderText = "Storage Capacity";
            this.clmCapacity.MinimumWidth = 8;
            this.clmCapacity.Name = "clmCapacity";
            // 
            // clmStatus
            // 
            this.clmStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmStatus.HeaderText = "Stock Status";
            this.clmStatus.MinimumWidth = 8;
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            // 
            // clmUnitPrice
            // 
            this.clmUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmUnitPrice.DefaultCellStyle = dataGridViewCellStyle22;
            this.clmUnitPrice.HeaderText = "Unit Price";
            this.clmUnitPrice.MinimumWidth = 8;
            this.clmUnitPrice.Name = "clmUnitPrice";
            this.clmUnitPrice.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Location = new System.Drawing.Point(683, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 67);
            this.panel3.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.67517F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.32484F));
            this.tableLayoutPanel2.Controls.Add(this.txtStatus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(538, 67);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtStatus.BorderColor = System.Drawing.Color.Ivory;
            this.txtStatus.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtStatus.BorderRadius = 0;
            this.txtStatus.BorderSize = 2;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtStatus.ForeColor = System.Drawing.Color.Ivory;
            this.txtStatus.Location = new System.Drawing.Point(201, 14);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.MultiLine = false;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStatus.PasswordChar = false;
            this.txtStatus.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtStatus.PlaceHolderText = "Eg. Understock";
            this.txtStatus.Size = new System.Drawing.Size(309, 39);
            this.txtStatus.TabIndex = 4;
            this.txtStatus.TextBoxText = "";
            this.txtStatus.Texts = "";
            this.txtStatus.UnderLineStyle = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock Status:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(131, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 67);
            this.panel1.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.14679F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.85321F));
            this.tableLayoutPanel1.Controls.Add(this.txtName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(545, 67);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtName.BorderColor = System.Drawing.Color.Ivory;
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtName.ForeColor = System.Drawing.Color.Ivory;
            this.txtName.Location = new System.Drawing.Point(201, 14);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceHolderText = "Eg. Coal";
            this.txtName.Size = new System.Drawing.Size(322, 39);
            this.txtName.TabIndex = 4;
            this.txtName.TextBoxText = "";
            this.txtName.Texts = "";
            this.txtName.UnderLineStyle = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Material Name:";
            // 
            // btnRefesh
            // 
            this.btnRefesh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefesh.BackColor = System.Drawing.Color.Coral;
            this.btnRefesh.BackgroundColor = System.Drawing.Color.Coral;
            this.btnRefesh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRefesh.BorderFocusColor = System.Drawing.Color.Green;
            this.btnRefesh.BorderRadius = 10;
            this.btnRefesh.BorderSize = 0;
            this.btnRefesh.ClickKey = System.Windows.Forms.Keys.None;
            this.btnRefesh.FlatAppearance.BorderSize = 0;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.ForeColor = System.Drawing.Color.White;
            this.btnRefesh.Location = new System.Drawing.Point(681, 89);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(166, 47);
            this.btnRefesh.TabIndex = 18;
            this.btnRefesh.Text = "Refresh";
            this.btnRefesh.TextColor = System.Drawing.Color.White;
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.BackgroundColor = System.Drawing.Color.Teal;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderFocusColor = System.Drawing.Color.Green;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.ClickKey = System.Windows.Forms.Keys.None;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(510, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(166, 47);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(173)))), ((int)(((byte)(1)))));
            this.btnPrint.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(173)))), ((int)(((byte)(1)))));
            this.btnPrint.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrint.BorderFocusColor = System.Drawing.Color.Green;
            this.btnPrint.BorderRadius = 10;
            this.btnPrint.BorderSize = 0;
            this.btnPrint.ClickKey = System.Windows.Forms.Keys.None;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1217, 161);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(143, 47);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextColor = System.Drawing.Color.White;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1372, 647);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStockReport";
            this.Text = "frmWorkersRegisteration";
            this.Activated += new System.EventHandler(this.frmStockReport_Activated);
            this.Load += new System.EventHandler(this.frmStockReport_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmWorkersRegistration_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmWorkersRegistration_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmWorkersRegistration_MouseUp);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMaximize;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitPrice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controls.BFC_TextBox txtStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.BFC_TextBox txtName;
        private System.Windows.Forms.Label label3;
        private Controls.BFC_Button btnRefesh;
        private Controls.BFC_Button btnSearch;
        private Controls.BFC_Button btnPrint;
    }
}