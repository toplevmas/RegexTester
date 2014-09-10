using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RegexTester
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
          /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ctxPattern = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommandsRun = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCommandsFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommandsReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommandsSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCommandsEscape = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommandsGenerateCode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommandsShowGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommandsCompile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptionsIgnoreCase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptionsIgnoreWhitespace = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptionsMultiline = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptionsCompiled = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptionsExplicitCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptionsRightToLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptionsCultureInvariant = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptionsEcmaScript = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResults = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResultsTreeView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResultsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResultsAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResultsGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResultsCaptures = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResultsNoDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuResultsIncludeEmptyGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuResultsDontSort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResultsSortAlphabetically = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResultsShortest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResultsLargest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenDoc = new System.Windows.Forms.OpenFileDialog();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.staMatches = new System.Windows.Forms.ToolStripStatusLabel();
            this.staExecutionTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.staItemInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctxReplace = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tvwResults = new System.Windows.Forms.TreeView();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.rtbRegex = new System.Windows.Forms.RichTextBox();
            this.rtbReplace = new System.Windows.Forms.RichTextBox();
            this.lblMatches = new System.Windows.Forms.Label();
            this.dlgOpenRegex = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveRegex = new System.Windows.Forms.SaveFileDialog();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.HelpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabResultAndQuickRef = new System.Windows.Forms.TabControl();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.tabPageQuickRef = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvCharactorClass = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAssertion = new System.Windows.Forms.DataGridView();
            this.colTrainingImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrainingLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvGroupingConstruct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvQuantifiers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvBackreference = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dgvEscape = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgvAlternationConstruct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dgvAlternation = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txtViewMaxMatches = new System.Windows.Forms.ToolStripTextBox();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbSource = new QWhale.Editor.SyntaxEdit(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.tabResultAndQuickRef.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            this.tabPageQuickRef.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharactorClass)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssertion)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupingConstruct)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantifiers)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackreference)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscape)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlternationConstruct)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlternation)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxPattern
            // 
            this.ctxPattern.Name = "ctxPattern";
            this.ctxPattern.Size = new System.Drawing.Size(61, 4);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(3, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 15);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Regex";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuCommands,
            this.mnuOptions,
            this.mnuResults,
            this.mnuHelp});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip1.Size = new System.Drawing.Size(699, 25);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.ToolStripSeparator4,
            this.mnuFileProperties,
            this.ToolStripSeparator5,
            this.mnuFileLoad,
            this.ToolStripSeparator6,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(39, 21);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(152, 22);
            this.mnuFileNew.Text = "New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(152, 22);
            this.mnuFileOpen.Text = "Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(152, 22);
            this.mnuFileSave.Text = "Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(152, 22);
            this.mnuFileSaveAs.Text = "SaveAs";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuFileProperties
            // 
            this.mnuFileProperties.Name = "mnuFileProperties";
            this.mnuFileProperties.Size = new System.Drawing.Size(152, 22);
            this.mnuFileProperties.Text = "Properties";
            this.mnuFileProperties.Click += new System.EventHandler(this.mnuFileProperties_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuFileLoad
            // 
            this.mnuFileLoad.Name = "mnuFileLoad";
            this.mnuFileLoad.Size = new System.Drawing.Size(152, 22);
            this.mnuFileLoad.Text = "Load";
            this.mnuFileLoad.Click += new System.EventHandler(this.mnuFileLoad_Click);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(152, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditWordWrap});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(42, 21);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuEditWordWrap
            // 
            this.mnuEditWordWrap.Name = "mnuEditWordWrap";
            this.mnuEditWordWrap.Size = new System.Drawing.Size(152, 22);
            this.mnuEditWordWrap.Text = "WordWrap";
            this.mnuEditWordWrap.Click += new System.EventHandler(this.mnuEditWordWrap_Click);
            // 
            // mnuCommands
            // 
            this.mnuCommands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCommandsRun,
            this.ToolStripSeparator1,
            this.mnuCommandsFind,
            this.mnuCommandsReplace,
            this.mnuCommandsSplit,
            this.ToolStripSeparator3,
            this.mnuCommandsEscape,
            this.mnuCommandsGenerateCode,
            this.mnuCommandsShowGroups,
            this.mnuCommandsCompile});
            this.mnuCommands.Name = "mnuCommands";
            this.mnuCommands.Size = new System.Drawing.Size(86, 21);
            this.mnuCommands.Text = "&Commands";
            // 
            // mnuCommandsRun
            // 
            this.mnuCommandsRun.Name = "mnuCommandsRun";
            this.mnuCommandsRun.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuCommandsRun.Size = new System.Drawing.Size(167, 22);
            this.mnuCommandsRun.Text = "Run";
            this.mnuCommandsRun.Click += new System.EventHandler(this.mnuCommandsRun_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // mnuCommandsFind
            // 
            this.mnuCommandsFind.Name = "mnuCommandsFind";
            this.mnuCommandsFind.Size = new System.Drawing.Size(167, 22);
            this.mnuCommandsFind.Text = "Find";
            this.mnuCommandsFind.Click += new System.EventHandler(this.mnuCommandsFind_Click);
            // 
            // mnuCommandsReplace
            // 
            this.mnuCommandsReplace.Name = "mnuCommandsReplace";
            this.mnuCommandsReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuCommandsReplace.Size = new System.Drawing.Size(167, 22);
            this.mnuCommandsReplace.Text = "Replace";
            this.mnuCommandsReplace.Click += new System.EventHandler(this.mnuCommandsReplace_Click);
            // 
            // mnuCommandsSplit
            // 
            this.mnuCommandsSplit.Name = "mnuCommandsSplit";
            this.mnuCommandsSplit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnuCommandsSplit.Size = new System.Drawing.Size(167, 22);
            this.mnuCommandsSplit.Text = "Split";
            this.mnuCommandsSplit.Click += new System.EventHandler(this.mnuCommandsSplit_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(164, 6);
            // 
            // mnuCommandsEscape
            // 
            this.mnuCommandsEscape.Name = "mnuCommandsEscape";
            this.mnuCommandsEscape.Size = new System.Drawing.Size(167, 22);
            this.mnuCommandsEscape.Text = "Escape";
            this.mnuCommandsEscape.Click += new System.EventHandler(this.mnuCommandsEscape_Click);
            // 
            // mnuCommandsGenerateCode
            // 
            this.mnuCommandsGenerateCode.Name = "mnuCommandsGenerateCode";
            this.mnuCommandsGenerateCode.Size = new System.Drawing.Size(167, 22);
            this.mnuCommandsGenerateCode.Text = "GenerateCode";
            this.mnuCommandsGenerateCode.Click += new System.EventHandler(this.mnuCommandsGenerateCode_Click);
            // 
            // mnuCommandsShowGroups
            // 
            this.mnuCommandsShowGroups.Name = "mnuCommandsShowGroups";
            this.mnuCommandsShowGroups.Size = new System.Drawing.Size(167, 22);
            this.mnuCommandsShowGroups.Text = "ShowGroups";
            this.mnuCommandsShowGroups.Click += new System.EventHandler(this.mnuCommandsShowGroups_Click);
            // 
            // mnuCommandsCompile
            // 
            this.mnuCommandsCompile.Name = "mnuCommandsCompile";
            this.mnuCommandsCompile.Size = new System.Drawing.Size(167, 22);
            this.mnuCommandsCompile.Text = "Compile";
            this.mnuCommandsCompile.Click += new System.EventHandler(this.mnuCommandsCompile_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptionsIgnoreCase,
            this.mnuOptionsIgnoreWhitespace,
            this.mnuOptionsMultiline,
            this.mnuOptionsCompiled,
            this.mnuOptionsExplicitCapture,
            this.mnuOptionsRightToLeft,
            this.mnuOptionsCultureInvariant,
            this.mnuOptionsEcmaScript});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(66, 21);
            this.mnuOptions.Text = "&Options";
            // 
            // mnuOptionsIgnoreCase
            // 
            this.mnuOptionsIgnoreCase.Name = "mnuOptionsIgnoreCase";
            this.mnuOptionsIgnoreCase.Size = new System.Drawing.Size(182, 22);
            this.mnuOptionsIgnoreCase.Text = "IgnoreCase";
            this.mnuOptionsIgnoreCase.Click += new System.EventHandler(this.mnuOptionsIgnoreCase_Click);
            // 
            // mnuOptionsIgnoreWhitespace
            // 
            this.mnuOptionsIgnoreWhitespace.Name = "mnuOptionsIgnoreWhitespace";
            this.mnuOptionsIgnoreWhitespace.Size = new System.Drawing.Size(182, 22);
            this.mnuOptionsIgnoreWhitespace.Text = "IgnoreWhitespace";
            this.mnuOptionsIgnoreWhitespace.Click += new System.EventHandler(this.mnuOptionsIgnoreWhitespace_Click);
            // 
            // mnuOptionsMultiline
            // 
            this.mnuOptionsMultiline.Name = "mnuOptionsMultiline";
            this.mnuOptionsMultiline.Size = new System.Drawing.Size(182, 22);
            this.mnuOptionsMultiline.Text = "Multiline";
            this.mnuOptionsMultiline.Click += new System.EventHandler(this.mnuOptionsMultiline_Click);
            // 
            // mnuOptionsCompiled
            // 
            this.mnuOptionsCompiled.Name = "mnuOptionsCompiled";
            this.mnuOptionsCompiled.Size = new System.Drawing.Size(182, 22);
            this.mnuOptionsCompiled.Text = "Compiled";
            this.mnuOptionsCompiled.Click += new System.EventHandler(this.mnuOptionsCompiled_Click);
            // 
            // mnuOptionsExplicitCapture
            // 
            this.mnuOptionsExplicitCapture.Name = "mnuOptionsExplicitCapture";
            this.mnuOptionsExplicitCapture.Size = new System.Drawing.Size(182, 22);
            this.mnuOptionsExplicitCapture.Text = "ExplicitCapture";
            this.mnuOptionsExplicitCapture.Click += new System.EventHandler(this.mnuOptionsExplicitCapture_Click);
            // 
            // mnuOptionsRightToLeft
            // 
            this.mnuOptionsRightToLeft.Name = "mnuOptionsRightToLeft";
            this.mnuOptionsRightToLeft.Size = new System.Drawing.Size(182, 22);
            this.mnuOptionsRightToLeft.Text = "RightToLeft";
            this.mnuOptionsRightToLeft.Click += new System.EventHandler(this.mnuOptionsRightToLeft_Click);
            // 
            // mnuOptionsCultureInvariant
            // 
            this.mnuOptionsCultureInvariant.Name = "mnuOptionsCultureInvariant";
            this.mnuOptionsCultureInvariant.Size = new System.Drawing.Size(182, 22);
            this.mnuOptionsCultureInvariant.Text = "CultureInvariant";
            this.mnuOptionsCultureInvariant.Click += new System.EventHandler(this.mnuOptionsCultureInvariant_Click);
            // 
            // mnuOptionsEcmaScript
            // 
            this.mnuOptionsEcmaScript.Name = "mnuOptionsEcmaScript";
            this.mnuOptionsEcmaScript.Size = new System.Drawing.Size(182, 22);
            this.mnuOptionsEcmaScript.Text = "EcmaScript";
            this.mnuOptionsEcmaScript.Click += new System.EventHandler(this.mnuOptionsEcmaScript_Click);
            // 
            // mnuResults
            // 
            this.mnuResults.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuResultsTreeView,
            this.mnuResultsReport,
            this.mnuResultsAuto,
            this.ToolStripTextBox1,
            this.mnuResultsGroups,
            this.mnuResultsCaptures,
            this.mnuResultsNoDetails,
            this.ToolStripSeparator2,
            this.mnuResultsIncludeEmptyGroups,
            this.ToolStripMenuItem1,
            this.ToolStripSeparator7,
            this.mnuResultsDontSort,
            this.mnuResultsSortAlphabetically,
            this.mnuResultsShortest,
            this.mnuResultsLargest});
            this.mnuResults.Name = "mnuResults";
            this.mnuResults.Size = new System.Drawing.Size(61, 21);
            this.mnuResults.Text = "&Results";
            // 
            // mnuResultsTreeView
            // 
            this.mnuResultsTreeView.Name = "mnuResultsTreeView";
            this.mnuResultsTreeView.Size = new System.Drawing.Size(212, 22);
            this.mnuResultsTreeView.Text = "TreeView";
            this.mnuResultsTreeView.Click += new System.EventHandler(this.mnuResultsTreeView_Click);
            // 
            // mnuResultsReport
            // 
            this.mnuResultsReport.Name = "mnuResultsReport";
            this.mnuResultsReport.Size = new System.Drawing.Size(212, 22);
            this.mnuResultsReport.Text = "Report";
            this.mnuResultsReport.Click += new System.EventHandler(this.mnuResultsReport_Click);
            // 
            // mnuResultsAuto
            // 
            this.mnuResultsAuto.Name = "mnuResultsAuto";
            this.mnuResultsAuto.Size = new System.Drawing.Size(212, 22);
            this.mnuResultsAuto.Text = "Auto";
            this.mnuResultsAuto.Click += new System.EventHandler(this.mnuResultsAuto_Click);
            // 
            // ToolStripTextBox1
            // 
            this.ToolStripTextBox1.Name = "ToolStripTextBox1";
            this.ToolStripTextBox1.Size = new System.Drawing.Size(212, 22);
            this.ToolStripTextBox1.Text = "&Max number  of results";
            // 
            // mnuResultsGroups
            // 
            this.mnuResultsGroups.Name = "mnuResultsGroups";
            this.mnuResultsGroups.Size = new System.Drawing.Size(212, 22);
            this.mnuResultsGroups.Text = "Groups";
            this.mnuResultsGroups.Click += new System.EventHandler(this.mnuResultsGroups_Click);
            // 
            // mnuResultsCaptures
            // 
            this.mnuResultsCaptures.Name = "mnuResultsCaptures";
            this.mnuResultsCaptures.Size = new System.Drawing.Size(212, 22);
            this.mnuResultsCaptures.Text = "Captures";
            this.mnuResultsCaptures.Click += new System.EventHandler(this.mnuResultsCaptures_Click);
            // 
            // mnuResultsNoDetails
            // 
            this.mnuResultsNoDetails.Name = "mnuResultsNoDetails";
            this.mnuResultsNoDetails.Size = new System.Drawing.Size(212, 22);
            this.mnuResultsNoDetails.Text = "No Details";
            this.mnuResultsNoDetails.Click += new System.EventHandler(this.mnuResultsNoDetails_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // mnuResultsIncludeEmptyGroups
            // 
            this.mnuResultsIncludeEmptyGroups.Name = "mnuResultsIncludeEmptyGroups";
            this.mnuResultsIncludeEmptyGroups.Size = new System.Drawing.Size(212, 22);
            this.mnuResultsIncludeEmptyGroups.Text = "IncludeEmptyGroups";
            this.mnuResultsIncludeEmptyGroups.Click += new System.EventHandler(this.mnuResultsIncludeEmptyGroups_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(209, 6);
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(209, 6);
            // 
            // mnuResultsDontSort
            // 
            this.mnuResultsDontSort.Name = "mnuResultsDontSort";
            this.mnuResultsDontSort.Size = new System.Drawing.Size(212, 22);
            this.mnuResultsDontSort.Text = " Dont Sort";
            this.mnuResultsDontSort.Click += new System.EventHandler(this.mnuResultsDontSort_Click);
            // 
            // mnuResultsSortAlphabetically
            // 
            this.mnuResultsSortAlphabetically.Name = "mnuResultsSortAlphabetically";
            this.mnuResultsSortAlphabetically.Size = new System.Drawing.Size(212, 22);
            this.mnuResultsSortAlphabetically.Text = "Sort Alphabetically";
            this.mnuResultsSortAlphabetically.Click += new System.EventHandler(this.mnuResultsSortAlphabetically_Click);
            // 
            // mnuResultsShortest
            // 
            this.mnuResultsShortest.Name = "mnuResultsShortest";
            this.mnuResultsShortest.Size = new System.Drawing.Size(212, 22);
            this.mnuResultsShortest.Text = "Shortest";
            this.mnuResultsShortest.Click += new System.EventHandler(this.mnuResultsShortest_Click);
            // 
            // mnuResultsLargest
            // 
            this.mnuResultsLargest.Name = "mnuResultsLargest";
            this.mnuResultsLargest.Size = new System.Drawing.Size(212, 22);
            this.mnuResultsLargest.Text = "Largest";
            this.mnuResultsLargest.Click += new System.EventHandler(this.mnuResultsLargest_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(47, 21);
            this.mnuHelp.Text = "&Help";
            // 
            // dlgOpenDoc
            // 
            this.dlgOpenDoc.Filter = "Text files (*.txt;*.doc)|*.txt;*.doc|All files|*.*";
            this.dlgOpenDoc.Title = "Open a text document";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(3, 150);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 15);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Source";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplace.Location = new System.Drawing.Point(3, 100);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(53, 15);
            this.lblReplace.TabIndex = 3;
            this.lblReplace.Text = "Replace";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staMatches,
            this.staExecutionTime,
            this.staItemInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 559);
            this.StatusStrip1.MinimumSize = new System.Drawing.Size(753, 22);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(753, 22);
            this.StatusStrip1.TabIndex = 10;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // staMatches
            // 
            this.staMatches.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.staMatches.Name = "staMatches";
            this.staMatches.Size = new System.Drawing.Size(96, 17);
            this.staMatches.Text = "Found matches";
            // 
            // staExecutionTime
            // 
            this.staExecutionTime.Name = "staExecutionTime";
            this.staExecutionTime.Size = new System.Drawing.Size(92, 17);
            this.staExecutionTime.Text = "Execution time";
            // 
            // staItemInfo
            // 
            this.staItemInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.staItemInfo.Name = "staItemInfo";
            this.staItemInfo.Size = new System.Drawing.Size(60, 17);
            this.staItemInfo.Text = "Item info";
            // 
            // ctxReplace
            // 
            this.ctxReplace.Name = "ctxPattern";
            this.ctxReplace.Size = new System.Drawing.Size(61, 4);
            // 
            // tvwResults
            // 
            this.tvwResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwResults.Location = new System.Drawing.Point(3, 3);
            this.tvwResults.Name = "tvwResults";
            this.tvwResults.ShowRootLines = false;
            this.tvwResults.Size = new System.Drawing.Size(611, 154);
            this.tvwResults.TabIndex = 8;
            this.ToolTip1.SetToolTip(this.tvwResults, "All the matches found. §Double-click on an item to see groups and captures.");
            // 
            // rtbResults
            // 
            this.rtbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbResults.DetectUrls = false;
            this.rtbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResults.HideSelection = false;
            this.rtbResults.Location = new System.Drawing.Point(15, 42);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbResults.Size = new System.Drawing.Size(0, 70);
            this.rtbResults.TabIndex = 9;
            this.rtbResults.Text = "";
            this.ToolTip1.SetToolTip(this.rtbResults, "The replaced text, or the split elements, or the matches in report format.");
            // 
            // rtbRegex
            // 
            this.rtbRegex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbRegex.ContextMenuStrip = this.ctxPattern;
            this.rtbRegex.DetectUrls = false;
            this.rtbRegex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbRegex.HideSelection = false;
            this.rtbRegex.Location = new System.Drawing.Point(71, 3);
            this.rtbRegex.Name = "rtbRegex";
            this.rtbRegex.Size = new System.Drawing.Size(625, 94);
            this.rtbRegex.TabIndex = 2;
            this.rtbRegex.Text = "";
            this.ToolTip1.SetToolTip(this.rtbRegex, "The regular expression pattern. §Right-click to display list of common patterns.");
            // 
            // rtbReplace
            // 
            this.rtbReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbReplace.ContextMenuStrip = this.ctxReplace;
            this.rtbReplace.DetectUrls = false;
            this.rtbReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbReplace.Location = new System.Drawing.Point(71, 103);
            this.rtbReplace.Name = "rtbReplace";
            this.rtbReplace.Size = new System.Drawing.Size(625, 44);
            this.rtbReplace.TabIndex = 4;
            this.rtbReplace.Text = "";
            this.ToolTip1.SetToolTip(this.rtbReplace, "The replace pattern. §Right-click to display list of common patterns.");
            // 
            // lblMatches
            // 
            this.lblMatches.AutoSize = true;
            this.lblMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatches.Location = new System.Drawing.Point(3, 342);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(54, 15);
            this.lblMatches.TabIndex = 7;
            this.lblMatches.Text = "Matches";
            // 
            // dlgOpenRegex
            // 
            this.dlgOpenRegex.DefaultExt = "regex";
            this.dlgOpenRegex.Filter = "Regex files (*.regex)|*.regex|All files|*.*";
            this.dlgOpenRegex.Title = "Open a regex file";
            // 
            // dlgSaveRegex
            // 
            this.dlgSaveRegex.DefaultExt = "regex";
            this.dlgSaveRegex.Filter = "Regex files (*.regex)|*.regex|All files|*.*";
            this.dlgSaveRegex.Title = "Save a regex file";
            // 
            // tabResultAndQuickRef
            // 
            this.tabResultAndQuickRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabResultAndQuickRef.Controls.Add(this.tabPageResult);
            this.tabResultAndQuickRef.Controls.Add(this.tabPageQuickRef);
            this.tabResultAndQuickRef.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabResultAndQuickRef.Location = new System.Drawing.Point(71, 345);
            this.tabResultAndQuickRef.Name = "tabResultAndQuickRef";
            this.tabResultAndQuickRef.SelectedIndex = 0;
            this.tabResultAndQuickRef.Size = new System.Drawing.Size(625, 186);
            this.tabResultAndQuickRef.TabIndex = 11;
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.tvwResults);
            this.tabPageResult.Controls.Add(this.rtbResults);
            this.tabPageResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(617, 160);
            this.tabPageResult.TabIndex = 1;
            this.tabPageResult.Text = "匹配结果";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // tabPageQuickRef
            // 
            this.tabPageQuickRef.Controls.Add(this.tabControl1);
            this.tabPageQuickRef.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuickRef.Name = "tabPageQuickRef";
            this.tabPageQuickRef.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuickRef.Size = new System.Drawing.Size(617, 160);
            this.tabPageQuickRef.TabIndex = 0;
            this.tabPageQuickRef.Text = "快速参考";
            this.tabPageQuickRef.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 154);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvCharactorClass);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(603, 128);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "字符类";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvCharactorClass
            // 
            this.dgvCharactorClass.AllowUserToAddRows = false;
            this.dgvCharactorClass.AllowUserToDeleteRows = false;
            this.dgvCharactorClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCharactorClass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCharactorClass.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCharactorClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCharactorClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCharactorClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCharactorClass.ColumnHeadersHeight = 25;
            this.dgvCharactorClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvCharactorClass.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCharactorClass.Location = new System.Drawing.Point(6, 30);
            this.dgvCharactorClass.Name = "dgvCharactorClass";
            this.dgvCharactorClass.RowHeadersVisible = false;
            this.dgvCharactorClass.RowHeadersWidth = 25;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCharactorClass.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCharactorClass.RowTemplate.Height = 23;
            this.dgvCharactorClass.Size = new System.Drawing.Size(594, 88);
            this.dgvCharactorClass.TabIndex = 61;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "字符类";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 60F;
            this.dataGridViewTextBoxColumn2.HeaderText = "描述";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "模式";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 30F;
            this.dataGridViewTextBoxColumn4.HeaderText = "匹配";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "字符类与一组字符中的任何一个字符匹配。 字符类包括下表中列出的语言元素";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dgvAssertion);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(603, 128);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "定位点";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(689, 12);
            this.label4.TabIndex = 61;
            this.label4.Text = "定位点或原子零宽度断言会使匹配成功或失败，具体取决于字符串中的当前位置，但它们不会使引擎在字符串中前进或使用字符。";
            // 
            // dgvAssertion
            // 
            this.dgvAssertion.AllowUserToAddRows = false;
            this.dgvAssertion.AllowUserToDeleteRows = false;
            this.dgvAssertion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAssertion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAssertion.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAssertion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAssertion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssertion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAssertion.ColumnHeadersHeight = 25;
            this.dgvAssertion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrainingImage,
            this.colTrainingLabel,
            this.Column1,
            this.Column2});
            this.dgvAssertion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAssertion.Location = new System.Drawing.Point(6, 30);
            this.dgvAssertion.Name = "dgvAssertion";
            this.dgvAssertion.RowHeadersVisible = false;
            this.dgvAssertion.RowHeadersWidth = 25;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssertion.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAssertion.RowTemplate.Height = 23;
            this.dgvAssertion.Size = new System.Drawing.Size(594, 82);
            this.dgvAssertion.TabIndex = 60;
            // 
            // colTrainingImage
            // 
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            this.colTrainingImage.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTrainingImage.HeaderText = "断言";
            this.colTrainingImage.Name = "colTrainingImage";
            this.colTrainingImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTrainingImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTrainingLabel
            // 
            this.colTrainingLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrainingLabel.FillWeight = 60F;
            this.colTrainingLabel.HeaderText = "描述";
            this.colTrainingLabel.Name = "colTrainingLabel";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "模式";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 30F;
            this.Column2.HeaderText = "匹配";
            this.Column2.Name = "Column2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.dgvGroupingConstruct);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(603, 128);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "分组构造";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(425, 12);
            this.label8.TabIndex = 63;
            this.label8.Text = "分组构造描述了正则表达式的子表达式，通常用于捕获输入字符串的子字符串。";
            // 
            // dgvGroupingConstruct
            // 
            this.dgvGroupingConstruct.AllowUserToAddRows = false;
            this.dgvGroupingConstruct.AllowUserToDeleteRows = false;
            this.dgvGroupingConstruct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroupingConstruct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGroupingConstruct.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGroupingConstruct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGroupingConstruct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupingConstruct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvGroupingConstruct.ColumnHeadersHeight = 25;
            this.dgvGroupingConstruct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.dgvGroupingConstruct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGroupingConstruct.Location = new System.Drawing.Point(6, 30);
            this.dgvGroupingConstruct.Name = "dgvGroupingConstruct";
            this.dgvGroupingConstruct.RowHeadersVisible = false;
            this.dgvGroupingConstruct.RowHeadersWidth = 25;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupingConstruct.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvGroupingConstruct.RowTemplate.Height = 23;
            this.dgvGroupingConstruct.Size = new System.Drawing.Size(594, 82);
            this.dgvGroupingConstruct.TabIndex = 62;
            // 
            // dataGridViewTextBoxColumn25
            // 
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn25.HeaderText = "分组构造";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn26.FillWeight = 60F;
            this.dataGridViewTextBoxColumn26.HeaderText = "描述";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.HeaderText = "模式";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn28.FillWeight = 30F;
            this.dataGridViewTextBoxColumn28.HeaderText = "匹配";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.dgvQuantifiers);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(603, 128);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "限定符";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(581, 12);
            this.label5.TabIndex = 62;
            this.label5.Text = "限定符指定在输入字符串中必须存在上一个元素（可以是字符、组或字符类）的多少个实例才能出现匹配项。";
            // 
            // dgvQuantifiers
            // 
            this.dgvQuantifiers.AllowUserToAddRows = false;
            this.dgvQuantifiers.AllowUserToDeleteRows = false;
            this.dgvQuantifiers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuantifiers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvQuantifiers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvQuantifiers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvQuantifiers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuantifiers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvQuantifiers.ColumnHeadersHeight = 25;
            this.dgvQuantifiers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvQuantifiers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuantifiers.Location = new System.Drawing.Point(6, 30);
            this.dgvQuantifiers.Name = "dgvQuantifiers";
            this.dgvQuantifiers.RowHeadersVisible = false;
            this.dgvQuantifiers.RowHeadersWidth = 25;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuantifiers.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvQuantifiers.RowTemplate.Height = 23;
            this.dgvQuantifiers.Size = new System.Drawing.Size(594, 69);
            this.dgvQuantifiers.TabIndex = 61;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn5.HeaderText = "限定符";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.FillWeight = 60F;
            this.dataGridViewTextBoxColumn6.HeaderText = "描述";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "模式";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.FillWeight = 30F;
            this.dataGridViewTextBoxColumn8.HeaderText = "匹配";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.dgvBackreference);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(603, 128);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "反向引用构造";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 12);
            this.label6.TabIndex = 64;
            this.label6.Text = "反向引用允许在同一正则表达式中随后标识以前匹配的子表达式。";
            // 
            // dgvBackreference
            // 
            this.dgvBackreference.AllowUserToAddRows = false;
            this.dgvBackreference.AllowUserToDeleteRows = false;
            this.dgvBackreference.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBackreference.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBackreference.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBackreference.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBackreference.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBackreference.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvBackreference.ColumnHeadersHeight = 25;
            this.dgvBackreference.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvBackreference.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBackreference.Location = new System.Drawing.Point(6, 30);
            this.dgvBackreference.Name = "dgvBackreference";
            this.dgvBackreference.RowHeadersVisible = false;
            this.dgvBackreference.RowHeadersWidth = 25;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBackreference.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvBackreference.RowTemplate.Height = 23;
            this.dgvBackreference.Size = new System.Drawing.Size(594, 92);
            this.dgvBackreference.TabIndex = 63;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn9.HeaderText = "反向构造";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.FillWeight = 60F;
            this.dataGridViewTextBoxColumn10.HeaderText = "描述";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "模式";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.FillWeight = 30F;
            this.dataGridViewTextBoxColumn12.HeaderText = "匹配";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dgvEscape);
            this.tabPage7.Controls.Add(this.label7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(603, 128);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "字符转义";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dgvEscape
            // 
            this.dgvEscape.AllowUserToAddRows = false;
            this.dgvEscape.AllowUserToDeleteRows = false;
            this.dgvEscape.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEscape.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEscape.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEscape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEscape.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEscape.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvEscape.ColumnHeadersHeight = 25;
            this.dgvEscape.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.dgvEscape.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEscape.Location = new System.Drawing.Point(6, 30);
            this.dgvEscape.Name = "dgvEscape";
            this.dgvEscape.RowHeadersVisible = false;
            this.dgvEscape.RowHeadersWidth = 25;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEscape.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvEscape.RowTemplate.Height = 23;
            this.dgvEscape.Size = new System.Drawing.Size(594, 69);
            this.dgvEscape.TabIndex = 65;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn21.HeaderText = "限定符";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn22.FillWeight = 60F;
            this.dataGridViewTextBoxColumn22.HeaderText = "描述";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.HeaderText = "模式";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn24.FillWeight = 30F;
            this.dataGridViewTextBoxColumn24.HeaderText = "匹配";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(551, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "正则表达式中的反斜杠字符 (\\) 指示其后跟的字符是特殊字符（如下表所示），或应按原义解释该字符";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dgvAlternationConstruct);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(603, 128);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "替换构造";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvAlternationConstruct
            // 
            this.dgvAlternationConstruct.AllowUserToAddRows = false;
            this.dgvAlternationConstruct.AllowUserToDeleteRows = false;
            this.dgvAlternationConstruct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlternationConstruct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlternationConstruct.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAlternationConstruct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAlternationConstruct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlternationConstruct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvAlternationConstruct.ColumnHeadersHeight = 25;
            this.dgvAlternationConstruct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dgvAlternationConstruct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlternationConstruct.Location = new System.Drawing.Point(6, 30);
            this.dgvAlternationConstruct.Name = "dgvAlternationConstruct";
            this.dgvAlternationConstruct.RowHeadersVisible = false;
            this.dgvAlternationConstruct.RowHeadersWidth = 25;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlternationConstruct.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvAlternationConstruct.RowTemplate.Height = 23;
            this.dgvAlternationConstruct.Size = new System.Drawing.Size(594, 69);
            this.dgvAlternationConstruct.TabIndex = 64;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn13.HeaderText = "替换构造";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.FillWeight = 60F;
            this.dataGridViewTextBoxColumn14.HeaderText = "描述";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "模式";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.FillWeight = 30F;
            this.dataGridViewTextBoxColumn16.HeaderText = "匹配";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(299, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "替换构造用于修改正则表达式以启用 either/or 匹配。";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dgvAlternation);
            this.tabPage8.Controls.Add(this.label10);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(603, 128);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "替换";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dgvAlternation
            // 
            this.dgvAlternation.AllowUserToAddRows = false;
            this.dgvAlternation.AllowUserToDeleteRows = false;
            this.dgvAlternation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlternation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlternation.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAlternation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAlternation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlternation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvAlternation.ColumnHeadersHeight = 25;
            this.dgvAlternation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.Column3,
            this.Column4});
            this.dgvAlternation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlternation.Location = new System.Drawing.Point(6, 30);
            this.dgvAlternation.Name = "dgvAlternation";
            this.dgvAlternation.RowHeadersVisible = false;
            this.dgvAlternation.RowHeadersWidth = 25;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlternation.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvAlternation.RowTemplate.Height = 23;
            this.dgvAlternation.Size = new System.Drawing.Size(594, 69);
            this.dgvAlternation.TabIndex = 65;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewCellStyle23.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn17.HeaderText = "字符";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn18.FillWeight = 60F;
            this.dataGridViewTextBoxColumn18.HeaderText = "描述";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "模式";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn20.FillWeight = 30F;
            this.dataGridViewTextBoxColumn20.HeaderText = "匹配";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "输入字符串";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "结果字符串";
            this.Column4.Name = "Column4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "替换是替换模式中支持的正则表达式语言元素。";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.label12);
            this.tabPage9.Controls.Add(this.label11);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(603, 128);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "About";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "点击每行首列可粘贴到文本框，\r\n选择每个单元格可以ctrl+c、ctrl+v";
            // 
            // txtViewMaxMatches
            // 
            this.txtViewMaxMatches.Name = "txtViewMaxMatches";
            this.txtViewMaxMatches.Size = new System.Drawing.Size(152, 22);
            this.txtViewMaxMatches.Text = "MaxMatches";
            this.txtViewMaxMatches.Click += new System.EventHandler(this.txtViewMaxMatches_Click);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(152, 22);
            this.mnuHelpAbout.Text = "About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // rtbSource
            // 
            this.rtbSource.BackColor = System.Drawing.SystemColors.Window;
            this.rtbSource.BorderStyle = QWhale.Common.EditBorderStyle.FixedSingle;
            this.rtbSource.Braces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rtbSource.Braces.BracesOptions = ((QWhale.Editor.TextSource.BracesOptions)((QWhale.Editor.TextSource.BracesOptions.Highlight | QWhale.Editor.TextSource.BracesOptions.TempHighlight)));
            this.rtbSource.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSource.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSource.Gutter.BrushColor = System.Drawing.SystemColors.Window;
            this.rtbSource.Gutter.LineNumbersBackColor = System.Drawing.SystemColors.GrayText;
            this.rtbSource.Gutter.Options = QWhale.Editor.GutterOptions.None;
            this.rtbSource.HyperText.HighlightHyperText = true;
            this.rtbSource.Location = new System.Drawing.Point(71, 153);
            this.rtbSource.Name = "rtbSource";
            this.rtbSource.NavigateOptions = QWhale.Editor.TextSource.NavigateOptions.None;
            this.rtbSource.Outlining.OutlineOptions = QWhale.Editor.OutlineOptions.None;
            this.rtbSource.Printing.AllowedOptions = QWhale.Editor.PrintOptions.None;
            this.rtbSource.Printing.Options = QWhale.Editor.PrintOptions.None;
            this.rtbSource.Scrolling.Options = ((QWhale.Editor.ScrollingOptions)((((QWhale.Editor.ScrollingOptions.SmoothScroll | QWhale.Editor.ScrollingOptions.UseScrollDelta)
                        | QWhale.Editor.ScrollingOptions.AllowSplitHorz)
                        | QWhale.Editor.ScrollingOptions.AllowSplitVert)));
            this.rtbSource.Selection.Options = QWhale.Editor.SelectionOptions.None;
            this.rtbSource.Size = new System.Drawing.Size(625, 186);
            this.rtbSource.TabIndex = 12;
            this.rtbSource.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.759547F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.24046F));
            this.tableLayoutPanel1.Controls.Add(this.rtbRegex, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbSource, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabResultAndQuickRef, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.rtbReplace, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblReplace, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMatches, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 534);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(407, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "http://msdn.microsoft.com/zh-cn/library/az24scfc%28v=vs.110%29.aspx";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 581);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.StatusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Code Architects Regex Tester";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.tabResultAndQuickRef.ResumeLayout(false);
            this.tabPageResult.ResumeLayout(false);
            this.tabPageQuickRef.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharactorClass)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssertion)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupingConstruct)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantifiers)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackreference)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscape)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlternationConstruct)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlternation)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Label Label1;
        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem mnuFile;
        internal ToolStripMenuItem mnuOptions;
        internal ToolStripMenuItem mnuOptionsIgnoreCase;
        internal ToolStripMenuItem mnuOptionsMultiline;
        internal ToolStripMenuItem mnuOptionsIgnoreWhitespace;
        internal ToolStripMenuItem mnuOptionsCompiled;
        internal ToolStripMenuItem mnuOptionsExplicitCapture;
        internal ToolStripMenuItem mnuOptionsRightToLeft;
        internal ToolStripMenuItem mnuOptionsCultureInvariant;
        internal ToolStripMenuItem mnuOptionsEcmaScript;
        internal ToolStripMenuItem mnuFileOpen;
        internal OpenFileDialog dlgOpenDoc;
        internal Label Label2;
        internal ToolStripMenuItem mnuFileNew;

        internal ToolStripMenuItem mnuResults;
        internal ToolStripMenuItem mnuCommands;
        internal ToolStripMenuItem mnuCommandsFind;
        internal ToolStripMenuItem mnuCommandsReplace;
        internal ToolStripMenuItem mnuCommandsSplit;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripMenuItem mnuCommandsEscape;
        internal Label lblReplace;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel staExecutionTime;
        internal ToolStripStatusLabel staMatches;
        internal TreeView tvwResults;
        internal ToolStripMenuItem mnuResultsGroups;
        internal ToolStripMenuItem mnuResultsCaptures;
        internal ToolStripMenuItem mnuResultsNoDetails;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripMenuItem mnuResultsDontSort;
        internal ToolStripMenuItem mnuResultsSortAlphabetically;
        internal ToolStripMenuItem mnuResultsShortest;
        internal ToolStripMenuItem mnuResultsLargest;
        internal ToolStripMenuItem ToolStripTextBox1;
        internal ToolStripTextBox txtViewMaxMatches;
        internal RichTextBox rtbResults;
        internal ToolStripSeparator ToolStripMenuItem1;
        internal ContextMenuStrip ctxPattern
        ;
        internal ContextMenuStrip ctxReplace;
        internal RichTextBox rtbRegex;
        internal RichTextBox rtbReplace;
        internal ToolStripMenuItem mnuCommandsRun;
        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripMenuItem mnuFileSave;
        internal ToolStripMenuItem mnuFileSaveAs;
        internal ToolStripSeparator ToolStripSeparator4;
        internal ToolStripMenuItem mnuFileProperties;
        internal ToolStripSeparator ToolStripSeparator5;
        internal ToolStripMenuItem mnuFileLoad;
        internal ToolStripSeparator ToolStripSeparator6;
        internal ToolStripMenuItem mnuFileExit;
        internal ToolStripStatusLabel staItemInfo;
        internal ToolStripMenuItem mnuResultsTreeView;
        internal ToolStripMenuItem mnuResultsReport;
        internal ToolStripSeparator ToolStripSeparator7;
        internal Label lblMatches;
        internal ToolStripMenuItem mnuResultsAuto;
        internal ToolStripMenuItem mnuEdit;
        internal ToolStripMenuItem mnuEditWordWrap;
        
        internal OpenFileDialog dlgOpenRegex;
        internal SaveFileDialog dlgSaveRegex;
        internal ToolStripMenuItem mnuCommandsGenerateCode;
        internal ToolStripMenuItem mnuCommandsShowGroups;
        internal ToolStripMenuItem mnuResultsIncludeEmptyGroups;
        internal ToolStripMenuItem mnuCommandsCompile;
        internal ToolTip ToolTip1;
        internal HelpProvider HelpProvider1;
        private TabControl tabResultAndQuickRef;
        private TabPage tabPageResult;
        private TabPage tabPageQuickRef;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvCharactorClass;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label label3;
        private TabPage tabPage2;
        private Label label4;
        private DataGridView dgvAssertion;
        private DataGridViewTextBoxColumn colTrainingImage;
        private DataGridViewTextBoxColumn colTrainingLabel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TabPage tabPage3;
        private Label label8;
        private DataGridView dgvGroupingConstruct;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private TabPage tabPage4;
        private Label label5;
        private DataGridView dgvQuantifiers;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private TabPage tabPage5;
        private Label label6;
        private DataGridView dgvBackreference;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private TabPage tabPage7;
        private DataGridView dgvEscape;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private Label label7;
        private TabPage tabPage6;
        private DataGridView dgvAlternationConstruct;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private Label label9;
        private TabPage tabPage8;
        private DataGridView dgvAlternation;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label10;
        private TabPage tabPage9;
        private Label label11;
        internal ToolStripMenuItem mnuHelp;
        internal ToolStripMenuItem mnuHelpAbout;
        private QWhale.Editor.SyntaxEdit rtbSource;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label12;
    }
}
