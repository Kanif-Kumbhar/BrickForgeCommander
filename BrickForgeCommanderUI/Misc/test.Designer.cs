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
            this.anyasReport1 = new BrickForgeCommanderUI.Controls.AnyasReport();
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
            this.btnCrying.Click += new System.EventHandler(this.btnCrying_Click);
            // 
            // btnConfused
            // 
            this.btnConfused.Location = new System.Drawing.Point(599, 51);
            this.btnConfused.Name = "btnConfused";
            this.btnConfused.Size = new System.Drawing.Size(130, 72);
            this.btnConfused.TabIndex = 2;
            this.btnConfused.Text = "P";
            this.btnConfused.UseVisualStyleBackColor = true;
            this.btnConfused.Click += new System.EventHandler(this.btnConfused_Click);
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
            // anyasReport1
            // 
            this.anyasReport1.BackColor = System.Drawing.SystemColors.Window;
            this.anyasReport1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.anyasReport1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.anyasReport1.BorderRadius = 0;
            this.anyasReport1.BorderSize = 2;
            this.anyasReport1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.anyasReport1.ForeColor = System.Drawing.Color.DimGray;
            this.anyasReport1.Location = new System.Drawing.Point(436, 352);
            this.anyasReport1.Margin = new System.Windows.Forms.Padding(4);
            this.anyasReport1.MultiLine = false;
            this.anyasReport1.Name = "anyasReport1";
            this.anyasReport1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.anyasReport1.PasswordChar = false;
            this.anyasReport1.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.anyasReport1.PlaceHolderText = "";
            this.anyasReport1.Size = new System.Drawing.Size(250, 39);
            this.anyasReport1.TabIndex = 6;
            this.anyasReport1.TextBoxText = "";
            this.anyasReport1.Texts = "";
            this.anyasReport1.UnderLineStyle = false;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.anyasReport1);
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
        private Controls.AnyasReport anyasReport1;
    }
}