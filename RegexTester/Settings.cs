using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using RegexTester.My;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
namespace RegexTester
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), CompilerGenerated]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
		private static bool addedHandler;
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
		public static Settings Default
		{
			get
			{
				if (!Settings.addedHandler)
				{
					object obj = Settings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					Monitor.Enter(obj);
					try
					{
						if (!Settings.addedHandler)
						{
							MyProject.Application.Shutdown += new ShutdownEventHandler(Settings.AutoSaveSettings);
							Settings.addedHandler = true;
						}
					}
					finally
					{
						Monitor.Exit(obj);
					}
				}
				return Settings.defaultInstance;
			}
		}
		[EditorBrowsable(EditorBrowsableState.Advanced), DebuggerNonUserCode]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}
	}
}
