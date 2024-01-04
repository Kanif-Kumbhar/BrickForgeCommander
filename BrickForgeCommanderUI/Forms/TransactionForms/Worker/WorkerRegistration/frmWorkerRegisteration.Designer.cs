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
            this.bfC_Button1 = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.quantityTextBox1 = new BrickForgeCommanderUI.Controls.Validation.QuantityTextBox();
            this.quantityTextBox2 = new BrickForgeCommanderUI.Controls.Validation.QuantityTextBox();
            this.quantityTextBox3 = new BrickForgeCommanderUI.Controls.Validation.QuantityTextBox();
            this.quantityTextBox4 = new BrickForgeCommanderUI.Controls.Validation.QuantityTextBox();
            this.quantityTextBox5 = new BrickForgeCommanderUI.Controls.Validation.QuantityTextBox();
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
            // quantityTextBox1
            // 
            this.quantityTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.quantityTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.quantityTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.quantityTextBox1.BorderRadius = 0;
            this.quantityTextBox1.BorderSize = 2;
            this.quantityTextBox1.ConnectedButton = null;
            this.quantityTextBox1.DataErrorMessage = "Please enter valid input.";
            this.quantityTextBox1.DataFormat = BrickForgeCommanderUI.Controls.Validation.DataType.Alphabetic;
            this.quantityTextBox1.ErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.quantityTextBox1.ErrorForeColor = System.Drawing.Color.Black;
            this.quantityTextBox1.ErrorMessage = "Please fill the above field.";
            this.quantityTextBox1.ErrroColor = System.Drawing.Color.Aquamarine;
            this.quantityTextBox1.ErrroForeColor = System.Drawing.Color.Black;
            this.quantityTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.quantityTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.quantityTextBox1.Location = new System.Drawing.Point(440, 208);
            this.quantityTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTextBox1.MultiLine = false;
            this.quantityTextBox1.Name = "quantityTextBox1";
            this.quantityTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.quantityTextBox1.PasswordChar = false;
            this.quantityTextBox1.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.quantityTextBox1.PlaceHolderText = "";
            this.quantityTextBox1.Size = new System.Drawing.Size(250, 41);
            this.quantityTextBox1.TabIndex = 2;
            this.quantityTextBox1.TextBoxText = "";
            this.quantityTextBox1.Texts = "";
            this.quantityTextBox1.UnderLineStyle = false;
            // 
            // quantityTextBox2
            // 
            this.quantityTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.quantityTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.quantityTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.quantityTextBox2.BorderRadius = 0;
            this.quantityTextBox2.BorderSize = 2;
            this.quantityTextBox2.ConnectedButton = this.bfC_Button1;
            this.quantityTextBox2.DataErrorMessage = "Please enter valid input.";
            this.quantityTextBox2.DataFormat = BrickForgeCommanderUI.Controls.Validation.DataType.Alphabetic;
            this.quantityTextBox2.ErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.quantityTextBox2.ErrorForeColor = System.Drawing.Color.Black;
            this.quantityTextBox2.ErrorMessage = "Please fill the above field.";
            this.quantityTextBox2.ErrroColor = System.Drawing.Color.Aquamarine;
            this.quantityTextBox2.ErrroForeColor = System.Drawing.Color.Black;
            this.quantityTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.quantityTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.quantityTextBox2.Location = new System.Drawing.Point(106, 208);
            this.quantityTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTextBox2.MultiLine = false;
            this.quantityTextBox2.Name = "quantityTextBox2";
            this.quantityTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.quantityTextBox2.PasswordChar = false;
            this.quantityTextBox2.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.quantityTextBox2.PlaceHolderText = "enter number";
            this.quantityTextBox2.Size = new System.Drawing.Size(250, 39);
            this.quantityTextBox2.TabIndex = 2;
            this.quantityTextBox2.TextBoxText = "";
            this.quantityTextBox2.Texts = "";
            this.quantityTextBox2.UnderLineStyle = false;
            // 
            // quantityTextBox3
            // 
            this.quantityTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.quantityTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.quantityTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.quantityTextBox3.BorderRadius = 0;
            this.quantityTextBox3.BorderSize = 2;
            this.quantityTextBox3.ConnectedButton = null;
            this.quantityTextBox3.DataErrorMessage = "Please enter valid input.";
            this.quantityTextBox3.DataFormat = BrickForgeCommanderUI.Controls.Validation.DataType.Alphabetic;
            this.quantityTextBox3.ErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.quantityTextBox3.ErrorForeColor = System.Drawing.Color.Black;
            this.quantityTextBox3.ErrorMessage = "Please fill the above field.";
            this.quantityTextBox3.ErrroColor = System.Drawing.Color.Aquamarine;
            this.quantityTextBox3.ErrroForeColor = System.Drawing.Color.Black;
            this.quantityTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.quantityTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.quantityTextBox3.Location = new System.Drawing.Point(799, 208);
            this.quantityTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTextBox3.MultiLine = false;
            this.quantityTextBox3.Name = "quantityTextBox3";
            this.quantityTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.quantityTextBox3.PasswordChar = false;
            this.quantityTextBox3.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.quantityTextBox3.PlaceHolderText = "";
            this.quantityTextBox3.Size = new System.Drawing.Size(250, 39);
            this.quantityTextBox3.TabIndex = 2;
            this.quantityTextBox3.TextBoxText = "";
            this.quantityTextBox3.Texts = "";
            this.quantityTextBox3.UnderLineStyle = false;
            // 
            // quantityTextBox4
            // 
            this.quantityTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.quantityTextBox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.quantityTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.quantityTextBox4.BorderRadius = 0;
            this.quantityTextBox4.BorderSize = 2;
            this.quantityTextBox4.ConnectedButton = this.bfC_Button1;
            this.quantityTextBox4.DataErrorMessage = "Please enter valid input.";
            this.quantityTextBox4.DataFormat = BrickForgeCommanderUI.Controls.Validation.DataType.Alphabetic;
            this.quantityTextBox4.ErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.quantityTextBox4.ErrorForeColor = System.Drawing.Color.Black;
            this.quantityTextBox4.ErrorMessage = "Please fill the above field.";
            this.quantityTextBox4.ErrroColor = System.Drawing.Color.Aquamarine;
            this.quantityTextBox4.ErrroForeColor = System.Drawing.Color.Black;
            this.quantityTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.quantityTextBox4.ForeColor = System.Drawing.Color.DimGray;
            this.quantityTextBox4.Location = new System.Drawing.Point(440, 208);
            this.quantityTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTextBox4.MultiLine = false;
            this.quantityTextBox4.Name = "quantityTextBox4";
            this.quantityTextBox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.quantityTextBox4.PasswordChar = false;
            this.quantityTextBox4.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.quantityTextBox4.PlaceHolderText = "enter number";
            this.quantityTextBox4.Size = new System.Drawing.Size(250, 39);
            this.quantityTextBox4.TabIndex = 2;
            this.quantityTextBox4.TextBoxText = "";
            this.quantityTextBox4.Texts = "";
            this.quantityTextBox4.UnderLineStyle = false;
            // 
            // quantityTextBox5
            // 
            this.quantityTextBox5.BackColor = System.Drawing.SystemColors.Window;
            this.quantityTextBox5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.quantityTextBox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.quantityTextBox5.BorderRadius = 0;
            this.quantityTextBox5.BorderSize = 2;
            this.quantityTextBox5.ConnectedButton = this.bfC_Button1;
            this.quantityTextBox5.DataErrorMessage = "Please enter valid input.";
            this.quantityTextBox5.DataFormat = BrickForgeCommanderUI.Controls.Validation.DataType.Alphabetic;
            this.quantityTextBox5.ErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.quantityTextBox5.ErrorForeColor = System.Drawing.Color.Black;
            this.quantityTextBox5.ErrorMessage = "Please fill the above field.";
            this.quantityTextBox5.ErrroColor = System.Drawing.Color.Aquamarine;
            this.quantityTextBox5.ErrroForeColor = System.Drawing.Color.Black;
            this.quantityTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.quantityTextBox5.ForeColor = System.Drawing.Color.DimGray;
            this.quantityTextBox5.Location = new System.Drawing.Point(799, 208);
            this.quantityTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTextBox5.MultiLine = false;
            this.quantityTextBox5.Name = "quantityTextBox5";
            this.quantityTextBox5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.quantityTextBox5.PasswordChar = false;
            this.quantityTextBox5.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.quantityTextBox5.PlaceHolderText = "enter number";
            this.quantityTextBox5.Size = new System.Drawing.Size(250, 39);
            this.quantityTextBox5.TabIndex = 2;
            this.quantityTextBox5.TextBoxText = "";
            this.quantityTextBox5.Texts = "";
            this.quantityTextBox5.UnderLineStyle = false;
            // 
            // frmWorkerRegisteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 643);
            this.Controls.Add(this.quantityTextBox5);
            this.Controls.Add(this.quantityTextBox3);
            this.Controls.Add(this.quantityTextBox4);
            this.Controls.Add(this.quantityTextBox2);
            this.Controls.Add(this.quantityTextBox1);
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
        private Controls.Validation.QuantityTextBox quantityTextBox1;
        private Controls.Validation.QuantityTextBox quantityTextBox2;
        private Controls.Validation.QuantityTextBox quantityTextBox3;
        private Controls.Validation.QuantityTextBox quantityTextBox4;
        private Controls.Validation.QuantityTextBox quantityTextBox5;
    }
}