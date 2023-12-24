namespace BrickForgeCommanderUI.Misc
{
    partial class test
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
            this.btnAngry = new System.Windows.Forms.Button();
            this.btnCrying = new System.Windows.Forms.Button();
            this.btnConfused = new System.Windows.Forms.Button();
            this.btnNervous = new System.Windows.Forms.Button();
            this.btnSmile = new System.Windows.Forms.Button();
            this.btnHappy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAngry
            // 
            this.btnAngry.Location = new System.Drawing.Point(38, 51);
            this.btnAngry.Name = "btnAngry";
            this.btnAngry.Size = new System.Drawing.Size(130, 72);
            this.btnAngry.TabIndex = 0;
            this.btnAngry.Text = "A";
            this.btnAngry.UseVisualStyleBackColor = true;
            this.btnAngry.Click += new System.EventHandler(this.btnAngry_Click);
            // 
            // btnCrying
            // 
            this.btnCrying.Location = new System.Drawing.Point(320, 51);
            this.btnCrying.Name = "btnCrying";
            this.btnCrying.Size = new System.Drawing.Size(130, 72);
            this.btnCrying.TabIndex = 1;
            this.btnCrying.Text = "C";
            this.btnCrying.UseVisualStyleBackColor = true;
            // 
            // btnConfused
            // 
            this.btnConfused.Location = new System.Drawing.Point(599, 51);
            this.btnConfused.Name = "btnConfused";
            this.btnConfused.Size = new System.Drawing.Size(130, 72);
            this.btnConfused.TabIndex = 2;
            this.btnConfused.Text = "P";
            this.btnConfused.UseVisualStyleBackColor = true;
            // 
            // btnNervous
            // 
            this.btnNervous.Location = new System.Drawing.Point(320, 210);
            this.btnNervous.Name = "btnNervous";
            this.btnNervous.Size = new System.Drawing.Size(130, 72);
            this.btnNervous.TabIndex = 3;
            this.btnNervous.Text = "N";
            this.btnNervous.UseVisualStyleBackColor = true;
            // 
            // btnSmile
            // 
            this.btnSmile.Location = new System.Drawing.Point(599, 210);
            this.btnSmile.Name = "btnSmile";
            this.btnSmile.Size = new System.Drawing.Size(130, 72);
            this.btnSmile.TabIndex = 4;
            this.btnSmile.Text = "S";
            this.btnSmile.UseVisualStyleBackColor = true;
            // 
            // btnHappy
            // 
            this.btnHappy.Location = new System.Drawing.Point(38, 210);
            this.btnHappy.Name = "btnHappy";
            this.btnHappy.Size = new System.Drawing.Size(130, 72);
            this.btnHappy.TabIndex = 5;
            this.btnHappy.Text = "H";
            this.btnHappy.UseVisualStyleBackColor = true;
            this.btnHappy.Click += new System.EventHandler(this.btnHappy_Click);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHappy);
            this.Controls.Add(this.btnSmile);
            this.Controls.Add(this.btnNervous);
            this.Controls.Add(this.btnConfused);
            this.Controls.Add(this.btnCrying);
            this.Controls.Add(this.btnAngry);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAngry;
        private System.Windows.Forms.Button btnCrying;
        private System.Windows.Forms.Button btnConfused;
        private System.Windows.Forms.Button btnNervous;
        private System.Windows.Forms.Button btnSmile;
        private System.Windows.Forms.Button btnHappy;
    }
}