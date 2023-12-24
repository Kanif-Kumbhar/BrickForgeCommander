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
            // frmModeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 434);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModeDetails";
            this.Text = "frmModeDetails";
            this.Load += new System.EventHandler(this.frmModeDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.BFC_DropDownMenu bfC_DropDownMenu1;
    }
}