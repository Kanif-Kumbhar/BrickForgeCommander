using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
        private Color errroColor = Color.FromArgb(255, 255, 128, 128);
        private Color errorForeColor = Color.White;

        private int range;

        public override Button ConnectedButton
        {
            get => base.ConnectedButton;
            set => base.ConnectedButton = value;
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

        protected  bool IsInputValid()
        {
            return Regex.IsMatch(this.Texts, InputRegexPattern);
        }

        private void UpdateIsValid()
        {
            if (IsInputValid()) 
            { 

            }
        }
        #endregion
    }
}
