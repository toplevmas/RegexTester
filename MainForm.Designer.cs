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
            this.mnuResultMaxnum = new System.Windows.Forms.ToolStripMenuItem();
            this.txtViewMaxMatches = new System.Windows.Forms.ToolStripTextBox();
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
            this.rtbResults = new RichTextBoxEx();
            this.rtbRegex = new RichTextBoxEx();
            this.rtbReplace = new RichTextBoxEx();
            this.lblMatches = new System.Windows.Forms.Label();
            this.dlgOpenRegex = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveRegex = new System.Windows.Forms.SaveFileDialog();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.HelpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabResultAndQuickRef = new System.Windows.Forms.TabControl();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbSource = new QWhale.Editor.SyntaxEdit(this.components);
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mnuRegexHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.tabResultAndQuickRef.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
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
            this.MenuStrip1.Size = new System.Drawing.Size(727, 25);
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
            this.ToolStripMenuItem1,
            this.mnuResultsGroups,
            this.mnuResultsCaptures,
            this.mnuResultsNoDetails,
            this.ToolStripSeparator2,
            this.mnuResultMaxnum,
            this.mnuResultsIncludeEmptyGroups,
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
            // mnuResultMaxnum
            // 
            this.mnuResultMaxnum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtViewMaxMatches});
            this.mnuResultMaxnum.Name = "mnuResultMaxnum";
            this.mnuResultMaxnum.Size = new System.Drawing.Size(212, 22);
            this.mnuResultMaxnum.Text = "&Max number  of results";
            // 
            // txtViewMaxMatches
            // 
            this.txtViewMaxMatches.Name = "txtViewMaxMatches";
            this.txtViewMaxMatches.Size = new System.Drawing.Size(152, 23);
            this.txtViewMaxMatches.Text = "MaxMatches";
            this.txtViewMaxMatches.Click += new System.EventHandler(this.txtViewMaxMatches_Click);
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
            this.mnuResultsCaptures.Text = "Groups And Captures";
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
            this.mnuResultsIncludeEmptyGroups.Text = "Include Empty Groups";
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
            this.mnuResultsDontSort.Text = "Dont Sort";
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
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegexHelp});
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
            this.StatusStrip1.Location = new System.Drawing.Point(0, 562);
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
            this.tvwResults.Size = new System.Drawing.Size(637, 156);
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
            this.rtbResults.Size = new System.Drawing.Size(26, 72);
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
            this.rtbRegex.Location = new System.Drawing.Point(73, 3);
            this.rtbRegex.Name = "rtbRegex";
            this.rtbRegex.Size = new System.Drawing.Size(651, 94);
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
            this.rtbReplace.Location = new System.Drawing.Point(73, 103);
            this.rtbReplace.Name = "rtbReplace";
            this.rtbReplace.Size = new System.Drawing.Size(651, 44);
            this.rtbReplace.TabIndex = 4;
            this.rtbReplace.Text = "";
            this.ToolTip1.SetToolTip(this.rtbReplace, "The replace pattern. §Right-click to display list of common patterns.");
            // 
            // lblMatches
            // 
            this.lblMatches.AutoSize = true;
            this.lblMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatches.Location = new System.Drawing.Point(3, 343);
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
            this.tabResultAndQuickRef.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabResultAndQuickRef.Location = new System.Drawing.Point(73, 346);
            this.tabResultAndQuickRef.Name = "tabResultAndQuickRef";
            this.tabResultAndQuickRef.SelectedIndex = 0;
            this.tabResultAndQuickRef.Size = new System.Drawing.Size(651, 188);
            this.tabResultAndQuickRef.TabIndex = 11;
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.tvwResults);
            this.tabPageResult.Controls.Add(this.rtbResults);
            this.tabPageResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(643, 162);
            this.tabPageResult.TabIndex = 1;
            this.tabPageResult.Text = "匹配结果";
            this.tabPageResult.UseVisualStyleBackColor = true;
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
            this.rtbSource.Location = new System.Drawing.Point(73, 153);
            this.rtbSource.Name = "rtbSource";
            this.rtbSource.NavigateOptions = QWhale.Editor.TextSource.NavigateOptions.None;
            this.rtbSource.Outlining.OutlineOptions = QWhale.Editor.OutlineOptions.None;
            this.rtbSource.Printing.AllowedOptions = QWhale.Editor.PrintOptions.None;
            this.rtbSource.Printing.Options = QWhale.Editor.PrintOptions.None;
            this.rtbSource.Scrolling.Options = ((QWhale.Editor.ScrollingOptions)((((QWhale.Editor.ScrollingOptions.SmoothScroll | QWhale.Editor.ScrollingOptions.UseScrollDelta)
                        | QWhale.Editor.ScrollingOptions.AllowSplitHorz)
                        | QWhale.Editor.ScrollingOptions.AllowSplitVert)));
            this.rtbSource.Selection.Options = QWhale.Editor.SelectionOptions.None;
            this.rtbSource.Size = new System.Drawing.Size(651, 187);
            this.rtbSource.TabIndex = 12;
            this.rtbSource.Text = "";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.759547F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.24046F));
            this.tableLayoutPanel.Controls.Add(this.rtbRegex, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.Label1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.rtbSource, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.tabResultAndQuickRef, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.rtbReplace, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblReplace, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.Label2, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lblMatches, 0, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(727, 537);
            this.tableLayoutPanel.TabIndex = 13;
            // 
            // mnuRegexHelp
            // 
            this.mnuRegexHelp.Name = "mnuRegexHelp";
            this.mnuRegexHelp.Size = new System.Drawing.Size(160, 22);
            this.mnuRegexHelp.Text = "正则表达式帮助";
            this.mnuRegexHelp.Click += new System.EventHandler(this.mnuRegexHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 584);
            this.Controls.Add(this.tableLayoutPanel);
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
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
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
        internal ToolStripMenuItem mnuResultMaxnum;
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
        internal ToolStripMenuItem mnuHelp;
        internal ToolStripMenuItem mnuHelpAbout;
        private QWhale.Editor.SyntaxEdit rtbSource;
        private TableLayoutPanel tableLayoutPanel;
        private ToolStripMenuItem mnuRegexHelp;
    }
}
