using System;
using System.Linq;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Helpers
{
    public static class FormHelper
    {
        public static void OpenForm<T>() where T : Form, new()
        {
            Form formToOpen = Application.OpenForms.OfType<T>().FirstOrDefault();

            if (formToOpen == null)
            {
                formToOpen = new T();
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
    }
}
