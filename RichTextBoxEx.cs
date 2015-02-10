using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RegexTester
{
    class RichTextBoxEx : RichTextBox
    {
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (!base.AutoWordSelection)
            {
                base.AutoWordSelection = true;
                base.AutoWordSelection = false;
            }
        }
    }
}
