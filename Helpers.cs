using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
namespace RegexTester
{
	[StandardModule]
	internal sealed class Helpers
	{
		public static void SetTooltipsAndHelpMessages(Form frm, ToolTip tooltip, HelpProvider helpProv)
		{
			Control[] childControls = Helpers.GetChildControls(frm);
			checked
			{
				for (int i = 0; i < childControls.Length; i++)
				{
					Control control = childControls[i];
					string text = tooltip.GetToolTip(control);
					text = text.Replace("§", "\r\n");
					tooltip.SetToolTip(control, text);
					helpProv.SetHelpString(control, text);
				}
			}
		}
		public static Control[] GetChildControls(Control ctrl)
		{
			List<Control> list = new List<Control>();
            IEnumerator enumerator = ctrl.Controls.GetEnumerator();
			try
			{
				
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					list.Add(control);
					list.AddRange(Helpers.GetChildControls(control));
				}
			}
			finally
			{
				//IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return list.ToArray();
		}
	}
}
