using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Controls.Validation
{
    public class RequiredFieldTextBox : BFC_TextBox
    {
        private Color errorColor;
        private Color oldColor;

        private string errorMessage = "Please enter all the required fields";

        private Button connectedButton;

        public RequiredFieldTextBox()
        {
            oldColor = this.BackColor;

            this.TextChanged += (sender, e) => OnTextChanged();
            this.Validating += (sender, e) => OnValidating(e);
            this.Enter += (sender, e) => OnEnter();
        }

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

        [Category("Validation")]
        public Button ConnectedButton
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
                    connectedButton.Enabled = false;
                    connectedButton.Click += (sender, e) => UpdateIsEmpty();
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

        #region Functions

          private void UpdateIsEmpty()
        {
            if (IsEmpty())
            {
                MessageBox.Show(errorMessage, "Validation Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BackColor = errorColor;
            }
            else
            {
                this.BackColor = oldColor;
            }
        }


        private bool IsEmpty()
        {
            return string.IsNullOrEmpty(this.Texts);
        }

        private void SetOriginalColor()
        {
            this.BackColor = oldColor;
        }

        private void OnTextChanged()
        {
            if (!string.IsNullOrEmpty(this.Texts))
            {
                SetOriginalColor();
            }
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            UpdateIsEmpty();
            if (!IsEmpty())
            {
                connectedButton.Enabled = true;
            }
        }

        private void OnEnter()
        {
            if(IsEmpty()) 
            {
                this.BackColor = oldColor;
            }
        }

        #endregion
    }
}
