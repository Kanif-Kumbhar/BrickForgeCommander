using BrickForgeCommanderUI.Misc.Anya_sReport;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static BrickForgeCommanderUI.Misc.Anya_sReport.AnyaReports;

namespace BrickForgeCommanderUI.Controls.Validation
{
    public enum DataType
    {
        Alphabetic,
        Numeric,
        AlphaNumeric
    }
    public class DataFieldTextBox : RequiredFieldTextBox
    {
        private DataType selectedOption;
        private Color errroColor = Color.FromArgb(128, 255, 255);
        private Color errorForeColor = Color.Black;

        private string errorMessage = "Please enter valid input.";
        private int range = 10;

        public DataFieldTextBox()
        {
            this.TextChanged += (sender, e) => OnTextChanged();
            this.Validating += (sender, e) => OnValidating(e);
            this.Enter += (sender, e) => OnEnter();
            this.Leave += (sender, e) => OnLeave();
        }
        public override Button ConnectedButton
        {
            get => base.ConnectedButton;
            set
            {
                base.ConnectedButton = value;
                if (connectedButton != null)
                {
                    connectedButton.Click += (sender, e) =>
                    {
                        SetErrorColor();
                        GetErrorMessage();
                    };
                }
                this.Invalidate();
            }
        }

        [Category("Data Validation")]
        [Description("Textbox color when input is not in acceptable format.")]
        public Color ErrroColor
        {
            get
            {
                return errroColor;
            }
            set
            {
                errroColor = value;
                this.Invalidate();
            }
        }

        [Category("Data Validation")]
        [Description("Textbox forecolor when input is not in acceptable format.")]
        public Color ErrroForeColor
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

        [Category("Data Validation")]
        [Description("Accepted range of input data.")]
        public int Range
        {
            get
            {
                return range;
            }
            set
            {
                range = value;
                this.Invalidate();
            }
        }

        [Category("Data Validation")]
        [DisplayName("Data Format")]
        [Description("Format of input which is acceptable.")]
        public DataType DataFormat
        {
            get
            {
                return selectedOption;
            }
            set
            {
                selectedOption = value;
                this.Invalidate();
            }
        }

        [Category("Data Validation")]
        [DisplayName("Errro Message")]
        [Description("Message to display when user enters wrong type of input.")]
        public string DataErrorMessage
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

        #region DataType Function
        protected string InputRegexPattern
        {
            get
            {
                switch (DataFormat)
                {
                    case DataType.Alphabetic:
                        return $"^[a-zA-Z]{{1,{range}}}$";

                    case DataType.Numeric:
                        return $"^[0-9]{{1,{range}}}$";

                    case DataType.AlphaNumeric:
                        return $"^[a-zA-Z0-9]{{1,{range}}}$";

                    default:
                        return string.Empty;
                }
            }
        }

        protected bool IsInputValid()
        {
            return Regex.IsMatch(this.Texts, InputRegexPattern);
        }

        private void UpdateIsValid()
        {
            if (!IsInputValid())
            {
                GetErrorColor();
            }
            else
            {
                SetOriginalColor();
            }
        }

        private void GetErrorColor()
        {
            this.BackColor = errroColor;
            this.ForeColor = errorForeColor;
        }
        private void SetErrorColor()
        {
            if (!IsEmpty())
            {
                UpdateIsValid();
            }
        }

        private void GetErrorMessage()
        {
            string textName = this.Name.Substring(3);

            if (!IsEmpty() && !IsInputValid())
            {
                AnyaReports.Show($"{errorMessage} \n \n Field Name: {textName} \n" +
                    $"Expected range: {range} \n" +
                    $"Expected input type: {selectedOption}",
                    "Invalid Input Type!!", ReportButton.Ok, Anya.Confused);
            }
        }

        protected new void OnEnter()
        {
            if (!IsEmpty())
            {
                SetOriginalColor();
            }
        }

        protected void OnLeave()
        {
            if (!IsEmpty())
            {
                UpdateIsValid();
            }
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);

            if (!IsEmpty())
            {
                UpdateIsValid();
            }
        }
        #endregion
    }
}
