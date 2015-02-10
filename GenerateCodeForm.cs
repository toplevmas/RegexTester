using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace RegexTester
{
	[DesignerGenerated]
	public class GenerateCodeForm : Form
	{
		private IContainer components;
		[AccessedThroughProperty("radVisualBasic")]
		private RadioButton _radVisualBasic;
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;
		[AccessedThroughProperty("chkVerbatimStrings")]
		private CheckBox _chkVerbatimStrings;
		[AccessedThroughProperty("radVisualCSharp")]
		private RadioButton _radVisualCSharp;
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;
		[AccessedThroughProperty("chkGenerateLoops")]
		private CheckBox _chkGenerateLoops;
		[AccessedThroughProperty("chkAssumeImports")]
		private CheckBox _chkAssumeImports;
		[AccessedThroughProperty("chkInstanceMethods")]
		private CheckBox _chkInstanceMethods;
		[AccessedThroughProperty("txtCode")]
		private TextBox _txtCode;
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;
		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;
		[AccessedThroughProperty("chkCopyToClipboard")]
		private CheckBox _chkCopyToClipboard;
		[AccessedThroughProperty("chkDescriptionAsComment")]
		private CheckBox _chkDescriptionAsComment;
		[AccessedThroughProperty("HelpProvider1")]
		private HelpProvider _HelpProvider1;
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;
		public ProjectOptions Options;
		private bool initializing;
		internal virtual RadioButton radVisualBasic
		{
			get
			{
				return this._radVisualBasic;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._radVisualBasic != null)
				{
					this._radVisualBasic.CheckedChanged -= new EventHandler(this.radVisualCSharp_CheckedChanged);
				}
				this._radVisualBasic = value;
				if (this._radVisualBasic != null)
				{
					this._radVisualBasic.CheckedChanged += new EventHandler(this.radVisualCSharp_CheckedChanged);
				}
			}
		}
		internal virtual GroupBox GroupBox1
		{
			get
			{
				return this._GroupBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}
		internal virtual CheckBox chkVerbatimStrings
		{
			get
			{
				return this._chkVerbatimStrings;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._chkVerbatimStrings != null)
				{
					this._chkVerbatimStrings.CheckedChanged -= new EventHandler(this.radVisualCSharp_CheckedChanged);
				}
				this._chkVerbatimStrings = value;
				if (this._chkVerbatimStrings != null)
				{
					this._chkVerbatimStrings.CheckedChanged += new EventHandler(this.radVisualCSharp_CheckedChanged);
				}
			}
		}
		internal virtual RadioButton radVisualCSharp
		{
			get
			{
				return this._radVisualCSharp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._radVisualCSharp != null)
				{
					this._radVisualCSharp.CheckedChanged -= new EventHandler(this.radVisualCSharp_CheckedChanged);
				}
				this._radVisualCSharp = value;
				if (this._radVisualCSharp != null)
				{
					this._radVisualCSharp.CheckedChanged += new EventHandler(this.radVisualCSharp_CheckedChanged);
				}
			}
		}
		internal virtual GroupBox GroupBox2
		{
			get
			{
				return this._GroupBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}
		internal virtual CheckBox chkGenerateLoops
		{
			get
			{
				return this._chkGenerateLoops;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._chkGenerateLoops != null)
				{
					this._chkGenerateLoops.CheckedChanged -= new EventHandler(this.radVisualCSharp_CheckedChanged);
				}
				this._chkGenerateLoops = value;
				if (this._chkGenerateLoops != null)
				{
					this._chkGenerateLoops.CheckedChanged += new EventHandler(this.radVisualCSharp_CheckedChanged);
				}
			}
		}
		internal virtual CheckBox chkAssumeImports
		{
			get
			{
				return this._chkAssumeImports;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._chkAssumeImports != null)
				{
					this._chkAssumeImports.CheckedChanged -= new EventHandler(this.radVisualCSharp_CheckedChanged);
				}
				this._chkAssumeImports = value;
				if (this._chkAssumeImports != null)
				{
					this._chkAssumeImports.CheckedChanged += new EventHandler(this.radVisualCSharp_CheckedChanged);
				}
			}
		}
		internal virtual CheckBox chkInstanceMethods
		{
			get
			{
				return this._chkInstanceMethods;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._chkInstanceMethods != null)
				{
					this._chkInstanceMethods.CheckedChanged -= new EventHandler(this.radVisualCSharp_CheckedChanged);
				}
				this._chkInstanceMethods = value;
				if (this._chkInstanceMethods != null)
				{
					this._chkInstanceMethods.CheckedChanged += new EventHandler(this.radVisualCSharp_CheckedChanged);
				}
			}
		}
		internal virtual TextBox txtCode
		{
			get
			{
				return this._txtCode;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtCode = value;
			}
		}
		internal virtual Button btnCancel
		{
			get
			{
				return this._btnCancel;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnCancel = value;
			}
		}
		internal virtual Button btnOK
		{
			get
			{
				return this._btnOK;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnOK != null)
				{
					this._btnOK.Click -= new EventHandler(this.btnOK_Click);
				}
				this._btnOK = value;
				if (this._btnOK != null)
				{
					this._btnOK.Click += new EventHandler(this.btnOK_Click);
				}
			}
		}
		internal virtual CheckBox chkCopyToClipboard
		{
			get
			{
				return this._chkCopyToClipboard;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkCopyToClipboard = value;
			}
		}
		internal virtual CheckBox chkDescriptionAsComment
		{
			get
			{
				return this._chkDescriptionAsComment;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._chkDescriptionAsComment != null)
				{
					this._chkDescriptionAsComment.CheckedChanged -= new EventHandler(this.radVisualCSharp_CheckedChanged);
				}
				this._chkDescriptionAsComment = value;
				if (this._chkDescriptionAsComment != null)
				{
					this._chkDescriptionAsComment.CheckedChanged += new EventHandler(this.radVisualCSharp_CheckedChanged);
				}
			}
		}
		internal virtual HelpProvider HelpProvider1
		{
			get
			{
				return this._HelpProvider1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HelpProvider1 = value;
			}
		}
		internal virtual ToolTip ToolTip1
		{
			get
			{
				return this._ToolTip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTip1 = value;
			}
		}
		public GenerateCodeForm()
		{
			base.Load += new EventHandler(this.GenerateCodeForm_Load);
			this.initializing = true;
			this.InitializeComponent();
		}
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			this.radVisualBasic = new RadioButton();
			this.GroupBox1 = new GroupBox();
			this.chkVerbatimStrings = new CheckBox();
			this.radVisualCSharp = new RadioButton();
			this.GroupBox2 = new GroupBox();
			this.chkDescriptionAsComment = new CheckBox();
			this.chkGenerateLoops = new CheckBox();
			this.chkAssumeImports = new CheckBox();
			this.chkInstanceMethods = new CheckBox();
			this.txtCode = new TextBox();
			this.btnCancel = new Button();
			this.btnOK = new Button();
			this.chkCopyToClipboard = new CheckBox();
			this.HelpProvider1 = new HelpProvider();
			this.ToolTip1 = new ToolTip(this.components);
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.SuspendLayout();
			this.radVisualBasic.AutoSize = true;
			Control arg_F0_0 = this.radVisualBasic;
			Point location = new Point(18, 21);
			arg_F0_0.Location = location;
			this.radVisualBasic.Name = "radVisualBasic";
			Control arg_117_0 = this.radVisualBasic;
			Size size = new Size(82, 17);
			arg_117_0.Size = size;
			this.radVisualBasic.TabIndex = 0;
			this.radVisualBasic.TabStop = true;
			this.radVisualBasic.Text = "Visual &Basic";
			this.ToolTip1.SetToolTip(this.radVisualBasic, "Generate Visual Basic code");
			this.radVisualBasic.UseVisualStyleBackColor = true;
			this.GroupBox1.Controls.Add(this.chkVerbatimStrings);
			this.GroupBox1.Controls.Add(this.radVisualCSharp);
			this.GroupBox1.Controls.Add(this.radVisualBasic);
			Control arg_1BA_0 = this.GroupBox1;
			location = new Point(12, 12);
			arg_1BA_0.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			Control arg_1E4_0 = this.GroupBox1;
			size = new Size(230, 122);
			arg_1E4_0.Size = size;
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Language";
			this.chkVerbatimStrings.AutoSize = true;
			Control arg_22F_0 = this.chkVerbatimStrings;
			location = new Point(40, 75);
			arg_22F_0.Location = location;
			this.chkVerbatimStrings.Name = "chkVerbatimStrings";
			Control arg_256_0 = this.chkVerbatimStrings;
			size = new Size(120, 17);
			arg_256_0.Size = size;
			this.chkVerbatimStrings.TabIndex = 2;
			this.chkVerbatimStrings.Text = "&Verbatim (@) strings";
			this.ToolTip1.SetToolTip(this.chkVerbatimStrings, "If selected, generated code uses @ C# strings.");
			this.chkVerbatimStrings.UseVisualStyleBackColor = true;
			this.radVisualCSharp.AutoSize = true;
			Control arg_2B7_0 = this.radVisualCSharp;
			location = new Point(18, 48);
			arg_2B7_0.Location = location;
			this.radVisualCSharp.Name = "radVisualCSharp";
			Control arg_2DE_0 = this.radVisualCSharp;
			size = new Size(70, 17);
			arg_2DE_0.Size = size;
			this.radVisualCSharp.TabIndex = 1;
			this.radVisualCSharp.TabStop = true;
			this.radVisualCSharp.Text = "Visual &C#";
			this.ToolTip1.SetToolTip(this.radVisualCSharp, "Generate C# code");
			this.radVisualCSharp.UseVisualStyleBackColor = true;
			this.GroupBox2.Controls.Add(this.chkDescriptionAsComment);
			this.GroupBox2.Controls.Add(this.chkGenerateLoops);
			this.GroupBox2.Controls.Add(this.chkAssumeImports);
			this.GroupBox2.Controls.Add(this.chkInstanceMethods);
			Control arg_39A_0 = this.GroupBox2;
			location = new Point(259, 13);
			arg_39A_0.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			Control arg_3C4_0 = this.GroupBox2;
			size = new Size(230, 121);
			arg_3C4_0.Size = size;
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Options";
			this.chkDescriptionAsComment.AutoSize = true;
			Control arg_40F_0 = this.chkDescriptionAsComment;
			location = new Point(16, 98);
			arg_40F_0.Location = location;
			this.chkDescriptionAsComment.Name = "chkDescriptionAsComment";
			Control arg_439_0 = this.chkDescriptionAsComment;
			size = new Size(139, 17);
			arg_439_0.Size = size;
			this.chkDescriptionAsComment.TabIndex = 3;
			this.chkDescriptionAsComment.Text = "&Description as comment";
			this.ToolTip1.SetToolTip(this.chkDescriptionAsComment, "The generated code contains a comment equal to the regex description. §(This option is disabled if the current regular expression has no description.)");
			this.chkDescriptionAsComment.UseVisualStyleBackColor = true;
			this.chkGenerateLoops.AutoSize = true;
			Control arg_49A_0 = this.chkGenerateLoops;
			location = new Point(16, 74);
			arg_49A_0.Location = location;
			this.chkGenerateLoops.Name = "chkGenerateLoops";
			Control arg_4C1_0 = this.chkGenerateLoops;
			size = new Size(93, 17);
			arg_4C1_0.Size = size;
			this.chkGenerateLoops.TabIndex = 2;
			this.chkGenerateLoops.Text = "&Generate loop";
			this.ToolTip1.SetToolTip(this.chkGenerateLoops, "The generate code contains a loop that visits all matches or split lines. §(This option is disabled if the current command is Replace.)");
			this.chkGenerateLoops.UseVisualStyleBackColor = true;
			this.chkAssumeImports.AutoSize = true;
			Control arg_522_0 = this.chkAssumeImports;
			location = new Point(16, 48);
			arg_522_0.Location = location;
			this.chkAssumeImports.Name = "chkAssumeImports";
			Control arg_54C_0 = this.chkAssumeImports;
			size = new Size(130, 17);
			arg_54C_0.Size = size;
			this.chkAssumeImports.TabIndex = 1;
			this.chkAssumeImports.Text = "&Assume Imports/using";
			this.ToolTip1.SetToolTip(this.chkAssumeImports, "Assume that the System.Text.RegularExpressions namespace §has been imported in current source file.");
			this.chkAssumeImports.UseVisualStyleBackColor = true;
			this.chkInstanceMethods.AutoSize = true;
			Control arg_5AD_0 = this.chkInstanceMethods;
			location = new Point(16, 20);
			arg_5AD_0.Location = location;
			this.chkInstanceMethods.Name = "chkInstanceMethods";
			Control arg_5D4_0 = this.chkInstanceMethods;
			size = new Size(105, 17);
			arg_5D4_0.Size = size;
			this.chkInstanceMethods.TabIndex = 0;
			this.chkInstanceMethods.Text = "&Instance method";
			this.ToolTip1.SetToolTip(this.chkInstanceMethods, "If selected the generated code uses the Find, Replace, or Split instance method. §Otherwise generate code that uses the static version of these methods.");
			this.chkInstanceMethods.UseVisualStyleBackColor = true;
			Control arg_62C_0 = this.txtCode;
			location = new Point(12, 148);
			arg_62C_0.Location = location;
			this.txtCode.Multiline = true;
			this.txtCode.Name = "txtCode";
			Control arg_662_0 = this.txtCode;
			size = new Size(478, 101);
			arg_662_0.Size = size;
			this.txtCode.TabIndex = 2;
			this.ToolTip1.SetToolTip(this.txtCode, "The generated source code.");
			this.btnCancel.DialogResult = DialogResult.Cancel;
			Control arg_6AD_0 = this.btnCancel;
			location = new Point(426, 255);
			arg_6AD_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_6D4_0 = this.btnCancel;
			size = new Size(64, 23);
			arg_6D4_0.Size = size;
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.ToolTip1.SetToolTip(this.btnCancel, "Close the dialog box without copying the generated code to the Clipboard.");
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnOK.DialogResult = DialogResult.OK;
			Control arg_73B_0 = this.btnOK;
			location = new Point(354, 255);
			arg_73B_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_762_0 = this.btnOK;
			size = new Size(64, 23);
			arg_762_0.Size = size;
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.ToolTip1.SetToolTip(this.btnOK, "Close the dialog box and optionally copy the generated code to the Clipboard.");
			this.btnOK.UseVisualStyleBackColor = true;
			this.chkCopyToClipboard.AutoSize = true;
			Control arg_7C6_0 = this.chkCopyToClipboard;
			location = new Point(12, 259);
			arg_7C6_0.Location = location;
			this.chkCopyToClipboard.Name = "chkCopyToClipboard";
			Control arg_7F0_0 = this.chkCopyToClipboard;
			size = new Size(169, 17);
			arg_7F0_0.Size = size;
			this.chkCopyToClipboard.TabIndex = 3;
			this.chkCopyToClipboard.Text = "C&opy code to clipboard on exit";
			this.ToolTip1.SetToolTip(this.chkCopyToClipboard, "If enabled, generated code is copied to the Clipboard §when the user clicks on the OK button.");
			this.chkCopyToClipboard.UseVisualStyleBackColor = true;
			this.AcceptButton = this.btnOK;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			size = new Size(499, 284);
			this.ClientSize = size;
			this.Controls.Add(this.chkCopyToClipboard);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GenerateCodeForm";
			this.Text = "Generate Code";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private void GenerateCodeForm_Load(object sender, EventArgs e)
		{
			Helpers.SetTooltipsAndHelpMessages(this, this.ToolTip1, this.HelpProvider1);
			if (this.Options.Language == LanguageOption.VisualBasic)
			{
				this.radVisualBasic.Checked = true;
			}
			else
			{
				this.radVisualCSharp.Checked = true;
			}
			this.chkVerbatimStrings.Checked = this.Options.VerbatimStrings;
			this.chkInstanceMethods.Checked = this.Options.InstanceMethods;
			this.chkAssumeImports.Checked = this.Options.AssumeImports;
			this.chkGenerateLoops.Checked = this.Options.GenerateLoop;
			this.chkDescriptionAsComment.Checked = this.Options.IncludeComment;
			this.chkCopyToClipboard.Checked = this.Options.CopyCodeOnExit;
			this.chkGenerateLoops.Enabled = (this.Options.Command != Command.Replace);
			this.chkDescriptionAsComment.Enabled = (this.Options.RegexDescription.Length > 0);
			this.initializing = false;
			this.RefreshCode();
		}
		private void radVisualCSharp_CheckedChanged(object sender, EventArgs e)
		{
			this.RefreshCode();
		}
		private void btnOK_Click(object sender, EventArgs e)
		{
			if (this.radVisualBasic.Checked)
			{
				this.Options.Language = LanguageOption.VisualBasic;
			}
			else
			{
				this.Options.Language = LanguageOption.VisualCsharp;
			}
			this.Options.VerbatimStrings = this.chkVerbatimStrings.Checked;
			this.Options.InstanceMethods = this.chkInstanceMethods.Checked;
			this.Options.AssumeImports = this.chkAssumeImports.Checked;
			this.Options.GenerateLoop = this.chkGenerateLoops.Checked;
			this.Options.IncludeComment = this.chkDescriptionAsComment.Checked;
			this.Options.CopyCodeOnExit = this.chkCopyToClipboard.Checked;
			if (this.Options.CopyCodeOnExit)
			{
				Clipboard.SetText(this.txtCode.Text);
			}
			this.DialogResult = DialogResult.OK;
		}
		public void RefreshCode()
		{
			this.chkVerbatimStrings.Enabled = this.radVisualCSharp.Checked;
			checked
			{
				if (!this.initializing)
				{
					string text = this.Options.RegexText;
					string text2 = "re";
					string text3 = "\"text\"";
					string text4 = "";
					if (!this.chkAssumeImports.Checked)
					{
						text4 = "System.Text.RegularExpressions.";
					}
					string text5 = "//";
					string text6 = "";
					if ((this.Options.RegexOptions & RegexOptions.IgnoreCase) > RegexOptions.None)
					{
						text6 += " | {0}RegexOptions.IgnoreCase";
					}
					if ((this.Options.RegexOptions & RegexOptions.IgnorePatternWhitespace) > RegexOptions.None)
					{
						text6 += " | {0}RegexOptions.IgnorePatternWhitespace";
					}
					if ((this.Options.RegexOptions & RegexOptions.Multiline) > RegexOptions.None)
					{
						text6 += " | {0}RegexOptions.Multiline";
					}
					if ((this.Options.RegexOptions & RegexOptions.Compiled) > RegexOptions.None)
					{
						text6 += " | {0}RegexOptions.Compiled";
					}
					if ((this.Options.RegexOptions & RegexOptions.ExplicitCapture) > RegexOptions.None)
					{
						text6 += " | {0}RegexOptions.ExplicitCapture";
					}
					if ((this.Options.RegexOptions & RegexOptions.RightToLeft) > RegexOptions.None)
					{
						text6 += " | {0}RegexOptions.RightToLeft";
					}
					if ((this.Options.RegexOptions & RegexOptions.CultureInvariant) > RegexOptions.None)
					{
						text6 += " | {0}RegexOptions.CultureInvariant";
					}
					if ((this.Options.RegexOptions & RegexOptions.ECMAScript) > RegexOptions.None)
					{
						text6 += " | {0}RegexOptions.ECMAScript";
					}
					if (text6.Length == 0)
					{
						text6 = "{0}RegexOptions.None";
					}
					else
					{
						text6 = text6.Substring(3);
					}
					text6 = string.Format(text6, text4);
					string text7 = null;
					if (this.radVisualBasic.Checked)
					{
						text = "\"" + text.Replace("\"", "\"\"") + "\"";
						text6 = text6.Replace("|", "Or");
						text5 = "'";
						if (this.chkInstanceMethods.Checked)
						{
							text7 = "Dim {1} As New {2}Regex({3}, {4}){0}";
						}
						switch (this.Options.Command)
						{
						case Command.Find:
							if (this.chkInstanceMethods.Checked)
							{
								text7 += "Dim mc As {2}MatchCollection = re.Matches({5}){0}";
							}
							else
							{
								text7 = "Dim mc As {2}MatchCollection = {2}Regex.Matches({5}, {3}, {4}){0}";
							}
							if (this.chkGenerateLoops.Checked)
							{
								text7 += "For Each ma As {2}Match in mc{0}{0}Next{0}";
							}
							break;
						case Command.Replace:
							if (this.chkInstanceMethods.Checked)
							{
								text7 += "Dim result As String = {1}.Replace({5}){0}";
							}
							else
							{
								text7 = "Dim result As String = {2}Regex.Replace({5}, {3}, {4}){0}";
							}
							break;
						case Command.Split:
							if (this.chkInstanceMethods.Checked)
							{
								text7 += "Dim lines() As String = re.Split({5}){0}";
							}
							else
							{
								text7 = "Dim lines() as String = {2}Regex.Split({5}, {3}, {4}){0}";
							}
							if (this.chkGenerateLoops.Checked)
							{
								text7 += "For Each line As String In lines{0}{0}Next{0}";
							}
							break;
						}
					}
					else
					{
						if (this.chkVerbatimStrings.Checked)
						{
							text = "@\"" + text.Replace("\"", "\"\"") + "\"";
						}
						else
						{
							text = "\"" + text.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"";
						}
						if (this.chkInstanceMethods.Checked)
						{
							text7 = "{2}Regex {1} = new {2}Regex({3}, {4});{0}";
						}
						switch (this.Options.Command)
						{
						case Command.Find:
							if (this.chkInstanceMethods.Checked)
							{
								text7 += "{2}MatchCollection mc = re.Matches({5});{0}";
							}
							else
							{
								text7 = "{2}MatchCollection mc = {2}Regex.Matches({5}, {3}, {4});{0}";
							}
							if (this.chkGenerateLoops.Checked)
							{
								text7 += "foreach ({2}Match ma in mc){0}{{{0}}}{0}";
							}
							break;
						case Command.Replace:
							if (this.chkInstanceMethods.Checked)
							{
								text7 += "string result = {1}.Replace({5});{0}";
							}
							else
							{
								text7 = "string result = {2}Regex.Replace({5}, {3}, {4});{0}";
							}
							break;
						case Command.Split:
							if (this.chkInstanceMethods.Checked)
							{
								text7 += "string[] lines= re.Split({5});{0}";
							}
							else
							{
								text7 = "string[] lines = {2}Regex.Split({5}, {3}, {4});{0}";
							}
							if (this.chkGenerateLoops.Checked)
							{
								text7 += "foreach (string line in lines){0}{{{0}}}{0}";
							}
							break;
						}
					}
					if (this.chkDescriptionAsComment.Checked && this.Options.RegexDescription.Length > 0)
					{
						string text8 = "";
						string[] array = this.Options.RegexDescription.Split(new string[]
						{
							"\r\n"
						}, StringSplitOptions.RemoveEmptyEntries);
						for (int i = 0; i < array.Length; i++)
						{
							string text9 = array[i];
							text8 = string.Concat(new string[]
							{
								text8,
								text5,
								" ",
								text9,
								"\r\n"
							});
						}
						text7 = text8 + text7;
					}
					text7 = string.Format(text7, new object[]
					{
						"\r\n",
						text2,
						text4,
						text,
						text6,
						text3
					});
					this.txtCode.Text = text7;
				}
			}
		}
	}
}
