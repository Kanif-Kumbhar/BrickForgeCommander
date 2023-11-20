using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Dashboard
{
    public partial class frmDashBoard : Form
    {
        #region Initialization

        bool sideBarExpand;
        bool masterCollapsed;
        bool productionCollapsed;
        //  bool orderCollapsed;
        // bool salesCollapsed;
        // bool reportCollapsed;
        private Padding initialMarginbtnToday;
        private Padding initialMarginbtnThisMonth;

        #endregion
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {

        }

        #region TimerCode

        private void timerMaster_Tick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                if (masterCollapsed)
                {
                    fpnlMasterContainer.Height += 10;
                    if (fpnlMasterContainer.Height == fpnlMasterContainer.MaximumSize.Height)
                    {
                        masterCollapsed = false;
                        timerMaster.Stop();
                    }
                }
                else
                {
                    fpnlMasterContainer.Height -= 10;
                    if (fpnlMasterContainer.Height == fpnlMasterContainer.MinimumSize.Height)
                    {
                        masterCollapsed = true;
                        timerMaster.Stop();
                    }
                }
            }
        }

        private void timerProduction_Tick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                if (productionCollapsed)
                {
                    fpnlProduction.Height += 10;
                    if (fpnlProduction.Height == fpnlProduction.MaximumSize.Height)
                    {
                        productionCollapsed = false;
                        timerProduction.Stop();
                    }
                }
                else
                {
                    fpnlProduction.Height -= 10;
                    if (fpnlProduction.Height == fpnlProduction.MinimumSize.Height)
                    {
                        productionCollapsed = true;
                        timerProduction.Stop();
                    }
                }
            }
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                //if sidebar is expand,minimize
                siderBar.Width -= 10;
                pnlMain.Left = siderBar.Right;
                if (siderBar.Width == siderBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                siderBar.Width += 10;
                pnlMain.Left = siderBar.Right;
                if (siderBar.Width == siderBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        #endregion

        #region TimerCall



        #endregion

        #region NavButtons

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void pbMaximize_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void btnMaster_Click(object sender, EventArgs e)
        {
            timerMaster.Start();
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            timerProduction.Start();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
           sideBarTimer.Start();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void frmDashBoard_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Adjust the width of multiple buttons when the form is maximized
                AdjustButtonPadding();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                RestoreInitialMargin();
            }
        }

       
        private void AdjustButtonPadding()
        {
            initialMarginbtnThisMonth = btnThisMonth.Margin;
            initialMarginbtnToday = btnToday.Margin;
            // Calculate the new padding for each button based on the form's size
            //int newButtonPadding = (this.Width - 2 * btnToday.Left - btnToday.Width) / 4;
            int marginIncrease = 15;
            int newButtonPadding = btnToday.Margin.Left + marginIncrease;

            // Set the new padding for each button
            btnToday.Margin = new Padding(newButtonPadding, btnToday.Margin.Left, newButtonPadding, btnToday.Margin.Right);
            btnThisMonth.Margin = new Padding(newButtonPadding, btnThisMonth.Margin.Left, newButtonPadding, btnThisMonth.Margin.Right);
        }

        private void RestoreInitialMargin()
        {
            // Restore the initial margin for each button
            btnToday.Margin = initialMarginbtnToday;
            btnThisMonth.Margin = initialMarginbtnThisMonth;
        }
    }
}
