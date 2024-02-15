namespace BrickForgeCommanderUI.Forms.TransactionForms.Production
{
    partial class frmBricksPaymentSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBricksPaymentSetting));
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMaximize = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMakingQuantity = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMakingAmount = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDhulaiQuantity = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.txtDhulaiAmount = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNikashiQuantity = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.txtNikashiAmount = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxBrickType = new BrickForgeCommanderUI.Controls.BFC_ComboBox();
            this.btnClear = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.btnInsert = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.label11 = new System.Windows.Forms.Label();
            this.product = new BrickForgeCommanderUI.DataSet.Product();
            this.brickDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brickDetailsTableAdapter = new BrickForgeCommanderUI.DataSet.ProductTableAdapters.BrickDetailsTableAdapter();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1703, 521);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.pbClose);
            this.flowLayoutPanel1.Controls.Add(this.pbMaximize);
            this.flowLayoutPanel1.Controls.Add(this.pbMinimize);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1560, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(143, 38);
            this.flowLayoutPanel1.TabIndex = 2;
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
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Location = new System.Drawing.Point(25, 82);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(550, 372);
            this.panel6.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 363);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Making Payment";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(581, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 372);
            this.panel1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 363);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dhulai Payment";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(1137, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 372);
            this.panel3.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 363);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nikashi Payment";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.91822F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.08178F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMakingQuantity, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMakingAmount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtMakingQuantity
            // 
            this.txtMakingQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMakingQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtMakingQuantity.BorderColor = System.Drawing.Color.Ivory;
            this.txtMakingQuantity.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMakingQuantity.BorderRadius = 0;
            this.txtMakingQuantity.BorderSize = 2;
            this.txtMakingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtMakingQuantity.ForeColor = System.Drawing.Color.Ivory;
            this.txtMakingQuantity.Location = new System.Drawing.Point(208, 62);
            this.txtMakingQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtMakingQuantity.MultiLine = false;
            this.txtMakingQuantity.Name = "txtMakingQuantity";
            this.txtMakingQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMakingQuantity.PasswordChar = false;
            this.txtMakingQuantity.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtMakingQuantity.PlaceHolderText = "Eg. 1000";
            this.txtMakingQuantity.Size = new System.Drawing.Size(322, 39);
            this.txtMakingQuantity.TabIndex = 5;
            this.txtMakingQuantity.TextBoxText = "";
            this.txtMakingQuantity.Texts = "";
            this.txtMakingQuantity.UnderLineStyle = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bricks Quantity:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount:";
            // 
            // txtMakingAmount
            // 
            this.txtMakingAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMakingAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtMakingAmount.BorderColor = System.Drawing.Color.Ivory;
            this.txtMakingAmount.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMakingAmount.BorderRadius = 0;
            this.txtMakingAmount.BorderSize = 2;
            this.txtMakingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtMakingAmount.ForeColor = System.Drawing.Color.Ivory;
            this.txtMakingAmount.Location = new System.Drawing.Point(208, 225);
            this.txtMakingAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtMakingAmount.MultiLine = false;
            this.txtMakingAmount.Name = "txtMakingAmount";
            this.txtMakingAmount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMakingAmount.PasswordChar = false;
            this.txtMakingAmount.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtMakingAmount.PlaceHolderText = "Eg. Coal";
            this.txtMakingAmount.Size = new System.Drawing.Size(322, 39);
            this.txtMakingAmount.TabIndex = 5;
            this.txtMakingAmount.TextBoxText = "";
            this.txtMakingAmount.Texts = "";
            this.txtMakingAmount.UnderLineStyle = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.91822F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.08178F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDhulaiQuantity, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDhulaiAmount, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(538, 327);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bricks Quantity:";
            // 
            // txtDhulaiQuantity
            // 
            this.txtDhulaiQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDhulaiQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtDhulaiQuantity.BorderColor = System.Drawing.Color.Ivory;
            this.txtDhulaiQuantity.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDhulaiQuantity.BorderRadius = 0;
            this.txtDhulaiQuantity.BorderSize = 2;
            this.txtDhulaiQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtDhulaiQuantity.ForeColor = System.Drawing.Color.Ivory;
            this.txtDhulaiQuantity.Location = new System.Drawing.Point(208, 62);
            this.txtDhulaiQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtDhulaiQuantity.MultiLine = false;
            this.txtDhulaiQuantity.Name = "txtDhulaiQuantity";
            this.txtDhulaiQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDhulaiQuantity.PasswordChar = false;
            this.txtDhulaiQuantity.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtDhulaiQuantity.PlaceHolderText = "Eg. 1000";
            this.txtDhulaiQuantity.Size = new System.Drawing.Size(322, 39);
            this.txtDhulaiQuantity.TabIndex = 5;
            this.txtDhulaiQuantity.TextBoxText = "";
            this.txtDhulaiQuantity.Texts = "";
            this.txtDhulaiQuantity.UnderLineStyle = true;
            // 
            // txtDhulaiAmount
            // 
            this.txtDhulaiAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDhulaiAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtDhulaiAmount.BorderColor = System.Drawing.Color.Ivory;
            this.txtDhulaiAmount.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDhulaiAmount.BorderRadius = 0;
            this.txtDhulaiAmount.BorderSize = 2;
            this.txtDhulaiAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtDhulaiAmount.ForeColor = System.Drawing.Color.Ivory;
            this.txtDhulaiAmount.Location = new System.Drawing.Point(208, 225);
            this.txtDhulaiAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDhulaiAmount.MultiLine = false;
            this.txtDhulaiAmount.Name = "txtDhulaiAmount";
            this.txtDhulaiAmount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDhulaiAmount.PasswordChar = false;
            this.txtDhulaiAmount.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtDhulaiAmount.PlaceHolderText = "Eg. Coal";
            this.txtDhulaiAmount.Size = new System.Drawing.Size(322, 39);
            this.txtDhulaiAmount.TabIndex = 5;
            this.txtDhulaiAmount.TextBoxText = "";
            this.txtDhulaiAmount.Texts = "";
            this.txtDhulaiAmount.UnderLineStyle = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(88, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.91822F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.08178F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtNikashiQuantity, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtNikashiAmount, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(538, 327);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bricks Quantity:";
            // 
            // txtNikashiQuantity
            // 
            this.txtNikashiQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNikashiQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtNikashiQuantity.BorderColor = System.Drawing.Color.Ivory;
            this.txtNikashiQuantity.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNikashiQuantity.BorderRadius = 0;
            this.txtNikashiQuantity.BorderSize = 2;
            this.txtNikashiQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtNikashiQuantity.ForeColor = System.Drawing.Color.Ivory;
            this.txtNikashiQuantity.Location = new System.Drawing.Point(208, 62);
            this.txtNikashiQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtNikashiQuantity.MultiLine = false;
            this.txtNikashiQuantity.Name = "txtNikashiQuantity";
            this.txtNikashiQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNikashiQuantity.PasswordChar = false;
            this.txtNikashiQuantity.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtNikashiQuantity.PlaceHolderText = "Eg. 1000";
            this.txtNikashiQuantity.Size = new System.Drawing.Size(322, 39);
            this.txtNikashiQuantity.TabIndex = 5;
            this.txtNikashiQuantity.TextBoxText = "";
            this.txtNikashiQuantity.Texts = "";
            this.txtNikashiQuantity.UnderLineStyle = true;
            // 
            // txtNikashiAmount
            // 
            this.txtNikashiAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNikashiAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtNikashiAmount.BorderColor = System.Drawing.Color.Ivory;
            this.txtNikashiAmount.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNikashiAmount.BorderRadius = 0;
            this.txtNikashiAmount.BorderSize = 2;
            this.txtNikashiAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtNikashiAmount.ForeColor = System.Drawing.Color.Ivory;
            this.txtNikashiAmount.Location = new System.Drawing.Point(208, 225);
            this.txtNikashiAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtNikashiAmount.MultiLine = false;
            this.txtNikashiAmount.Name = "txtNikashiAmount";
            this.txtNikashiAmount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNikashiAmount.PasswordChar = false;
            this.txtNikashiAmount.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtNikashiAmount.PlaceHolderText = "Eg. Coal";
            this.txtNikashiAmount.Size = new System.Drawing.Size(322, 39);
            this.txtNikashiAmount.TabIndex = 5;
            this.txtNikashiAmount.TextBoxText = "";
            this.txtNikashiAmount.Texts = "";
            this.txtNikashiAmount.UnderLineStyle = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(88, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Amount:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.tableLayoutPanel4);
            this.panel4.Location = new System.Drawing.Point(25, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(545, 67);
            this.panel4.TabIndex = 18;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.14679F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.85321F));
            this.tableLayoutPanel4.Controls.Add(this.cbxBrickType, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(545, 67);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(56, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Brick Type:";
            // 
            // cbxBrickType
            // 
            this.cbxBrickType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxBrickType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxBrickType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxBrickType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.cbxBrickType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.cbxBrickType.BorderSize = 0;
            this.cbxBrickType.DataSource = this.brickDetailsBindingSource;
            this.cbxBrickType.DisplayMember = "BrickName";
            this.cbxBrickType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxBrickType.Font = new System.Drawing.Font("Nirmala UI", 10.5F);
            this.cbxBrickType.ForeColor = System.Drawing.Color.Black;
            this.cbxBrickType.IconColor = System.Drawing.Color.MidnightBlue;
            this.cbxBrickType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxBrickType.ListTextColor = System.Drawing.Color.Black;
            this.cbxBrickType.Location = new System.Drawing.Point(200, 13);
            this.cbxBrickType.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxBrickType.Name = "cbxBrickType";
            this.cbxBrickType.Size = new System.Drawing.Size(268, 41);
            this.cbxBrickType.TabIndex = 2;
            this.cbxBrickType.Texts = "     -Select Brick Type-";
            this.cbxBrickType.ValueMember = "BrickId";
            this.cbxBrickType.OnSelectedIndexChanged += new System.EventHandler(this.cbxCity_OnSelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Coral;
            this.btnClear.BackgroundColor = System.Drawing.Color.Coral;
            this.btnClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.BorderFocusColor = System.Drawing.Color.Green;
            this.btnClear.BorderRadius = 10;
            this.btnClear.BorderSize = 0;
            this.btnClear.ClickKey = System.Windows.Forms.Keys.None;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(869, 457);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 47);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.Teal;
            this.btnInsert.BackgroundColor = System.Drawing.Color.Teal;
            this.btnInsert.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInsert.BorderFocusColor = System.Drawing.Color.Green;
            this.btnInsert.BorderRadius = 10;
            this.btnInsert.BorderSize = 0;
            this.btnInsert.ClickKey = System.Windows.Forms.Keys.None;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(698, 457);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(166, 47);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(-1, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(283, 30);
            this.label11.TabIndex = 8;
            this.label11.Text = "Bricks Payment Setting";
            // 
            // product
            // 
            this.product.DataSetName = "Product";
            this.product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brickDetailsBindingSource
            // 
            this.brickDetailsBindingSource.DataMember = "BrickDetails";
            this.brickDetailsBindingSource.DataSource = this.product;
            // 
            // brickDetailsTableAdapter
            // 
            this.brickDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frmBricksPaymentSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1703, 570);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBricksPaymentSetting";
            this.Text = "frmWorkersRegisteration";
            this.Load += new System.EventHandler(this.frmBricksPaymentSetting_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmWorkersRegistration_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmWorkersRegistration_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmWorkersRegistration_MouseUp);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.panel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMaximize;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.BFC_TextBox txtMakingQuantity;
        private System.Windows.Forms.Label label3;
        private Controls.BFC_TextBox txtMakingAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private Controls.BFC_TextBox txtNikashiQuantity;
        private Controls.BFC_TextBox txtNikashiAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private Controls.BFC_TextBox txtDhulaiQuantity;
        private Controls.BFC_TextBox txtDhulaiAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label7;
        private Controls.BFC_ComboBox cbxBrickType;
        private Controls.BFC_Button btnClear;
        private Controls.BFC_Button btnInsert;
        private System.Windows.Forms.Label label11;
        private DataSet.Product product;
        private System.Windows.Forms.BindingSource brickDetailsBindingSource;
        private DataSet.ProductTableAdapters.BrickDetailsTableAdapter brickDetailsTableAdapter;
    }
}