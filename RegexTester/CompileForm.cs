using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace RegexTester
{
	[DesignerGenerated]
	public class CompileForm : Form
	{
		private IContainer components;
		[AccessedThroughProperty("btnRemove")]
		private Button _btnRemove;
		[AccessedThroughProperty("btnCompile")]
		private Button _btnCompile;
		[AccessedThroughProperty("txtNamespace")]
		private TextBox _txtNamespace;
		[AccessedThroughProperty("Label1")]
		private Label _Label1;
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;
		[AccessedThroughProperty("dlgOpenRegex")]
		private OpenFileDialog _dlgOpenRegex;
		[AccessedThroughProperty("dgrRegexes")]
		private DataGridView _dgrRegexes;
		[AccessedThroughProperty("btnFile")]
		private Button _btnFile;
		[AccessedThroughProperty("RegexBindingSource")]
		private BindingSource _RegexBindingSource;
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;
		[AccessedThroughProperty("btnClear")]
		private Button _btnClear;
		[AccessedThroughProperty("btnCurrent")]
		private Button _btnCurrent;
		[AccessedThroughProperty("grdcolName")]
		private DataGridViewTextBoxColumn _grdcolName;
		[AccessedThroughProperty("grdcolPattern")]
		private DataGridViewTextBoxColumn _grdcolPattern;
		[AccessedThroughProperty("dgrcolOptions")]
		private DataGridViewTextBoxColumn _dgrcolOptions;
		[AccessedThroughProperty("Label2")]
		private Label _Label2;
		[AccessedThroughProperty("dlgSaveAssembly")]
		private SaveFileDialog _dlgSaveAssembly;
		[AccessedThroughProperty("txtAssemblyName")]
		private TextBox _txtAssemblyName;
		[AccessedThroughProperty("Label3")]
		private Label _Label3;
		[AccessedThroughProperty("dlgAssemblyPath")]
		private FolderBrowserDialog _dlgAssemblyPath;
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;
		[AccessedThroughProperty("btnBrowse")]
		private Button _btnBrowse;
		[AccessedThroughProperty("txtPath")]
		private TextBox _txtPath;
		[AccessedThroughProperty("Label4")]
		private Label _Label4;
		[AccessedThroughProperty("Label5")]
		private Label _Label5;
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;
		[AccessedThroughProperty("HelpProvider1")]
		private HelpProvider _HelpProvider1;
		public MainForm MainForm;
		private static BindingList<RegexInfo> regexList = new BindingList<RegexInfo>();
		internal virtual Button btnRemove
		{
			get
			{
				return this._btnRemove;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnRemove != null)
				{
					this._btnRemove.Click -= new EventHandler(this.btnRemove_Click);
				}
				this._btnRemove = value;
				if (this._btnRemove != null)
				{
					this._btnRemove.Click += new EventHandler(this.btnRemove_Click);
				}
			}
		}
		internal virtual Button btnCompile
		{
			get
			{
				return this._btnCompile;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnCompile != null)
				{
					this._btnCompile.Click -= new EventHandler(this.btnCompile_Click);
				}
				this._btnCompile = value;
				if (this._btnCompile != null)
				{
					this._btnCompile.Click += new EventHandler(this.btnCompile_Click);
				}
			}
		}
		internal virtual TextBox txtNamespace
		{
			get
			{
				return this._txtNamespace;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtNamespace = value;
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
		internal virtual OpenFileDialog dlgOpenRegex
		{
			get
			{
				return this._dlgOpenRegex;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dlgOpenRegex = value;
			}
		}
		internal virtual DataGridView dgrRegexes
		{
			get
			{
				return this._dgrRegexes;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dgrRegexes = value;
			}
		}
		internal virtual Button btnFile
		{
			get
			{
				return this._btnFile;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnFile != null)
				{
					this._btnFile.Click -= new EventHandler(this.btnFile_Click);
				}
				this._btnFile = value;
				if (this._btnFile != null)
				{
					this._btnFile.Click += new EventHandler(this.btnFile_Click);
				}
			}
		}
		internal virtual BindingSource RegexBindingSource
		{
			get
			{
				return this._RegexBindingSource;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RegexBindingSource = value;
			}
		}
		internal virtual Button btnNew
		{
			get
			{
				return this._btnNew;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnNew != null)
				{
					this._btnNew.Click -= new EventHandler(this.btnNew_Click);
				}
				this._btnNew = value;
				if (this._btnNew != null)
				{
					this._btnNew.Click += new EventHandler(this.btnNew_Click);
				}
			}
		}
		internal virtual Button btnClear
		{
			get
			{
				return this._btnClear;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnClear != null)
				{
					this._btnClear.Click -= new EventHandler(this.btnClear_Click);
				}
				this._btnClear = value;
				if (this._btnClear != null)
				{
					this._btnClear.Click += new EventHandler(this.btnClear_Click);
				}
			}
		}
		internal virtual Button btnCurrent
		{
			get
			{
				return this._btnCurrent;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnCurrent != null)
				{
					this._btnCurrent.Click -= new EventHandler(this.btnCurrent_Click);
				}
				this._btnCurrent = value;
				if (this._btnCurrent != null)
				{
					this._btnCurrent.Click += new EventHandler(this.btnCurrent_Click);
				}
			}
		}
		internal virtual DataGridViewTextBoxColumn grdcolName
		{
			get
			{
				return this._grdcolName;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._grdcolName = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn grdcolPattern
		{
			get
			{
				return this._grdcolPattern;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._grdcolPattern = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn dgrcolOptions
		{
			get
			{
				return this._dgrcolOptions;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dgrcolOptions = value;
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
		internal virtual SaveFileDialog dlgSaveAssembly
		{
			get
			{
				return this._dlgSaveAssembly;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dlgSaveAssembly = value;
			}
		}
		internal virtual TextBox txtAssemblyName
		{
			get
			{
				return this._txtAssemblyName;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtAssemblyName = value;
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
		internal virtual FolderBrowserDialog dlgAssemblyPath
		{
			get
			{
				return this._dlgAssemblyPath;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dlgAssemblyPath = value;
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
		internal virtual Button btnBrowse
		{
			get
			{
				return this._btnBrowse;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnBrowse != null)
				{
					this._btnBrowse.Click -= new EventHandler(this.btnBrowse_Click);
				}
				this._btnBrowse = value;
				if (this._btnBrowse != null)
				{
					this._btnBrowse.Click += new EventHandler(this.btnBrowse_Click);
				}
			}
		}
		internal virtual TextBox txtPath
		{
			get
			{
				return this._txtPath;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtPath = value;
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
		public CompileForm()
		{
			base.Load += new EventHandler(this.CompileForm_Load);
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
			this.btnRemove = new Button();
			this.btnCompile = new Button();
			this.txtNamespace = new TextBox();
			this.Label1 = new Label();
			this.btnCancel = new Button();
			this.dlgOpenRegex = new OpenFileDialog();
			this.dgrRegexes = new DataGridView();
			this.grdcolName = new DataGridViewTextBoxColumn();
			this.grdcolPattern = new DataGridViewTextBoxColumn();
			this.dgrcolOptions = new DataGridViewTextBoxColumn();
			this.RegexBindingSource = new BindingSource(this.components);
			this.btnFile = new Button();
			this.btnNew = new Button();
			this.btnClear = new Button();
			this.btnCurrent = new Button();
			this.Label2 = new Label();
			this.dlgSaveAssembly = new SaveFileDialog();
			this.txtAssemblyName = new TextBox();
			this.Label3 = new Label();
			this.dlgAssemblyPath = new FolderBrowserDialog();
			this.GroupBox1 = new GroupBox();
			this.btnBrowse = new Button();
			this.txtPath = new TextBox();
			this.Label4 = new Label();
			this.Label5 = new Label();
			this.ToolTip1 = new ToolTip(this.components);
			this.HelpProvider1 = new HelpProvider();
			((ISupportInitialize)this.dgrRegexes).BeginInit();
			((ISupportInitialize)this.RegexBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			this.btnRemove.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			Control arg_18C_0 = this.btnRemove;
			Point location = new Point(776, 154);
			arg_18C_0.Location = location;
			this.btnRemove.Name = "btnRemove";
			Control arg_1B3_0 = this.btnRemove;
			Size size = new Size(58, 23);
			arg_1B3_0.Size = size;
			this.btnRemove.TabIndex = 6;
			this.btnRemove.Text = "&Remove";
			this.ToolTip1.SetToolTip(this.btnRemove, "Remove the selected regular expression from the list. §(Click on the row header to the left to select an item.)");
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnCompile.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Control arg_21B_0 = this.btnCompile;
			location = new Point(776, 239);
			arg_21B_0.Location = location;
			this.btnCompile.Name = "btnCompile";
			Control arg_242_0 = this.btnCompile;
			size = new Size(58, 23);
			arg_242_0.Size = size;
			this.btnCompile.TabIndex = 9;
			this.btnCompile.Text = "&Compile";
			this.ToolTip1.SetToolTip(this.btnCompile, "Compile the list of regular expressions and generate an assembly.");
			this.btnCompile.UseVisualStyleBackColor = true;
			this.txtNamespace.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			Control arg_2A8_0 = this.txtNamespace;
			location = new Point(459, 20);
			arg_2A8_0.Location = location;
			this.txtNamespace.Name = "txtNamespace";
			Control arg_2D2_0 = this.txtNamespace;
			size = new Size(298, 20);
			arg_2D2_0.Size = size;
			this.txtNamespace.TabIndex = 3;
			this.ToolTip1.SetToolTip(this.txtNamespace, "The namespace used for all the compiled regular expressions.");
			this.Label1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.Label1.AutoSize = true;
			Control arg_327_0 = this.Label1;
			location = new Point(363, 25);
			arg_327_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_34E_0 = this.Label1;
			size = new Size(90, 13);
			arg_34E_0.Size = size;
			this.Label1.TabIndex = 2;
			this.Label1.Text = "R&oot Namespace";
			this.btnCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnCancel.DialogResult = DialogResult.Cancel;
			Control arg_3A0_0 = this.btnCancel;
			location = new Point(776, 268);
			arg_3A0_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_3C7_0 = this.btnCancel;
			size = new Size(58, 23);
			arg_3C7_0.Size = size;
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.ToolTip1.SetToolTip(this.btnCancel, "Close the dialog box without compiling.");
			this.btnCancel.UseVisualStyleBackColor = true;
			this.dlgOpenRegex.DefaultExt = "regex";
			this.dlgOpenRegex.Filter = "Regex files (*.regex)|*.regex|All files|*.*";
			this.dlgOpenRegex.Multiselect = true;
			this.dlgOpenRegex.Title = "Open a regex file";
			this.dgrRegexes.AllowUserToAddRows = false;
			this.dgrRegexes.AllowUserToResizeRows = false;
			this.dgrRegexes.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.dgrRegexes.AutoGenerateColumns = false;
			this.dgrRegexes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgrRegexes.Columns.AddRange(new DataGridViewColumn[]
			{
				this.grdcolName,
				this.grdcolPattern,
				this.dgrcolOptions
			});
			this.dgrRegexes.DataSource = this.RegexBindingSource;
			Control arg_4D9_0 = this.dgrRegexes;
			location = new Point(7, 29);
			arg_4D9_0.Location = location;
			this.dgrRegexes.MultiSelect = false;
			this.dgrRegexes.Name = "dgrRegexes";
			this.dgrRegexes.RowHeadersWidth = 24;
			Control arg_51F_0 = this.dgrRegexes;
			size = new Size(764, 177);
			arg_51F_0.Size = size;
			this.dgrRegexes.TabIndex = 1;
			this.ToolTip1.SetToolTip(this.dgrRegexes, "The list of regular expressions to be compiled.");
			this.grdcolName.DataPropertyName = "Name";
			this.grdcolName.HeaderText = "Name";
			this.grdcolName.MaxInputLength = 30;
			this.grdcolName.Name = "grdcolName";
			this.grdcolName.Width = 150;
			this.grdcolPattern.DataPropertyName = "Pattern";
			this.grdcolPattern.HeaderText = "Pattern";
			this.grdcolPattern.MaxInputLength = 1024;
			this.grdcolPattern.Name = "grdcolPattern";
			this.grdcolPattern.Width = 480;
			this.dgrcolOptions.DataPropertyName = "OptionsText";
			this.dgrcolOptions.HeaderText = "Options";
			this.dgrcolOptions.Name = "dgrcolOptions";
			this.RegexBindingSource.AllowNew = false;
			this.btnFile.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			Control arg_641_0 = this.btnFile;
			location = new Point(776, 87);
			arg_641_0.Location = location;
			this.btnFile.Name = "btnFile";
			Control arg_668_0 = this.btnFile;
			size = new Size(58, 23);
			arg_668_0.Size = size;
			this.btnFile.TabIndex = 5;
			this.btnFile.Text = "&File";
			this.ToolTip1.SetToolTip(this.btnFile, "Add a regular expression saved in a file to the list.");
			this.btnFile.UseVisualStyleBackColor = true;
			this.btnNew.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			Control arg_6CD_0 = this.btnNew;
			location = new Point(776, 29);
			arg_6CD_0.Location = location;
			this.btnNew.Name = "btnNew";
			Control arg_6F4_0 = this.btnNew;
			size = new Size(58, 23);
			arg_6F4_0.Size = size;
			this.btnNew.TabIndex = 3;
			this.btnNew.Text = "&New";
			this.ToolTip1.SetToolTip(this.btnNew, "Add a new (blank) regular expression to the list.");
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnClear.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			Control arg_75C_0 = this.btnClear;
			location = new Point(776, 183);
			arg_75C_0.Location = location;
			this.btnClear.Name = "btnClear";
			Control arg_783_0 = this.btnClear;
			size = new Size(58, 23);
			arg_783_0.Size = size;
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "C&lear";
			this.ToolTip1.SetToolTip(this.btnClear, "Remove all items from the list.");
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnCurrent.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			Control arg_7E8_0 = this.btnCurrent;
			location = new Point(776, 58);
			arg_7E8_0.Location = location;
			this.btnCurrent.Name = "btnCurrent";
			Control arg_80F_0 = this.btnCurrent;
			size = new Size(58, 23);
			arg_80F_0.Size = size;
			this.btnCurrent.TabIndex = 4;
			this.btnCurrent.Text = "C&urrent";
			this.ToolTip1.SetToolTip(this.btnCurrent, "Add the current regular expression (the one being §tested in the main window) to the list.");
			this.btnCurrent.UseVisualStyleBackColor = true;
			this.Label2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.Label2.AutoSize = true;
			Control arg_87F_0 = this.Label2;
			location = new Point(9, 209);
			arg_87F_0.Location = location;
			this.Label2.Name = "Label2";
			Control arg_8A9_0 = this.Label2;
			size = new Size(734, 13);
			arg_8A9_0.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "OPTIONS: I=Ignore case,  M=Multiline, X=Ignore,PatternWhitespace,  C=compiled,  N=ExplicitCapture,  R=RightToLeft, U=CultureInvariant, A=EcmaScript";
			this.dlgSaveAssembly.DefaultExt = "dll";
			this.dlgSaveAssembly.Filter = "All assemblies (*.dll)|*.dll";
			this.dlgSaveAssembly.Title = "Select the destination assembly";
			this.txtAssemblyName.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			Control arg_919_0 = this.txtAssemblyName;
			location = new Point(58, 22);
			arg_919_0.Location = location;
			this.txtAssemblyName.Name = "txtAssemblyName";
			Control arg_943_0 = this.txtAssemblyName;
			size = new Size(261, 20);
			arg_943_0.Size = size;
			this.txtAssemblyName.TabIndex = 1;
			this.ToolTip1.SetToolTip(this.txtAssemblyName, "The name of the compiled assembly. §(It is also used to name the generated DLL file.)");
			this.Label3.AutoSize = true;
			Control arg_987_0 = this.Label3;
			location = new Point(6, 22);
			arg_987_0.Location = location;
			this.Label3.Name = "Label3";
			Control arg_9AE_0 = this.Label3;
			size = new Size(35, 13);
			arg_9AE_0.Size = size;
			this.Label3.TabIndex = 0;
			this.Label3.Text = "&Name";
			this.GroupBox1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.GroupBox1.Controls.Add(this.btnBrowse);
			this.GroupBox1.Controls.Add(this.txtPath);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.txtAssemblyName);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.txtNamespace);
			Control arg_A8A_0 = this.GroupBox1;
			location = new Point(7, 234);
			arg_A8A_0.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			Control arg_AB4_0 = this.GroupBox1;
			size = new Size(764, 88);
			arg_AB4_0.Size = size;
			this.GroupBox1.TabIndex = 8;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Generated assembly";
			this.btnBrowse.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			Control arg_B03_0 = this.btnBrowse;
			location = new Point(325, 53);
			arg_B03_0.Location = location;
			this.btnBrowse.Name = "btnBrowse";
			Control arg_B2A_0 = this.btnBrowse;
			size = new Size(34, 23);
			arg_B2A_0.Size = size;
			this.btnBrowse.TabIndex = 6;
			this.btnBrowse.Text = "...";
			this.ToolTip1.SetToolTip(this.btnBrowse, "Select the output path.");
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.txtPath.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			Control arg_B8C_0 = this.txtPath;
			location = new Point(58, 53);
			arg_B8C_0.Location = location;
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			Control arg_BC2_0 = this.txtPath;
			size = new Size(261, 20);
			arg_BC2_0.Size = size;
			this.txtPath.TabIndex = 5;
			this.ToolTip1.SetToolTip(this.txtPath, "The directory where the compiled assembly is created.");
			this.Label4.AutoSize = true;
			Control arg_C06_0 = this.Label4;
			location = new Point(6, 56);
			arg_C06_0.Location = location;
			this.Label4.Name = "Label4";
			Control arg_C2D_0 = this.Label4;
			size = new Size(29, 13);
			arg_C2D_0.Size = size;
			this.Label4.TabIndex = 4;
			this.Label4.Text = "&Path";
			this.Label5.AutoSize = true;
			Control arg_C6B_0 = this.Label5;
			location = new Point(4, 9);
			arg_C6B_0.Location = location;
			this.Label5.Name = "Label5";
			Control arg_C95_0 = this.Label5;
			size = new Size(411, 13);
			arg_C95_0.Size = size;
			this.Label5.TabIndex = 0;
			this.Label5.Text = "Enter the regular expressions expressions to be compiled, or add them from .regex files";
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			size = new Size(846, 339);
			this.ClientSize = size;
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.btnCurrent);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnFile);
			this.Controls.Add(this.dgrRegexes);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnCompile);
			this.Controls.Add(this.btnRemove);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			size = new Size(854, 373);
			this.MinimumSize = size;
			this.Name = "CompileForm";
			this.Text = "Compile to Assembly";
			((ISupportInitialize)this.dgrRegexes).EndInit();
			((ISupportInitialize)this.RegexBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private void CompileForm_Load(object sender, EventArgs e)
		{
			Helpers.SetTooltipsAndHelpMessages(this, this.ToolTip1, this.HelpProvider1);
			this.RegexBindingSource.DataSource = CompileForm.regexList;
		}
		private void btnNew_Click(object sender, EventArgs e)
		{
			CompileForm.regexList.Add(new RegexInfo());
		}
		private void btnCurrent_Click(object sender, EventArgs e)
		{
			this.MainForm.UpdateOptionFiels();
			RegexInfo item = RegexInfo.FromProjectOption(this.MainForm.Options);
			CompileForm.regexList.Add(item);
		}
		private void btnFile_Click(object sender, EventArgs e)
		{
			if (this.dlgOpenRegex.ShowDialog() != DialogResult.Cancel)
			{
				try
				{
					ProjectOptions prjOptions = ProjectOptions.Load(this.dlgOpenRegex.FileName);
					RegexInfo item = RegexInfo.FromProjectOption(prjOptions);
					CompileForm.regexList.Add(item);
				}
				catch (Exception expr_35)
				{
					ProjectData.SetProjectError(expr_35);
					Exception ex = expr_35;
					MessageBox.Show(ex.Message, "Unable to open regex file", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
			}
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (this.dgrRegexes.SelectedRows.Count == 0)
			{
				MessageBox.Show("Please select an entire row", "Remove row", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
            {
                IEnumerator enumerator = this.dgrRegexes.SelectedRows.GetEnumerator();
				try
				{
				
					while (enumerator.MoveNext())
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
						CompileForm.regexList.RemoveAt(dataGridViewRow.Index);
					}
				}
				finally
				{
				 
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}
		private void btnClear_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to remove all items?", "Remove all rows", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				CompileForm.regexList.Clear();
			}
		}
		private void btnCompile_Click(object sender, EventArgs e)
		{
			List<RegexInfo> list = new List<RegexInfo>();
			if (this.txtAssemblyName.TextLength == 0 || this.txtNamespace.TextLength == 0)
			{
				MessageBox.Show("Please type the name of the assembly and its root namespace", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				if (this.txtPath.TextLength == 0)
				{
					MessageBox.Show("Please select the output path.", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
                {
                    IEnumerator<RegexInfo> enumerator = CompileForm.regexList.GetEnumerator();
					try
					{
						
						while (enumerator.MoveNext())
						{
							RegexInfo current = enumerator.Current;
							if (Operators.CompareString(current.Name, "", false) != 0 || Operators.CompareString(current.Pattern, "", false) != 0)
							{
								if (Operators.CompareString(current.Name, "", false) == 0 | Operators.CompareString(current.Pattern, "", false) == 0)
								{
									MessageBox.Show("Please enter name and pattern for all regex expressions", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
									return;
								}
								list.Add(current);
							}
						}
					}
					finally
					{
						 
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					if (list.Count == 0)
					{
						MessageBox.Show("Please enter one or more regex expressions", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						List<RegexCompilationInfo> list2 = new List<RegexCompilationInfo>();
                        List<RegexInfo>.Enumerator enumerator2 = list.GetEnumerator();
						try
						{
							
							while (enumerator2.MoveNext())
							{
								RegexInfo current2 = enumerator2.Current;
								RegexCompilationInfo item = new RegexCompilationInfo(current2.Pattern, current2.Options, current2.Name, this.txtNamespace.Text, true);
								list2.Add(item);
							}
						}
						finally
						{
							 
							((IDisposable)enumerator2).Dispose();
						}
						RegexCompilationInfo[] regexinfos = list2.ToArray();
						AssemblyName assemblyName = new AssemblyName(this.txtAssemblyName.Text);
						assemblyName.CodeBase = Path.Combine(this.txtPath.Text, Path.ChangeExtension(this.txtAssemblyName.Text, ".dll"));
						try
						{
							Regex.CompileToAssembly(regexinfos, assemblyName);
							MessageBox.Show("The assembly has been created", "Compilation Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						catch (Exception expr_1F9)
						{
							ProjectData.SetProjectError(expr_1F9);
							Exception ex = expr_1F9;
							MessageBox.Show(ex.Message, "Compilation Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
		}
		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (this.dlgAssemblyPath.ShowDialog() == DialogResult.OK)
			{
				this.txtPath.Text = this.dlgAssemblyPath.SelectedPath;
			}
		}
	}
}
