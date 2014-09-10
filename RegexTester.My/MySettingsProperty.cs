using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
namespace RegexTester.My
{
	[StandardModule, HideModuleName, DebuggerNonUserCode, CompilerGenerated]
	internal sealed class MySettingsProperty
	{
		[HelpKeyword("My.Settings")]
		internal static Settings Settings
		{
			get
			{
				return Settings.Default;
			}
		}
	}
}
