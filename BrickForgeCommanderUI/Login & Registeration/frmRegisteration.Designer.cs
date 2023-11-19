namespace BrickForgeCommanderUI.Login___Registeration
{
    partial class frmRegisteration
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
            this.lblAlready = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btbRegister = new System.Windows.Forms.Button();
            this.CheckbxShowPas = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblBackToLogIN = new System.Windows.Forms.Label();
            this.lblGetStarted = new System.Windows.Forms.Label();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.lblConPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAlready
            // 
            this.lblAlready.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAlready.AutoSize = true;
            this.lblAlready.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAlready.Location = new System.Drawing.Point(60, 570);
            this.lblAlready.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlready.Name = "lblAlready";
            this.lblAlready.Size = new System.Drawing.Size(255, 28);
            this.lblAlready.TabIndex = 42;
            this.lblAlready.Text = "Already Have An Account";
            this.lblAlready.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button2.Location = new System.Drawing.Point(25, 493);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(324, 61);
            this.button2.TabIndex = 41;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btbRegister
            // 
            this.btbRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btbRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbRegister.FlatAppearance.BorderSize = 0;
            this.btbRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbRegister.ForeColor = System.Drawing.Color.White;
            this.btbRegister.Location = new System.Drawing.Point(25, 399);
            this.btbRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btbRegister.Name = "btbRegister";
            this.btbRegister.Size = new System.Drawing.Size(324, 61);
            this.btbRegister.TabIndex = 40;
            this.btbRegister.Text = "REGISTER";
            this.btbRegister.UseVisualStyleBackColor = false;
            this.btbRegister.Click += new System.EventHandler(this.btbRegister_Click);
            // 
            // CheckbxShowPas
            // 
            this.CheckbxShowPas.AutoSize = true;
            this.CheckbxShowPas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckbxShowPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckbxShowPas.Location = new System.Drawing.Point(171, 329);
            this.CheckbxShowPas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckbxShowPas.Name = "CheckbxShowPas";
            this.CheckbxShowPas.Size = new System.Drawing.Size(178, 32);
            this.CheckbxShowPas.TabIndex = 39;
            this.CheckbxShowPas.Text = "Show Password";
            this.CheckbxShowPas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckbxShowPas.UseVisualStyleBackColor = true;
            this.CheckbxShowPas.CheckedChanged += new System.EventHandler(this.CheckbxShowPas_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(20, 199);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(324, 27);
            this.txtPassword.TabIndex = 38;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(17, 166);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(105, 28);
            this.lblPassword.TabIndex = 37;
            this.lblPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Location = new System.Drawing.Point(20, 121);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(324, 27);
            this.txtUserName.TabIndex = 36;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(15, 88);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(121, 28);
            this.lblUserName.TabIndex = 35;
            this.lblUserName.Text = "User Name:";
            // 
            // lblBackToLogIN
            // 
            this.lblBackToLogIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblBackToLogIN.AutoSize = true;
            this.lblBackToLogIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBackToLogIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblBackToLogIN.Location = new System.Drawing.Point(107, 610);
            this.lblBackToLogIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackToLogIN.Name = "lblBackToLogIN";
            this.lblBackToLogIN.Size = new System.Drawing.Size(147, 28);
            this.lblBackToLogIN.TabIndex = 43;
            this.lblBackToLogIN.Text = "Back To LogIN";
            this.lblBackToLogIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBackToLogIN.Click += new System.EventHandler(this.lblBackToLogIN_Click);
            // 
            // lblGetStarted
            // 
            this.lblGetStarted.AutoSize = true;
            this.lblGetStarted.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetStarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblGetStarted.Location = new System.Drawing.Point(13, 24);
            this.lblGetStarted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGetStarted.Name = "lblGetStarted";
            this.lblGetStarted.Size = new System.Drawing.Size(300, 40);
            this.lblGetStarted.TabIndex = 34;
            this.lblGetStarted.Text = "REGISTRATION";
            // 
            // txtConPassword
            // 
            this.txtConPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtConPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConPassword.Location = new System.Drawing.Point(23, 292);
            this.txtConPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.PasswordChar = '*';
            this.txtConPassword.Size = new System.Drawing.Size(324, 27);
            this.txtConPassword.TabIndex = 45;
            this.txtConPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConPassword_KeyDown);
            // 
            // lblConPassword
            // 
            this.lblConPassword.AutoSize = true;
            this.lblConPassword.Location = new System.Drawing.Point(20, 259);
            this.lblConPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConPassword.Name = "lblConPassword";
            this.lblConPassword.Size = new System.Drawing.Size(187, 28);
            this.lblConPassword.TabIndex = 44;
            this.lblConPassword.Text = "Confirm Password:";
            // 
            // frmRegisteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(362, 652);
            this.Controls.Add(this.txtConPassword);
            this.Controls.Add(this.lblConPassword);
            this.Controls.Add(this.lblAlready);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btbRegister);
            this.Controls.Add(this.CheckbxShowPas);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblBackToLogIN);
            this.Controls.Add(this.lblGetStarted);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(362, 652);
            this.MinimumSize = new System.Drawing.Size(362, 652);
            this.Name = "frmRegisteration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegisteration";
            this.Load += new System.EventHandler(this.frmRegisteration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlready;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btbRegister;
        private System.Windows.Forms.CheckBox CheckbxShowPas;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblBackToLogIN;
        private System.Windows.Forms.Label lblGetStarted;
        private System.Windows.Forms.TextBox txtConPassword;
        private System.Windows.Forms.Label lblConPassword;
    }
}