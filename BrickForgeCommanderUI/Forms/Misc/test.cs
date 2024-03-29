﻿using BrickForgeCommanderUI.Misc.Anya_sReport;
using System;
using System.Windows.Forms;
using BrickForgeCommanderUI.Helpers;
using static BrickForgeCommanderUI.Misc.Anya_sReport.AnyaReports;

namespace BrickForgeCommanderUI.Misc
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Create DataGridView
            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;

            // Create Columns
            DataGridViewTextBoxColumn clmDocumentName = new DataGridViewTextBoxColumn();
            clmDocumentName.HeaderText = "Document Name";
            clmDocumentName.Name = "clmDocumentName";

            DataGridViewImageColumn clmDocumentPreview = new DataGridViewImageColumn();
            clmDocumentPreview.HeaderText = "Document Preview";
            clmDocumentPreview.Name = "clmDocumentPreview";

            DataGridViewButtonColumn clmAction = new DataGridViewButtonColumn();
            clmAction.HeaderText = "Action";
            clmAction.Name = "clmAction";
            clmAction.Text = "Upload";
            clmAction.UseColumnTextForButtonValue = true;

            // Add Columns to DataGridView
            dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                clmDocumentName,
                clmDocumentPreview,
                clmAction
            });

            // Add DataGridView to Form
            Controls.Add(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = AnyaReports.Show("Are you sure you want to delete this record?", "Confirm Delete", ReportButton.OkCancle,Anya.Crying );

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                // User clicked 'No' or closed the message box
                MessageBox.Show("Delete operation canceled.", "Operation Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           AnyaReports.Show("Are you sure you want to delete this record?", "Confirm Delete", ReportButton.OkCancleRetry, Anya.Crying);
        }

        private void bfC_Button1_Click(object sender, EventArgs e)
        {
            AnyaReports.Show("Hello");
        }

        private void btnNervous_Click(object sender, EventArgs e)
        {
            if ((DialogResult  = AnyaReports.Show("Hello", "Testing", ReportButton.YesNoCancle, Anya.Nervous)) == DialogResult.Yes)
            {
                AnyaReports.Show("Done","",ReportButton.Ok,Anya.Crying);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (ShortcutKeyHandler.ProcessShortcutKeys(this, keyData))
            {
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnConfused_Click(object sender, EventArgs e)
        {
            
        }

        private void bfcNewButton1_Click(object sender, EventArgs e)
        {

        }

        private void bfC_Button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("A");
        }

        private void bfC_Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("B");
        }

        private void bfC_Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C");
        }

        private void bfC_Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("D");
        }

    }
}
