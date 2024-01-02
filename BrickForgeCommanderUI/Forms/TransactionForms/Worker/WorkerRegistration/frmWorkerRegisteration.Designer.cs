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
            this.submitbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitbutton
            // 
            this.submitbutton.Location = new System.Drawing.Point(657, 181);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(107, 45);
            this.submitbutton.TabIndex = 1;
            this.submitbutton.Text = "button1";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(0, 0);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 26);
            this.tb1.TabIndex = 0;
            // 
            // frmWorkerRegisteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 643);
            this.Controls.Add(this.submitbutton);
            this.Name = "frmWorkerRegisteration";
            this.Load += new System.EventHandler(this.frmWorkerRegisteration_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb1;
    }
}