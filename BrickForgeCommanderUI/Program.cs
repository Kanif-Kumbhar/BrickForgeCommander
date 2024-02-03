using System;
using System.Windows.Forms;
using BrickForgeCommanderUI.Dashboard;
using BrickForgeCommanderUI.Forms.TransactionForms.Worker;
using BrickForgeCommanderUI.Forms.TransactionForms.Worker.WorkerRegistration;
using BrickForgeCommanderUI.Misc;


namespace BrickForgeCommanderUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmStaffList());
        }
    }
}
