using BrickForgeCommanderUI.Misc.Anya_sReport;
using System;
using System.Windows.Forms;
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
    }
}
