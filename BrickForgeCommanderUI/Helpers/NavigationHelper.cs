using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Helpers
{
    public static class NavigationHelper
    {
        public static bool ProcessArrowKeyNavigation(Control control, Keys keyData)
        {
            if (keyData == Keys.Right || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Up)
            {
                MoveFocus(control, keyData);
                return true;
            }

            return false;
        }

        private static void MoveFocus(Control control, Keys keyData)
        {
            Control nextControl = FindNextControlInDirection(control, keyData);

            if (nextControl != null)
            {
                nextControl.Focus();
            }
        }

        private static Control FindNextControlInDirection(Control currentControl, Keys keyData)
        {
            bool forward = keyData == Keys.Right || keyData == Keys.Down;
            bool horizontal = keyData == Keys.Right || keyData == Keys.Left;

            Control parentContainer = currentControl.Parent;

            if (parentContainer != null)
            {
                List<Control> focusableControls = parentContainer.Controls.Cast<Control>()
                    .Where(c => c.TabStop && c.Visible && c.Enabled)
                    .OrderBy(c => forward ? c.TabIndex : -c.TabIndex)
                    .ToList();

                int currentIndex = focusableControls.IndexOf(currentControl);
                int nextIndex = (currentIndex + (forward ? 1 : -1) + focusableControls.Count) % focusableControls.Count;

                Control nextControl = focusableControls[nextIndex];

                while (ShouldSkipControl(nextControl, horizontal))
                {
                    nextIndex = (nextIndex + (forward ? 1 : -1) + focusableControls.Count) % focusableControls.Count;
                    nextControl = focusableControls[nextIndex];
                }

                return nextControl;
            }

            return null;
        }

        private static bool ShouldSkipControl(Control control, bool horizontal)
        {
            return control.TabIndex <= 0;
        }
    }
}
