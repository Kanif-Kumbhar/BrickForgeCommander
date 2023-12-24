using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Misc.Anya_sReport
{
    public partial class AnyaReports : Form
    {
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
        {
            txtReport.Text = text;
        }
        public AnyaReports(string text, string caption)
        {
            txtReport.Text = text;
            lblCaption.Text = caption;
        }
        public AnyaReports(string text, string caption, ReportButton buttons)
        {
            txtReport.Text = text;
            lblCaption.Text = caption;
            GetButtons(buttons);
        }
        public AnyaReports(string text, string caption, ReportButton buttons, Anya mood)
        {
            InitializeComponent();
            txtReport.Text = text;
            lblCaption.Text = caption;
            GetButtons(buttons);
            GetAnyaMood(mood);
        }

        private void AnyaReports_Load(object sender, EventArgs e)
        {
            btnCancle.Hide();
            btnOk.Hide();
            btnRetry.Hide();
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
            switch (button)
            {
                case ReportButton.Ok:
                    btnOk.Show();
                    break;
                case ReportButton.OkCancle:
                    btnOk.Show();
                    btnCancle.Show();
                    break;
                case ReportButton.Retry:
                    btnRetry.Location = btnCancle.Location;
                    btnRetry.Show();
                    break;
                case ReportButton.OkCancleRetry:
                    btnOk.Show();
                    btnCancle.Show();
                    btnRetry.Show();
                    break;
                default:
                    break;
            }
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

        #endregion


        private void AnyaReports_FormClosing(object sender, FormClosingEventArgs e)
        {
            picboxAnya.Image?.Dispose();
        }
    }
}
