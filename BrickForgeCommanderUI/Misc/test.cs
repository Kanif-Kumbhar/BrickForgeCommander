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

        private void btnAngry_Click(object sender, EventArgs e)
        {
            AnyaReports.Show("Hello");
        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            AnyaReports.Show("Hello my name is anya and im 88 year old how are yu meuodknddkdvvsnvvkvn", "test", ReportButton.OkCancle, Anya.Confused);
        }

        private void btnCrying_Click(object sender, EventArgs e)
        {
            AnyaReports.Show("Hello","Testttt",ReportButton.Retry);
        }

        private void btnConfused_Click(object sender, EventArgs e)
        {
            AnyaReports.Show("Hello", "Testttt", ReportButton.OkCancleRetry);
        }
    }
}
