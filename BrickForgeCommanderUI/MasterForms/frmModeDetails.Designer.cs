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
            this.components = new System.ComponentModel.Container();
            this.bfC_DropDownMenu1 = new BrickForgeCommanderUI.Controls.BFC_DropDownMenu(this.components);
            this.bfC_TextBox1 = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.bfC_TextBox2 = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.SuspendLayout();
            // 
            // bfC_DropDownMenu1
            // 
            this.bfC_DropDownMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bfC_DropDownMenu1.IsMainMenu = false;
            this.bfC_DropDownMenu1.MenuItemHeight = 25;
            this.bfC_DropDownMenu1.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.bfC_DropDownMenu1.Name = "bfC_DropDownMenu1";
            this.bfC_DropDownMenu1.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.bfC_DropDownMenu1.Size = new System.Drawing.Size(61, 4);
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
            this.bfC_TextBox1.Location = new System.Drawing.Point(468, 203);
            this.bfC_TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.bfC_TextBox1.MultiLine = false;
            this.bfC_TextBox1.Name = "bfC_TextBox1";
            this.bfC_TextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.bfC_TextBox1.PasswordChar = false;
            this.bfC_TextBox1.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.bfC_TextBox1.PlaceHolderText = "";
            this.bfC_TextBox1.Size = new System.Drawing.Size(250, 39);
            this.bfC_TextBox1.TabIndex = 1;
            this.bfC_TextBox1.Texts = "";
            this.bfC_TextBox1.UnderLineStyle = false;
            this.bfC_TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bfC_TextBox1_KeyDown);
            // 
            // bfC_TextBox2
            // 
            this.bfC_TextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.bfC_TextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.bfC_TextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.bfC_TextBox2.BorderRadius = 0;
            this.bfC_TextBox2.BorderSize = 2;
            this.bfC_TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.bfC_TextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.bfC_TextBox2.Location = new System.Drawing.Point(552, 290);
            this.bfC_TextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.bfC_TextBox2.MultiLine = false;
            this.bfC_TextBox2.Name = "bfC_TextBox2";
            this.bfC_TextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.bfC_TextBox2.PasswordChar = false;
            this.bfC_TextBox2.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.bfC_TextBox2.PlaceHolderText = "";
            this.bfC_TextBox2.Size = new System.Drawing.Size(250, 39);
            this.bfC_TextBox2.TabIndex = 2;
            this.bfC_TextBox2.Texts = "";
            this.bfC_TextBox2.UnderLineStyle = false;
            // 
            // frmModeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bfC_TextBox2);
            this.Controls.Add(this.bfC_TextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModeDetails";
            this.Text = "frmModeDetails";
            this.Load += new System.EventHandler(this.frmModeDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.BFC_DropDownMenu bfC_DropDownMenu1;
        private Controls.BFC_TextBox bfC_TextBox1;
        private Controls.BFC_TextBox bfC_TextBox2;
    }
}