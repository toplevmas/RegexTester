using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
namespace RegexTester
{
	public class ProjectOptions
	{
		[XmlIgnore]
		public string RegexFile;
		public string RegexName;
		public string RegexDescription;
		public string RegexText;
		public string ReplaceText;
		public string SourceText;
		public Command Command;
		public RegexOptions RegexOptions;
		public DetailOption Detail;
		public int MaxMatches;
		public SortOption Sort;
		public bool WordWrap;
		public FormatOption Format;
		public bool IncludeEmptyGroups;
		public LanguageOption Language;
		public bool VerbatimStrings;
		public bool InstanceMethods;
		public bool AssumeImports;
		public bool GenerateLoop;
		public bool IncludeComment;
		public bool CopyCodeOnExit;
		[XmlIgnore]
		private ProjectOptions LoadValues;
		public bool HasChanged
		{
			get
			{
				int arg_E7_0;
				if (Operators.CompareString(this.RegexText, this.LoadValues.RegexText, false) == 0 && Operators.CompareString(this.ReplaceText, this.LoadValues.ReplaceText, false) == 0)
				{
					if (Operators.CompareString(this.SourceText, this.LoadValues.SourceText, false) == 0)
					{
						if (this.Command == this.LoadValues.Command)
						{
							if (this.RegexOptions == this.LoadValues.RegexOptions)
							{
								if (this.Detail == this.LoadValues.Detail)
								{
									if (this.MaxMatches == this.LoadValues.MaxMatches)
									{
										if (this.Sort == this.LoadValues.Sort)
										{
											if (this.Format == this.LoadValues.Format)
											{
												if (this.WordWrap == this.LoadValues.WordWrap)
												{
													arg_E7_0 = 0;
													return arg_E7_0 != 0;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				arg_E7_0 = 1;
				return arg_E7_0 != 0;
			}
		}
		public ProjectOptions()
		{
			this.RegexName = "";
			this.RegexDescription = "";
			this.RegexText = "";
			this.ReplaceText = "";
			this.SourceText = "";
			this.Command = Command.Find;
			this.Detail = DetailOption.Groups;
			this.MaxMatches = 1000;
			this.Sort = SortOption.Position;
			this.WordWrap = true;
			this.Format = FormatOption.Auto;
			this.IncludeEmptyGroups = true;
			this.Language = LanguageOption.VisualBasic;
			this.VerbatimStrings = false;
			this.InstanceMethods = true;
			this.AssumeImports = true;
			this.GenerateLoop = true;
			this.IncludeComment = true;
			this.CopyCodeOnExit = true;
		}
		public void ClearChanges()
		{
			this.LoadValues = (ProjectOptions)this.MemberwiseClone();
		}
		public static ProjectOptions Load(string fileName)
		{
			ProjectOptions result;
			using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProjectOptions));
				ProjectOptions projectOptions = (ProjectOptions)xmlSerializer.Deserialize(fileStream);
				projectOptions.RegexFile = fileName;
				projectOptions.ClearChanges();
				result = projectOptions;
			}
			return result;
		}
		public void Save(string fileName)
		{
			using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProjectOptions));
				xmlSerializer.Serialize(fileStream, this);
				this.RegexFile = fileName;
				this.ClearChanges();
			}
		}
	}
}
