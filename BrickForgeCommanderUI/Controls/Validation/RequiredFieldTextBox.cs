using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Controls.Validation
{
    public class RequiredFieldTextBox : BFC_TextBox
    {
        private bool isEmpty;
        private Color errorColor;
        private Color oldColor;

        private Button connectedButton;

        public RequiredFieldTextBox()
        {
            oldColor = this.BackColor;

            this.TextChanged += (sender, e) => OnTextChanged();
            this.Leave += (sender, e) => OnLeave();
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
                    connectedButton.Click += (sender, e) => UpdateIsEmpty();

                    this.TextChanged += (sender, e) => UpdateButtonState();

                    UpdateButtonState();
                }

                this.Invalidate();
            }
        }
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
            isEmpty = IsEmpty();
            if (isEmpty)
            {
                MessageBox.Show("Please fill in the input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BackColor = errorColor;
                this.Focus();
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

        private void OnLeave()
        {
            UpdateIsEmpty();
        }
        private void UpdateButtonState()
        {
            if (IsEmpty())
            {
                connectedButton.Enabled = false;
            }
            else
            {
                connectedButton.Enabled = true;
            }
        }
        #endregion
    }
}
