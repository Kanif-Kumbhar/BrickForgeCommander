using BrickForgeCommanderUI.Controls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Helpers
{
    public static class ShortcutKeyHandler
    {
        public static bool ProcessShortcutKeys(Form form, Keys keyData)
        {
            foreach (Control control in form.Controls)
            {
                if (control is BFC_Button button && button.ClickKey == keyData)
                {
                    button.PerformClick();
                    return true;
                }
            }

            return false;
        }
    }
}