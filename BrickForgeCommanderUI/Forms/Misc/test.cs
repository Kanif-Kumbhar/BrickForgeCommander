using BrickForgeCommanderUI.Misc.Anya_sReport;
using System;
using System.Windows.Forms;
using BrickForgeCommanderUI.Helpers;
using BrickForgeCommanderUI.Login___Registeration;
using static BrickForgeCommanderUI.Misc.Anya_sReport.AnyaReports;

namespace BrickForgeCommanderUI.Misc
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
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

        private void btnConfused_Click(object sender, EventArgs e)
        {
            
        }

        private void bfcNewButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
