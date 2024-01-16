using System;
using System.Windows.Forms;
using BrickForgeCommanderUI.Forms.MasterForms.Master;


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
            Application.Run(new frmVenderTypeDetails());
        }
    }
}
