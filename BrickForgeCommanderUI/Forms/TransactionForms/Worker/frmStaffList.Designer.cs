namespace BrickForgeCommanderUI.Forms.TransactionForms.Worker
{
    partial class frmStaffList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMaximize = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDocument = new System.Windows.Forms.DataGridView();
            this.btnRefesh = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.btnPrint = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.btnNewRegistration = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.btnSearch = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.txtBloodGroup = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.txtBatch = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.txtCity = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.txtName = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.bFCDataSet = new BrickForgeCommanderUI.BFCDataSet();
            this.staffListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffListTableAdapter = new BrickForgeCommanderUI.BFCDataSetTableAdapters.StaffListTableAdapter();
            this.workerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerVendorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentImageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlMain.Controls.Add(this.btnRefesh);
            this.pnlMain.Controls.Add(this.btnPrint);
            this.pnlMain.Controls.Add(this.btnNewRegistration);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.panel5);
            this.pnlMain.Controls.Add(this.panel6);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 49);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1200, 951);
            this.pnlMain.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.tableLayoutPanel3);
            this.panel5.Location = new System.Drawing.Point(617, 159);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(538, 67);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Location = new System.Drawing.Point(12, 415);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1176, 524);
            this.panel6.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.tableLayoutPanel4);
            this.panel4.Location = new System.Drawing.Point(51, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(545, 67);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Location = new System.Drawing.Point(617, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 67);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(51, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 67);
            this.panel1.TabIndex = 1;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.pbClose);
            this.flowLayoutPanel1.Controls.Add(this.pbMaximize);
            this.flowLayoutPanel1.Controls.Add(this.pbMinimize);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1057, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(143, 38);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 30);
            this.label11.TabIndex = 4;
            this.label11.Text = "Staff List Preview";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.63306F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.36694F));
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.94695F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.05304F));
            this.tableLayoutPanel3.Controls.Add(this.txtBloodGroup, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(538, 67);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.68884F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.31116F));
            this.tableLayoutPanel4.Controls.Add(this.txtBatch, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(545, 67);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Blood Group:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Batch Name:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.67517F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.32484F));
            this.tableLayoutPanel2.Controls.Add(this.txtCity, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(538, 67);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "City:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDocument);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(9, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1158, 502);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Staff List";
            // 
            // dgvDocument
            // 
            this.dgvDocument.AllowUserToAddRows = false;
            this.dgvDocument.AutoGenerateColumns = false;
            this.dgvDocument.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDocument.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDocument.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocument.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerIdDataGridViewTextBoxColumn,
            this.workerVendorIdDataGridViewTextBoxColumn,
            this.batchIdDataGridViewTextBoxColumn,
            this.roleIdDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn,
            this.vendorIdDataGridViewTextBoxColumn,
            this.vendorNameDataGridViewTextBoxColumn,
            this.vendorAddressDataGridViewTextBoxColumn,
            this.cityIdDataGridViewTextBoxColumn,
            this.cityNameDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn,
            this.vendorTypeIdDataGridViewTextBoxColumn,
            this.vendorTypeNameDataGridViewTextBoxColumn,
            this.documentIdDataGridViewTextBoxColumn,
            this.documentNameDataGridViewTextBoxColumn,
            this.documentImageDataGridViewTextBoxColumn});
            this.dgvDocument.DataSource = this.staffListBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocument.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocument.Location = new System.Drawing.Point(15, 48);
            this.dgvDocument.Name = "dgvDocument";
            this.dgvDocument.RowHeadersVisible = false;
            this.dgvDocument.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDocument.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDocument.RowTemplate.Height = 40;
            this.dgvDocument.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDocument.Size = new System.Drawing.Size(1131, 440);
            this.dgvDocument.TabIndex = 6;
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
            this.btnRefesh.Location = new System.Drawing.Point(609, 257);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(166, 47);
            this.btnRefesh.TabIndex = 11;
            this.btnRefesh.Text = "Refresh";
            this.btnRefesh.TextColor = System.Drawing.Color.White;
            this.btnRefesh.UseVisualStyleBackColor = false;
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
            this.btnPrint.Location = new System.Drawing.Point(1045, 359);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(143, 47);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextColor = System.Drawing.Color.White;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnNewRegistration
            // 
            this.btnNewRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.btnNewRegistration.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.btnNewRegistration.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNewRegistration.BorderFocusColor = System.Drawing.Color.Green;
            this.btnNewRegistration.BorderRadius = 10;
            this.btnNewRegistration.BorderSize = 0;
            this.btnNewRegistration.ClickKey = System.Windows.Forms.Keys.None;
            this.btnNewRegistration.FlatAppearance.BorderSize = 0;
            this.btnNewRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRegistration.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRegistration.ForeColor = System.Drawing.Color.Black;
            this.btnNewRegistration.Location = new System.Drawing.Point(825, 359);
            this.btnNewRegistration.Name = "btnNewRegistration";
            this.btnNewRegistration.Size = new System.Drawing.Size(214, 47);
            this.btnNewRegistration.TabIndex = 11;
            this.btnNewRegistration.Text = "New Registration";
            this.btnNewRegistration.TextColor = System.Drawing.Color.Black;
            this.btnNewRegistration.UseVisualStyleBackColor = false;
            this.btnNewRegistration.Click += new System.EventHandler(this.btnNewRegistration_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(438, 257);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(166, 47);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBloodGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtBloodGroup.BorderColor = System.Drawing.Color.Ivory;
            this.txtBloodGroup.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBloodGroup.BorderRadius = 0;
            this.txtBloodGroup.BorderSize = 2;
            this.txtBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBloodGroup.ForeColor = System.Drawing.Color.Ivory;
            this.txtBloodGroup.Location = new System.Drawing.Point(213, 14);
            this.txtBloodGroup.Margin = new System.Windows.Forms.Padding(4);
            this.txtBloodGroup.MultiLine = false;
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBloodGroup.PasswordChar = false;
            this.txtBloodGroup.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtBloodGroup.PlaceHolderText = "";
            this.txtBloodGroup.Size = new System.Drawing.Size(231, 39);
            this.txtBloodGroup.TabIndex = 4;
            this.txtBloodGroup.TextBoxText = "";
            this.txtBloodGroup.Texts = "";
            this.txtBloodGroup.UnderLineStyle = true;
            // 
            // txtBatch
            // 
            this.txtBatch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtBatch.BorderColor = System.Drawing.Color.Ivory;
            this.txtBatch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBatch.BorderRadius = 0;
            this.txtBatch.BorderSize = 2;
            this.txtBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBatch.ForeColor = System.Drawing.Color.Ivory;
            this.txtBatch.Location = new System.Drawing.Point(187, 14);
            this.txtBatch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBatch.MultiLine = false;
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBatch.PasswordChar = false;
            this.txtBatch.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtBatch.PlaceHolderText = "";
            this.txtBatch.Size = new System.Drawing.Size(279, 39);
            this.txtBatch.TabIndex = 4;
            this.txtBatch.TextBoxText = "";
            this.txtBatch.Texts = "";
            this.txtBatch.UnderLineStyle = true;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtCity.BorderColor = System.Drawing.Color.Ivory;
            this.txtCity.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCity.BorderRadius = 0;
            this.txtCity.BorderSize = 2;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtCity.ForeColor = System.Drawing.Color.Ivory;
            this.txtCity.Location = new System.Drawing.Point(111, 14);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.MultiLine = false;
            this.txtCity.Name = "txtCity";
            this.txtCity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCity.PasswordChar = false;
            this.txtCity.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtCity.PlaceHolderText = "";
            this.txtCity.Size = new System.Drawing.Size(231, 39);
            this.txtCity.TabIndex = 4;
            this.txtCity.TextBoxText = "";
            this.txtCity.Texts = "";
            this.txtCity.UnderLineStyle = true;
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
            this.txtName.Location = new System.Drawing.Point(181, 14);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceHolderText = "";
            this.txtName.Size = new System.Drawing.Size(285, 39);
            this.txtName.TabIndex = 4;
            this.txtName.TextBoxText = "";
            this.txtName.Texts = "";
            this.txtName.UnderLineStyle = true;
            // 
            // bFCDataSet
            // 
            this.bFCDataSet.DataSetName = "BFCDataSet";
            this.bFCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffListBindingSource
            // 
            this.staffListBindingSource.DataMember = "StaffList";
            this.staffListBindingSource.DataSource = this.bFCDataSet;
            // 
            // staffListTableAdapter
            // 
            this.staffListTableAdapter.ClearBeforeFill = true;
            // 
            // workerIdDataGridViewTextBoxColumn
            // 
            this.workerIdDataGridViewTextBoxColumn.DataPropertyName = "WorkerId";
            this.workerIdDataGridViewTextBoxColumn.HeaderText = "WorkerId";
            this.workerIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.workerIdDataGridViewTextBoxColumn.Name = "workerIdDataGridViewTextBoxColumn";
            this.workerIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // workerVendorIdDataGridViewTextBoxColumn
            // 
            this.workerVendorIdDataGridViewTextBoxColumn.DataPropertyName = "WorkerVendorId";
            this.workerVendorIdDataGridViewTextBoxColumn.HeaderText = "WorkerVendorId";
            this.workerVendorIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.workerVendorIdDataGridViewTextBoxColumn.Name = "workerVendorIdDataGridViewTextBoxColumn";
            this.workerVendorIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // batchIdDataGridViewTextBoxColumn
            // 
            this.batchIdDataGridViewTextBoxColumn.DataPropertyName = "BatchId";
            this.batchIdDataGridViewTextBoxColumn.HeaderText = "BatchId";
            this.batchIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.batchIdDataGridViewTextBoxColumn.Name = "batchIdDataGridViewTextBoxColumn";
            this.batchIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // roleIdDataGridViewTextBoxColumn
            // 
            this.roleIdDataGridViewTextBoxColumn.DataPropertyName = "RoleId";
            this.roleIdDataGridViewTextBoxColumn.HeaderText = "RoleId";
            this.roleIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roleIdDataGridViewTextBoxColumn.Name = "roleIdDataGridViewTextBoxColumn";
            this.roleIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            this.roleNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // vendorIdDataGridViewTextBoxColumn
            // 
            this.vendorIdDataGridViewTextBoxColumn.DataPropertyName = "VendorId";
            this.vendorIdDataGridViewTextBoxColumn.HeaderText = "VendorId";
            this.vendorIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vendorIdDataGridViewTextBoxColumn.Name = "vendorIdDataGridViewTextBoxColumn";
            this.vendorIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // vendorNameDataGridViewTextBoxColumn
            // 
            this.vendorNameDataGridViewTextBoxColumn.DataPropertyName = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.HeaderText = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vendorNameDataGridViewTextBoxColumn.Name = "vendorNameDataGridViewTextBoxColumn";
            this.vendorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendorNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // vendorAddressDataGridViewTextBoxColumn
            // 
            this.vendorAddressDataGridViewTextBoxColumn.DataPropertyName = "VendorAddress";
            this.vendorAddressDataGridViewTextBoxColumn.HeaderText = "VendorAddress";
            this.vendorAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vendorAddressDataGridViewTextBoxColumn.Name = "vendorAddressDataGridViewTextBoxColumn";
            this.vendorAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityIdDataGridViewTextBoxColumn
            // 
            this.cityIdDataGridViewTextBoxColumn.DataPropertyName = "CityId";
            this.cityIdDataGridViewTextBoxColumn.HeaderText = "CityId";
            this.cityIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cityIdDataGridViewTextBoxColumn.Name = "cityIdDataGridViewTextBoxColumn";
            this.cityIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            this.cityNameDataGridViewTextBoxColumn.DataPropertyName = "CityName";
            this.cityNameDataGridViewTextBoxColumn.HeaderText = "CityName";
            this.cityNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            this.cityNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneNoDataGridViewTextBoxColumn
            // 
            this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.HeaderText = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
            this.phoneNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // vendorTypeIdDataGridViewTextBoxColumn
            // 
            this.vendorTypeIdDataGridViewTextBoxColumn.DataPropertyName = "VendorTypeId";
            this.vendorTypeIdDataGridViewTextBoxColumn.HeaderText = "VendorTypeId";
            this.vendorTypeIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vendorTypeIdDataGridViewTextBoxColumn.Name = "vendorTypeIdDataGridViewTextBoxColumn";
            this.vendorTypeIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // vendorTypeNameDataGridViewTextBoxColumn
            // 
            this.vendorTypeNameDataGridViewTextBoxColumn.DataPropertyName = "VendorTypeName";
            this.vendorTypeNameDataGridViewTextBoxColumn.HeaderText = "VendorTypeName";
            this.vendorTypeNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vendorTypeNameDataGridViewTextBoxColumn.Name = "vendorTypeNameDataGridViewTextBoxColumn";
            this.vendorTypeNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // documentIdDataGridViewTextBoxColumn
            // 
            this.documentIdDataGridViewTextBoxColumn.DataPropertyName = "DocumentId";
            this.documentIdDataGridViewTextBoxColumn.HeaderText = "DocumentId";
            this.documentIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.documentIdDataGridViewTextBoxColumn.Name = "documentIdDataGridViewTextBoxColumn";
            this.documentIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // documentNameDataGridViewTextBoxColumn
            // 
            this.documentNameDataGridViewTextBoxColumn.DataPropertyName = "DocumentName";
            this.documentNameDataGridViewTextBoxColumn.HeaderText = "DocumentName";
            this.documentNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.documentNameDataGridViewTextBoxColumn.Name = "documentNameDataGridViewTextBoxColumn";
            this.documentNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // documentImageDataGridViewTextBoxColumn
            // 
            this.documentImageDataGridViewTextBoxColumn.DataPropertyName = "DocumentImage";
            this.documentImageDataGridViewTextBoxColumn.HeaderText = "DocumentImage";
            this.documentImageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.documentImageDataGridViewTextBoxColumn.Name = "documentImageDataGridViewTextBoxColumn";
            this.documentImageDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmStaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1200, 1000);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStaffList";
            this.Text = "frmWorkersRegisteration";
            this.Load += new System.EventHandler(this.frmStaffList_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmWorkersRegistration_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmWorkersRegistration_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmWorkersRegistration_MouseUp);
            this.pnlMain.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMaximize;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Controls.BFC_Button btnRefesh;
        private Controls.BFC_Button btnSearch;
        private Controls.BFC_Button btnPrint;
        private Controls.BFC_Button btnNewRegistration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private Controls.BFC_TextBox txtBloodGroup;
        private Controls.BFC_TextBox txtBatch;
        private Controls.BFC_TextBox txtCity;
        private Controls.BFC_TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDocument;
        private BFCDataSet bFCDataSet;
        private System.Windows.Forms.BindingSource staffListBindingSource;
        private BFCDataSetTableAdapters.StaffListTableAdapter staffListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerVendorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentImageDataGridViewTextBoxColumn;
    }
}