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
	public class EscapeForm : Form
	{
		private IContainer components;
		[AccessedThroughProperty("Label1")]
		private Label Label1;
		[AccessedThroughProperty("txtText")]
		private TextBox _txtText;
		[AccessedThroughProperty("radEscape")]
		private RadioButton _radEscape;
		[AccessedThroughProperty("radUnescape")]
		private RadioButton _radUnescape;
		[AccessedThroughProperty("Label2")]
		private Label _Label2;
		[AccessedThroughProperty("txtResult")]
		private TextBox _txtResult;
		[AccessedThroughProperty("chkCopyToClipboard")]
		private CheckBox _chkCopyToClipboard;
		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;
		[AccessedThroughProperty("lblError")]
		private Label _lblError;
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;
		[AccessedThroughProperty("HelpProvider1")]
		private HelpProvider _HelpProvider1;
		public ProjectOptions Options;
		 
		internal virtual TextBox txtText
		{
			get
			{
				return this._txtText;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._txtText != null)
				{
					this._txtText.TextChanged -= new EventHandler(this.txtText_TextChanged);
				}
				this._txtText = value;
				if (this._txtText != null)
				{
					this._txtText.TextChanged += new EventHandler(this.txtText_TextChanged);
				}
			}
		}
		internal virtual RadioButton radEscape
		{
			get
			{
				return this._radEscape;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._radEscape != null)
				{
					this._radEscape.CheckedChanged -= new EventHandler(this.radUnescape_CheckedChanged);
				}
				this._radEscape = value;
				if (this._radEscape != null)
				{
					this._radEscape.CheckedChanged += new EventHandler(this.radUnescape_CheckedChanged);
				}
			}
		}
		internal virtual RadioButton radUnescape
		{
			get
			{
				return this._radUnescape;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._radUnescape != null)
				{
					this._radUnescape.CheckedChanged -= new EventHandler(this.radUnescape_CheckedChanged);
				}
				this._radUnescape = value;
				if (this._radUnescape != null)
				{
					this._radUnescape.CheckedChanged += new EventHandler(this.radUnescape_CheckedChanged);
				}
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
		internal virtual TextBox txtResult
		{
			get
			{
				return this._txtResult;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtResult = value;
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
		internal virtual Label lblError
		{
			get
			{
				return this._lblError;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblError = value;
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
		public EscapeForm()
		{
			base.Load += new EventHandler(this.EscapeForm_Load);
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
		//[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			this.Label1 = new Label();
			this.txtText = new TextBox();
			this.radEscape = new RadioButton();
			this.radUnescape = new RadioButton();
			this.Label2 = new Label();
			this.txtResult = new TextBox();
			this.chkCopyToClipboard = new CheckBox();
			this.btnOK = new Button();
			this.btnCancel = new Button();
			this.lblError = new Label();
			this.ToolTip1 = new ToolTip(this.components);
			this.HelpProvider1 = new HelpProvider();
			this.SuspendLayout();
			Control arg_AD_0 = this.Label1;
			Point location = new Point(12, 9);
			arg_AD_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_D4_0 = this.Label1;
			Size size = new Size(37, 23);
			arg_D4_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "&Text";
			Control arg_107_0 = this.txtText;
			location = new Point(55, 9);
			arg_107_0.Location = location;
			this.txtText.Multiline = true;
			this.txtText.Name = "txtText";
			this.txtText.ScrollBars = ScrollBars.Vertical;
			Control arg_149_0 = this.txtText;
			size = new Size(552, 97);
			arg_149_0.Size = size;
			this.txtText.TabIndex = 1;
			this.txtText.Text = "Enter a string that you want to escape or unescape.";
			this.radEscape.AutoSize = true;
			this.radEscape.Checked = true;
			Control arg_194_0 = this.radEscape;
			location = new Point(55, 112);
			arg_194_0.Location = location;
			this.radEscape.Name = "radEscape";
			Control arg_1BB_0 = this.radEscape;
			size = new Size(61, 17);
			arg_1BB_0.Size = size;
			this.radEscape.TabIndex = 2;
			this.radEscape.TabStop = true;
			this.radEscape.Text = "&Escape";
			this.ToolTip1.SetToolTip(this.radEscape, "Test the Escape command.");
			this.radEscape.UseVisualStyleBackColor = true;
			this.radUnescape.AutoSize = true;
			Control arg_228_0 = this.radUnescape;
			location = new Point(122, 112);
			arg_228_0.Location = location;
			this.radUnescape.Name = "radUnescape";
			Control arg_24F_0 = this.radUnescape;
			size = new Size(74, 17);
			arg_24F_0.Size = size;
			this.radUnescape.TabIndex = 3;
			this.radUnescape.Text = "&Unescape";
			this.ToolTip1.SetToolTip(this.radUnescape, "Test the Unescape command.");
			this.radUnescape.UseVisualStyleBackColor = true;
			Control arg_2A7_0 = this.Label2;
			location = new Point(12, 137);
			arg_2A7_0.Location = location;
			this.Label2.Name = "Label2";
			Control arg_2CE_0 = this.Label2;
			size = new Size(37, 23);
			arg_2CE_0.Size = size;
			this.Label2.TabIndex = 5;
			this.Label2.Text = "&Result";
			Control arg_304_0 = this.txtResult;
			location = new Point(55, 137);
			arg_304_0.Location = location;
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.ReadOnly = true;
			this.txtResult.ScrollBars = ScrollBars.Vertical;
			Control arg_352_0 = this.txtResult;
			size = new Size(552, 94);
			arg_352_0.Size = size;
			this.txtResult.TabIndex = 6;
			this.txtResult.Text = "The result of the Escape or Unescape method.";
			this.chkCopyToClipboard.AutoSize = true;
			this.chkCopyToClipboard.Checked = true;
			this.chkCopyToClipboard.CheckState = CheckState.Checked;
			Control arg_3AC_0 = this.chkCopyToClipboard;
			location = new Point(471, 114);
			arg_3AC_0.Location = location;
			this.chkCopyToClipboard.Name = "chkCopyToClipboard";
			Control arg_3D6_0 = this.chkCopyToClipboard;
			size = new Size(137, 17);
			arg_3D6_0.Size = size;
			this.chkCopyToClipboard.TabIndex = 4;
			this.chkCopyToClipboard.Text = "C&opy result to Clipboard";
			this.ToolTip1.SetToolTip(this.chkCopyToClipboard, "If selected, the result is copied to the Clipboard §when the user clicks on the OK button.");
			this.chkCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			Control arg_43D_0 = this.btnOK;
			location = new Point(451, 237);
			arg_43D_0.Location = location;
			this.btnOK.Name = "btnOK";
			Control arg_464_0 = this.btnOK;
			size = new Size(75, 23);
			arg_464_0.Size = size;
			this.btnOK.TabIndex = 8;
			this.btnOK.Text = "OK";
			this.ToolTip1.SetToolTip(this.btnOK, "Close the dialog box and optionally copy the result to the Clipboard.");
			this.btnOK.UseVisualStyleBackColor = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			Control arg_4CB_0 = this.btnCancel;
			location = new Point(532, 237);
			arg_4CB_0.Location = location;
			this.btnCancel.Name = "btnCancel";
			Control arg_4F2_0 = this.btnCancel;
			size = new Size(75, 23);
			arg_4F2_0.Size = size;
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.ToolTip1.SetToolTip(this.btnCancel, "Close the dialog box without copying the result to the Clipboard.");
			this.btnCancel.UseVisualStyleBackColor = true;
			this.lblError.AutoSize = true;
			this.lblError.ForeColor = Color.Red;
			Control arg_567_0 = this.lblError;
			location = new Point(52, 237);
			arg_567_0.Location = location;
			this.lblError.Name = "lblError";
			Control arg_58E_0 = this.lblError;
			size = new Size(39, 13);
			arg_58E_0.Size = size;
			this.lblError.TabIndex = 7;
			this.lblError.Text = "lblError";
			this.AcceptButton = this.btnOK;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			size = new Size(619, 270);
			this.ClientSize = size;
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.chkCopyToClipboard);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.radUnescape);
			this.Controls.Add(this.radEscape);
			this.Controls.Add(this.txtText);
			this.Controls.Add(this.Label1);
			this.Name = "EscapeForm";
			this.Text = "Escape Command";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private void EscapeForm_Load(object sender, EventArgs e)
		{
			Helpers.SetTooltipsAndHelpMessages(this, this.ToolTip1, this.HelpProvider1);
			this.txtText.Text = this.Options.RegexText;
			this.lblError.Text = "";
		}
		private void radUnescape_CheckedChanged(object sender, EventArgs e)
		{
			this.txtText.Text = "";
		}
		private void txtText_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (this.radEscape.Checked)
				{
					this.txtResult.Text = Regex.Escape(this.txtText.Text);
				}
				else
				{
					this.txtResult.Text = Regex.Unescape(this.txtText.Text);
				}
				this.lblError.Text = "";
			}
			catch (Exception expr_57)
			{
				ProjectData.SetProjectError(expr_57);
				Exception ex = expr_57;
				this.lblError.Text = ex.Message;
				ProjectData.ClearProjectError();
			}
		}
		private void btnOK_Click(object sender, EventArgs e)
		{
			if (this.chkCopyToClipboard.Checked && this.txtResult.TextLength > 0)
			{
				Clipboard.SetText(this.txtResult.Text);
			}
			this.DialogResult = DialogResult.OK;
		}
	}
}
