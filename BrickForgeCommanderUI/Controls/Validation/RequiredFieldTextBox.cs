using BrickForgeCommanderUI.Misc.Anya_sReport;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static BrickForgeCommanderUI.Misc.Anya_sReport.AnyaReports;

namespace BrickForgeCommanderUI.Controls.Validation
{
    public class RequiredFieldTextBox : BFC_TextBox
    {
        private Color errorColor = Color.FromArgb(255, 128, 128);
        private Color oldColor;

        private Color errorForeColor = Color.Black;
        private Color oldForeColor;

        private string errorMessage = "Please fill the above field.";

        protected Button connectedButton;

        public RequiredFieldTextBox()
        {
            InitializeComponent();
            oldColor = this.BackColor;
            oldForeColor = this.ForeColor;

            this.TextChanged += (sender, e) => OnTextChanged();
            this.Validating += (sender, e) => OnValidating(e);
            this.Enter += (sender, e) => OnEnter();
        }

        #region Properties

        [Category("Validation")]
        public virtual Button ConnectedButton
        {
            get
            {
                return connectedButton;
            }
            set
            {
                connectedButton = value;

                if (connectedButton != null)
                {
                    connectedButton.Click += (sender, e) =>
                    {
                        UpdateIsEmpty();
                        InvokeErrorMessage();
                    };
                }
                this.Invalidate();
            }
        }


        [Browsable(true)]
        [Category("Validation")]
        public Color ErrorColor
        {
            get
            {
                return errorColor;
            }
            set
            {
                errorColor = value;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Validation")]
        public Color ErrorForeColor
        {
            get
            {
                return errorForeColor;
            }
            set
            {
                errorForeColor = value;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Validation")]
        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }
            set
            {
                errorMessage = value;
                this.Invalidate();
            }
        }
        #endregion

        #region Functions

        protected virtual void InvokeErrorMessage()
        {
            string textName = this.Name.Substring(3);
            if (IsEmpty())
            {
                string message = $"{errorMessage} \n \n \n Field Name:{textName}";
                AnyaReports.Show(message, "Empty Field Warning", ReportButton.Ok, Anya.Nervous);
            }
        }
        protected void UpdateIsEmpty()
        {
            if (IsEmpty())
            {
                this.BackColor = errorColor;
                this.ForeColor = errorForeColor;
            }
            else
            {
                this.BackColor = oldColor;
                this.ForeColor = oldForeColor;
            }
        }

        protected bool IsEmpty()
        {
            return string.IsNullOrEmpty(this.Texts);
        }

        protected void SetOriginalColor()
        {
            this.BackColor = oldColor;
            this.ForeColor = oldForeColor;
        }

        protected void OnTextChanged()
        {
            if (!string.IsNullOrEmpty(this.Texts))
            {
                SetOriginalColor();
            }
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            UpdateIsEmpty();
        }

        protected virtual void OnEnter()
        {
            if (IsEmpty())
            {
                this.BackColor = oldColor;
                this.ForeColor = oldForeColor;
            }
        }

        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.MinimumSize = new System.Drawing.Size(0, 25);
            this.textBox1.Size = new System.Drawing.Size(230, 27);
            this.textBox1.TabIndex = 1;
            // 
            // RequiredFieldTextBox
            // 
            this.Name = "RequiredFieldTextBox";
            this.Size = new System.Drawing.Size(250, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
