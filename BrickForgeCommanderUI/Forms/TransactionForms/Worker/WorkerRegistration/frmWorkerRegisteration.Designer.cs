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
            this.dataFieldTextBox1 = new BrickForgeCommanderUI.Controls.Validation.DataFieldTextBox();
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
            // dataFieldTextBox1
            // 
            this.dataFieldTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.dataFieldTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dataFieldTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.dataFieldTextBox1.BorderRadius = 0;
            this.dataFieldTextBox1.BorderSize = 2;
            this.dataFieldTextBox1.ConnectedButton = null;
            this.dataFieldTextBox1.ErrorColor = System.Drawing.Color.Empty;
            this.dataFieldTextBox1.ErrorForeColor = System.Drawing.Color.Empty;
            this.dataFieldTextBox1.ErrorMessage = "Please fill the above field.";
            this.dataFieldTextBox1.ErrroColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataFieldTextBox1.ErrroForeColor = System.Drawing.Color.White;
            this.dataFieldTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dataFieldTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.dataFieldTextBox1.Location = new System.Drawing.Point(350, 219);
            this.dataFieldTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.dataFieldTextBox1.MultiLine = false;
            this.dataFieldTextBox1.Name = "dataFieldTextBox1";
            this.dataFieldTextBox1.NumericValidationProperty = 0;
            this.dataFieldTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.dataFieldTextBox1.PasswordChar = false;
            this.dataFieldTextBox1.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.dataFieldTextBox1.PlaceHolderText = "";
            this.dataFieldTextBox1.SelectedOption = BrickForgeCommanderUI.Controls.Validation.UserChoice.NumericDataValidation;
            this.dataFieldTextBox1.Size = new System.Drawing.Size(250, 41);
            this.dataFieldTextBox1.TabIndex = 2;
            this.dataFieldTextBox1.TextBoxText = "";
            this.dataFieldTextBox1.Texts = "";
            this.dataFieldTextBox1.UnderLineStyle = false;
            // 
            // frmWorkerRegisteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 643);
            this.Controls.Add(this.dataFieldTextBox1);
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
        private Controls.Validation.DataFieldTextBox dataFieldTextBox1;
    }
}