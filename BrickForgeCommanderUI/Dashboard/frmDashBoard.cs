using BrickForgeCommanderUI.Dashboard.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private Button currentButton;

        #endregion

        private DashBoard model;

        public frmDashBoard()
        {
            InitializeComponent();
            //Default - Last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7d.Select();

            HighlightCurrentButton(btnLast7d);

            model = new DashBoard();
            LoadData();
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Text;
            lblEndDate.Text = dtpEndDate.Text;
            dgvUnderStock.Columns[1].Width = 50;
        }

        #region Functions

        private void HighlightCurrentButton(object button)
        {
            var btn = (Button)button;

            btn.BackColor = btnLast30d.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;

            if(currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = this.BackColor;
                currentButton.ForeColor = Color.FromArgb(123, 141, 181); 
            }
            currentButton = btn;

            if(btn == btnCustom)
            {
                dtpStartDate.Enabled = true;
                dtpEndDate.Enabled = true;
                btnOk.Visible = true;
                lblStartDate.Cursor = Cursors.Hand;
                lblEndDate.Cursor = Cursors.Hand;
            }
            else
            {
                dtpStartDate.Enabled = false;
                dtpEndDate.Enabled = false;
                btnOk.Visible = false;
                lblStartDate.Cursor = Cursors.Default;
                lblEndDate.Cursor = Cursors.Default;
            }
        }

        static void max()
        {
            
        }

        #endregion

        #region DashBoardCharts

        private void LoadData()
        {
            var refereshData  = model.LoadData(dtpStartDate.Value,dtpEndDate.Value);
            if (refereshData == true)
            {
                lblTotalOrders.Text = model.NumOrders.ToString();
                lblTotalRevenue.Text = "₹" + model.TotalRevenue.ToString();
                lblTotalProfit.Text = "₹" + model.TotalProfit.ToString();

                lblNumberOfCustomer.Text = model.NumCustomers.ToString();
                lblNumberOfSupplier.Text = model.NumSuppliers.ToString();
                lblNumberOfProducts.Text = model.NumProducts.ToString();

                chartGrossRevenue.DataSource = model.GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "Date";
                chartGrossRevenue.Series[0].YValueMembers = "Total Amount";
                chartGrossRevenue.DataBind();

                chartTop5Products.DataSource = model.TopProductsList;
                chartTop5Products.Series[0].XValueMember = "Key";
                chartTop5Products.Series[0].YValueMembers = "Value";

                dgvUnderStock.DataSource = model.UnderStockList;
                dgvUnderStock.Columns[0].HeaderText = "Item";
                dgvUnderStock.Columns[1].HeaderText = "Units";

                Console.WriteLine("Loaded View: ");
            }
            else
            {
                Console.WriteLine("View not loaded, same query");
            }
        }

        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOk.Visible = false;
        }
        #endregion

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

        #region Buttons Click Events

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
          
        }



        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
            HighlightCurrentButton(sender);

        }

        private void btnLast7d_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
            HighlightCurrentButton(sender);

        }
        private void btnLast30d_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
            HighlightCurrentButton(sender);

        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year,DateTime.Today.Month,1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
            HighlightCurrentButton(sender);
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            HighlightCurrentButton(sender);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        #endregion

        private void lblStartDate_Click(object sender, EventArgs e)
        {
            if(currentButton == btnCustom)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustom)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Text;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblEndDate.Text = dtpEndDate.Text;
        }
    }
}
