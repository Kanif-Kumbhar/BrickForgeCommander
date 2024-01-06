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
            this.txtQuantity = new BrickForgeCommanderUI.Controls.Validation.QuantityTextBox();
            this.bfC_Button1 = new BrickForgeCommanderUI.Controls.BFC_Button();
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
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantity.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtQuantity.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtQuantity.BorderRadius = 0;
            this.txtQuantity.BorderSize = 2;
            this.txtQuantity.ConnectedButton = this.bfC_Button1;
            this.txtQuantity.DataErrorMessage = "Please enter valid input.";
            this.txtQuantity.DataFormat = BrickForgeCommanderUI.Controls.Validation.DataType.Alphabetic;
            this.txtQuantity.ErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtQuantity.ErrorForeColor = System.Drawing.Color.Black;
            this.txtQuantity.ErrorMessage = "Please fill the above field.";
            this.txtQuantity.ErrroColor = System.Drawing.Color.Aquamarine;
            this.txtQuantity.ErrroForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.txtQuantity.Location = new System.Drawing.Point(478, 174);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.MultiLine = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQuantity.PasswordChar = false;
            this.txtQuantity.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtQuantity.PlaceHolderText = "0000";
            this.txtQuantity.Size = new System.Drawing.Size(250, 39);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.TextBoxText = "";
            this.txtQuantity.Texts = "";
            this.txtQuantity.UnderLineStyle = false;
            // 
            // bfC_Button1
            // 
            this.bfC_Button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bfC_Button1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.bfC_Button1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bfC_Button1.BorderFocusColor = System.Drawing.Color.Green;
            this.bfC_Button1.BorderRadius = 20;
            this.bfC_Button1.BorderSize = 0;
            this.bfC_Button1.ClickKey = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
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
            // frmWorkerRegisteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 643);
            this.Controls.Add(this.txtQuantity);
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
        private Controls.Validation.QuantityTextBox txtQuantity;
    }
}