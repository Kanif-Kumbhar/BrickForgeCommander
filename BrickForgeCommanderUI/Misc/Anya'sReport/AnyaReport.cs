using System;
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
            //btnOk.Location = btnClose.Location;

            lblReport.Text = text;
        }

        public AnyaReports(string text, string caption)
            : this(text)
        {
            btnRetry.Visible = false;
            btnCancle.Visible = false;
           // btnOk.Location = btnClose.Location;

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


        private void AnyaReports_Load(object sender, EventArgs e)
        {
            //Empty
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
                    btnOk.Visible = true;
                    break;
                case ReportButton.OkCancle:
                    btnOk.Visible = true;
                    btnCancle.Visible = true;
                    break;
                case ReportButton.Retry:
                    btnRetry.Location = btnCancle.Location;
                    btnRetry.Visible = true;
                    break;
                case ReportButton.OkCancleRetry:
                    btnOk.Visible = true;
                    btnCancle.Visible = true;
                    btnRetry.Visible = true;
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
