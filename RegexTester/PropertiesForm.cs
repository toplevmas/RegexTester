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
	public class PropertiesForm : Form
	{
		private IContainer components;
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;
		[AccessedThroughProperty("chkEcmaScript")]
		private CheckBox _chkEcmaScript;
		[AccessedThroughProperty("chkCultureInvariant")]
		private CheckBox _chkCultureInvariant;
		[AccessedThroughProperty("chkRightToLeft")]
		private CheckBox _chkRightToLeft;
		[AccessedThroughProperty("chkExplicitCapture")]
		private CheckBox _chkExplicitCapture;
		[AccessedThroughProperty("chkCompiled")]
		private CheckBox _chkCompiled;
		[AccessedThroughProperty("chkMultiline")]
		private CheckBox _chkMultiline;
		[AccessedThroughProperty("chkIgnoreWhitespace")]
		private CheckBox _chkIgnoreWhitespace;
		[AccessedThroughProperty("chkIgnoreCase")]
		private CheckBox _chkIgnoreCase;
		[AccessedThroughProperty("Label3")]
		private Label _Label3;
		[AccessedThroughProperty("txtDescription")]
		private TextBox _txtDescription;
		[AccessedThroughProperty("Label2")]
		private Label _Label2;
		[AccessedThroughProperty("txtName")]
		private TextBox _txtName;
		[AccessedThroughProperty("Label1")]
		private Label _Label1;
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;
		[AccessedThroughProperty("cboSort")]
		private ComboBox _cboSort;
		[AccessedThroughProperty("Label5")]
		private Label _Label5;
		[AccessedThroughProperty("cboFormat")]
		private ComboBox _cboFormat;
		[AccessedThroughProperty("Label4")]
		private Label _Label4;
		[AccessedThroughProperty("Label7")]
		private Label _Label7;
		[AccessedThroughProperty("cboDetails")]
		private ComboBox _cboDetails;
		[AccessedThroughProperty("Label6")]
		private Label _Label6;
		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;
		[AccessedThroughProperty("numMatches")]
		private NumericUpDown _numMatches;
		[AccessedThroughProperty("chkWordWrap")]
		private CheckBox _chkWordWrap;
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;
		[AccessedThroughProperty("chkIncludeEmptyGroups")]
		private CheckBox _chkIncludeEmptyGroups;
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;
		[AccessedThroughProperty("HelpProvider1")]
		private HelpProvider _HelpProvider1;
		public ProjectOptions Options;
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
		internal virtual CheckBox chkEcmaScript
		{
			get
			{
				return this._chkEcmaScript;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkEcmaScript = value;
			}
		}
		internal virtual CheckBox chkCultureInvariant
		{
			get
			{
				return this._chkCultureInvariant;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkCultureInvariant = value;
			}
		}
		internal virtual CheckBox chkRightToLeft
		{
			get
			{
				return this._chkRightToLeft;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkRightToLeft = value;
			}
		}
		internal virtual CheckBox chkExplicitCapture
		{
			get
			{
				return this._chkExplicitCapture;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkExplicitCapture = value;
			}
		}
		internal virtual CheckBox chkCompiled
		{
			get
			{
				return this._chkCompiled;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkCompiled = value;
			}
		}
		internal virtual CheckBox chkMultiline
		{
			get
			{
				return this._chkMultiline;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkMultiline = value;
			}
		}
		internal virtual CheckBox chkIgnoreWhitespace
		{
			get
			{
				return this._chkIgnoreWhitespace;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkIgnoreWhitespace = value;
			}
		}
		internal virtual CheckBox chkIgnoreCase
		{
			get
			{
				return this._chkIgnoreCase;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkIgnoreCase = value;
			}
		}
		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}
		internal virtual TextBox txtDescription
		{
			get
			{
				return this._txtDescription;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtDescription = value;
			}
		}
		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}
		internal virtual TextBox txtName
		{
			get
			{
				return this._txtName;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtName = value;
			}
		}
		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
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
		internal virtual ComboBox cboSort
		{
			get
			{
				return this._cboSort;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cboSort = value;
			}
		}
		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}
		internal virtual ComboBox cboFormat
		{
			get
			{
				return this._cboFormat;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cboFormat = value;
			}
		}
		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}
		internal virtual Label Label7
		{
			get
			{
				return this._Label7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}
		internal virtual ComboBox cboDetails
		{
			get
			{
				return this._cboDetails;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cboDetails = value;
			}
		}
		internal virtual Label Label6
		{
			get
			{
				return this._Label6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
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
		internal virtual NumericUpDown numMatches
		{
			get
			{
				return this._numMatches;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._numMatches = value;
			}
		}
		internal virtual CheckBox chkWordWrap
		{
			get
			{
				return this._chkWordWrap;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkWordWrap = value;
			}
		}
		internal virtual GroupBox GroupBox3
		{
			get
			{
				return this._GroupBox3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox3 = value;
			}
		}
		internal virtual CheckBox chkIncludeEmptyGroups
		{
			get
			{
				return this._chkIncludeEmptyGroups;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkIncludeEmptyGroups = value;
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
		public PropertiesForm()
		{
			base.Load += new EventHandler(this.PropertiesForm_Load);
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
			this.GroupBox1 = new GroupBox();
			this.chkEcmaScript = new CheckBox();
			this.chkCultureInvariant = new CheckBox();
			this.chkRightToLeft = new CheckBox();
			this.chkExplicitCapture = new CheckBox();
			this.chkCompiled = new CheckBox();
			this.chkMultiline = new CheckBox();
			this.chkIgnoreWhitespace = new CheckBox();
			this.chkIgnoreCase = new CheckBox();
			this.Label3 = new Label();
			this.txtDescription = new TextBox();
			this.Label2 = new Label();
			this.txtName = new TextBox();
			this.Label1 = new Label();
			this.GroupBox2 = new GroupBox();
			this.chkIncludeEmptyGroups = new CheckBox();
			this.numMatches = new NumericUpDown();
			this.Label7 = new Label();
			this.cboDetails = new ComboBox();
			this.Label6 = new Label();
			this.cboSort = new ComboBox();
			this.Label5 = new Label();
			this.cboFormat = new ComboBox();
			this.Label4 = new Label();
			this.chkWordWrap = new CheckBox();
			this.btnOK = new Button();
			this.btnCancel = new Button();
			this.GroupBox3 = new GroupBox();
			this.ToolTip1 = new ToolTip(this.components);
			this.HelpProvider1 = new HelpProvider();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((ISupportInitialize)this.numMatches).BeginInit();
			this.GroupBox3.SuspendLayout();
			this.SuspendLayout();
			this.GroupBox1.Controls.Add(this.chkEcmaScript);
			this.GroupBox1.Controls.Add(this.chkCultureInvariant);
			this.GroupBox1.Controls.Add(this.chkRightToLeft);
			this.GroupBox1.Controls.Add(this.chkExplicitCapture);
			this.GroupBox1.Controls.Add(this.chkCompiled);
			this.GroupBox1.Controls.Add(this.chkMultiline);
			this.GroupBox1.Controls.Add(this.chkIgnoreWhitespace);
			this.GroupBox1.Controls.Add(this.chkIgnoreCase);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.txtDescription);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtName);
			this.GroupBox1.Controls.Add(this.Label1);
			Control arg_2BD_0 = this.GroupBox1;
			Point location = new Point(12, 12);
			arg_2BD_0.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			Control arg_2EA_0 = this.GroupBox1;
			Size size = new Size(616, 182);
			arg_2EA_0.Size = size;
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Regex";
			this.chkEcmaScript.AutoSize = true;
			Control arg_33B_0 = this.chkEcmaScript;
			location = new Point(460, 150);
			arg_33B_0.Location = location;
			this.chkEcmaScript.Name = "chkEcmaScript";
			Control arg_362_0 = this.chkEcmaScript;
			size = new Size(83, 17);
			arg_362_0.Size = size;
			this.chkEcmaScript.TabIndex = 12;
			this.chkEcmaScript.Text = "ECM&AScript";
			this.ToolTip1.SetToolTip(this.chkEcmaScript, "Enables ECMAScript-compliant behavior. §This flag can be used only in conjunction with the IgnoreCase, Multiline, and Compiled flags. ");
			this.chkEcmaScript.UseVisualStyleBackColor = true;
			this.chkCultureInvariant.AutoSize = true;
			Control arg_3C7_0 = this.chkCultureInvariant;
			location = new Point(460, 127);
			arg_3C7_0.Location = location;
			this.chkCultureInvariant.Name = "chkCultureInvariant";
			Control arg_3EE_0 = this.chkCultureInvariant;
			size = new Size(102, 17);
			arg_3EE_0.Size = size;
			this.chkCultureInvariant.TabIndex = 11;
			this.chkCultureInvariant.Text = "C&ulture invariant";
			this.ToolTip1.SetToolTip(this.chkCultureInvariant, "Uses the culture implied by CultureInfo.InvariantCulture, instead of §the locale assigned to the current thread.");
			this.chkCultureInvariant.UseVisualStyleBackColor = true;
			this.chkRightToLeft.AutoSize = true;
			Control arg_456_0 = this.chkRightToLeft;
			location = new Point(310, 151);
			arg_456_0.Location = location;
			this.chkRightToLeft.Name = "chkRightToLeft";
			Control arg_47D_0 = this.chkRightToLeft;
			size = new Size(80, 17);
			arg_47D_0.Size = size;
			this.chkRightToLeft.TabIndex = 10;
			this.chkRightToLeft.Text = "&Right to left";
			this.ToolTip1.SetToolTip(this.chkRightToLeft, "Specifies that the search is from right to left §instead of from left to right. If a starting index is specified, §it should point to the end of the string. ");
			this.chkRightToLeft.UseVisualStyleBackColor = true;
			this.chkExplicitCapture.AutoSize = true;
			Control arg_4E5_0 = this.chkExplicitCapture;
			location = new Point(310, 128);
			arg_4E5_0.Location = location;
			this.chkExplicitCapture.Name = "chkExplicitCapture";
			Control arg_50C_0 = this.chkExplicitCapture;
			size = new Size(98, 17);
			arg_50C_0.Size = size;
			this.chkExplicitCapture.TabIndex = 9;
			this.chkExplicitCapture.Text = "&Explicit capture";
			this.ToolTip1.SetToolTip(this.chkExplicitCapture, "Captures only explicitly named or numbered groups §of the form (?<name>) so that naked parentheses act as noncapturing §groups without your having to use the (?:) construct.");
			this.chkExplicitCapture.UseVisualStyleBackColor = true;
			this.chkCompiled.AutoSize = true;
			Control arg_574_0 = this.chkCompiled;
			location = new Point(206, 151);
			arg_574_0.Location = location;
			this.chkCompiled.Name = "chkCompiled";
			Control arg_59B_0 = this.chkCompiled;
			size = new Size(69, 17);
			arg_59B_0.Size = size;
			this.chkCompiled.TabIndex = 8;
			this.chkCompiled.Text = "&Compiled";
			this.ToolTip1.SetToolTip(this.chkCompiled, "Compiles the regular expression and generates MSIL code; §this option generates faster code at the expense of longer start-up time.");
			this.chkCompiled.UseVisualStyleBackColor = true;
			this.chkMultiline.AutoSize = true;
			Control arg_5FF_0 = this.chkMultiline;
			location = new Point(206, 127);
			arg_5FF_0.Location = location;
			this.chkMultiline.Name = "chkMultiline";
			Control arg_626_0 = this.chkMultiline;
			size = new Size(64, 17);
			arg_626_0.Size = size;
			this.chkMultiline.TabIndex = 7;
			this.chkMultiline.Text = "&Multiline";
			this.ToolTip1.SetToolTip(this.chkMultiline, "Multiline mode; changes the behavior of §^ and $ so that they match the beginning and end of individual lines, respectively, §instead of the whole string.");
			this.chkMultiline.UseVisualStyleBackColor = true;
			this.chkIgnoreWhitespace.AutoSize = true;
			Control arg_68A_0 = this.chkIgnoreWhitespace;
			location = new Point(75, 151);
			arg_68A_0.Location = location;
			this.chkIgnoreWhitespace.Name = "chkIgnoreWhitespace";
			Control arg_6B1_0 = this.chkIgnoreWhitespace;
			size = new Size(116, 17);
			arg_6B1_0.Size = size;
			this.chkIgnoreWhitespace.TabIndex = 6;
			this.chkIgnoreWhitespace.Text = "Ignore &Whitespace";
			this.ToolTip1.SetToolTip(this.chkIgnoreWhitespace, "Ignores unescaped white space from the pattern and §enables comments marked with #. Significant spaces §in the pattern must be specified as [ ] or \\x20.");
			this.chkIgnoreWhitespace.UseVisualStyleBackColor = true;
			this.chkIgnoreCase.AutoSize = true;
			Control arg_715_0 = this.chkIgnoreCase;
			location = new Point(75, 128);
			arg_715_0.Location = location;
			this.chkIgnoreCase.Name = "chkIgnoreCase";
			Control arg_73C_0 = this.chkIgnoreCase;
			size = new Size(83, 17);
			arg_73C_0.Size = size;
			this.chkIgnoreCase.TabIndex = 5;
			this.chkIgnoreCase.Text = "&Ignore Case";
			this.ToolTip1.SetToolTip(this.chkIgnoreCase, "Ignore case in searches");
			this.chkIgnoreCase.UseVisualStyleBackColor = true;
			this.Label3.AutoSize = true;
			Control arg_7A0_0 = this.Label3;
			location = new Point(9, 128);
			arg_7A0_0.Location = location;
			this.Label3.Name = "Label3";
			Control arg_7C7_0 = this.Label3;
			size = new Size(43, 13);
			arg_7C7_0.Size = size;
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Options";
			this.txtDescription.AcceptsReturn = true;
			Control arg_806_0 = this.txtDescription;
			location = new Point(75, 58);
			arg_806_0.Location = location;
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ScrollBars = ScrollBars.Vertical;
			Control arg_848_0 = this.txtDescription;
			size = new Size(529, 52);
			arg_848_0.Size = size;
			this.txtDescription.TabIndex = 3;
			this.ToolTip1.SetToolTip(this.txtDescription, "The free-format description of the regular expression.§Can be used to generate comments in code.");
			this.Label2.AutoSize = true;
			Control arg_88D_0 = this.Label2;
			location = new Point(9, 58);
			arg_88D_0.Location = location;
			this.Label2.Name = "Label2";
			Control arg_8B4_0 = this.Label2;
			size = new Size(60, 13);
			arg_8B4_0.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "&Description";
			Control arg_8E7_0 = this.txtName;
			location = new Point(74, 25);
			arg_8E7_0.Location = location;
			this.txtName.Name = "txtName";
			Control arg_911_0 = this.txtName;
			size = new Size(530, 20);
			arg_911_0.Size = size;
			this.txtName.TabIndex = 1;
			this.ToolTip1.SetToolTip(this.txtName, "The name of the regular expression. §It is used when the expression is compiled.");
			this.Label1.AutoSize = true;
			Control arg_956_0 = this.Label1;
			location = new Point(9, 28);
			arg_956_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_97D_0 = this.Label1;
			size = new Size(35, 13);
			arg_97D_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "&Name";
			this.GroupBox2.Controls.Add(this.chkIncludeEmptyGroups);
			this.GroupBox2.Controls.Add(this.numMatches);
			this.GroupBox2.Controls.Add(this.Label7);
			this.GroupBox2.Controls.Add(this.cboDetails);
			this.GroupBox2.Controls.Add(this.Label6);
			this.GroupBox2.Controls.Add(this.cboSort);
			this.GroupBox2.Controls.Add(this.Label5);
			this.GroupBox2.Controls.Add(this.cboFormat);
			this.GroupBox2.Controls.Add(this.Label4);
			Control arg_A79_0 = this.GroupBox2;
			location = new Point(12, 212);
			arg_A79_0.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			Control arg_AA6_0 = this.GroupBox2;
			size = new Size(295, 177);
			arg_AA6_0.Size = size;
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Results";
			this.chkIncludeEmptyGroups.AutoSize = true;
			Control arg_AF4_0 = this.chkIncludeEmptyGroups;
			location = new Point(75, 150);
			arg_AF4_0.Location = location;
			this.chkIncludeEmptyGroups.Name = "chkIncludeEmptyGroups";
			Control arg_B1B_0 = this.chkIncludeEmptyGroups;
			size = new Size(127, 17);
			arg_B1B_0.Size = size;
			this.chkIncludeEmptyGroups.TabIndex = 8;
			this.chkIncludeEmptyGroups.Text = "Include empty g&roups";
			this.ToolTip1.SetToolTip(this.chkIncludeEmptyGroups, "If selected, groups are included in results §even if they match an empty string.");
			this.chkIncludeEmptyGroups.UseVisualStyleBackColor = true;
			NumericUpDown arg_B85_0 = this.numMatches;
			decimal num = new decimal(new int[]
			{
				100,
				0,
				0,
				0
			});
			arg_B85_0.Increment = num;
			Control arg_B9C_0 = this.numMatches;
			location = new Point(75, 26);
			arg_B9C_0.Location = location;
			NumericUpDown arg_BCB_0 = this.numMatches;
			num = new decimal(new int[]
			{
				10000,
				0,
				0,
				0
			});
			arg_BCB_0.Maximum = num;
			NumericUpDown arg_BF7_0 = this.numMatches;
			num = new decimal(new int[]
			{
				100,
				0,
				0,
				0
			});
			arg_BF7_0.Minimum = num;
			this.numMatches.Name = "numMatches";
			Control arg_C1E_0 = this.numMatches;
			size = new Size(83, 20);
			arg_C1E_0.Size = size;
			this.numMatches.TabIndex = 1;
			this.numMatches.TextAlign = HorizontalAlignment.Right;
			this.ToolTip1.SetToolTip(this.numMatches, "Maximum number of matches that are displayed.");
			NumericUpDown arg_C78_0 = this.numMatches;
			num = new decimal(new int[]
			{
				100,
				0,
				0,
				0
			});
			arg_C78_0.Value = num;
			Control arg_C8F_0 = this.Label7;
			location = new Point(9, 26);
			arg_C8F_0.Location = location;
			this.Label7.Name = "Label7";
			Control arg_CB6_0 = this.Label7;
			size = new Size(73, 30);
			arg_CB6_0.Size = size;
			this.Label7.TabIndex = 0;
			this.Label7.Text = "Ma&x number of matches";
			this.cboDetails.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cboDetails.FormattingEnabled = true;
			this.cboDetails.Items.AddRange(new object[]
			{
				"No details",
				"Groups",
				"Groups and Captures"
			});
			Control arg_D36_0 = this.cboDetails;
			location = new Point(75, 123);
			arg_D36_0.Location = location;
			this.cboDetails.Name = "cboDetails";
			Control arg_D60_0 = this.cboDetails;
			size = new Size(186, 21);
			arg_D60_0.Size = size;
			this.cboDetails.TabIndex = 7;
			this.ToolTip1.SetToolTip(this.cboDetails, "Whether groups and captures are displayed in results");
			this.Label6.AutoSize = true;
			Control arg_DA5_0 = this.Label6;
			location = new Point(9, 123);
			arg_DA5_0.Location = location;
			this.Label6.Name = "Label6";
			Control arg_DCC_0 = this.Label6;
			size = new Size(39, 13);
			arg_DCC_0.Size = size;
			this.Label6.TabIndex = 6;
			this.Label6.Text = "De&tails";
			this.cboSort.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cboSort.FormattingEnabled = true;
			this.cboSort.Items.AddRange(new object[]
			{
				"Sort on Position",
				"Sort on Name",
				"Shortest first",
				"Longest first"
			});
			Control arg_E55_0 = this.cboSort;
			location = new Point(74, 93);
			arg_E55_0.Location = location;
			this.cboSort.Name = "cboSort";
			Control arg_E7F_0 = this.cboSort;
			size = new Size(186, 21);
			arg_E7F_0.Size = size;
			this.cboSort.TabIndex = 5;
			this.ToolTip1.SetToolTip(this.cboSort, "How results are sorted");
			this.Label5.AutoSize = true;
			Control arg_EC4_0 = this.Label5;
			location = new Point(10, 93);
			arg_EC4_0.Location = location;
			this.Label5.Name = "Label5";
			Control arg_EEB_0 = this.Label5;
			size = new Size(26, 13);
			arg_EEB_0.Size = size;
			this.Label5.TabIndex = 4;
			this.Label5.Text = "&Sort";
			this.cboFormat.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cboFormat.FormattingEnabled = true;
			this.cboFormat.Items.AddRange(new object[]
			{
				"Auto",
				"Treeview",
				"Report"
			});
			Control arg_F6B_0 = this.cboFormat;
			location = new Point(74, 58);
			arg_F6B_0.Location = location;
			this.cboFormat.Name = "cboFormat";
			Control arg_F95_0 = this.cboFormat;
			size = new Size(186, 21);
			arg_F95_0.Size = size;
			this.cboFormat.TabIndex = 3;
			this.ToolTip1.SetToolTip(this.cboFormat, "Sets the format used to display results. §Results are displayed either in a treeview or a textbox. §By default, the Find command uses the treeview, all other commands use the textbox.");
			this.Label4.AutoSize = true;
			Control arg_FDA_0 = this.Label4;
			location = new Point(9, 61);
			arg_FDA_0.Location = location;
			this.Label4.Name = "Label4";
			Control arg_1001_0 = this.Label4;
			size = new Size(39, 13);
			arg_1001_0.Size = size;
			this.Label4.TabIndex = 2;
			this.Label4.Text = "&Format";
			this.chkWordWrap.AutoSize = true;
			Control arg_1040_0 = this.chkWordWrap;
			location = new Point(35, 29);
			arg_1040_0.Location = location;
			this.chkWordWrap.Name = "chkWordWrap";
			Control arg_1067_0 = this.chkWordWrap;
			size = new Size(78, 17);
			arg_1067_0.Size = size;
			this.chkWordWrap.TabIndex = 0;
			this.chkWordWrap.Text = "&Word wrap";
			this.ToolTip1.SetToolTip(this.chkWordWrap, "Word-wrap mode for all textboxes in the main form.");
			this.chkWordWrap.UseVisualStyleBackColor = true;
			Control arg_10C2_0 = this.btnOK;
			location = new Point(472, 405);
			arg_10C2_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_10E9_0 = this.btnOK;
			size = new Size(75, 23);
			arg_10E9_0.Size = size;
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.ToolTip1.SetToolTip(this.btnOK, "Save all properties and close the dialog box.");
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnCancel.DialogResult = DialogResult.Cancel;
			Control arg_1150_0 = this.btnCancel;
			location = new Point(553, 405);
			arg_1150_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_1177_0 = this.btnCancel;
			size = new Size(75, 23);
			arg_1177_0.Size = size;
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.ToolTip1.SetToolTip(this.btnCancel, "Close the dialog box without saving.");
			this.btnCancel.UseVisualStyleBackColor = true;
			this.GroupBox3.Controls.Add(this.chkWordWrap);
			Control arg_11E8_0 = this.GroupBox3;
			location = new Point(322, 212);
			arg_11E8_0.Location = location;
			this.GroupBox3.Name = "GroupBox3";
			Control arg_1215_0 = this.GroupBox3;
			size = new Size(306, 177);
			arg_1215_0.Size = size;
			this.GroupBox3.TabIndex = 2;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Miscellaneous";
			this.AcceptButton = this.btnOK;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			size = new Size(639, 439);
			this.ClientSize = size;
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PropertiesForm";
			this.Text = "Properties";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			((ISupportInitialize)this.numMatches).EndInit();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.ResumeLayout(false);
		}
		private void PropertiesForm_Load(object sender, EventArgs e)
		{
			Helpers.SetTooltipsAndHelpMessages(this, this.ToolTip1, this.HelpProvider1);
			this.txtName.Text = this.Options.RegexName;
			this.txtDescription.Text = this.Options.RegexDescription;
			this.chkIgnoreCase.Checked = ((this.Options.RegexOptions & RegexOptions.IgnoreCase) > RegexOptions.None);
			this.chkIgnoreWhitespace.Checked = ((this.Options.RegexOptions & RegexOptions.IgnorePatternWhitespace) > RegexOptions.None);
			this.chkMultiline.Checked = ((this.Options.RegexOptions & RegexOptions.Multiline) > RegexOptions.None);
			this.chkCompiled.Checked = ((this.Options.RegexOptions & RegexOptions.Compiled) > RegexOptions.None);
			this.chkExplicitCapture.Checked = ((this.Options.RegexOptions & RegexOptions.ExplicitCapture) > RegexOptions.None);
			this.chkRightToLeft.Checked = ((this.Options.RegexOptions & RegexOptions.RightToLeft) > RegexOptions.None);
			this.chkCultureInvariant.Checked = ((this.Options.RegexOptions & RegexOptions.CultureInvariant) > RegexOptions.None);
			this.chkEcmaScript.Checked = ((this.Options.RegexOptions & RegexOptions.ECMAScript) > RegexOptions.None);
			this.numMatches.Value = new decimal(this.Options.MaxMatches);
			this.chkWordWrap.Checked = this.Options.WordWrap;
			this.cboFormat.SelectedIndex = (int)this.Options.Format;
			this.cboDetails.SelectedIndex = (int)this.Options.Detail;
			this.cboSort.SelectedIndex = (int)this.Options.Sort;
			this.chkIncludeEmptyGroups.Checked = this.Options.IncludeEmptyGroups;
		}
		private void btnOK_Click(object sender, EventArgs e)
		{
			this.Options.RegexName = this.txtName.Text;
			this.Options.RegexDescription = this.txtDescription.Text;
			this.SetRegexOption(RegexOptions.IgnoreCase, this.chkIgnoreCase.Checked);
			this.SetRegexOption(RegexOptions.IgnorePatternWhitespace, this.chkIgnoreWhitespace.Checked);
			this.SetRegexOption(RegexOptions.Multiline, this.chkMultiline.Checked);
			this.SetRegexOption(RegexOptions.Compiled, this.chkCompiled.Checked);
			this.SetRegexOption(RegexOptions.ExplicitCapture, this.chkExplicitCapture.Checked);
			this.SetRegexOption(RegexOptions.RightToLeft, this.chkRightToLeft.Checked);
			this.SetRegexOption(RegexOptions.CultureInvariant, this.chkCultureInvariant.Checked);
			this.SetRegexOption(RegexOptions.ECMAScript, this.chkEcmaScript.Checked);
			this.Options.MaxMatches = Convert.ToInt32(this.numMatches.Value);
			this.Options.WordWrap = this.chkWordWrap.Checked;
			this.Options.Format = (FormatOption)this.cboFormat.SelectedIndex;
			this.Options.Detail = (DetailOption)this.cboDetails.SelectedIndex;
			this.Options.Sort = (SortOption)this.cboSort.SelectedIndex;
			this.Options.IncludeEmptyGroups = this.chkIncludeEmptyGroups.Checked;
			this.DialogResult = DialogResult.OK;
		}
		private void SetRegexOption(RegexOptions bitMask, bool value)
		{
			if (value)
			{
				this.Options.RegexOptions = (this.Options.RegexOptions | bitMask);
			}
			else
			{
				this.Options.RegexOptions = (this.Options.RegexOptions & ~bitMask);
			}
		}
	}
}
