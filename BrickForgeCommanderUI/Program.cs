﻿using BrickForgeCommanderUI.Dashboard;
using BrickForgeCommanderUI.Forms.TransactionForms.Worker.WorkerRegistration;
using BrickForgeCommanderUI.MasterForms.Menu;
using BrickForgeCommanderUI.Misc;
using BrickForgeCommanderUI.Misc.Anya_sReport;
using System;
using System.Windows.Forms;

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
            Application.Run(new frmWorkerRegisteration());
        }
    }
}
