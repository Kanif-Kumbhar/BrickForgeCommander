namespace BrickForgeCommanderUI.Forms.TransactionForms.Worker.WorkerRegistration
{
    partial class frmWorkerRegisteration
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.txtAddress = new BrickForgeCommanderUI.Controls.Validation.DataFieldTextBox();
            this.bfC_Button1 = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.txtName = new BrickForgeCommanderUI.Controls.Validation.DataFieldTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(0, 0);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 26);
            this.tb1.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAddress.BorderRadius = 0;
            this.txtAddress.BorderSize = 2;
            this.txtAddress.ConnectedButton = this.bfC_Button1;
            this.txtAddress.DataFormat = BrickForgeCommanderUI.Controls.Validation.DataType.Alphabetic;
            this.txtAddress.ErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtAddress.ErrorForeColor = System.Drawing.Color.White;
            this.txtAddress.ErrorMessage = "Please fill the above field.";
            this.txtAddress.ErrroColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAddress.ErrroForeColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtAddress.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddress.Location = new System.Drawing.Point(634, 204);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.MultiLine = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceHolderText = "hh";
            this.txtAddress.Range = 5;
            this.txtAddress.Size = new System.Drawing.Size(250, 39);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextBoxText = "";
            this.txtAddress.Texts = "";
            this.txtAddress.UnderLineStyle = false;
            // 
            // bfC_Button1
            // 
            this.bfC_Button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bfC_Button1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.bfC_Button1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bfC_Button1.BorderFocusColor = System.Drawing.Color.Green;
            this.bfC_Button1.BorderRadius = 20;
            this.bfC_Button1.BorderSize = 0;
            this.bfC_Button1.FlatAppearance.BorderSize = 0;
            this.bfC_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfC_Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bfC_Button1.Location = new System.Drawing.Point(467, 339);
            this.bfC_Button1.Name = "bfC_Button1";
            this.bfC_Button1.Size = new System.Drawing.Size(150, 40);
            this.bfC_Button1.TabIndex = 1;
            this.bfC_Button1.Text = "bfC_Button1";
            this.bfC_Button1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bfC_Button1.UseVisualStyleBackColor = false;
            this.bfC_Button1.Click += new System.EventHandler(this.bfC_Button1_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 2;
            this.txtName.ConnectedButton = this.bfC_Button1;
            this.txtName.DataFormat = BrickForgeCommanderUI.Controls.Validation.DataType.Alphabetic;
            this.txtName.ErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtName.ErrorForeColor = System.Drawing.Color.White;
            this.txtName.ErrorMessage = "Please fill the above field.";
            this.txtName.ErrroColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtName.ErrroForeColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(318, 204);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceHolderText = "hh";
            this.txtName.Range = 5;
            this.txtName.Size = new System.Drawing.Size(250, 39);
            this.txtName.TabIndex = 2;
            this.txtName.TextBoxText = "";
            this.txtName.Texts = "";
            this.txtName.UnderLineStyle = false;
            // 
            // frmWorkerRegisteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 643);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bfC_Button1);
            this.KeyPreview = true;
            this.Name = "frmWorkerRegisteration";
            this.Load += new System.EventHandler(this.frmWorkerRegisteration_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmWorkerRegisteration_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb1;
        private Controls.BFC_Button bfC_Button1;
        private Controls.Validation.DataFieldTextBox txtName;
        private Controls.Validation.DataFieldTextBox txtAddress;
    }
}