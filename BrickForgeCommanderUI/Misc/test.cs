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
            AnyaReports.Show("Hello", "test", ReportButton.Ok, Anya.Confused);
        }
    }
}
