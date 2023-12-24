namespace BrickForgeCommanderUI.Login___Registeration
{
    partial class frmLogin
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
            this.button2 = new System.Windows.Forms.Button();
            this.btbLogin = new System.Windows.Forms.Button();
            this.CheckbxShowPas = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblResetPwd = new System.Windows.Forms.Label();
            this.lblGetStarted = new System.Windows.Forms.Label();
            this.lblForgotPwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button2.Location = new System.Drawing.Point(20, 396);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(324, 61);
            this.button2.TabIndex = 31;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btbLogin
            // 
            this.btbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbLogin.FlatAppearance.BorderSize = 0;
            this.btbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbLogin.ForeColor = System.Drawing.Color.White;
            this.btbLogin.Location = new System.Drawing.Point(20, 303);
            this.btbLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btbLogin.Name = "btbLogin";
            this.btbLogin.Size = new System.Drawing.Size(324, 61);
            this.btbLogin.TabIndex = 30;
            this.btbLogin.Text = "LOG IN";
            this.btbLogin.UseVisualStyleBackColor = false;
            this.btbLogin.Click += new System.EventHandler(this.btbLogin_Click);
            // 
            // CheckbxShowPas
            // 
            this.CheckbxShowPas.AutoSize = true;
            this.CheckbxShowPas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckbxShowPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckbxShowPas.Location = new System.Drawing.Point(166, 233);
            this.CheckbxShowPas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckbxShowPas.Name = "CheckbxShowPas";
            this.CheckbxShowPas.Size = new System.Drawing.Size(178, 32);
            this.CheckbxShowPas.TabIndex = 29;
            this.CheckbxShowPas.Text = "Show Password";
            this.CheckbxShowPas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckbxShowPas.UseVisualStyleBackColor = true;
            this.CheckbxShowPas.CheckedChanged += new System.EventHandler(this.CheckbxShowPas_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(20, 196);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(324, 27);
            this.txtPassword.TabIndex = 28;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(17, 163);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(105, 28);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Location = new System.Drawing.Point(20, 118);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(324, 27);
            this.txtUserName.TabIndex = 26;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(15, 85);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(121, 28);
            this.lblUserName.TabIndex = 25;
            this.lblUserName.Text = "User Name:";
            // 
            // lblResetPwd
            // 
            this.lblResetPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblResetPwd.AutoSize = true;
            this.lblResetPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResetPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblResetPwd.Location = new System.Drawing.Point(98, 523);
            this.lblResetPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResetPwd.Name = "lblResetPwd";
            this.lblResetPwd.Size = new System.Drawing.Size(157, 28);
            this.lblResetPwd.TabIndex = 33;
            this.lblResetPwd.Text = "Reset Password";
            this.lblResetPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResetPwd.Click += new System.EventHandler(this.lblCreateAccount_Click);
            // 
            // lblGetStarted
            // 
            this.lblGetStarted.AutoSize = true;
            this.lblGetStarted.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetStarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblGetStarted.Location = new System.Drawing.Point(13, 21);
            this.lblGetStarted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGetStarted.Name = "lblGetStarted";
            this.lblGetStarted.Size = new System.Drawing.Size(135, 40);
            this.lblGetStarted.TabIndex = 24;
            this.lblGetStarted.Text = "LOGIN";
            // 
            // lblForgotPwd
            // 
            this.lblForgotPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblForgotPwd.AutoSize = true;
            this.lblForgotPwd.Font = new System.Drawing.Font("Nirmala UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblForgotPwd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblForgotPwd.Location = new System.Drawing.Point(85, 488);
            this.lblForgotPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForgotPwd.Name = "lblForgotPwd";
            this.lblForgotPwd.Size = new System.Drawing.Size(192, 30);
            this.lblForgotPwd.TabIndex = 32;
            this.lblForgotPwd.Text = "Forgot Password ?";
            this.lblForgotPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 585);
            this.Controls.Add(this.lblForgotPwd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btbLogin);
            this.Controls.Add(this.CheckbxShowPas);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblResetPwd);
            this.Controls.Add(this.lblGetStarted);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(362, 585);
            this.MinimumSize = new System.Drawing.Size(362, 585);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btbLogin;
        private System.Windows.Forms.CheckBox CheckbxShowPas;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblResetPwd;
        private System.Windows.Forms.Label lblGetStarted;
        private System.Windows.Forms.Label lblForgotPwd;
    }
}