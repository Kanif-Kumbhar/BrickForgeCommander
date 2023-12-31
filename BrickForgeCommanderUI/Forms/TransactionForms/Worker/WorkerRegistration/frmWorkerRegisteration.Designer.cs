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
            this.button1 = new System.Windows.Forms.Button();
            this.bfC_TextBox1 = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.requiredFieldTextBox1 = new BrickForgeCommanderUI.Controls.Validation.RequiredFieldTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bfC_TextBox1
            // 
            this.bfC_TextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.bfC_TextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.bfC_TextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.bfC_TextBox1.BorderRadius = 0;
            this.bfC_TextBox1.BorderSize = 2;
            this.bfC_TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.bfC_TextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.bfC_TextBox1.Location = new System.Drawing.Point(727, 296);
            this.bfC_TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.bfC_TextBox1.MultiLine = false;
            this.bfC_TextBox1.Name = "bfC_TextBox1";
            this.bfC_TextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.bfC_TextBox1.PasswordChar = false;
            this.bfC_TextBox1.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.bfC_TextBox1.PlaceHolderText = "";
            this.bfC_TextBox1.Size = new System.Drawing.Size(250, 39);
            this.bfC_TextBox1.TabIndex = 3;
            this.bfC_TextBox1.TextBoxText = "";
            this.bfC_TextBox1.Texts = "";
            this.bfC_TextBox1.UnderLineStyle = false;
            // 
            // requiredFieldTextBox1
            // 
            this.requiredFieldTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.requiredFieldTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.requiredFieldTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.requiredFieldTextBox1.BorderRadius = 0;
            this.requiredFieldTextBox1.BorderSize = 2;
            this.requiredFieldTextBox1.ConnectedButton = this.button1;
            this.requiredFieldTextBox1.ErrorColor = System.Drawing.Color.Red;
            this.requiredFieldTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.requiredFieldTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.requiredFieldTextBox1.Location = new System.Drawing.Point(454, 199);
            this.requiredFieldTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.requiredFieldTextBox1.MultiLine = false;
            this.requiredFieldTextBox1.Name = "requiredFieldTextBox1";
            this.requiredFieldTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.requiredFieldTextBox1.PasswordChar = false;
            this.requiredFieldTextBox1.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.requiredFieldTextBox1.PlaceHolderText = "dd";
            this.requiredFieldTextBox1.Size = new System.Drawing.Size(250, 39);
            this.requiredFieldTextBox1.TabIndex = 2;
            this.requiredFieldTextBox1.TextBoxText = "";
            this.requiredFieldTextBox1.Texts = "";
            this.requiredFieldTextBox1.UnderLineStyle = false;
            // 
            // frmWorkerRegisteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 643);
            this.Controls.Add(this.bfC_TextBox1);
            this.Controls.Add(this.requiredFieldTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "frmWorkerRegisteration";
            this.Load += new System.EventHandler(this.frmWorkerRegisteration_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Controls.Validation.RequiredFieldTextBox requiredFieldTextBox1;
        private Controls.BFC_TextBox bfC_TextBox1;
    }
}