namespace BrickForgeCommanderUI.Login___Registeration
{
    partial class frmForgotPwd
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
            this.btnResetPwd = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.CheckbxShowKey = new System.Windows.Forms.CheckBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbShowPwd = new System.Windows.Forms.CheckBox();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.lblConfirmPwd = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResetPwd
            // 
            this.btnResetPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnResetPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPwd.FlatAppearance.BorderSize = 0;
            this.btnResetPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPwd.ForeColor = System.Drawing.Color.White;
            this.btnResetPwd.Location = new System.Drawing.Point(23, 593);
            this.btnResetPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetPwd.Name = "btnResetPwd";
            this.btnResetPwd.Size = new System.Drawing.Size(324, 61);
            this.btnResetPwd.TabIndex = 40;
            this.btnResetPwd.Text = "RESET PASSWORD";
            this.btnResetPwd.UseVisualStyleBackColor = false;
            this.btnResetPwd.Click += new System.EventHandler(this.btnResetPwd_Click_1);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Location = new System.Drawing.Point(23, 128);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(324, 27);
            this.txtUserName.TabIndex = 36;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(18, 95);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(121, 28);
            this.lblUserName.TabIndex = 35;
            this.lblUserName.Text = "User Name:";
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblHead.Location = new System.Drawing.Point(16, 31);
            this.lblHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(299, 33);
            this.lblHead.TabIndex = 34;
            this.lblHead.Text = "RESET PASSWORD";
            // 
            // CheckbxShowKey
            // 
            this.CheckbxShowKey.AutoSize = true;
            this.CheckbxShowKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckbxShowKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckbxShowKey.Location = new System.Drawing.Point(214, 248);
            this.CheckbxShowKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckbxShowKey.Name = "CheckbxShowKey";
            this.CheckbxShowKey.Size = new System.Drawing.Size(125, 32);
            this.CheckbxShowKey.TabIndex = 44;
            this.CheckbxShowKey.Text = "Show Key";
            this.CheckbxShowKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckbxShowKey.UseVisualStyleBackColor = true;
            this.CheckbxShowKey.CheckedChanged += new System.EventHandler(this.CheckbxShowKey_CheckedChanged);
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKey.Location = new System.Drawing.Point(21, 211);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '*';
            this.txtKey.Size = new System.Drawing.Size(324, 27);
            this.txtKey.TabIndex = 43;
            this.txtKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKey_KeyDown);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(18, 178);
            this.lblKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(200, 28);
            this.lblKey.TabIndex = 42;
            this.lblKey.Text = "Authentication Key:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(21, 401);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(324, 27);
            this.txtPassword.TabIndex = 46;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(18, 368);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(154, 28);
            this.lblPassword.TabIndex = 45;
            this.lblPassword.Text = "New Password:";
            // 
            // cbShowPwd
            // 
            this.cbShowPwd.AutoSize = true;
            this.cbShowPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowPwd.Location = new System.Drawing.Point(167, 535);
            this.cbShowPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbShowPwd.Name = "cbShowPwd";
            this.cbShowPwd.Size = new System.Drawing.Size(178, 32);
            this.cbShowPwd.TabIndex = 50;
            this.cbShowPwd.Text = "Show Password";
            this.cbShowPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbShowPwd.UseVisualStyleBackColor = true;
            this.cbShowPwd.CheckedChanged += new System.EventHandler(this.cbShowPwd_CheckedChanged);
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtConfirmPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPwd.Location = new System.Drawing.Point(21, 493);
            this.txtConfirmPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(324, 27);
            this.txtConfirmPwd.TabIndex = 49;
            this.txtConfirmPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPwd_KeyDown);
            // 
            // lblConfirmPwd
            // 
            this.lblConfirmPwd.AutoSize = true;
            this.lblConfirmPwd.Location = new System.Drawing.Point(18, 460);
            this.lblConfirmPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            this.lblConfirmPwd.Size = new System.Drawing.Size(187, 28);
            this.lblConfirmPwd.TabIndex = 48;
            this.lblConfirmPwd.Text = "Confirm Password:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(19, 288);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(324, 61);
            this.btnSubmit.TabIndex = 51;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmForgotPwd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 364);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbShowPwd);
            this.Controls.Add(this.txtConfirmPwd);
            this.Controls.Add(this.lblConfirmPwd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.CheckbxShowKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btnResetPwd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(362, 671);
            this.MinimumSize = new System.Drawing.Size(362, 364);
            this.Name = "frmForgotPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmForgotPwd";
            this.Load += new System.EventHandler(this.frmForgotPwd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmForgotPwd_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnResetPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.CheckBox CheckbxShowKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox cbShowPwd;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.Label lblConfirmPwd;
        private System.Windows.Forms.Button btnSubmit;
    }
}