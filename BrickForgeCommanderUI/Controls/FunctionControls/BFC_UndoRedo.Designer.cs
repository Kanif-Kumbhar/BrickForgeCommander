namespace BrickForgeCommanderUI.Controls.FunctionControls
{
    partial class BFC_UndoRedo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUndo = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.btnRedo = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.SuspendLayout();
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUndo.BackColor = System.Drawing.SystemColors.Control;
            this.btnUndo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnUndo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUndo.BorderRadius = 0;
            this.btnUndo.BorderSize = 0;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.Image = global::BrickForgeCommanderUI.Properties.Resources.icons8_undo_40;
            this.btnUndo.Location = new System.Drawing.Point(7, 5);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(49, 40);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.TextColor = System.Drawing.Color.White;
            this.btnUndo.UseVisualStyleBackColor = false;
            // 
            // btnRedo
            // 
            this.btnRedo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedo.BackColor = System.Drawing.SystemColors.Control;
            this.btnRedo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnRedo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRedo.BorderRadius = 0;
            this.btnRedo.BorderSize = 0;
            this.btnRedo.FlatAppearance.BorderSize = 0;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.ForeColor = System.Drawing.Color.White;
            this.btnRedo.Image = global::BrickForgeCommanderUI.Properties.Resources.icons8_redo_40;
            this.btnRedo.Location = new System.Drawing.Point(56, 5);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(49, 40);
            this.btnRedo.TabIndex = 1;
            this.btnRedo.TextColor = System.Drawing.Color.White;
            this.btnRedo.UseVisualStyleBackColor = false;
            // 
            // BFC_UndoRedo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.MaximumSize = new System.Drawing.Size(112, 50);
            this.MinimumSize = new System.Drawing.Size(112, 50);
            this.Name = "BFC_UndoRedo";
            this.Size = new System.Drawing.Size(112, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private BFC_Button btnUndo;
        private BFC_Button btnRedo;
    }
}
