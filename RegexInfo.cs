using System;
using System.Text.RegularExpressions;
namespace RegexTester
{
	internal class RegexInfo
	{
		private string m_Name;
		private string m_Pattern;
		private RegexOptions m_Options;
		public string Name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}
		public string Pattern
		{
			get
			{
				return this.m_Pattern;
			}
			set
			{
				this.m_Pattern = value;
			}
		}
		public RegexOptions Options
		{
			get
			{
				return this.m_Options;
			}
			set
			{
				this.m_Options = value;
			}
		}
		public string OptionsText
		{
			get
			{
				string text = "";
				if ((this.m_Options & RegexOptions.IgnoreCase) > RegexOptions.None)
				{
					text += "I";
				}
				if ((this.m_Options & RegexOptions.IgnorePatternWhitespace) > RegexOptions.None)
				{
					text += "X";
				}
				if ((this.m_Options & RegexOptions.Multiline) > RegexOptions.None)
				{
					text += "M";
				}
				if ((this.m_Options & RegexOptions.Compiled) > RegexOptions.None)
				{
					text += "C";
				}
				if ((this.m_Options & RegexOptions.ExplicitCapture) > RegexOptions.None)
				{
					text += "N";
				}
				if ((this.m_Options & RegexOptions.RightToLeft) > RegexOptions.None)
				{
					text += "R";
				}
				if ((this.m_Options & RegexOptions.CultureInvariant) > RegexOptions.None)
				{
					text += "U";
				}
				if ((this.m_Options & RegexOptions.ECMAScript) > RegexOptions.None)
				{
					text += "A";
				}
				return text;
			}
			set
			{
				value = value.ToUpper();
				this.m_Options = RegexOptions.None;
				if (value.Contains("I"))
				{
					this.m_Options |= RegexOptions.IgnoreCase;
				}
				if (value.Contains("X"))
				{
					this.m_Options |= RegexOptions.IgnorePatternWhitespace;
				}
				if (value.Contains("M"))
				{
					this.m_Options |= RegexOptions.Multiline;
				}
				if (value.Contains("C"))
				{
					this.m_Options |= RegexOptions.Compiled;
				}
				if (value.Contains("N"))
				{
					this.m_Options |= RegexOptions.ExplicitCapture;
				}
				if (value.Contains("R"))
				{
					this.m_Options |= RegexOptions.RightToLeft;
				}
				if (value.Contains("U"))
				{
					this.m_Options |= RegexOptions.CultureInvariant;
				}
				if (value.Contains("A"))
				{
					this.m_Options |= RegexOptions.ECMAScript;
				}
			}
		}
		public RegexInfo()
		{
			this.m_Name = "";
			this.m_Pattern = "";
		}
		public static RegexInfo FromProjectOption(ProjectOptions prjOptions)
		{
			return new RegexInfo
			{
				Name = prjOptions.RegexName,
				Pattern = prjOptions.RegexText,
				Options = prjOptions.RegexOptions
			};
		}
	}
}
