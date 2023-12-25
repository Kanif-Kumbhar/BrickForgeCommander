using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Misc.Anya_sReport
{
    public partial class AnyaReports : Form
    {

        #region DialogResults
        public static DialogResult Show(string text)
        {
            AnyaReports customDialog = new AnyaReports(text);
            return customDialog.ShowDialog();
        }

        public static DialogResult Show(string text, string caption)
        {
            AnyaReports customDialog = new AnyaReports(text, caption);
            return customDialog.ShowDialog();
        }

        public static DialogResult Show(string text, string caption, ReportButton buttons)
        {
            AnyaReports customDialog = new AnyaReports(text, caption, buttons);
            return customDialog.ShowDialog();
        }

        public static DialogResult Show(string text, string caption, ReportButton buttons, Anya mood)
        {
            AnyaReports customDialog = new AnyaReports(text, caption, buttons, mood);
            return customDialog.ShowDialog();
        }
        #endregion

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );
        public AnyaReports()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        public AnyaReports(string text)
            : this()
        {
            btnRetry.Visible = false;
            btnCancle.Visible = false;

            txtReport.Text = text;
        }

        public AnyaReports(string text, string caption)
            : this(text)
        {
            btnRetry.Visible = false;
            btnCancle.Visible = false;

            lblCaption.Text = caption;
        }

        public AnyaReports(string text, string caption, ReportButton buttons)
            : this(text, caption)
        {
            GetButtons(buttons);
        }

        public AnyaReports(string text, string caption, ReportButton buttons, Anya mood)
            : this(text, caption, buttons)
        {
            GetAnyaMood(mood);
        }
        public AnyaReports(string text, string caption, ReportButton buttons, Anya mood, ReportType isScrollable)
             : this(text, caption, buttons, mood)
        {
            GetReportType(isScrollable);
        }

        private void AnyaReports_Load(object sender, EventArgs e)
        {
            txtReport.ReadOnly = true;
            this.AcceptButton = btnCancle;
        }

        private void GetAnyaMood(Anya mood)
        {
            switch (mood)
            {
                case Anya.Angry:
                    picboxAnya.Image = Properties.Resources.Angry_Anya;
                    break;
                case Anya.Confused:
                    picboxAnya.Image = Properties.Resources.Confused_Anya;
                    break;
                case Anya.Crying:
                    picboxAnya.Image = Properties.Resources.Crying_Anya;
                    break;
                case Anya.Happy:
                    picboxAnya.Image = Properties.Resources.Happy_Anya;
                    break;
                case Anya.Nervous:
                    picboxAnya.Image = Properties.Resources.Nervous_Anya;
                    break;
                case Anya.Smile:
                    picboxAnya.Image = Properties.Resources.Smile_Anya;
                    break;
                default:
                    break;
            }
        }

        private void GetButtons(ReportButton button)
        {
            btnOk.Visible = false;
            btnRetry.Visible = false;
            btnCancle.Visible = false;

            switch (button)
            {
                case ReportButton.Ok:
                    btnOk.Visible = true;
                    break;
                case ReportButton.OkCancle:
                    btnOk.Visible = true;
                    btnCancle.Visible = true;
                    SwapButtons(btnOk, btnCancle);
                    break;
                case ReportButton.Retry:
                    btnRetry.Visible = true;
                    SwapButtons(btnRetry, btnOk);
                    break;
                case ReportButton.OkCancleRetry:
                    btnOk.Visible = true;
                    btnRetry.Visible = true;
                    btnCancle.Visible = true;
                    SwapButtons(btnOk, btnRetry);
                    break;
                default:
                    break;
            }
        }

        private void GetReportType(ReportType isScroable)
        {
            txtReport.ScrollBars = RichTextBoxScrollBars.None;
            switch (isScroable)
            {
                case ReportType.Yes:
                    txtReport.ScrollBars = RichTextBoxScrollBars.Vertical;
                    break;
                case ReportType.No:
                    txtReport.ScrollBars = RichTextBoxScrollBars.None;
                    break;
            }
        }

        private void SwapButtons(Button btn1, Button btn2)
        {
            Point tempLocation = btn1.Location;
            btn1.Location = btn2.Location;
            btn2.Location = tempLocation;
        }
        #region enums
        public enum ReportButton
        {
            Ok,
            OkCancle,
            Retry,
            OkCancleRetry,
        }

        public enum Anya
        {
            Angry,
            Confused,
            Crying,
            Happy,
            Nervous,
            Smile
        }

        public enum ReportType
        {
            Yes,
            No,
        }

        #endregion


        private void AnyaReports_FormClosing(object sender, FormClosingEventArgs e)
        {
            picboxAnya.Image?.Dispose();
        }


    }
}
