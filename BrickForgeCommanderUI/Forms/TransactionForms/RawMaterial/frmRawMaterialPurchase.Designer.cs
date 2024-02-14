namespace BrickForgeCommanderUI.Forms.TransactionForms.RawMaterial
{
    partial class frmRawMaterialPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialPurchase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnPrint = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.btnInsert = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.btnClear = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewRole = new BrickForgeCommanderUI.Controls.NavControls.BfcNewButton();
            this.cbxSupplier = new BrickForgeCommanderUI.Controls.BFC_ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxMaterial = new BrickForgeCommanderUI.Controls.BFC_ComboBox();
            this.rawMaterialDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawMaterials = new BrickForgeCommanderUI.DataSet.RawMaterials();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.txtPurchasePrice = new BrickForgeCommanderUI.Controls.Validation.AmountTextBox();
            this.bfcNewButton1 = new BrickForgeCommanderUI.Controls.NavControls.BfcNewButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRawMaterial = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMaximize = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rawMaterialDetailsTableAdapter = new BrickForgeCommanderUI.DataSet.RawMaterialsTableAdapters.RawMaterialDetailsTableAdapter();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterials)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterial)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlMain.Controls.Add(this.btnPrint);
            this.pnlMain.Controls.Add(this.btnInsert);
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.panel6);
            this.pnlMain.Location = new System.Drawing.Point(0, 49);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1736, 756);
            this.pnlMain.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.btnPrint.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.btnPrint.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrint.BorderFocusColor = System.Drawing.Color.Green;
            this.btnPrint.BorderRadius = 10;
            this.btnPrint.BorderSize = 0;
            this.btnPrint.ClickKey = System.Windows.Forms.Keys.None;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(1593, 319);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(133, 47);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextColor = System.Drawing.Color.Black;
            this.btnPrint.UseVisualStyleBackColor = false;
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
            this.btnInsert.Location = new System.Drawing.Point(723, 229);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(166, 47);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            this.btnClear.Location = new System.Drawing.Point(895, 229);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 47);
            this.btnClear.TabIndex = 16;
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
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1712, 210);
            this.panel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1706, 193);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.64706F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.235294F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.64706F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.176471F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.52941F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.Controls.Add(this.btnNewRole, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxSupplier, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxMaterial, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPurchasePrice, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.bfcNewButton1, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1700, 157);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNewRole
            // 
            this.btnNewRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnNewRole.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnNewRole.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNewRole.BorderFocusColor = System.Drawing.Color.Green;
            this.btnNewRole.BorderRadius = 0;
            this.btnNewRole.BorderSize = 0;
            this.btnNewRole.ClickKey = System.Windows.Forms.Keys.None;
            this.btnNewRole.DisplayType = BrickForgeCommanderUI.Controls.NavControls.DisplayType.Icon;
            this.btnNewRole.FlatAppearance.BorderSize = 0;
            this.btnNewRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRole.ForeColor = System.Drawing.Color.White;
            this.btnNewRole.FormName = null;
            this.btnNewRole.Image = ((System.Drawing.Image)(resources.GetObject("btnNewRole.Image")));
            this.btnNewRole.Location = new System.Drawing.Point(353, 81);
            this.btnNewRole.Name = "btnNewRole";
            this.btnNewRole.Size = new System.Drawing.Size(64, 57);
            this.btnNewRole.TabIndex = 10;
            this.btnNewRole.TextColor = System.Drawing.Color.White;
            this.btnNewRole.Texts = null;
            this.btnNewRole.UseVisualStyleBackColor = false;
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.cbxSupplier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.cbxSupplier.BorderSize = 0;
            this.cbxSupplier.DisplayMember = "CityName";
            this.cbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxSupplier.Font = new System.Drawing.Font("Nirmala UI", 10.5F);
            this.cbxSupplier.ForeColor = System.Drawing.Color.Black;
            this.cbxSupplier.IconColor = System.Drawing.Color.MidnightBlue;
            this.cbxSupplier.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxSupplier.ListTextColor = System.Drawing.Color.Black;
            this.cbxSupplier.Location = new System.Drawing.Point(3, 81);
            this.cbxSupplier.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(341, 57);
            this.cbxSupplier.TabIndex = 7;
            this.cbxSupplier.Texts = "";
            this.cbxSupplier.ValueMember = "CityId";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier Name:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(458, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raw Material:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(929, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1311, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Purchase Price:";
            // 
            // cbxMaterial
            // 
            this.cbxMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.cbxMaterial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.cbxMaterial.BorderSize = 0;
            this.cbxMaterial.DataSource = this.rawMaterialDetailsBindingSource;
            this.cbxMaterial.DisplayMember = "MaterialName";
            this.cbxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxMaterial.Font = new System.Drawing.Font("Nirmala UI", 10.5F);
            this.cbxMaterial.ForeColor = System.Drawing.Color.Black;
            this.cbxMaterial.IconColor = System.Drawing.Color.MidnightBlue;
            this.cbxMaterial.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxMaterial.ListTextColor = System.Drawing.Color.Black;
            this.cbxMaterial.Location = new System.Drawing.Point(458, 81);
            this.cbxMaterial.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Size = new System.Drawing.Size(341, 57);
            this.cbxMaterial.TabIndex = 6;
            this.cbxMaterial.Texts = "-Select Raw Material-";
            this.cbxMaterial.ValueMember = "MaterialId";
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.30851F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.69149F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtQuantity, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(929, 81);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(376, 73);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(320, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "kg";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtQuantity.BorderColor = System.Drawing.Color.Ivory;
            this.txtQuantity.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtQuantity.BorderRadius = 0;
            this.txtQuantity.BorderSize = 2;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtQuantity.ForeColor = System.Drawing.Color.Ivory;
            this.txtQuantity.Location = new System.Drawing.Point(4, 4);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.MultiLine = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQuantity.PasswordChar = false;
            this.txtQuantity.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtQuantity.PlaceHolderText = "Eg. 1000";
            this.txtQuantity.Size = new System.Drawing.Size(307, 39);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.TextBoxText = "";
            this.txtQuantity.Texts = "";
            this.txtQuantity.UnderLineStyle = true;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtPurchasePrice.BorderColor = System.Drawing.Color.White;
            this.txtPurchasePrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPurchasePrice.BorderRadius = 0;
            this.txtPurchasePrice.BorderSize = 2;
            this.txtPurchasePrice.ConnectedButton = null;
            this.txtPurchasePrice.DataErrorMessage = "Please enter valid input.";
            this.txtPurchasePrice.DataFormat = BrickForgeCommanderUI.Controls.Validation.DataType.Alphabetic;
            this.txtPurchasePrice.ErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtPurchasePrice.ErrorForeColor = System.Drawing.Color.Black;
            this.txtPurchasePrice.ErrorMessage = "Please fill the above field.";
            this.txtPurchasePrice.ErrroColor = System.Drawing.Color.Aquamarine;
            this.txtPurchasePrice.ErrroForeColor = System.Drawing.Color.Black;
            this.txtPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtPurchasePrice.ForeColor = System.Drawing.Color.DimGray;
            this.txtPurchasePrice.Location = new System.Drawing.Point(1312, 82);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPurchasePrice.MultiLine = false;
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPurchasePrice.PasswordChar = false;
            this.txtPurchasePrice.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtPurchasePrice.PlaceHolderText = "Eg. 1000";
            this.txtPurchasePrice.Size = new System.Drawing.Size(273, 39);
            this.txtPurchasePrice.TabIndex = 9;
            this.txtPurchasePrice.TextBoxText = "";
            this.txtPurchasePrice.Texts = "";
            this.txtPurchasePrice.UnderLineStyle = true;
            // 
            // bfcNewButton1
            // 
            this.bfcNewButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.bfcNewButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.bfcNewButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bfcNewButton1.BorderFocusColor = System.Drawing.Color.Green;
            this.bfcNewButton1.BorderRadius = 0;
            this.bfcNewButton1.BorderSize = 0;
            this.bfcNewButton1.ClickKey = System.Windows.Forms.Keys.None;
            this.bfcNewButton1.DisplayType = BrickForgeCommanderUI.Controls.NavControls.DisplayType.Icon;
            this.bfcNewButton1.FlatAppearance.BorderSize = 0;
            this.bfcNewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfcNewButton1.ForeColor = System.Drawing.Color.White;
            this.bfcNewButton1.FormName = null;
            this.bfcNewButton1.Image = ((System.Drawing.Image)(resources.GetObject("bfcNewButton1.Image")));
            this.bfcNewButton1.Location = new System.Drawing.Point(808, 81);
            this.bfcNewButton1.Name = "bfcNewButton1";
            this.bfcNewButton1.Size = new System.Drawing.Size(64, 57);
            this.bfcNewButton1.TabIndex = 10;
            this.bfcNewButton1.TextColor = System.Drawing.Color.White;
            this.bfcNewButton1.Texts = null;
            this.bfcNewButton1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Location = new System.Drawing.Point(12, 372);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1712, 372);
            this.panel6.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.dgvRawMaterial);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1706, 363);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Staff List";
            // 
            // dgvRawMaterial
            // 
            this.dgvRawMaterial.AllowUserToAddRows = false;
            this.dgvRawMaterial.AllowUserToResizeColumns = false;
            this.dgvRawMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvRawMaterial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRawMaterial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRawMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmSrNo,
            this.clmSupplierName,
            this.clmName,
            this.clmQuantity,
            this.clmPurchase,
            this.clmStatus,
            this.clmDate});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRawMaterial.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRawMaterial.Location = new System.Drawing.Point(6, 36);
            this.dgvRawMaterial.Name = "dgvRawMaterial";
            this.dgvRawMaterial.RowHeadersVisible = false;
            this.dgvRawMaterial.RowHeadersWidth = 62;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dgvRawMaterial.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRawMaterial.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvRawMaterial.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMaterial.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRawMaterial.RowTemplate.Height = 40;
            this.dgvRawMaterial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRawMaterial.Size = new System.Drawing.Size(1694, 321);
            this.dgvRawMaterial.TabIndex = 7;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.MinimumWidth = 8;
            this.clmId.Name = "clmId";
            this.clmId.Visible = false;
            this.clmId.Width = 150;
            // 
            // clmSrNo
            // 
            this.clmSrNo.HeaderText = "Sr. No.";
            this.clmSrNo.MinimumWidth = 8;
            this.clmSrNo.Name = "clmSrNo";
            this.clmSrNo.ReadOnly = true;
            this.clmSrNo.Width = 130;
            // 
            // clmSupplierName
            // 
            this.clmSupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSupplierName.HeaderText = "Supplier Name";
            this.clmSupplierName.MinimumWidth = 8;
            this.clmSupplierName.Name = "clmSupplierName";
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
            this.clmQuantity.HeaderText = "Quantity";
            this.clmQuantity.MinimumWidth = 8;
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            this.clmQuantity.Width = 260;
            // 
            // clmPurchase
            // 
            this.clmPurchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmPurchase.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmPurchase.HeaderText = "Purchase Price";
            this.clmPurchase.MinimumWidth = 8;
            this.clmPurchase.Name = "clmPurchase";
            this.clmPurchase.ReadOnly = true;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Stock Status";
            this.clmStatus.MinimumWidth = 8;
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.Width = 150;
            // 
            // clmDate
            // 
            this.clmDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDate.HeaderText = "Date";
            this.clmDate.MinimumWidth = 8;
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.pbClose);
            this.flowLayoutPanel1.Controls.Add(this.pbMaximize);
            this.flowLayoutPanel1.Controls.Add(this.pbMinimize);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1593, 13);
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
            this.label11.Location = new System.Drawing.Point(3, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 30);
            this.label11.TabIndex = 6;
            this.label11.Text = "Raw Material Purchase";
            // 
            // rawMaterialDetailsTableAdapter
            // 
            this.rawMaterialDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frmRawMaterialPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1736, 805);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRawMaterialPurchase";
            this.Text = "frmWorkersRegisteration";
            this.Activated += new System.EventHandler(this.frmRawMaterialPurchase_Activated);
            this.Load += new System.EventHandler(this.frmRawMaterialPurchase_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmWorkersRegistration_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmWorkersRegistration_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmWorkersRegistration_MouseUp);
            this.pnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterials)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterial)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRawMaterial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Controls.BFC_ComboBox cbxSupplier;
        private Controls.BFC_ComboBox cbxMaterial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controls.BFC_TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private Controls.Validation.AmountTextBox txtPurchasePrice;
        private Controls.BFC_Button btnInsert;
        private Controls.BFC_Button btnClear;
        private Controls.BFC_Button btnPrint;
        private Controls.NavControls.BfcNewButton btnNewRole;
        private Controls.NavControls.BfcNewButton bfcNewButton1;
        private DataSet.RawMaterials rawMaterials;
        private System.Windows.Forms.BindingSource rawMaterialDetailsBindingSource;
        private DataSet.RawMaterialsTableAdapters.RawMaterialDetailsTableAdapter rawMaterialDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
    }
}