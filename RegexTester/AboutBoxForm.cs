using Microsoft.VisualBasic.CompilerServices;
using RegexTester.My;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace RegexTester
{
	[DesignerGenerated]
	public sealed class AboutBoxForm : Form
	{
		[AccessedThroughProperty("TableLayoutPanel")]
		private TableLayoutPanel _TableLayoutPanel;
		[AccessedThroughProperty("LogoPictureBox")]
		private PictureBox _LogoPictureBox;
		[AccessedThroughProperty("LabelProductName")]
		private Label _LabelProductName;
		[AccessedThroughProperty("LabelVersion")]
		private Label _LabelVersion;
		[AccessedThroughProperty("LabelCompanyName")]
		private Label _LabelCompanyName;
		[AccessedThroughProperty("TextBoxDescription")]
		private TextBox _TextBoxDescription;
		[AccessedThroughProperty("OKButton")]
		private Button _OKButton;
		[AccessedThroughProperty("LabelCopyright")]
		private Label _LabelCopyright;
		private IContainer components;
		internal  TableLayoutPanel TableLayoutPanel
		{
			get
			{
				return this._TableLayoutPanel;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TableLayoutPanel = value;
			}
		}
		internal  PictureBox LogoPictureBox
		{
			get
			{
				return this._LogoPictureBox;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LogoPictureBox = value;
			}
		}
		internal  Label LabelProductName
		{
			get
			{
				return this._LabelProductName;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelProductName = value;
			}
		}
		internal  Label LabelVersion
		{
			get
			{
				return this._LabelVersion;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelVersion = value;
			}
		}
		internal  Label LabelCompanyName
		{
			get
			{
				return this._LabelCompanyName;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCompanyName = value;
			}
		}
		internal  TextBox TextBoxDescription
		{
			get
			{
				return this._TextBoxDescription;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxDescription = value;
			}
		}
		internal  Button OKButton
		{
			get
			{
				return this._OKButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._OKButton != null)
				{
					this._OKButton.Click -= new EventHandler(this.OKButton_Click);
				}
				this._OKButton = value;
				if (this._OKButton != null)
				{
					this._OKButton.Click += new EventHandler(this.OKButton_Click);
				}
			}
		}
		internal  Label LabelCopyright
		{
			get
			{
				return this._LabelCopyright;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCopyright = value;
			}
		}
		public AboutBoxForm()
		{
			base.Load += new EventHandler(this.AboutBoxForm_Load);
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutBoxForm));
			this.TableLayoutPanel = new TableLayoutPanel();
			this.LogoPictureBox = new PictureBox();
			this.LabelProductName = new Label();
			this.LabelVersion = new Label();
			this.LabelCopyright = new Label();
			this.LabelCompanyName = new Label();
			this.TextBoxDescription = new TextBox();
			this.OKButton = new Button();
			this.TableLayoutPanel.SuspendLayout();
			((ISupportInitialize)this.LogoPictureBox).BeginInit();
			this.SuspendLayout();
			this.TableLayoutPanel.ColumnCount = 2;
			this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33f));
			this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67f));
			this.TableLayoutPanel.Controls.Add(this.LogoPictureBox, 0, 0);
			this.TableLayoutPanel.Controls.Add(this.LabelProductName, 1, 0);
			this.TableLayoutPanel.Controls.Add(this.LabelVersion, 1, 1);
			this.TableLayoutPanel.Controls.Add(this.LabelCopyright, 1, 2);
			this.TableLayoutPanel.Controls.Add(this.LabelCompanyName, 1, 3);
			this.TableLayoutPanel.Controls.Add(this.TextBoxDescription, 1, 4);
			this.TableLayoutPanel.Controls.Add(this.OKButton, 1, 5);
			this.TableLayoutPanel.Dock = DockStyle.Fill;
			Control arg_18E_0 = this.TableLayoutPanel;
			Point location = new Point(9, 9);
			arg_18E_0.Location = location;
			this.TableLayoutPanel.Name = "TableLayoutPanel";
			this.TableLayoutPanel.RowCount = 6;
			this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
			this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
			this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
			this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
			this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
			Control arg_26F_0 = this.TableLayoutPanel;
			Size size = new Size(396, 258);
			arg_26F_0.Size = size;
			this.TableLayoutPanel.TabIndex = 0;
			this.LogoPictureBox.Dock = DockStyle.Fill;
			this.LogoPictureBox.Image = (Image)componentResourceManager.GetObject("LogoPictureBox.Image");
			Control arg_2B7_0 = this.LogoPictureBox;
			location = new Point(3, 3);
			arg_2B7_0.Location = location;
			this.LogoPictureBox.Name = "LogoPictureBox";
			this.TableLayoutPanel.SetRowSpan(this.LogoPictureBox, 6);
			Control arg_2F3_0 = this.LogoPictureBox;
			size = new Size(124, 252);
			arg_2F3_0.Size = size;
			this.LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			this.LogoPictureBox.TabIndex = 0;
			this.LogoPictureBox.TabStop = false;
			this.LabelProductName.Dock = DockStyle.Fill;
			Control arg_33C_0 = this.LabelProductName;
			location = new Point(136, 0);
			arg_33C_0.Location = location;
			Control arg_353_0 = this.LabelProductName;
			Padding padding = new Padding(6, 0, 3, 0);
			arg_353_0.Margin = padding;
			Control arg_369_0 = this.LabelProductName;
			size = new Size(0, 17);
			arg_369_0.MaximumSize = size;
			this.LabelProductName.Name = "LabelProductName";
			Control arg_393_0 = this.LabelProductName;
			size = new Size(257, 17);
			arg_393_0.Size = size;
			this.LabelProductName.TabIndex = 0;
			this.LabelProductName.Text = "Product Name";
			this.LabelProductName.TextAlign = ContentAlignment.MiddleLeft;
			this.LabelVersion.Dock = DockStyle.Fill;
			Control arg_3E2_0 = this.LabelVersion;
			location = new Point(136, 25);
			arg_3E2_0.Location = location;
			Control arg_3F9_0 = this.LabelVersion;
			padding = new Padding(6, 0, 3, 0);
			arg_3F9_0.Margin = padding;
			Control arg_40F_0 = this.LabelVersion;
			size = new Size(0, 17);
			arg_40F_0.MaximumSize = size;
			this.LabelVersion.Name = "LabelVersion";
			Control arg_439_0 = this.LabelVersion;
			size = new Size(257, 17);
			arg_439_0.Size = size;
			this.LabelVersion.TabIndex = 0;
			this.LabelVersion.Text = "Version";
			this.LabelVersion.TextAlign = ContentAlignment.MiddleLeft;
			this.LabelCopyright.Dock = DockStyle.Fill;
			Control arg_488_0 = this.LabelCopyright;
			location = new Point(136, 50);
			arg_488_0.Location = location;
			Control arg_49F_0 = this.LabelCopyright;
			padding = new Padding(6, 0, 3, 0);
			arg_49F_0.Margin = padding;
			Control arg_4B5_0 = this.LabelCopyright;
			size = new Size(0, 17);
			arg_4B5_0.MaximumSize = size;
			this.LabelCopyright.Name = "LabelCopyright";
			Control arg_4DF_0 = this.LabelCopyright;
			size = new Size(257, 17);
			arg_4DF_0.Size = size;
			this.LabelCopyright.TabIndex = 0;
			this.LabelCopyright.Text = "Copyright";
			this.LabelCopyright.TextAlign = ContentAlignment.MiddleLeft;
			this.LabelCompanyName.Dock = DockStyle.Fill;
			Control arg_52E_0 = this.LabelCompanyName;
			location = new Point(136, 75);
			arg_52E_0.Location = location;
			Control arg_545_0 = this.LabelCompanyName;
			padding = new Padding(6, 0, 3, 0);
			arg_545_0.Margin = padding;
			Control arg_55B_0 = this.LabelCompanyName;
			size = new Size(0, 17);
			arg_55B_0.MaximumSize = size;
			this.LabelCompanyName.Name = "LabelCompanyName";
			Control arg_585_0 = this.LabelCompanyName;
			size = new Size(257, 17);
			arg_585_0.Size = size;
			this.LabelCompanyName.TabIndex = 0;
			this.LabelCompanyName.Text = "Company Name";
			this.LabelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
			this.TextBoxDescription.Dock = DockStyle.Fill;
			Control arg_5D4_0 = this.TextBoxDescription;
			location = new Point(136, 103);
			arg_5D4_0.Location = location;
			Control arg_5EB_0 = this.TextBoxDescription;
			padding = new Padding(6, 3, 3, 3);
			arg_5EB_0.Margin = padding;
			this.TextBoxDescription.Multiline = true;
			this.TextBoxDescription.Name = "TextBoxDescription";
			this.TextBoxDescription.ReadOnly = true;
			this.TextBoxDescription.ScrollBars = ScrollBars.Both;
			Control arg_639_0 = this.TextBoxDescription;
			size = new Size(257, 123);
			arg_639_0.Size = size;
			this.TextBoxDescription.TabIndex = 0;
			this.TextBoxDescription.TabStop = false;
			this.TextBoxDescription.Text = componentResourceManager.GetString("TextBoxDescription.Text");
			this.OKButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.OKButton.DialogResult = DialogResult.Cancel;
			Control arg_69D_0 = this.OKButton;
			location = new Point(318, 232);
			arg_69D_0.Location = location;
			this.OKButton.Name = "OKButton";
			Control arg_6C4_0 = this.OKButton;
			size = new Size(75, 23);
			arg_6C4_0.Size = size;
			this.OKButton.TabIndex = 0;
			this.OKButton.Text = "&OK";
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.CancelButton = this.OKButton;
			size = new Size(414, 276);
			this.ClientSize = size;
			this.Controls.Add(this.TableLayoutPanel);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutBoxForm";
			padding = new Padding(9);
			this.Padding = padding;
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "AboutBoxForm";
			this.TableLayoutPanel.ResumeLayout(false);
			this.TableLayoutPanel.PerformLayout();
			((ISupportInitialize)this.LogoPictureBox).EndInit();
			this.ResumeLayout(false);
		}
		private void AboutBoxForm_Load(object sender, EventArgs e)
		{
			string arg;
			if (Operators.CompareString(MyProject.Application.Info.Title, "", false) != 0)
			{
				arg = MyProject.Application.Info.Title;
			}
			else
			{
				arg = Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName);
			}
			this.Text = string.Format("About {0}", arg);
			this.LabelProductName.Text = MyProject.Application.Info.ProductName;
			this.LabelVersion.Text = string.Format("Version {0}", MyProject.Application.Info.Version.ToString());
			this.LabelCopyright.Text = MyProject.Application.Info.Copyright;
			this.LabelCompanyName.Text = MyProject.Application.Info.CompanyName;
			this.TextBoxDescription.Text = MyProject.Application.Info.Description;
		}
		private void OKButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
