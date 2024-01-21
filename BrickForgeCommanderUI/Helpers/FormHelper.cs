using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Helpers
{
    public static class FormHelper
    {
        public enum FormPosition
        {
            Center,
            Top,
            Bottom,
            Left,
            Right,
            TopLeft,
            TopRight,
            BottomLeft,
            BottomRight
        }

        public static void OpenForm<T>(Panel parentPanel, FormPosition position = FormPosition.Center) where T : Form, new()
        {
            Form formToOpen = Application.OpenForms.OfType<T>().FirstOrDefault();

            if (formToOpen == null)
            {
                formToOpen = new T();

                if (parentPanel != null)
                {
                    formToOpen.TopLevel = false;
                    formToOpen.FormBorderStyle = FormBorderStyle.None;

                    // Adjust the form's position based on the specified enum
                    AdjustFormPosition(formToOpen, parentPanel, position);

                    parentPanel.Controls.Add(formToOpen);
                    formToOpen.BringToFront();
                }

                formToOpen.Show();
            }
            else
            {
                formToOpen.Activate();
            }
        }

        public static DialogResult OpenDialogForm<T>() where T : Form, new()
        {
            using (Form dialogForm = new T())
            {
                return dialogForm.ShowDialog();
            }
        }

        private static void AdjustFormPosition(Form form, Panel parentPanel, FormPosition position)
        {
            switch (position)
            {
                case FormPosition.Center:
                    form.Location = new Point((parentPanel.Width - form.Width) / 2, (parentPanel.Height - form.Height) / 2);
                    break;

                case FormPosition.Top:
                    form.Location = new Point((parentPanel.Width - form.Width) / 2, 0);
                    break;

                case FormPosition.Bottom:
                    form.Location = new Point((parentPanel.Width - form.Width) / 2, parentPanel.Height - form.Height);
                    break;

                case FormPosition.Left:
                    form.Location = new Point(0, (parentPanel.Height - form.Height) / 2);
                    break;

                case FormPosition.Right:
                    form.Location = new Point(parentPanel.Width - form.Width, (parentPanel.Height - form.Height) / 2);
                    break;

                case FormPosition.TopLeft:
                    form.Location = new Point(0, 0);
                    break;

                case FormPosition.TopRight:
                    form.Location = new Point(parentPanel.Width - form.Width, 0);
                    break;

                case FormPosition.BottomLeft:
                    form.Location = new Point(0, parentPanel.Height - form.Height);
                    break;

                case FormPosition.BottomRight:
                    form.Location = new Point(parentPanel.Width - form.Width, parentPanel.Height - form.Height);
                    break;
            }
        }
    }
}
