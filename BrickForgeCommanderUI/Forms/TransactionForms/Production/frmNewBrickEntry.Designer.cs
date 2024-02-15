namespace BrickForgeCommanderUI.Forms.TransactionForms.Production
{
    partial class frmNewBrickEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewBrickEntry));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtProfitMargin = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRawMaterialCost = new BrickForgeCommanderUI.Controls.Validation.AmountTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new BrickForgeCommanderUI.Controls.Validation.AmountTextBox();
            this.txtCreditScore = new BrickForgeCommanderUI.Controls.Validation.AmountTextBox();
            this.txtTotalAmount = new BrickForgeCommanderUI.Controls.Validation.AmountTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLabourCharges = new BrickForgeCommanderUI.Controls.Validation.AmountTextBox();
            this.btnInsert = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxBrickType = new BrickForgeCommanderUI.Controls.BFC_ComboBox();
            this.brickDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product = new BrickForgeCommanderUI.DataSet.Product();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAddRawMaterial = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddRow = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.dgvRawMaterial = new System.Windows.Forms.DataGridView();
            this.clmSrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rawMaterialDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawMaterials = new BrickForgeCommanderUI.DataSet.RawMaterials();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMaximize = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rawMaterialDetailsTableAdapter = new BrickForgeCommanderUI.DataSet.RawMaterialsTableAdapters.RawMaterialDetailsTableAdapter();
            this.brickDetailsTableAdapter = new BrickForgeCommanderUI.DataSet.ProductTableAdapters.BrickDetailsTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brickDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterials)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 598);
            this.panel2.TabIndex = 1;
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
            this.btnClear.Location = new System.Drawing.Point(560, 499);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 47);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(10, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 410);
            this.panel1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 401);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brick Details";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.96227F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.03773F));
            this.tableLayoutPanel2.Controls.Add(this.txtProfitMargin, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtRawMaterialCost, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtUnitPrice, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtCreditScore, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtTotalAmount, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtLabourCharges, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(530, 365);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtProfitMargin
            // 
            this.txtProfitMargin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProfitMargin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtProfitMargin.BorderColor = System.Drawing.Color.Ivory;
            this.txtProfitMargin.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtProfitMargin.BorderRadius = 0;
            this.txtProfitMargin.BorderSize = 2;
            this.txtProfitMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtProfitMargin.ForeColor = System.Drawing.Color.White;
            this.txtProfitMargin.Location = new System.Drawing.Point(237, 190);
            this.txtProfitMargin.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfitMargin.MultiLine = false;
            this.txtProfitMargin.Name = "txtProfitMargin";
            this.txtProfitMargin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProfitMargin.PasswordChar = false;
            this.txtProfitMargin.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtProfitMargin.PlaceHolderText = "Eg. 1000";
            this.txtProfitMargin.Size = new System.Drawing.Size(289, 39);
            this.txtProfitMargin.TabIndex = 5;
            this.txtProfitMargin.TextBoxText = "";
            this.txtProfitMargin.Texts = "";
            this.txtProfitMargin.UnderLineStyle = true;
            this.txtProfitMargin.Leave += new System.EventHandler(this.txtProfitMargin_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Raw Material Cost:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(99, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unit Price:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Profit Margin:";
            // 
            // txtRawMaterialCost
            // 
            this.txtRawMaterialCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRawMaterialCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtRawMaterialCost.BorderColor = System.Drawing.Color.Ivory;
            this.txtRawMaterialCost.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRawMaterialCost.BorderRadius = 0;
            this.txtRawMaterialCost.BorderSize = 2;
            this.txtRawMaterialCost.ConnectedButton = null;
            this.txtRawMaterialCost.DataErrorMessage = "Please enter valid input.";
            this.txtRawMaterialCost.DataFormat = BrickForgeCommanderUI.Controls.Validation.DataType.Alphabetic;
            this.txtRawMaterialCost.ErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtRawMaterialCost.ErrorForeColor = System.Drawing.Color.Black;
            this.txtRawMaterialCost.ErrorMessage = "Please fill the above field.";
            this.txtRawMaterialCost.ErrroColor = System.Drawing.Color.Aquamarine;
            this.txtRawMaterialCost.ErrroForeColor = System.Drawing.Color.Black;
            this.txtRawMaterialCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtRawMaterialCost.ForeColor = System.Drawing.Color.White;
            this.txtRawMaterialCost.Location = new System.Drawing.Point(237, 70);
            this.txtRawMaterialCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtRawMaterialCost.MultiLine = false;
            this.txtRawMaterialCost.Name = "txtRawMaterialCost";
            this.txtRawMaterialCost.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRawMaterialCost.PasswordChar = false;
            this.txtRawMaterialCost.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtRawMaterialCost.PlaceHolderText = "Eg. 100";
            this.txtRawMaterialCost.Size = new System.Drawing.Size(273, 39);
            this.txtRawMaterialCost.TabIndex = 7;
            this.txtRawMaterialCost.TextBoxText = "";
            this.txtRawMaterialCost.Texts = "";
            this.txtRawMaterialCost.UnderLineStyle = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(70, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Credit Score:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(53, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Amount:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUnitPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtUnitPrice.BorderColor = System.Drawing.Color.Ivory;
            this.txtUnitPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUnitPrice.BorderRadius = 0;
            this.txtUnitPrice.BorderSize = 2;
            this.txtUnitPrice.ConnectedButton = null;
            this.txtUnitPrice.DataErrorMessage = "Please enter valid input.";
            this.txtUnitPrice.DataFormat = BrickForgeCommanderUI.Controls.Validation.DataType.Alphabetic;
            this.txtUnitPrice.ErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtUnitPrice.ErrorForeColor = System.Drawing.Color.Black;
            this.txtUnitPrice.ErrorMessage = "Please fill the above field.";
            this.txtUnitPrice.ErrroColor = System.Drawing.Color.Aquamarine;
            this.txtUnitPrice.ErrroForeColor = System.Drawing.Color.Black;
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtUnitPrice.ForeColor = System.Drawing.Color.White;
            this.txtUnitPrice.Location = new System.Drawing.Point(237, 130);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.MultiLine = false;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUnitPrice.PasswordChar = false;
            this.txtUnitPrice.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtUnitPrice.PlaceHolderText = "Eg. 100";
            this.txtUnitPrice.Size = new System.Drawing.Size(273, 39);
            this.txtUnitPrice.TabIndex = 7;
            this.txtUnitPrice.TextBoxText = "";
            this.txtUnitPrice.Texts = "";
            this.txtUnitPrice.UnderLineStyle = true;
            // 
            // txtCreditScore
            // 
            this.txtCreditScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCreditScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtCreditScore.BorderColor = System.Drawing.Color.Ivory;
            this.txtCreditScore.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCreditScore.BorderRadius = 0;
            this.txtCreditScore.BorderSize = 2;
            this.txtCreditScore.ConnectedButton = null;
            this.txtCreditScore.DataErrorMessage = "Please enter valid input.";
            this.txtCreditScore.DataFormat = BrickForgeCommanderUI.Controls.Validation.DataType.Alphabetic;
            this.txtCreditScore.ErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtCreditScore.ErrorForeColor = System.Drawing.Color.Black;
            this.txtCreditScore.ErrorMessage = "Please fill the above field.";
            this.txtCreditScore.ErrroColor = System.Drawing.Color.Aquamarine;
            this.txtCreditScore.ErrroForeColor = System.Drawing.Color.Black;
            this.txtCreditScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtCreditScore.ForeColor = System.Drawing.Color.White;
            this.txtCreditScore.Location = new System.Drawing.Point(237, 250);
            this.txtCreditScore.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditScore.MultiLine = false;
            this.txtCreditScore.Name = "txtCreditScore";
            this.txtCreditScore.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCreditScore.PasswordChar = false;
            this.txtCreditScore.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtCreditScore.PlaceHolderText = "Eg. 100";
            this.txtCreditScore.Size = new System.Drawing.Size(273, 39);
            this.txtCreditScore.TabIndex = 7;
            this.txtCreditScore.TextBoxText = "";
            this.txtCreditScore.Texts = "";
            this.txtCreditScore.UnderLineStyle = true;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtTotalAmount.BorderColor = System.Drawing.Color.Ivory;
            this.txtTotalAmount.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTotalAmount.BorderRadius = 0;
            this.txtTotalAmount.BorderSize = 2;
            this.txtTotalAmount.ConnectedButton = null;
            this.txtTotalAmount.DataErrorMessage = "Please enter valid input.";
            this.txtTotalAmount.DataFormat = BrickForgeCommanderUI.Controls.Validation.DataType.Alphabetic;
            this.txtTotalAmount.ErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtTotalAmount.ErrorForeColor = System.Drawing.Color.Black;
            this.txtTotalAmount.ErrorMessage = "Please fill the above field.";
            this.txtTotalAmount.ErrroColor = System.Drawing.Color.Aquamarine;
            this.txtTotalAmount.ErrroForeColor = System.Drawing.Color.Black;
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtTotalAmount.ForeColor = System.Drawing.Color.White;
            this.txtTotalAmount.Location = new System.Drawing.Point(237, 313);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmount.MultiLine = false;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotalAmount.PasswordChar = false;
            this.txtTotalAmount.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtTotalAmount.PlaceHolderText = "Eg. 100";
            this.txtTotalAmount.Size = new System.Drawing.Size(273, 39);
            this.txtTotalAmount.TabIndex = 7;
            this.txtTotalAmount.TextBoxText = "";
            this.txtTotalAmount.Texts = "";
            this.txtTotalAmount.UnderLineStyle = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Labour Charges:";
            // 
            // txtLabourCharges
            // 
            this.txtLabourCharges.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLabourCharges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtLabourCharges.BorderColor = System.Drawing.Color.Ivory;
            this.txtLabourCharges.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLabourCharges.BorderRadius = 0;
            this.txtLabourCharges.BorderSize = 2;
            this.txtLabourCharges.ConnectedButton = null;
            this.txtLabourCharges.DataErrorMessage = "Please enter valid input.";
            this.txtLabourCharges.DataFormat = BrickForgeCommanderUI.Controls.Validation.DataType.Alphabetic;
            this.txtLabourCharges.ErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtLabourCharges.ErrorForeColor = System.Drawing.Color.Black;
            this.txtLabourCharges.ErrorMessage = "Please fill the above field.";
            this.txtLabourCharges.ErrroColor = System.Drawing.Color.Aquamarine;
            this.txtLabourCharges.ErrroForeColor = System.Drawing.Color.Black;
            this.txtLabourCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtLabourCharges.ForeColor = System.Drawing.Color.White;
            this.txtLabourCharges.Location = new System.Drawing.Point(237, 10);
            this.txtLabourCharges.Margin = new System.Windows.Forms.Padding(4);
            this.txtLabourCharges.MultiLine = false;
            this.txtLabourCharges.Name = "txtLabourCharges";
            this.txtLabourCharges.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLabourCharges.PasswordChar = false;
            this.txtLabourCharges.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtLabourCharges.PlaceHolderText = "Eg. 100";
            this.txtLabourCharges.Size = new System.Drawing.Size(273, 39);
            this.txtLabourCharges.TabIndex = 7;
            this.txtLabourCharges.TextBoxText = "";
            this.txtLabourCharges.Texts = "";
            this.txtLabourCharges.UnderLineStyle = true;
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
            this.btnInsert.Location = new System.Drawing.Point(389, 499);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(166, 47);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.tableLayoutPanel4);
            this.panel4.Location = new System.Drawing.Point(10, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(545, 67);
            this.panel4.TabIndex = 25;
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
            this.cbxBrickType.OnSelectedIndexChanged += new System.EventHandler(this.cbxBrickType_OnSelectedIndexChanged);
            // 
            // brickDetailsBindingSource
            // 
            this.brickDetailsBindingSource.DataMember = "BrickDetails";
            this.brickDetailsBindingSource.DataSource = this.product;
            // 
            // product
            // 
            this.product.DataSetName = "Product";
            this.product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.btnAddRawMaterial);
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Location = new System.Drawing.Point(561, 8);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(569, 485);
            this.panel6.TabIndex = 24;
            // 
            // btnAddRawMaterial
            // 
            this.btnAddRawMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRawMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(173)))), ((int)(((byte)(1)))));
            this.btnAddRawMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(173)))), ((int)(((byte)(1)))));
            this.btnAddRawMaterial.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddRawMaterial.BorderFocusColor = System.Drawing.Color.Green;
            this.btnAddRawMaterial.BorderRadius = 10;
            this.btnAddRawMaterial.BorderSize = 0;
            this.btnAddRawMaterial.ClickKey = System.Windows.Forms.Keys.None;
            this.btnAddRawMaterial.FlatAppearance.BorderSize = 0;
            this.btnAddRawMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRawMaterial.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRawMaterial.ForeColor = System.Drawing.Color.White;
            this.btnAddRawMaterial.Location = new System.Drawing.Point(224, 432);
            this.btnAddRawMaterial.Name = "btnAddRawMaterial";
            this.btnAddRawMaterial.Size = new System.Drawing.Size(143, 47);
            this.btnAddRawMaterial.TabIndex = 21;
            this.btnAddRawMaterial.Text = "Add";
            this.btnAddRawMaterial.TextColor = System.Drawing.Color.White;
            this.btnAddRawMaterial.UseVisualStyleBackColor = false;
            this.btnAddRawMaterial.Click += new System.EventHandler(this.btnAddRawMaterial_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.btnAddRow);
            this.groupBox2.Controls.Add(this.dgvRawMaterial);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 423);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Raw Material List";
            // 
            // btnAddRow
            // 
            this.btnAddRow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddRow.BackColor = System.Drawing.Color.Ivory;
            this.btnAddRow.BackgroundColor = System.Drawing.Color.Ivory;
            this.btnAddRow.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddRow.BorderFocusColor = System.Drawing.Color.Green;
            this.btnAddRow.BorderRadius = 0;
            this.btnAddRow.BorderSize = 0;
            this.btnAddRow.ClickKey = System.Windows.Forms.Keys.None;
            this.btnAddRow.FlatAppearance.BorderSize = 0;
            this.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRow.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRow.ForeColor = System.Drawing.Color.White;
            this.btnAddRow.Image = global::BrickForgeCommanderUI.Properties.Resources.Add;
            this.btnAddRow.Location = new System.Drawing.Point(495, 0);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(43, 30);
            this.btnAddRow.TabIndex = 17;
            this.btnAddRow.TextColor = System.Drawing.Color.White;
            this.btnAddRow.UseVisualStyleBackColor = false;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // dgvRawMaterial
            // 
            this.dgvRawMaterial.AllowUserToAddRows = false;
            this.dgvRawMaterial.AllowUserToResizeColumns = false;
            this.dgvRawMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvRawMaterial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRawMaterial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRawMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSrNo,
            this.clmName,
            this.clmQuantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRawMaterial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRawMaterial.Location = new System.Drawing.Point(6, 36);
            this.dgvRawMaterial.Name = "dgvRawMaterial";
            this.dgvRawMaterial.RowHeadersVisible = false;
            this.dgvRawMaterial.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dgvRawMaterial.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRawMaterial.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvRawMaterial.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMaterial.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRawMaterial.RowTemplate.Height = 40;
            this.dgvRawMaterial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRawMaterial.Size = new System.Drawing.Size(551, 381);
            this.dgvRawMaterial.TabIndex = 7;
            this.dgvRawMaterial.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRawMaterial_CellValueChanged);
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
            this.clmName.DataSource = this.rawMaterialDetailsBindingSource;
            this.clmName.DisplayMember = "MaterialName";
            this.clmName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.clmName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clmName.HeaderText = "Material Name";
            this.clmName.MinimumWidth = 8;
            this.clmName.Name = "clmName";
            this.clmName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmName.ValueMember = "MaterialId";
            this.clmName.Width = 305;
            // 
            // rawMaterialDetailsBindingSource
            // 
            this.rawMaterialDetailsBindingSource.DataMember = "RawMaterialDetails";
            this.rawMaterialDetailsBindingSource.DataSource = this.rawMaterials;
            // 
            // rawMaterials
            // 
            this.rawMaterials.DataSetName = "RawMaterials";
            this.rawMaterials.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clmQuantity
            // 
            this.clmQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmQuantity.HeaderText = "Quantity";
            this.clmQuantity.MinimumWidth = 8;
            this.clmQuantity.Name = "clmQuantity";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.pbClose);
            this.flowLayoutPanel1.Controls.Add(this.pbMaximize);
            this.flowLayoutPanel1.Controls.Add(this.pbMinimize);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(997, 13);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 30);
            this.label11.TabIndex = 9;
            this.label11.Text = "New Brick Entry";
            // 
            // rawMaterialDetailsTableAdapter
            // 
            this.rawMaterialDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // brickDetailsTableAdapter
            // 
            this.brickDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frmNewBrickEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1140, 647);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewBrickEntry";
            this.Text = "frmWorkersRegisteration";
            this.Load += new System.EventHandler(this.frmNewBrickEntry_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmWorkersRegistration_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmWorkersRegistration_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmWorkersRegistration_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brickDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            this.panel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterials)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
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
        private DataSet.RawMaterials rawMaterials;
        private System.Windows.Forms.BindingSource rawMaterialDetailsBindingSource;
        private DataSet.RawMaterialsTableAdapters.RawMaterialDetailsTableAdapter rawMaterialDetailsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controls.BFC_TextBox txtProfitMargin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Controls.BFC_ComboBox cbxBrickType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controls.BFC_Button btnAddRow;
        private System.Windows.Forms.DataGridView dgvRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSrNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private Controls.Validation.AmountTextBox txtRawMaterialCost;
        private Controls.Validation.AmountTextBox txtLabourCharges;
        private Controls.Validation.AmountTextBox txtUnitPrice;
        private Controls.Validation.AmountTextBox txtCreditScore;
        private Controls.Validation.AmountTextBox txtTotalAmount;
        private Controls.BFC_Button btnClear;
        private Controls.BFC_Button btnInsert;
        private DataSet.Product product;
        private System.Windows.Forms.BindingSource brickDetailsBindingSource;
        private DataSet.ProductTableAdapters.BrickDetailsTableAdapter brickDetailsTableAdapter;
        private Controls.BFC_Button btnAddRawMaterial;
    }
}