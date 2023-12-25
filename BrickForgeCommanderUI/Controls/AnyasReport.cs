using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickForgeCommanderUI.Controls
{
    public class AnyasReport : BFC_TextBox
    {
        [Category("Custom")]
        public new event EventHandler TextChanged
        {
            add { base.TextChanged += value; }
            remove { base.TextChanged -= value; }
        }
    }
}
