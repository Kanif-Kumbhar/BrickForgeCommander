using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BrickForgeCommanderUI.Properties;

namespace BrickForgeCommanderUI.Controls.NavControls
{
    public enum DisplayType
    {
        Icon,
        Text,
        Both
    }

    public class BfcNewButton : BFC_Button
    {
        private DisplayType displayType;
        private string formName;

        private string text;

        #region Properties

        [Category("Naviagtion")]
        [DisplayName("Form Name")]
        [Description("Name of form to open [Namespace.ClassName].")]
        public string FormName
        {
            get => formName;
            set
            {
                formName = value;
                Invalidate();
            }
        }

        [Category("Naviagtion")]
        [DisplayName("Display Type")]
        [Description("Choose whether to display Icon, Text, or Both on the button")]
        public DisplayType DisplayType
        {
            get => displayType;
            set
            {
                displayType = value;
                SetButtonLayout();
                Invalidate();
            }
        }

        [Category("Naviagtion")]
        [DisplayName("Button Text")]
        [Description("Text to display on button.")]
        public string Texts
        {
            get => text;
            set
            {
                text = value;
                Invalidate();
            }
        }
        #endregion
        public BfcNewButton()
        {
            this.displayType = DisplayType.Icon;

            this.BackgroundColor = Color.FromArgb(85, 85, 85);
            this.BorderRadius = 0;
            SetButtonLayout();

            this.Click += BfcNewButton_Click;
        }

        #region Functions

        private void SetIcon()
        {
            this.Text = "";
            base.Text = "";
            this.Image = Resources.Add;
            this.ImageAlign = ContentAlignment.MiddleCenter;
        }

        private void SetText()
        {
            this.Text = text;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Image = null;
        }

        private void SetIconAndText()
        {
            this.Text = text;
            this.TextAlign = ContentAlignment.MiddleRight;
            this.Image = Resources.Add;
            this.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void SetButtonLayout()
        {
            switch (displayType)
            {
                case DisplayType.Icon:
                    SetIcon();
                    break;
                case DisplayType.Text:
                    SetText();
                    break;
                case DisplayType.Both:
                    SetIconAndText();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        #region Events

        protected void BfcNewButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(formName))
            {
                try
                {
                    // Dynamically create an instance of the specified form
                    Type formType = Type.GetType(formName);
                    Form form = (Form)Activator.CreateInstance(formType);

                    // Show the form
                    form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("FormName property is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        #endregion
    }
}