namespace BrickForgeCommanderUI.MasterForms.Menu
{
    partial class frmMasterMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHead = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bfC_Button6 = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.bfC_Button5 = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.bfC_Button4 = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.bfC_Button2 = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.btnVendorTypeDetails = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.bfC_Button3 = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.bfC_Close1 = new BrickForgeCommanderUI.Controls.NavControls.BFC_Close();
            this.panel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.bfC_Close1);
            this.panel1.Controls.Add(this.lblHead);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 46);
            this.panel1.TabIndex = 0;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(6, 4);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(170, 34);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Master Menu";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tableLayoutPanel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 46);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(600, 399);
            this.pnlMain.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.bfC_Button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bfC_Button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bfC_Button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bfC_Button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVendorTypeDetails, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bfC_Button3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33553F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 580);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bfC_Button6
            // 
            this.bfC_Button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bfC_Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bfC_Button6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bfC_Button6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bfC_Button6.BorderRadius = 20;
            this.bfC_Button6.BorderSize = 0;
            this.bfC_Button6.FlatAppearance.BorderSize = 0;
            this.bfC_Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfC_Button6.Font = new System.Drawing.Font("ROG Fonts", 7.999999F);
            this.bfC_Button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.bfC_Button6.Image = global::BrickForgeCommanderUI.Properties.Resources.CreditType;
            this.bfC_Button6.Location = new System.Drawing.Point(404, 212);
            this.bfC_Button6.Name = "bfC_Button6";
            this.bfC_Button6.Size = new System.Drawing.Size(157, 155);
            this.bfC_Button6.TabIndex = 5;
            this.bfC_Button6.Text = "Credit Score";
            this.bfC_Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bfC_Button6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.bfC_Button6.UseVisualStyleBackColor = false;
            // 
            // bfC_Button5
            // 
            this.bfC_Button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bfC_Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bfC_Button5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bfC_Button5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bfC_Button5.BorderRadius = 20;
            this.bfC_Button5.BorderSize = 0;
            this.bfC_Button5.FlatAppearance.BorderSize = 0;
            this.bfC_Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfC_Button5.Font = new System.Drawing.Font("ROG Fonts", 7.999999F);
            this.bfC_Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.bfC_Button5.Image = global::BrickForgeCommanderUI.Properties.Resources.VehicleType;
            this.bfC_Button5.Location = new System.Drawing.Point(211, 212);
            this.bfC_Button5.Name = "bfC_Button5";
            this.bfC_Button5.Size = new System.Drawing.Size(157, 155);
            this.bfC_Button5.TabIndex = 4;
            this.bfC_Button5.Text = "Vehicle Type";
            this.bfC_Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bfC_Button5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.bfC_Button5.UseVisualStyleBackColor = false;
            // 
            // bfC_Button4
            // 
            this.bfC_Button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bfC_Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bfC_Button4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bfC_Button4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bfC_Button4.BorderRadius = 20;
            this.bfC_Button4.BorderSize = 0;
            this.bfC_Button4.FlatAppearance.BorderSize = 0;
            this.bfC_Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfC_Button4.Font = new System.Drawing.Font("ROG Fonts", 7.999999F);
            this.bfC_Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.bfC_Button4.Image = global::BrickForgeCommanderUI.Properties.Resources.MaterialType;
            this.bfC_Button4.Location = new System.Drawing.Point(18, 212);
            this.bfC_Button4.Name = "bfC_Button4";
            this.bfC_Button4.Size = new System.Drawing.Size(157, 155);
            this.bfC_Button4.TabIndex = 3;
            this.bfC_Button4.Text = "Material Type";
            this.bfC_Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bfC_Button4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.bfC_Button4.UseVisualStyleBackColor = false;
            // 
            // bfC_Button2
            // 
            this.bfC_Button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bfC_Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bfC_Button2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bfC_Button2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bfC_Button2.BorderRadius = 20;
            this.bfC_Button2.BorderSize = 0;
            this.bfC_Button2.FlatAppearance.BorderSize = 0;
            this.bfC_Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfC_Button2.Font = new System.Drawing.Font("ROG Fonts", 7.999999F);
            this.bfC_Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.bfC_Button2.Image = global::BrickForgeCommanderUI.Properties.Resources.PaymentType;
            this.bfC_Button2.Location = new System.Drawing.Point(211, 14);
            this.bfC_Button2.Name = "bfC_Button2";
            this.bfC_Button2.Size = new System.Drawing.Size(157, 164);
            this.bfC_Button2.TabIndex = 1;
            this.bfC_Button2.Text = "Payment Type";
            this.bfC_Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bfC_Button2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.bfC_Button2.UseVisualStyleBackColor = false;
            // 
            // btnVendorTypeDetails
            // 
            this.btnVendorTypeDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVendorTypeDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnVendorTypeDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnVendorTypeDetails.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVendorTypeDetails.BorderRadius = 20;
            this.btnVendorTypeDetails.BorderSize = 0;
            this.btnVendorTypeDetails.FlatAppearance.BorderSize = 0;
            this.btnVendorTypeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendorTypeDetails.Font = new System.Drawing.Font("ROG Fonts", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendorTypeDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.btnVendorTypeDetails.Image = global::BrickForgeCommanderUI.Properties.Resources.icons8_business_man_64;
            this.btnVendorTypeDetails.Location = new System.Drawing.Point(18, 19);
            this.btnVendorTypeDetails.Name = "btnVendorTypeDetails";
            this.btnVendorTypeDetails.Size = new System.Drawing.Size(157, 154);
            this.btnVendorTypeDetails.TabIndex = 0;
            this.btnVendorTypeDetails.Text = "Vendor Type";
            this.btnVendorTypeDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendorTypeDetails.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.btnVendorTypeDetails.UseVisualStyleBackColor = false;
            this.btnVendorTypeDetails.Click += new System.EventHandler(this.btnVendorTypeDetails_Click);
            // 
            // bfC_Button3
            // 
            this.bfC_Button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bfC_Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bfC_Button3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bfC_Button3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bfC_Button3.BorderRadius = 20;
            this.bfC_Button3.BorderSize = 0;
            this.bfC_Button3.FlatAppearance.BorderSize = 0;
            this.bfC_Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfC_Button3.Font = new System.Drawing.Font("ROG Fonts", 7.999999F);
            this.bfC_Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.bfC_Button3.Image = global::BrickForgeCommanderUI.Properties.Resources.StatusType;
            this.bfC_Button3.Location = new System.Drawing.Point(404, 19);
            this.bfC_Button3.Name = "bfC_Button3";
            this.bfC_Button3.Size = new System.Drawing.Size(157, 154);
            this.bfC_Button3.TabIndex = 2;
            this.bfC_Button3.Text = "Status Type";
            this.bfC_Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bfC_Button3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.bfC_Button3.UseVisualStyleBackColor = false;
            // 
            // bfC_Close1
            // 
            this.bfC_Close1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.bfC_Close1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.bfC_Close1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bfC_Close1.BorderRadius = 0;
            this.bfC_Close1.BorderSize = 0;
            this.bfC_Close1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bfC_Close1.FlatAppearance.BorderSize = 0;
            this.bfC_Close1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfC_Close1.ForeColor = System.Drawing.Color.White;
            this.bfC_Close1.Image = ((System.Drawing.Image)(resources.GetObject("bfC_Close1.Image")));
            this.bfC_Close1.Location = new System.Drawing.Point(525, 0);
            this.bfC_Close1.Name = "bfC_Close1";
            this.bfC_Close1.Size = new System.Drawing.Size(75, 46);
            this.bfC_Close1.TabIndex = 1;
            this.bfC_Close1.TextColor = System.Drawing.Color.White;
            this.bfC_Close1.UseVisualStyleBackColor = false;
            // 
            // frmMasterMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(600, 445);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(600, 642);
            this.MinimumSize = new System.Drawing.Size(600, 445);
            this.Name = "frmMasterMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMasterMenu";
            this.Load += new System.EventHandler(this.frmMasterMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.BFC_Button btnVendorTypeDetails;
        private Controls.BFC_Button bfC_Button6;
        private Controls.BFC_Button bfC_Button5;
        private Controls.BFC_Button bfC_Button4;
        private Controls.BFC_Button bfC_Button3;
        private Controls.BFC_Button bfC_Button2;
        private System.Windows.Forms.Label lblHead;
        private Controls.NavControls.BFC_Close bfC_Close1;
    }
}