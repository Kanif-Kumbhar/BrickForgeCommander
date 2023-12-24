namespace BrickForgeCommanderUI.MasterForms
{
    partial class frmModeDetails
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
            this.bfC_Button1 = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.SuspendLayout();
            // 
            // bfC_Button1
            // 
            this.bfC_Button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bfC_Button1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.bfC_Button1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bfC_Button1.BorderRadius = 20;
            this.bfC_Button1.BorderSize = 0;
            this.bfC_Button1.FlatAppearance.BorderSize = 0;
            this.bfC_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfC_Button1.ForeColor = System.Drawing.Color.White;
            this.bfC_Button1.Location = new System.Drawing.Point(245, 145);
            this.bfC_Button1.Name = "bfC_Button1";
            this.bfC_Button1.Size = new System.Drawing.Size(150, 40);
            this.bfC_Button1.TabIndex = 0;
            this.bfC_Button1.Text = "bfC_Button1";
            this.bfC_Button1.TextColor = System.Drawing.Color.White;
            this.bfC_Button1.UseVisualStyleBackColor = false;
            this.bfC_Button1.Click += new System.EventHandler(this.bfC_Button1_Click);
            // 
            // frmModeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 434);
            this.Controls.Add(this.bfC_Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModeDetails";
            this.Text = "frmModeDetails";
            this.Load += new System.EventHandler(this.frmModeDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.BFC_Button bfC_Button1;
    }
}