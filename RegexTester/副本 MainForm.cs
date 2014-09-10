using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RegexTester.My;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
namespace RegexTester
{
    [DesignerGenerated]
    public class MainForm : Form
    {
        private IContainer components;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("MenuStrip1")]
        private MenuStrip _MenuStrip1;
        [AccessedThroughProperty("mnuFile")]
        private ToolStripMenuItem _mnuFile;
        [AccessedThroughProperty("mnuOptions")]
        private ToolStripMenuItem _mnuOptions;
        [AccessedThroughProperty("mnuOptionsIgnoreCase")]
        private ToolStripMenuItem _mnuOptionsIgnoreCase;
        [AccessedThroughProperty("mnuOptionsMultiline")]
        private ToolStripMenuItem _mnuOptionsMultiline;
        [AccessedThroughProperty("mnuOptionsIgnoreWhitespace")]
        private ToolStripMenuItem _mnuOptionsIgnoreWhitespace;
        [AccessedThroughProperty("mnuOptionsCompiled")]
        private ToolStripMenuItem _mnuOptionsCompiled;
        [AccessedThroughProperty("mnuOptionsExplicitCapture")]
        private ToolStripMenuItem _mnuOptionsExplicitCapture;
        [AccessedThroughProperty("mnuOptionsRightToLeft")]
        private ToolStripMenuItem _mnuOptionsRightToLeft;
        [AccessedThroughProperty("mnuOptionsCultureInvariant")]
        private ToolStripMenuItem _mnuOptionsCultureInvariant;
        [AccessedThroughProperty("mnuOptionsEcmaScript")]
        private ToolStripMenuItem _mnuOptionsEcmaScript;
        [AccessedThroughProperty("mnuFileOpen")]
        private ToolStripMenuItem _mnuFileOpen;
        [AccessedThroughProperty("dlgOpenDoc")]
        private OpenFileDialog _dlgOpenDoc;
        [AccessedThroughProperty("rtbSource")]
        private RichTextBox _rtbSource;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("mnuFileNew")]
        private ToolStripMenuItem _mnuFileNew;
        [AccessedThroughProperty("mnuResults")]
        private ToolStripMenuItem _mnuResults;
        [AccessedThroughProperty("mnuCommands")]
        private ToolStripMenuItem _mnuCommands;
        [AccessedThroughProperty("mnuCommandsFind")]
        private ToolStripMenuItem _mnuCommandsFind;
        [AccessedThroughProperty("mnuCommandsReplace")]
        private ToolStripMenuItem _mnuCommandsReplace;
        [AccessedThroughProperty("mnuCommandsSplit")]
        private ToolStripMenuItem _mnuCommandsSplit;
        [AccessedThroughProperty("ToolStripSeparator1")]
        private ToolStripSeparator _ToolStripSeparator1;
        [AccessedThroughProperty("mnuCommandsEscape")]
        private ToolStripMenuItem _mnuCommandsEscape;
        [AccessedThroughProperty("lblReplace")]
        private Label _lblReplace;
        [AccessedThroughProperty("StatusStrip1")]
        private StatusStrip _StatusStrip1;
        [AccessedThroughProperty("staExecutionTime")]
        private ToolStripStatusLabel _staExecutionTime;
        [AccessedThroughProperty("staMatches")]
        private ToolStripStatusLabel _staMatches;
        [AccessedThroughProperty("tvwResults")]
        private TreeView _tvwResults;
        [AccessedThroughProperty("mnuResultsGroups")]
        private ToolStripMenuItem _mnuResultsGroups;
        [AccessedThroughProperty("mnuResultsCaptures")]
        private ToolStripMenuItem _mnuResultsCaptures;
        [AccessedThroughProperty("mnuResultsNoDetails")]
        private ToolStripMenuItem _mnuResultsNoDetails;
        [AccessedThroughProperty("ToolStripSeparator2")]
        private ToolStripSeparator _ToolStripSeparator2;
        [AccessedThroughProperty("mnuResultsDontSort")]
        private ToolStripMenuItem _mnuResultsDontSort;
        [AccessedThroughProperty("mnuResultsSortAlphabetically")]
        private ToolStripMenuItem _mnuResultsSortAlphabetically;
        [AccessedThroughProperty("mnuResultsShortest")]
        private ToolStripMenuItem _mnuResultsShortest;
        [AccessedThroughProperty("mnuResultsLargest")]
        private ToolStripMenuItem _mnuResultsLargest;
        [AccessedThroughProperty("ToolStripTextBox1")]
        private ToolStripMenuItem _ToolStripTextBox1;
        [AccessedThroughProperty("txtViewMaxMatches")]
        private ToolStripTextBox _txtViewMaxMatches;
        [AccessedThroughProperty("rtbResults")]
        private RichTextBox _rtbResults;
        [AccessedThroughProperty("ToolStripMenuItem1")]
        private ToolStripSeparator _ToolStripMenuItem1;
        [AccessedThroughProperty("ctxPattern")]
        private ContextMenuStrip _ctxPattern;
        [AccessedThroughProperty("ctxReplace")]
        private ContextMenuStrip _ctxReplace;
        [AccessedThroughProperty("rtbRegex")]
        private RichTextBox _rtbRegex;
        [AccessedThroughProperty("rtbReplace")]
        private RichTextBox _rtbReplace;
        [AccessedThroughProperty("mnuCommandsRun")]
        private ToolStripMenuItem _mnuCommandsRun;
        [AccessedThroughProperty("ToolStripSeparator3")]
        private ToolStripSeparator _ToolStripSeparator3;
        [AccessedThroughProperty("mnuFileSave")]
        private ToolStripMenuItem _mnuFileSave;
        [AccessedThroughProperty("mnuFileSaveAs")]
        private ToolStripMenuItem _mnuFileSaveAs;
        [AccessedThroughProperty("ToolStripSeparator4")]
        private ToolStripSeparator _ToolStripSeparator4;
        [AccessedThroughProperty("mnuFileProperties")]
        private ToolStripMenuItem _mnuFileProperties;
        [AccessedThroughProperty("ToolStripSeparator5")]
        private ToolStripSeparator _ToolStripSeparator5;
        [AccessedThroughProperty("mnuFileLoad")]
        private ToolStripMenuItem _mnuFileLoad;
        [AccessedThroughProperty("ToolStripSeparator6")]
        private ToolStripSeparator _ToolStripSeparator6;
        [AccessedThroughProperty("mnuFileExit")]
        private ToolStripMenuItem _mnuFileExit;
        [AccessedThroughProperty("staItemInfo")]
        private ToolStripStatusLabel _staItemInfo;
        [AccessedThroughProperty("mnuResultsTreeView")]
        private ToolStripMenuItem _mnuResultsTreeView;
        [AccessedThroughProperty("mnuResultsReport")]
        private ToolStripMenuItem _mnuResultsReport;
        [AccessedThroughProperty("ToolStripSeparator7")]
        private ToolStripSeparator _ToolStripSeparator7;
        [AccessedThroughProperty("lblMatches")]
        private Label _lblMatches;
        [AccessedThroughProperty("mnuResultsAuto")]
        private ToolStripMenuItem _mnuResultsAuto;
        [AccessedThroughProperty("mnuEdit")]
        private ToolStripMenuItem _mnuEdit;
        [AccessedThroughProperty("mnuEditWordWrap")]
        private ToolStripMenuItem _mnuEditWordWrap;
        [AccessedThroughProperty("dlgOpenRegex")]
        private OpenFileDialog _dlgOpenRegex;
        [AccessedThroughProperty("dlgSaveRegex")]
        private SaveFileDialog _dlgSaveRegex;
        [AccessedThroughProperty("mnuCommandsGenerateCode")]
        private ToolStripMenuItem _mnuCommandsGenerateCode;
        [AccessedThroughProperty("mnuCommandsShowGroups")]
        private ToolStripMenuItem _mnuCommandsShowGroups;
        [AccessedThroughProperty("mnuResultsIncludeEmptyGroups")]
        private ToolStripMenuItem _mnuResultsIncludeEmptyGroups;
        [AccessedThroughProperty("mnuCommandsCompile")]
        private ToolStripMenuItem _mnuCommandsCompile;
        [AccessedThroughProperty("ToolTip1")]
        private ToolTip _ToolTip1;
        [AccessedThroughProperty("HelpProvider1")]
        private HelpProvider _HelpProvider1;
        [AccessedThroughProperty("mnuHelp")]
        private ToolStripMenuItem _mnuHelp;
        [AccessedThroughProperty("mnuHelpAbout")]
        private ToolStripMenuItem _mnuHelpAbout;
        internal ProjectOptions Options;
        internal Regex re;
        internal CompileForm CompileForm;
        internal Label Label1;
        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem mnuFile;
        internal ToolStripMenuItem mnuOptions;
        internal ToolStripMenuItem mnuOptionsIgnoreCase;
        internal ToolStripMenuItem mnuOptionsMultiline;
        internal ToolStripMenuItem mnuOptionsIgnoreWhitespace;
        internal ToolStripMenuItem mnuOptionsCompiled;
        internal ToolStripMenuItem mnuOptionsExplicitCapture
        {
            get
            {
                return this._mnuOptionsExplicitCapture;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuOptionsExplicitCapture != null)
                {
                    this._mnuOptionsExplicitCapture.Click -= new EventHandler(this.mnuOptionsExplicitCapture_Click);
                }
                this._mnuOptionsExplicitCapture = value;
                if (this._mnuOptionsExplicitCapture != null)
                {
                    this._mnuOptionsExplicitCapture.Click += new EventHandler(this.mnuOptionsExplicitCapture_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuOptionsRightToLeft
        {
            get
            {
                return this._mnuOptionsRightToLeft;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuOptionsRightToLeft != null)
                {
                    this._mnuOptionsRightToLeft.Click -= new EventHandler(this.mnuOptionsRightToLeft_Click);
                }
                this._mnuOptionsRightToLeft = value;
                if (this._mnuOptionsRightToLeft != null)
                {
                    this._mnuOptionsRightToLeft.Click += new EventHandler(this.mnuOptionsRightToLeft_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuOptionsCultureInvariant
        {
            get
            {
                return this._mnuOptionsCultureInvariant;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuOptionsCultureInvariant != null)
                {
                    this._mnuOptionsCultureInvariant.Click -= new EventHandler(this.mnuOptionsCultureInvariant_Click);
                }
                this._mnuOptionsCultureInvariant = value;
                if (this._mnuOptionsCultureInvariant != null)
                {
                    this._mnuOptionsCultureInvariant.Click += new EventHandler(this.mnuOptionsCultureInvariant_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuOptionsEcmaScript
        {
            get
            {
                return this._mnuOptionsEcmaScript;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuOptionsEcmaScript != null)
                {
                    this._mnuOptionsEcmaScript.Click -= new EventHandler(this.mnuOptionsEcmaScript_Click);
                }
                this._mnuOptionsEcmaScript = value;
                if (this._mnuOptionsEcmaScript != null)
                {
                    this._mnuOptionsEcmaScript.Click += new EventHandler(this.mnuOptionsEcmaScript_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuFileOpen
        {
            get
            {
                return this._mnuFileOpen;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuFileOpen != null)
                {
                    this._mnuFileOpen.Click -= new EventHandler(this.mnuFileOpen_Click);
                }
                this._mnuFileOpen = value;
                if (this._mnuFileOpen != null)
                {
                    this._mnuFileOpen.Click += new EventHandler(this.mnuFileOpen_Click);
                }
            }
        }
        internal OpenFileDialog dlgOpenDoc;
        internal RichTextBox rtbSource;
        internal Label Label2;
        public ToolStripMenuItem mnuFileNew
        {
            get
            {
                return this._mnuFileNew;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuFileNew != null)
                {
                    this._mnuFileNew.Click -= new EventHandler(this.mnuFileNew_Click);
                }
                this._mnuFileNew = value;
                if (this._mnuFileNew != null)
                {
                    this._mnuFileNew.Click += new EventHandler(this.mnuFileNew_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuResults;
        internal ToolStripMenuItem mnuCommands;
        internal ToolStripMenuItem mnuCommandsFind
        {
            get
            {
                return this._mnuCommandsFind;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuCommandsFind != null)
                {
                    this._mnuCommandsFind.Click -= new EventHandler(this.mnuCommandsFind_Click);
                }
                this._mnuCommandsFind = value;
                if (this._mnuCommandsFind != null)
                {
                    this._mnuCommandsFind.Click += new EventHandler(this.mnuCommandsFind_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuCommandsReplace
        {
            get
            {
                return this._mnuCommandsReplace;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuCommandsReplace != null)
                {
                    this._mnuCommandsReplace.Click -= new EventHandler(this.mnuCommandsReplace_Click);
                }
                this._mnuCommandsReplace = value;
                if (this._mnuCommandsReplace != null)
                {
                    this._mnuCommandsReplace.Click += new EventHandler(this.mnuCommandsReplace_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuCommandsSplit
        {
            get
            {
                return this._mnuCommandsSplit;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuCommandsSplit != null)
                {
                    this._mnuCommandsSplit.Click -= new EventHandler(this.mnuCommandsSplit_Click);
                }
                this._mnuCommandsSplit = value;
                if (this._mnuCommandsSplit != null)
                {
                    this._mnuCommandsSplit.Click += new EventHandler(this.mnuCommandsSplit_Click);
                }
            }
        }
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripMenuItem mnuCommandsEscape
        {
            get
            {
                return this._mnuCommandsEscape;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuCommandsEscape != null)
                {
                    this._mnuCommandsEscape.Click -= new EventHandler(this.mnuCommandsEscape_Click);
                }
                this._mnuCommandsEscape = value;
                if (this._mnuCommandsEscape != null)
                {
                    this._mnuCommandsEscape.Click += new EventHandler(this.mnuCommandsEscape_Click);
                }
            }
        }
        internal Label lblReplace;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel staExecutionTime;
        internal ToolStripStatusLabel staMatches;
        internal TreeView tvwResults;
        internal ToolStripMenuItem mnuResultsGroups
        {
            get
            {
                return this._mnuResultsGroups;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuResultsGroups != null)
                {
                    this._mnuResultsGroups.Click -= new EventHandler(this.mnuResultsGroups_Click);
                }
                this._mnuResultsGroups = value;
                if (this._mnuResultsGroups != null)
                {
                    this._mnuResultsGroups.Click += new EventHandler(this.mnuResultsGroups_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuResultsCaptures
        {
            get
            {
                return this._mnuResultsCaptures;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuResultsCaptures != null)
                {
                    this._mnuResultsCaptures.Click -= new EventHandler(this.mnuResultsCaptures_Click);
                }
                this._mnuResultsCaptures = value;
                if (this._mnuResultsCaptures != null)
                {
                    this._mnuResultsCaptures.Click += new EventHandler(this.mnuResultsCaptures_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuResultsNoDetails
        {
            get
            {
                return this._mnuResultsNoDetails;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuResultsNoDetails != null)
                {
                    this._mnuResultsNoDetails.Click -= new EventHandler(this.mnuResultsNoDetails_Click);
                }
                this._mnuResultsNoDetails = value;
                if (this._mnuResultsNoDetails != null)
                {
                    this._mnuResultsNoDetails.Click += new EventHandler(this.mnuResultsNoDetails_Click);
                }
            }
        }
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripMenuItem mnuResultsDontSort
        {
            get
            {
                return this._mnuResultsDontSort;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuResultsDontSort != null)
                {
                    this._mnuResultsDontSort.Click -= new EventHandler(this.mnuResultsDontSort_Click);
                }
                this._mnuResultsDontSort = value;
                if (this._mnuResultsDontSort != null)
                {
                    this._mnuResultsDontSort.Click += new EventHandler(this.mnuResultsDontSort_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuResultsSortAlphabetically
        {
            get
            {
                return this._mnuResultsSortAlphabetically;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuResultsSortAlphabetically != null)
                {
                    this._mnuResultsSortAlphabetically.Click -= new EventHandler(this.mnuResultsSortAlphabetically_Click);
                }
                this._mnuResultsSortAlphabetically = value;
                if (this._mnuResultsSortAlphabetically != null)
                {
                    this._mnuResultsSortAlphabetically.Click += new EventHandler(this.mnuResultsSortAlphabetically_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuResultsShortest
        {
            get
            {
                return this._mnuResultsShortest;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuResultsShortest != null)
                {
                    this._mnuResultsShortest.Click -= new EventHandler(this.mnuResultsShortest_Click);
                }
                this._mnuResultsShortest = value;
                if (this._mnuResultsShortest != null)
                {
                    this._mnuResultsShortest.Click += new EventHandler(this.mnuResultsShortest_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuResultsLargest
        {
            get
            {
                return this._mnuResultsLargest;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuResultsLargest != null)
                {
                    this._mnuResultsLargest.Click -= new EventHandler(this.mnuResultsLargest_Click);
                }
                this._mnuResultsLargest = value;
                if (this._mnuResultsLargest != null)
                {
                    this._mnuResultsLargest.Click += new EventHandler(this.mnuResultsLargest_Click);
                }
            }
        }
        internal ToolStripMenuItem ToolStripTextBox1;
        internal ToolStripTextBox txtViewMaxMatches
        {
            get
            {
                return this._txtViewMaxMatches;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._txtViewMaxMatches != null)
                {
                    this._txtViewMaxMatches.TextChanged -= new EventHandler(this.txtViewMaxMatches_Click);
                }
                this._txtViewMaxMatches = value;
                if (this._txtViewMaxMatches != null)
                {
                    this._txtViewMaxMatches.TextChanged += new EventHandler(this.txtViewMaxMatches_Click);
                }
            }
        }
        internal RichTextBox rtbResults;
        internal ToolStripSeparator ToolStripMenuItem1;
        internal ContextMenuStrip ctxPattern
        ;
        internal ContextMenuStrip ctxReplace;
        internal RichTextBox rtbRegex;
        internal RichTextBox rtbReplace;
        internal ToolStripMenuItem mnuCommandsRun
        {
            get
            {
                return this._mnuCommandsRun;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuCommandsRun != null)
                {
                    this._mnuCommandsRun.Click -= new EventHandler(this.mnuCommandsRun_Click);
                }
                this._mnuCommandsRun = value;
                if (this._mnuCommandsRun != null)
                {
                    this._mnuCommandsRun.Click += new EventHandler(this.mnuCommandsRun_Click);
                }
            }
        }
        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripMenuItem mnuFileSave
        {
            get
            {
                return this._mnuFileSave;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuFileSave != null)
                {
                    this._mnuFileSave.Click -= new EventHandler(this.mnuFileSave_Click);
                }
                this._mnuFileSave = value;
                if (this._mnuFileSave != null)
                {
                    this._mnuFileSave.Click += new EventHandler(this.mnuFileSave_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuFileSaveAs
        {
            get
            {
                return this._mnuFileSaveAs;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuFileSaveAs != null)
                {
                    this._mnuFileSaveAs.Click -= new EventHandler(this.mnuFileSaveAs_Click);
                }
                this._mnuFileSaveAs = value;
                if (this._mnuFileSaveAs != null)
                {
                    this._mnuFileSaveAs.Click += new EventHandler(this.mnuFileSaveAs_Click);
                }
            }
        }
        internal ToolStripSeparator ToolStripSeparator4;
        internal ToolStripMenuItem mnuFileProperties
        {
            get
            {
                return this._mnuFileProperties;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuFileProperties != null)
                {
                    this._mnuFileProperties.Click -= new EventHandler(this.mnuFileProperties_Click);
                }
                this._mnuFileProperties = value;
                if (this._mnuFileProperties != null)
                {
                    this._mnuFileProperties.Click += new EventHandler(this.mnuFileProperties_Click);
                }
            }
        }
        internal ToolStripSeparator ToolStripSeparator5;
        internal ToolStripMenuItem mnuFileLoad
        {
            get
            {
                return this._mnuFileLoad;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuFileLoad != null)
                {
                    this._mnuFileLoad.Click -= new EventHandler(this.mnuFileLoad_Click);
                }
                this._mnuFileLoad = value;
                if (this._mnuFileLoad != null)
                {
                    this._mnuFileLoad.Click += new EventHandler(this.mnuFileLoad_Click);
                }
            }
        }
        internal ToolStripSeparator ToolStripSeparator6;
        internal ToolStripMenuItem mnuFileExit
        {
            get
            {
                return this._mnuFileExit;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuFileExit != null)
                {
                    this._mnuFileExit.Click -= new EventHandler(this.mnuFileExit_Click);
                }
                this._mnuFileExit = value;
                if (this._mnuFileExit != null)
                {
                    this._mnuFileExit.Click += new EventHandler(this.mnuFileExit_Click);
                }
            }
        }
        internal ToolStripStatusLabel staItemInfo;
        internal ToolStripMenuItem mnuResultsTreeView
        {
            get
            {
                return this._mnuResultsTreeView;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuResultsTreeView != null)
                {
                    this._mnuResultsTreeView.Click -= new EventHandler(this.mnuResultsTreeView_Click);
                }
                this._mnuResultsTreeView = value;
                if (this._mnuResultsTreeView != null)
                {
                    this._mnuResultsTreeView.Click += new EventHandler(this.mnuResultsTreeView_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuResultsReport
        {
            get
            {
                return this._mnuResultsReport;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuResultsReport != null)
                {
                    this._mnuResultsReport.Click -= new EventHandler(this.mnuResultsReport_Click);
                }
                this._mnuResultsReport = value;
                if (this._mnuResultsReport != null)
                {
                    this._mnuResultsReport.Click += new EventHandler(this.mnuResultsReport_Click);
                }
            }
        }
        internal ToolStripSeparator ToolStripSeparator7;
        internal Label lblMatches;
        internal ToolStripMenuItem mnuResultsAuto
        {
            get
            {
                return this._mnuResultsAuto;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuResultsAuto != null)
                {
                    this._mnuResultsAuto.Click -= new EventHandler(this.mnuResultsAuto_Click);
                }
                this._mnuResultsAuto = value;
                if (this._mnuResultsAuto != null)
                {
                    this._mnuResultsAuto.Click += new EventHandler(this.mnuResultsAuto_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuEdit;
        internal ToolStripMenuItem mnuEditWordWrap
        {
            get
            {
                return this._mnuEditWordWrap;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuEditWordWrap != null)
                {
                    this._mnuEditWordWrap.Click -= new EventHandler(this.mnuEditWordWrap_Click);
                }
                this._mnuEditWordWrap = value;
                if (this._mnuEditWordWrap != null)
                {
                    this._mnuEditWordWrap.Click += new EventHandler(this.mnuEditWordWrap_Click);
                }
            }
        }
        ToolStripMenuItem _mnuEditRegexHelper;
        internal ToolStripMenuItem mnuEditRegexHelper
        {
            get
            {
                return this._mnuEditRegexHelper;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuEditRegexHelper != null)
                {
                    this._mnuEditRegexHelper.Click -= new EventHandler(this.mnuEditRegularHelper_Click);
                }
                this._mnuEditRegexHelper = value;
                if (this._mnuEditRegexHelper != null)
                {
                    this._mnuEditRegexHelper.Click += new EventHandler(this.mnuEditRegularHelper_Click);
                }
            }
        }
        internal OpenFileDialog dlgOpenRegex;
        internal SaveFileDialog dlgSaveRegex;
        internal ToolStripMenuItem mnuCommandsGenerateCode
        {
            get
            {
                return this._mnuCommandsGenerateCode;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuCommandsGenerateCode != null)
                {
                    this._mnuCommandsGenerateCode.Click -= new EventHandler(this.mnuCommandsGenerateCode_Click);
                }
                this._mnuCommandsGenerateCode = value;
                if (this._mnuCommandsGenerateCode != null)
                {
                    this._mnuCommandsGenerateCode.Click += new EventHandler(this.mnuCommandsGenerateCode_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuCommandsShowGroups
        {
            get
            {
                return this._mnuCommandsShowGroups;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuCommandsShowGroups != null)
                {
                    this._mnuCommandsShowGroups.Click -= new EventHandler(this.mnuCommandsShowGroups_Click);
                }
                this._mnuCommandsShowGroups = value;
                if (this._mnuCommandsShowGroups != null)
                {
                    this._mnuCommandsShowGroups.Click += new EventHandler(this.mnuCommandsShowGroups_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuResultsIncludeEmptyGroups
        {
            get
            {
                return this._mnuResultsIncludeEmptyGroups;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuResultsIncludeEmptyGroups != null)
                {
                    this._mnuResultsIncludeEmptyGroups.Click -= new EventHandler(this.mnuResultsIncludeEmptyGroups_Click);
                }
                this._mnuResultsIncludeEmptyGroups = value;
                if (this._mnuResultsIncludeEmptyGroups != null)
                {
                    this._mnuResultsIncludeEmptyGroups.Click += new EventHandler(this.mnuResultsIncludeEmptyGroups_Click);
                }
            }
        }
        internal ToolStripMenuItem mnuCommandsCompile
        {
            get
            {
                return this._mnuCommandsCompile;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuCommandsCompile != null)
                {
                    this._mnuCommandsCompile.Click -= new EventHandler(this.mnuCommandsCompile_Click);
                }
                this._mnuCommandsCompile = value;
                if (this._mnuCommandsCompile != null)
                {
                    this._mnuCommandsCompile.Click += new EventHandler(this.mnuCommandsCompile_Click);
                }
            }
        }
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private Label label7;
        private TabPage tabPage6;
        private DataGridView dgbAlternationConstruct;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private Label label9;
        private TabPage tabPage8;
        private DataGridView dgbAlternation;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label10;
        private TabPage tabPage9;
        private LinkLabel linkLabel1;
        private Label label11;
        internal ToolStripMenuItem mnuHelp;
        internal ToolStripMenuItem mnuHelpAbout
        {
            get
            {
                return this._mnuHelpAbout;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._mnuHelpAbout != null)
                {
                    this._mnuHelpAbout.Click -= new EventHandler(this.mnuHelpAbout_Click);
                }
                this._mnuHelpAbout = value;
                if (this._mnuHelpAbout != null)
                {
                    this._mnuHelpAbout.Click += new EventHandler(this.mnuHelpAbout_Click);
                }
            }
        }
        public MainForm()
        {
            base.Load += new EventHandler(this.MainForm_Load);
            this.Options = new ProjectOptions();
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctxPattern = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResults = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenDoc = new System.Windows.Forms.OpenFileDialog();
            this.rtbSource = new System.Windows.Forms.RichTextBox();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgbAlternationConstruct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dgbAlternation = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbAlternationConstruct)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbAlternation)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxPattern
            // 
            this.ctxPattern.Name = "ctxPattern";
            this.ctxPattern.Size = new System.Drawing.Size(61, 4);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(63, 38);
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
            this.MenuStrip1.Size = new System.Drawing.Size(753, 25);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSeparator4,
            this.ToolStripSeparator5,
            this.ToolStripSeparator6});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(39, 21);
            this.mnuFile.Text = "&File";
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(57, 6);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(57, 6);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(57, 6);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(42, 21);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuCommands
            // 
            this.mnuCommands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSeparator3,
            this.ToolStripSeparator1});
            this.mnuCommands.Name = "mnuCommands";
            this.mnuCommands.Size = new System.Drawing.Size(86, 21);
            this.mnuCommands.Text = "&Commands";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(57, 6);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(57, 6);
            // 
            // mnuOptions
            // 
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(66, 21);
            this.mnuOptions.Text = "&Options";
            // 
            // mnuResults
            // 
            this.mnuResults.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSeparator7,
            this.ToolStripSeparator2,
            this.ToolStripTextBox1,
            this.ToolStripMenuItem1});
            this.mnuResults.Name = "mnuResults";
            this.mnuResults.Size = new System.Drawing.Size(61, 21);
            this.mnuResults.Text = "&Results";
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(209, 6);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // ToolStripTextBox1
            // 
            this.ToolStripTextBox1.Name = "ToolStripTextBox1";
            this.ToolStripTextBox1.Size = new System.Drawing.Size(212, 22);
            this.ToolStripTextBox1.Text = "&Max number  of results";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(209, 6);
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
            // rtbSource
            // 
            this.rtbSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSource.DetectUrls = false;
            this.rtbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSource.HideSelection = false;
            this.rtbSource.Location = new System.Drawing.Point(67, 188);
            this.rtbSource.Name = "rtbSource";
            this.rtbSource.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbSource.Size = new System.Drawing.Size(674, 101);
            this.rtbSource.TabIndex = 6;
            this.rtbSource.Text = "";
            this.ToolTip1.SetToolTip(this.rtbSource, "The text on which the regular expression is applied. §Use the File-Load menu to l" +
                    "oad a text file.");
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 191);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 38);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Source";
            // 
            // lblReplace
            // 
            this.lblReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplace.Location = new System.Drawing.Point(12, 123);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(60, 40);
            this.lblReplace.TabIndex = 3;
            this.lblReplace.Text = "Replace";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staMatches,
            this.staExecutionTime,
            this.staItemInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 478);
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
            this.tvwResults.Size = new System.Drawing.Size(660, 132);
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
            this.rtbResults.Size = new System.Drawing.Size(28, 48);
            this.rtbResults.TabIndex = 9;
            this.rtbResults.Text = "";
            this.ToolTip1.SetToolTip(this.rtbResults, "The replaced text, or the split elements, or the matches in report format.");
            // 
            // rtbRegex
            // 
            this.rtbRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbRegex.ContextMenuStrip = this.ctxPattern;
            this.rtbRegex.DetectUrls = false;
            this.rtbRegex.Location = new System.Drawing.Point(67, 33);
            this.rtbRegex.Name = "rtbRegex";
            this.rtbRegex.Size = new System.Drawing.Size(674, 84);
            this.rtbRegex.TabIndex = 2;
            this.rtbRegex.Text = "";
            this.ToolTip1.SetToolTip(this.rtbRegex, "The regular expression pattern. §Right-click to display list of common patterns.");
            // 
            // rtbReplace
            // 
            this.rtbReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbReplace.ContextMenuStrip = this.ctxReplace;
            this.rtbReplace.DetectUrls = false;
            this.rtbReplace.Location = new System.Drawing.Point(67, 123);
            this.rtbReplace.Name = "rtbReplace";
            this.rtbReplace.Size = new System.Drawing.Size(674, 48);
            this.rtbReplace.TabIndex = 4;
            this.rtbReplace.Text = "";
            this.ToolTip1.SetToolTip(this.rtbReplace, "The replace pattern. §Right-click to display list of common patterns.");
            // 
            // lblMatches
            // 
            this.lblMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatches.Location = new System.Drawing.Point(12, 305);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(75, 38);
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
            this.tabResultAndQuickRef.Location = new System.Drawing.Point(67, 305);
            this.tabResultAndQuickRef.Name = "tabResultAndQuickRef";
            this.tabResultAndQuickRef.SelectedIndex = 0;
            this.tabResultAndQuickRef.Size = new System.Drawing.Size(674, 164);
            this.tabResultAndQuickRef.TabIndex = 11;
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.tvwResults);
            this.tabPageResult.Controls.Add(this.rtbResults);
            this.tabPageResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(666, 138);
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
            this.tabPageQuickRef.Size = new System.Drawing.Size(666, 138);
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
            this.tabControl1.Size = new System.Drawing.Size(660, 132);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvCharactorClass);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 106);
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
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle49.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCharactorClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle49;
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
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCharactorClass.RowsDefaultCellStyle = dataGridViewCellStyle51;
            this.dgvCharactorClass.RowTemplate.Height = 23;
            this.dgvCharactorClass.Size = new System.Drawing.Size(643, 66);
            this.dgvCharactorClass.TabIndex = 61;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle50.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle50;
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
            this.tabPage2.Size = new System.Drawing.Size(652, 106);
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
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle52.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle52.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle52.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle52.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssertion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle52;
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
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssertion.RowsDefaultCellStyle = dataGridViewCellStyle54;
            this.dgvAssertion.RowTemplate.Height = 23;
            this.dgvAssertion.Size = new System.Drawing.Size(643, 60);
            this.dgvAssertion.TabIndex = 60;
            // 
            // colTrainingImage
            // 
            dataGridViewCellStyle53.Padding = new System.Windows.Forms.Padding(2);
            this.colTrainingImage.DefaultCellStyle = dataGridViewCellStyle53;
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
            this.tabPage3.Size = new System.Drawing.Size(652, 106);
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
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle55.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupingConstruct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle55;
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
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupingConstruct.RowsDefaultCellStyle = dataGridViewCellStyle57;
            this.dgvGroupingConstruct.RowTemplate.Height = 23;
            this.dgvGroupingConstruct.Size = new System.Drawing.Size(643, 60);
            this.dgvGroupingConstruct.TabIndex = 62;
            // 
            // dataGridViewTextBoxColumn25
            // 
            dataGridViewCellStyle56.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle56;
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
            this.tabPage4.Size = new System.Drawing.Size(652, 106);
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
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle58.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle58.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuantifiers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
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
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuantifiers.RowsDefaultCellStyle = dataGridViewCellStyle60;
            this.dgvQuantifiers.RowTemplate.Height = 23;
            this.dgvQuantifiers.Size = new System.Drawing.Size(643, 47);
            this.dgvQuantifiers.TabIndex = 61;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle59.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle59;
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
            this.tabPage5.Size = new System.Drawing.Size(652, 106);
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
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle61.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle61.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBackreference.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle61;
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
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBackreference.RowsDefaultCellStyle = dataGridViewCellStyle63;
            this.dgvBackreference.RowTemplate.Height = 23;
            this.dgvBackreference.Size = new System.Drawing.Size(643, 70);
            this.dgvBackreference.TabIndex = 63;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewCellStyle62.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle62;
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
            this.tabPage7.Controls.Add(this.dataGridView1);
            this.tabPage7.Controls.Add(this.label7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(652, 106);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "字符转义";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle64.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle64.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle64.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle64;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 25;
            dataGridViewCellStyle66.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle66;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(643, 47);
            this.dataGridView1.TabIndex = 65;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewCellStyle65.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle65;
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
            this.tabPage6.Controls.Add(this.dgbAlternationConstruct);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(652, 106);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "替换构造";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgbAlternationConstruct
            // 
            this.dgbAlternationConstruct.AllowUserToAddRows = false;
            this.dgbAlternationConstruct.AllowUserToDeleteRows = false;
            this.dgbAlternationConstruct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbAlternationConstruct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgbAlternationConstruct.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgbAlternationConstruct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgbAlternationConstruct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle67.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle67.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle67.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle67.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle67.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle67.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbAlternationConstruct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle67;
            this.dgbAlternationConstruct.ColumnHeadersHeight = 25;
            this.dgbAlternationConstruct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dgbAlternationConstruct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgbAlternationConstruct.Location = new System.Drawing.Point(6, 30);
            this.dgbAlternationConstruct.Name = "dgbAlternationConstruct";
            this.dgbAlternationConstruct.RowHeadersVisible = false;
            this.dgbAlternationConstruct.RowHeadersWidth = 25;
            dataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbAlternationConstruct.RowsDefaultCellStyle = dataGridViewCellStyle69;
            this.dgbAlternationConstruct.RowTemplate.Height = 23;
            this.dgbAlternationConstruct.Size = new System.Drawing.Size(643, 47);
            this.dgbAlternationConstruct.TabIndex = 64;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewCellStyle68.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle68;
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
            this.tabPage8.Controls.Add(this.dgbAlternation);
            this.tabPage8.Controls.Add(this.label10);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(652, 106);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "替换";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dgbAlternation
            // 
            this.dgbAlternation.AllowUserToAddRows = false;
            this.dgbAlternation.AllowUserToDeleteRows = false;
            this.dgbAlternation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbAlternation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgbAlternation.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgbAlternation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgbAlternation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle70.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle70.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle70.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle70.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle70.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbAlternation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle70;
            this.dgbAlternation.ColumnHeadersHeight = 25;
            this.dgbAlternation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.Column3,
            this.Column4});
            this.dgbAlternation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgbAlternation.Location = new System.Drawing.Point(6, 30);
            this.dgbAlternation.Name = "dgbAlternation";
            this.dgbAlternation.RowHeadersVisible = false;
            this.dgbAlternation.RowHeadersWidth = 25;
            dataGridViewCellStyle72.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbAlternation.RowsDefaultCellStyle = dataGridViewCellStyle72;
            this.dgbAlternation.RowTemplate.Height = 23;
            this.dgbAlternation.Size = new System.Drawing.Size(643, 47);
            this.dgbAlternation.TabIndex = 65;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewCellStyle71.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle71;
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
            this.tabPage9.Controls.Add(this.linkLabel1);
            this.tabPage9.Controls.Add(this.label11);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(652, 106);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "About";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(218, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(407, 12);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://msdn.microsoft.com/zh-cn/library/az24scfc%28v=vs.110%29.aspx";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "点击每行首列可粘贴到文本框，\r\n选择每个单元格可以ctrl+c、ctrl+v";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 500);
            this.Controls.Add(this.tabResultAndQuickRef);
            this.Controls.Add(this.rtbRegex);
            this.Controls.Add(this.rtbReplace);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblMatches);
            this.Controls.Add(this.rtbSource);
            this.Controls.Add(this.Label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbAlternationConstruct)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbAlternation)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public void ExecuteCommand()
        {
            Stopwatch stopwatch = new Stopwatch();
            string text = "";
            string[] array = null;
            try
            {
                this.re = new Regex(this.rtbRegex.Text, this.Options.RegexOptions);
            }
            catch (Exception expr_34)
            {
                ProjectData.SetProjectError(expr_34);
                Exception ex = expr_34;
                this.staMatches.Text = "Parsing Error";
                MessageBox.Show(ex.Message, "Parsing error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
                return;
            }
            MatchCollection matchCollection;
            try
            {
                stopwatch.Start();
                matchCollection = this.re.Matches(this.rtbSource.Text);
                int count = matchCollection.Count;
                stopwatch.Stop();
                if (this.Options.Command == Command.Replace)
                {
                    stopwatch.Start();
                    text = this.re.Replace(this.rtbSource.Text, this.rtbReplace.Text);
                    stopwatch.Stop();
                }
                else
                {
                    if (this.Options.Command == Command.Split)
                    {
                        array = this.re.Split(this.rtbSource.Text);
                        stopwatch.Start();
                        stopwatch.Stop();
                    }
                }
                this.staExecutionTime.Text = string.Format("Execution: {0} msecs.   ", stopwatch.ElapsedMilliseconds);
                this.staMatches.Text = string.Format("Found {0} matches   ", count);
            }
            catch (Exception expr_151)
            {
                ProjectData.SetProjectError(expr_151);
                Exception ex2 = expr_151;
                this.staMatches.Text = "Execution error";
                MessageBox.Show(ex2.Message, "Execution error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
                return;
            }
            List<Match> list = new List<Match>();
            IEnumerator enumerator = matchCollection.GetEnumerator();
            try
            {

                while (enumerator.MoveNext())
                {
                    Match item = (Match)enumerator.Current;
                    list.Add(item);
                }
            }
            finally
            {

                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            this.Refresh();
            int num = 0;
            switch (this.Options.Sort)
            {
                case SortOption.Alphabetic:
                    list.Sort(new AlphaComparer());
                    break;
                case SortOption.ShortestFirst:
                    list.Sort(new ShortestComparer());
                    break;
                case SortOption.LargestFirst:
                    list.Sort(new LargestComparer());
                    break;
            }
            this.tvwResults.Nodes.Clear();
            int arg_24B_0 = 0;
            checked
            {
                int num2 = list.Count - 1;
                for (int i = arg_24B_0; i <= num2; i++)
                {
                    Match match = list[i];
                    TreeNode treeNode = this.tvwResults.Nodes.Add(match.Value);
                    treeNode.Tag = new NodeInfo(match, i.ToString());
                    if (this.Options.Detail != DetailOption.NoDetails && match.Groups.Count > 0)
                    {
                        treeNode.Nodes.Add("*");
                    }
                    num++;
                    if (num == this.Options.MaxMatches)
                    {
                        break;
                    }
                }
                if (matchCollection.Count > this.Options.MaxMatches)
                {
                    this.staItemInfo.Text = string.Format("(Only the first {0} are displayed)", this.Options.MaxMatches);
                }
                num = 0;
                if (this.Options.Command == Command.Find)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    int arg_33B_0 = 0;
                    int num3 = list.Count - 1;
                    for (int j = arg_33B_0; j <= num3; j++)
                    {
                        Match match2 = list[j];
                        stringBuilder.AppendFormat("MATCH[{0}]: '{1}'   [index={2}]", j, match2.Value, match2.Index);
                        stringBuilder.AppendLine();
                        if (this.Options.Detail != DetailOption.NoDetails)
                        {
                            int arg_3A0_0 = 1;
                            int num4 = match2.Groups.Count - 1;
                            for (int k = arg_3A0_0; k <= num4; k++)
                            {
                                Group group = match2.Groups[k];
                                if (group.Length != 0 || this.Options.IncludeEmptyGroups)
                                {
                                    stringBuilder.AppendFormat("   GROUP[{0}]: '{1}'   [index={2}]", this.re.GroupNameFromNumber(k), group.Value, group.Index);
                                    stringBuilder.AppendLine();
                                    if (this.Options.Detail != DetailOption.Groups)
                                    {
                                        int arg_429_0 = 0;
                                        int num5 = group.Captures.Count - 1;
                                        for (int l = arg_429_0; l <= num5; l++)
                                        {
                                            Capture capture = group.Captures[l];
                                            stringBuilder.AppendFormat("      CAPTURE[{0}]: '{1}'   [index={2}]", l, capture.Value, capture.Index);
                                            stringBuilder.AppendLine();
                                        }
                                    }
                                }
                            }
                            num++;
                            if (num == this.Options.MaxMatches)
                            {
                                break;
                            }
                        }
                    }
                    text = stringBuilder.ToString();
                }
                else
                {
                    if (this.Options.Command == Command.Split)
                    {
                        StringBuilder stringBuilder2 = new StringBuilder();
                        string[] array2 = array;
                        for (int m = 0; m < array2.Length; m++)
                        {
                            object obj = array2[m];
                            stringBuilder2.AppendFormat("[{0,3}]: {1}", num, RuntimeHelpers.GetObjectValue(obj));
                            stringBuilder2.AppendLine();
                            num++;
                            if (num == this.Options.MaxMatches)
                            {
                                break;
                            }
                        }
                        text = stringBuilder2.ToString();
                    }
                }
                this.rtbResults.Text = text;
                this.rtbResults.Select(0, 0);
            }
        }
        public void UpdateOptionFiels()
        {
            this.Options.RegexText = this.rtbRegex.Text;
            this.Options.ReplaceText = this.rtbReplace.Text;
            this.Options.SourceText = this.rtbSource.Text;
        }
        public bool OkToProceed()
        {
            this.UpdateOptionFiels();
            bool result = false;
            if (!this.Options.HasChanged)
            {
                result = true;
            }
            else
            {
                string text = string.Format("Current regex has been modified.{0}{0}Do you wish to save it?", "\r\n");
                switch (MessageBox.Show(text, "Confirm action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Cancel:
                        result = false;
                        break;
                    case DialogResult.Yes:
                        result = this.SaveRegex(this.Options.RegexFile);
                        break;
                    case DialogResult.No:
                        result = true;
                        break;
                }
            }
            return result;
        }
        public bool OpenRegex(string fileName)
        {
            bool result;
            if (string.IsNullOrEmpty(fileName))
            {
                if (this.dlgOpenRegex.ShowDialog() != DialogResult.OK)
                {
                    result = false;
                    return result;
                }
                fileName = this.dlgOpenRegex.FileName;
            }
            try
            {
                this.Options = ProjectOptions.Load(fileName);
                this.RefreshControlState();
                result = true;
            }
            catch (Exception expr_3F)
            {
                ProjectData.SetProjectError(expr_3F);
                Exception ex = expr_3F;
                MessageBox.Show(ex.Message, "Unable to open regex file", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                result = false;
                ProjectData.ClearProjectError();
            }
            return result;
        }
        public bool SaveRegex(string fileName)
        {
            bool result;
            if (this.Options.RegexName.Length == 0)
            {
                string text = Interaction.InputBox("Please assign a name to the current regex", "Saving Regex file", "", -1, -1);
                if (Operators.CompareString(text, "", false) == 0)
                {
                    MessageBox.Show("Current regex hasn't been saved.", "Missing regex name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    result = false;
                    return result;
                }
                this.Options.RegexName = text;
            }
            if (string.IsNullOrEmpty(fileName))
            {
                if (this.dlgSaveRegex.ShowDialog() != DialogResult.OK)
                {
                    result = false;
                    return result;
                }
                fileName = this.dlgSaveRegex.FileName;
            }
            try
            {
                this.Options.Save(fileName);
                this.RefreshControlState();
                result = true;
            }
            catch (Exception expr_9B)
            {
                ProjectData.SetProjectError(expr_9B);
                Exception ex = expr_9B;
                MessageBox.Show(ex.Message, "Unable to save regex file", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                result = false;
                ProjectData.ClearProjectError();
            }
            return result;
        }
        public void RefreshControlState()
        {
            this.rtbRegex.Text = this.Options.RegexText;
            this.rtbReplace.Text = this.Options.ReplaceText;
            this.rtbSource.Text = this.Options.SourceText;
            this.RefreshOptionsState();
            string title = MyProject.Application.Info.Title;
            if (string.IsNullOrEmpty(this.Options.RegexName))
            {
                this.Text = title + " - (unnamed regex)";
            }
            else
            {
                this.Text = title + " - " + this.Options.RegexName;
            }
        }
        public void RefreshOptionsState()
        {
            this.mnuEditWordWrap.Checked = this.Options.WordWrap;
            this.mnuCommandsFind.Checked = (this.Options.Command == Command.Find);
            this.mnuCommandsReplace.Checked = (this.Options.Command == Command.Replace);
            this.mnuCommandsSplit.Checked = (this.Options.Command == Command.Split);
            this.mnuOptionsCompiled.Checked = ((this.Options.RegexOptions & RegexOptions.Compiled) == RegexOptions.Compiled);
            this.mnuOptionsCultureInvariant.Checked = ((this.Options.RegexOptions & RegexOptions.CultureInvariant) == RegexOptions.CultureInvariant);
            this.mnuOptionsEcmaScript.Checked = ((this.Options.RegexOptions & RegexOptions.ECMAScript) == RegexOptions.ECMAScript);
            this.mnuOptionsExplicitCapture.Checked = ((this.Options.RegexOptions & RegexOptions.ExplicitCapture) == RegexOptions.ExplicitCapture);
            this.mnuOptionsIgnoreCase.Checked = ((this.Options.RegexOptions & RegexOptions.IgnoreCase) == RegexOptions.IgnoreCase);
            this.mnuOptionsIgnoreWhitespace.Checked = ((this.Options.RegexOptions & RegexOptions.IgnorePatternWhitespace) == RegexOptions.IgnorePatternWhitespace);
            this.mnuOptionsMultiline.Checked = ((this.Options.RegexOptions & RegexOptions.Multiline) == RegexOptions.Multiline);
            this.mnuOptionsRightToLeft.Checked = ((this.Options.RegexOptions & RegexOptions.RightToLeft) == RegexOptions.RightToLeft);
            this.mnuResultsAuto.Checked = (this.Options.Format == FormatOption.Auto);
            this.mnuResultsTreeView.Checked = (this.Options.Format == FormatOption.TreeView);
            this.mnuResultsReport.Checked = (this.Options.Format == FormatOption.Report);
            this.mnuResultsNoDetails.Checked = (this.Options.Detail == DetailOption.NoDetails);
            this.mnuResultsGroups.Checked = (this.Options.Detail == DetailOption.Groups);
            this.mnuResultsCaptures.Checked = (this.Options.Detail == DetailOption.GroupAndCaptures);
            this.txtViewMaxMatches.Text = this.Options.MaxMatches.ToString();
            this.mnuResultsIncludeEmptyGroups.Checked = this.Options.IncludeEmptyGroups;
            this.mnuResultsDontSort.Checked = (this.Options.Sort == SortOption.Position);
            this.mnuResultsSortAlphabetically.Checked = (this.Options.Sort == SortOption.Alphabetic);
            this.mnuResultsShortest.Checked = (this.Options.Sort == SortOption.ShortestFirst);
            this.mnuResultsLargest.Checked = (this.Options.Sort == SortOption.LargestFirst);
            this.tvwResults.Visible = (this.Options.Format == FormatOption.TreeView || (this.Options.Format == FormatOption.Auto && this.Options.Command == Command.Find));
            this.rtbResults.Visible = !this.tvwResults.Visible;
            this.staItemInfo.Visible = this.tvwResults.Visible;
            if (this.tvwResults.Visible)
            {
                this.lblMatches.Text = "Matches";
            }
            else
            {
                this.lblMatches.Text = "Report";
            }
            checked
            {
                if (this.Options.Command == Command.Replace)
                {
                    //Control arg_350_0 = this.rtbRegex;
                    Size size = new Size(this.rtbRegex.Width, this.rtbReplace.Top - this.rtbRegex.Top - 10);
                    this.rtbRegex.Size = size;
                    this.rtbReplace.Visible = true;
                    this.lblReplace.Visible = true;
                }
                else
                {
                    //Control arg_39F_0 = this.rtbRegex;
                    Size size = new Size(this.rtbRegex.Width, this.rtbReplace.Bottom - this.rtbRegex.Top);
                    this.rtbRegex.Size = size;
                    this.rtbReplace.Visible = false;
                    this.lblReplace.Visible = false;
                }
                this.rtbRegex.WordWrap = this.Options.WordWrap;
                this.rtbReplace.WordWrap = this.Options.WordWrap;
                this.rtbSource.WordWrap = this.Options.WordWrap;
                this.rtbResults.WordWrap = this.Options.WordWrap;
                if (this.Options.WordWrap)
                {
                    this.rtbRegex.ScrollBars = RichTextBoxScrollBars.Vertical;
                    this.rtbReplace.ScrollBars = RichTextBoxScrollBars.Vertical;
                    this.rtbSource.ScrollBars = RichTextBoxScrollBars.Vertical;
                    this.rtbResults.ScrollBars = RichTextBoxScrollBars.Vertical;
                }
                else
                {
                    this.rtbRegex.ScrollBars = RichTextBoxScrollBars.Both;
                    this.rtbReplace.ScrollBars = RichTextBoxScrollBars.Both;
                    this.rtbSource.ScrollBars = RichTextBoxScrollBars.Both;
                    this.rtbResults.ScrollBars = RichTextBoxScrollBars.Both;
                }
            }
        }
        public void BuildRegexMenu()
        {
            Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("RegexTester.Regexes.xml");
            StreamReader streamReader = new StreamReader(manifestResourceStream);
            string xml = streamReader.ReadToEnd();
            streamReader.Close();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);
            this.BuildRegexMenu_Sub(xmlDocument, this.ctxPattern, 1);
            this.BuildRegexMenu_Sub(xmlDocument, this.ctxReplace, 2);
        }
        public void BuildRegexMenu_Sub(XmlDocument xmlDoc, ContextMenuStrip rootMenu, int bitMask)
        {
            IEnumerator enumerator = xmlDoc.SelectNodes("//group").GetEnumerator();
            try
            {

                while (enumerator.MoveNext())
                {
                    XmlElement xmlElement = (XmlElement)enumerator.Current;
                    int num = Conversions.ToInteger(xmlElement.GetAttribute("includeBits"));
                    if ((num & bitMask) != 0)
                    {
                        string text = xmlElement.GetAttribute("text").Replace("§", "&");
                        if (Operators.CompareString(text, "-", false) == 0)
                        {
                            rootMenu.Items.Add(new ToolStripSeparator());
                        }
                        else
                        {
                            string toolTipText = xmlElement.GetAttribute("toolTip").Replace("§", "\r\n");
                            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(text);
                            toolStripMenuItem.ToolTipText = toolTipText;
                            rootMenu.Items.Add(toolStripMenuItem);
                            IEnumerator enumerator2 = xmlElement.SelectNodes("item").GetEnumerator();
                            try
                            {

                                while (enumerator2.MoveNext())
                                {
                                    XmlElement xmlElement2 = (XmlElement)enumerator2.Current;
                                    string text2 = xmlElement2.GetAttribute("text").Replace("§", "&");
                                    if (Operators.CompareString(text2, "-", false) == 0)
                                    {
                                        toolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
                                    }
                                    else
                                    {
                                        string toolTipText2 = xmlElement2.GetAttribute("toolTip").Replace("§", "\r\n");
                                        string attribute = xmlElement2.GetAttribute("regex");
                                        ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(text2);
                                        toolStripMenuItem2.ToolTipText = toolTipText2;
                                        toolStripMenuItem2.Tag = attribute;
                                        toolStripMenuItem.DropDownItems.Add(toolStripMenuItem2);
                                        toolStripMenuItem2.Click += new EventHandler(this.RegexMenu_Click);
                                    }
                                }
                            }
                            finally
                            {
                                ;
                                if (enumerator2 is IDisposable)
                                {
                                    (enumerator2 as IDisposable).Dispose();
                                }
                            }
                        }
                    }
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
        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            if (this.OkToProceed())
            {
                this.Options = new ProjectOptions();
                this.Options.ClearChanges();
                this.RefreshControlState();
            }
        }
        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            if (this.OkToProceed())
            {
                this.OpenRegex(null);
            }
        }
        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            this.UpdateOptionFiels();
            this.SaveRegex(this.Options.RegexFile);
        }
        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            this.UpdateOptionFiels();
            this.SaveRegex(null);
        }
        private void mnuFileLoad_Click(object sender, EventArgs e)
        {
            if (this.dlgOpenDoc.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.Options.SourceText = File.ReadAllText(this.dlgOpenDoc.FileName);
                    this.rtbSource.Text = this.Options.SourceText;
                }
                catch (Exception expr_43)
                {
                    ProjectData.SetProjectError(expr_43);
                    Exception ex = expr_43;
                    MessageBox.Show(ex.Message, "Unable to load document", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    ProjectData.ClearProjectError();
                }
            }
        }
        private void mnuFileProperties_Click(object sender, EventArgs e)
        {
            this.UpdateOptionFiels();
            if (new PropertiesForm
            {
                Options = this.Options
            }.ShowDialog() != DialogResult.Cancel)
            {
                this.RefreshControlState();
            }
        }
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            if (this.OkToProceed())
            {
                Application.Exit();
            }
        }
        private void mnuEditWordWrap_Click(object sender, EventArgs e)
        {
            this.Options.WordWrap = !this.Options.WordWrap;
            this.RefreshOptionsState();
        }

        private void mnuEditRegularHelper_Click(object sender, EventArgs e)
        {
            //RegularHelper.RegularHelperForm helper = new RegularHelper.RegularHelperForm();
            //helper.rtbRegex = this.rtbRegex;
            //helper.Show(this);
            //this.rtbRegex

        }

        private void mnuCommandsRun_Click(object sender, EventArgs e)
        {
            this.ExecuteCommand();
        }
        private void mnuCommandsFind_Click(object sender, EventArgs e)
        {
            if (this.Options.Command != Command.Find)
            {
                this.Options.Command = Command.Find;
                this.rtbResults.Clear();
                this.RefreshOptionsState();
            }
        }
        private void mnuCommandsReplace_Click(object sender, EventArgs e)
        {
            if (this.Options.Command != Command.Replace)
            {
                this.Options.Command = Command.Replace;
                this.rtbResults.Clear();
                this.RefreshOptionsState();
            }
        }
        private void mnuCommandsSplit_Click(object sender, EventArgs e)
        {
            if (this.Options.Command != Command.Split)
            {
                this.Options.Command = Command.Split;
                this.rtbResults.Clear();
                this.RefreshOptionsState();
            }
        }
        private void mnuCommandsShowGroups_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            checked
            {
                try
                {
                    Regex regex = new Regex(this.rtbRegex.Text);
                    string[] groupNames = regex.GetGroupNames();
                    int arg_26_0 = 0;
                    int num = groupNames.Length - 1;
                    for (int i = arg_26_0; i <= num; i++)
                    {
                        if (Operators.CompareString(groupNames[i], i.ToString(), false) == 0)
                        {
                            stringBuilder.AppendFormat("group[{0}]", i);
                        }
                        else
                        {
                            stringBuilder.AppendFormat("group[{0}] = {1}", i, groupNames[i]);
                        }
                        stringBuilder.AppendLine();
                    }
                    MessageBox.Show(stringBuilder.ToString(), "Capturing Groups", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception expr_8B)
                {
                    ProjectData.SetProjectError(expr_8B);
                    ProjectData.ClearProjectError();
                }
            }
        }
        private void mnuCommandsEscape_Click(object sender, EventArgs e)
        {
            this.UpdateOptionFiels();
            new EscapeForm
            {
                Options = this.Options
            }.ShowDialog();
        }
        private void mnuCommandsGenerateCode_Click(object sender, EventArgs e)
        {
            this.UpdateOptionFiels();
            new GenerateCodeForm
            {
                Options = this.Options
            }.ShowDialog();
        }
        private void mnuCommandsCompile_Click(object sender, EventArgs e)
        {
            if (this.CompileForm == null)
            {
                this.CompileForm = new CompileForm();
                this.CompileForm.MainForm = this;
            }
            this.CompileForm.Show();
        }
        private void mnuOptionsMultiline_Click(object sender, EventArgs e)
        {
            this.Options.RegexOptions = (this.Options.RegexOptions ^ RegexOptions.Multiline);
            this.RefreshOptionsState();
        }
        private void mnuOptionsIgnoreCase_Click(object sender, EventArgs e)
        {
            this.Options.RegexOptions = (this.Options.RegexOptions ^ RegexOptions.IgnoreCase);
            this.RefreshOptionsState();
        }
        private void mnuOptionsIgnoreWhitespace_Click(object sender, EventArgs e)
        {
            this.Options.RegexOptions = (this.Options.RegexOptions ^ RegexOptions.IgnorePatternWhitespace);
            this.RefreshOptionsState();
        }
        private void mnuOptionsCompiled_Click(object sender, EventArgs e)
        {
            this.Options.RegexOptions = (this.Options.RegexOptions ^ RegexOptions.Compiled);
            this.RefreshOptionsState();
        }
        private void mnuOptionsExplicitCapture_Click(object sender, EventArgs e)
        {
            this.Options.RegexOptions = (this.Options.RegexOptions ^ RegexOptions.ExplicitCapture);
            this.RefreshOptionsState();
        }
        private void mnuOptionsRightToLeft_Click(object sender, EventArgs e)
        {
            this.Options.RegexOptions = (this.Options.RegexOptions ^ RegexOptions.RightToLeft);
            this.RefreshOptionsState();
        }
        private void mnuOptionsCultureInvariant_Click(object sender, EventArgs e)
        {
            this.Options.RegexOptions = (this.Options.RegexOptions ^ RegexOptions.CultureInvariant);
            this.RefreshOptionsState();
        }
        private void mnuOptionsEcmaScript_Click(object sender, EventArgs e)
        {
            this.Options.RegexOptions = (this.Options.RegexOptions ^ RegexOptions.ECMAScript);
            this.RefreshOptionsState();
        }
        private void mnuResultsAuto_Click(object sender, EventArgs e)
        {
            this.Options.Format = FormatOption.Auto;
            this.RefreshOptionsState();
        }
        private void mnuResultsTreeView_Click(object sender, EventArgs e)
        {
            this.Options.Format = FormatOption.TreeView;
            this.RefreshOptionsState();
        }
        private void mnuResultsReport_Click(object sender, EventArgs e)
        {
            this.Options.Format = FormatOption.Report;
            this.RefreshOptionsState();
        }
        private void mnuResultsNoDetails_Click(object sender, EventArgs e)
        {
            this.Options.Detail = DetailOption.NoDetails;
            this.RefreshOptionsState();
        }
        private void mnuResultsGroups_Click(object sender, EventArgs e)
        {
            this.Options.Detail = DetailOption.Groups;
            this.RefreshOptionsState();
        }
        private void mnuResultsCaptures_Click(object sender, EventArgs e)
        {
            this.Options.Detail = DetailOption.GroupAndCaptures;
            this.RefreshOptionsState();
        }
        private void mnuResultsIncludeEmptyGroups_Click(object sender, EventArgs e)
        {
            this.Options.IncludeEmptyGroups = !this.Options.IncludeEmptyGroups;
            this.RefreshOptionsState();
        }
        private void mnuResultsDontSort_Click(object sender, EventArgs e)
        {
            this.Options.Sort = SortOption.Position;
            this.RefreshOptionsState();
        }
        private void mnuResultsSortAlphabetically_Click(object sender, EventArgs e)
        {
            this.Options.Sort = SortOption.Alphabetic;
            this.RefreshOptionsState();
        }
        private void mnuResultsShortest_Click(object sender, EventArgs e)
        {
            this.Options.Sort = SortOption.ShortestFirst;
            this.RefreshOptionsState();
        }
        private void mnuResultsLargest_Click(object sender, EventArgs e)
        {
            this.Options.Sort = SortOption.LargestFirst;
            this.RefreshOptionsState();
        }
        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutBoxForm aboutBoxForm = new AboutBoxForm();
            aboutBoxForm.ShowDialog();
        }
        private void RegexMenu_Click(object sender, EventArgs e)
        {
            ToolStrip owner = ((ToolStripMenuItem)sender).OwnerItem.Owner;
            RichTextBox richTextBox = this.rtbRegex;
            if (owner == this.ctxReplace)
            {
                richTextBox = this.rtbReplace;
            }
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            string text = Conversions.ToString(toolStripMenuItem.Tag);
            int selectionStart = this.rtbRegex.SelectionStart;
            richTextBox.SelectedText = text.Replace("§", "");
            int num = text.IndexOf("§");
            checked
            {
                if (num >= 0)
                {
                    int num2 = text.IndexOf("§", num + 1);
                    richTextBox.Select(selectionStart + num, num2 - num - 1);
                }
            }
        }
        private void tvwResults_AfterSelect(object sender, TreeViewEventArgs e)
        {
            NodeInfo nodeInfo = (NodeInfo)e.Node.Tag;
            string text = nodeInfo.Item.GetType().Name.ToUpper();
            this.staItemInfo.Text = string.Format("{0}[{1}]: Index={2}, Length={3}", new object[]
			{
				text,
				nodeInfo.Name,
				nodeInfo.Item.Index,
				nodeInfo.Item.Length
			});
            this.rtbSource.Select(nodeInfo.Item.Index, nodeInfo.Item.Length);
            this.rtbSource.ScrollToCaret();
        }
        private void tvwResults_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            checked
            {
                if (e.Node.Nodes.Count == 1 || Operators.CompareString(e.Node.Nodes[0].Text, "*", false) == 0)
                {
                    e.Node.Nodes.Clear();
                    NodeInfo nodeInfo = (NodeInfo)e.Node.Tag;
                    if (nodeInfo.Item.GetType() == typeof(Match))
                    {
                        Match match = (Match)nodeInfo.Item;
                        int arg_93_0 = 1;
                        int num = match.Groups.Count - 1;
                        for (int i = arg_93_0; i <= num; i++)
                        {
                            Group group = match.Groups[i];
                            if (group.Length != 0 || this.Options.IncludeEmptyGroups)
                            {
                                TreeNode treeNode = e.Node.Nodes.Add(group.Value);
                                treeNode.Tag = new NodeInfo(group, this.re.GroupNameFromNumber(i));
                                if (this.Options.Detail == DetailOption.GroupAndCaptures && group.Captures.Count > 0)
                                {
                                    treeNode.Nodes.Add("*");
                                }
                            }
                        }
                    }
                    else
                    {
                        if (nodeInfo.Item.GetType() == typeof(Group))
                        {
                            Group group2 = (Group)nodeInfo.Item;
                            int arg_166_0 = 0;
                            int num2 = group2.Captures.Count - 1;
                            for (int j = arg_166_0; j <= num2; j++)
                            {
                                Capture capture = group2.Captures[j];
                                if (capture.GetType() != typeof(Group))
                                {
                                    TreeNode treeNode2 = e.Node.Nodes.Add(capture.Value);
                                    treeNode2.Tag = new NodeInfo(capture, j.ToString());
                                }
                            }
                        }
                    }
                }
            }
        }
        private void txtViewMaxMatches_Click(object sender, EventArgs e)
        {
            int maxMatches;
            if (int.TryParse(this.txtViewMaxMatches.Text, out maxMatches))
            {
                this.Options.MaxMatches = maxMatches;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Helpers.SetTooltipsAndHelpMessages(this, this.ToolTip1, this.HelpProvider1);
            this.BuildRegexMenu();
            this.rtbResults.Bounds = this.tvwResults.Bounds;
            this.staMatches.Text = "";
            this.staExecutionTime.Text = "";
            this.staItemInfo.Text = "";
            this.Options.ClearChanges();

            this.tvwResults.BeforeExpand += new TreeViewCancelEventHandler(this.tvwResults_BeforeExpand);
            this.tvwResults.AfterSelect += new TreeViewEventHandler(this.tvwResults_AfterSelect);
            InitQuickRef();
        }

        private void InitQuickRef()
        {
            dgvCharactorClass.Rows.Add(new string[] { "[char_group]", "匹配 char_group 中的任何单个字符。 默认情况下，匹配区分大小写。", "[ae]", "“gray”中的“a”“lane”中的“a”和“e”" });
            dgvCharactorClass.Rows.Add(new string[] { "[^char_group]", "非：与不在 char_group 中的任何单个字符匹配。 默认情况下，character_group 中的字符区分大小写。", "[^aei]", "“reign”中的“r”、“g”和“n”" });
            dgvCharactorClass.Rows.Add(new string[] { "[first-last]", "字符范围：与从 first 到 last 的范围中的任何单个字符匹配。", "[A-Z]", "“AB123”中的“A”和“B”" });
            dgvCharactorClass.Rows.Add(new string[] { ".", @"通配符：与除 \n 之外的任何单个字符匹配。若要匹配原意句点字符（. 或 \u002E），您必须在该字符前面加上转义符 (\.)。", "a.e", "“nave”中的“ave”,“water”中的“ate”" });
            dgvCharactorClass.Rows.Add(new string[] { @"\p{name}", "与 name 指定的 Unicode 通用类别或命名块中的任何单个字符匹配。", @"\p{Lu}\p{IsCyrillic}", "“City Lights”中的“C”和“L”,“ДЖem”中的“Д”和“Ж”" });

            dgvCharactorClass.Rows.Add(new string[] { @"\P{name}", "与不在 name 指定的 Unicode 通用类别或命名块中的任何单个字符匹配。", @"\P{Lu},\P{IsCyrillic}", "“City”中的“i”、“t”和“y”,“ДЖem”中的“e”和“m”" });
            dgvCharactorClass.Rows.Add(new string[] { @"\w", "与任何单词字符匹配。", @"\w", "“ID A1.3”中的“I”、“D”、“A”、“1”和“3”" });
            dgvCharactorClass.Rows.Add(new string[] { @"\W", "与任何非单词字符匹配。", @"\W", "“ID A1.3”中的“ ”、“.”" });
            dgvCharactorClass.Rows.Add(new string[] { @"\s", "与任何空白字符匹配。", @"\w\s", "“ID A1.3”中的“D”" });
            dgvCharactorClass.Rows.Add(new string[] { @"\S", "与任何非空白字符匹配。", @"\s\S", "“int __ctr”中的“ _”" });
            dgvCharactorClass.Rows.Add(new string[] { @"\d", "与任何十进制数字匹配。", @"\d", "“4 = IV”中的“4”" });
            dgvCharactorClass.Rows.Add(new string[] { @"\D", "匹配不是十进制数的任意字符。", @"\D", "“4 = IV”中的“ ”、“=”、“ ”、“I”和“V” " });

            //dgvAssertion.Rows.Add(new string[] { "[char_group]", "匹配 char_group 中的任何单个字符。 默认情况下，匹配区分大小写。", "[ae]", "“gray”中的“a”\n“lane”中的“a”和“e”" });
            dgvAssertion.Rows.Add(new string[] { "^", "匹配必须从字符串或一行的开头开始。", @"^\d{3}", "“901”,“901-”" });
            dgvAssertion.Rows.Add(new string[] { "$", "匹配必须出现在字符串的末尾或出现在行或字符串末尾的 \n 之前。", @"-\d{3}$", "“-901-333”中的“-333”" });
            dgvAssertion.Rows.Add(new string[] { @"\A", "匹配必须出现在字符串的开头。", @"\A\d{3}", "“901”,“901-”" });
            dgvAssertion.Rows.Add(new string[] { @"\Z", "匹配必须出现在字符串的末尾或出现在字符串末尾的 \n 之前。", @"-\d{3}\Z", "“-901-333”中的“-333”" });
            dgvAssertion.Rows.Add(new string[] { @"\z", "匹配必须出现在字符串的末尾。", @"-\d{3}\z", "“-901-333”中的“-333”" });
            dgvAssertion.Rows.Add(new string[] { @"\G", "匹配必须出现在上一个匹配结束的地方。", @"\G\(\d\)", "“(1)(3)(5)[7](9)”中的“(1)”、“(3)”、“(5)”" });
            dgvAssertion.Rows.Add(new string[] { @"\b", @"匹配必须出现在 \w（字母数字）和 \W（非字母数字）字符之间的边界上。", @"\b\w+\s\w+\b", "“them theme them them”中的“them them”、“them theme”" });
            dgvAssertion.Rows.Add(new string[] { @"\B", @"匹配不得出现在 \b 边界上。", @"\Bend\w*\b", "“end sends endure lender”中的“ends”和“ender” " });

            dgvQuantifiers.Rows.Add(new string[] { "*", "匹配上一个元素零次或多次。", "\\d*\\.\\d", "“.0”，“19.9”和“219.9”" });
            dgvQuantifiers.Rows.Add(new string[] { "+", "匹配上一个元素一次或多次。", "\"be+\"", "“been”中的“bee”，“bent”中的“be”" });
            dgvQuantifiers.Rows.Add(new string[] { "?", "匹配前面的元素零次或一次。", "\"rai?n\"", "“ran”和“rain”" });
            dgvQuantifiers.Rows.Add(new string[] { "{n}", "匹配上一个元素恰好 n 次。", "\",\\d{3}\"", "“1,043.6”中的“,043”，“9,876,543,210”中的“,876”、“,543”和“,210”" });
            dgvQuantifiers.Rows.Add(new string[] { "{n,}", "匹配上一个元素至少 n 次。", "\"\\d{2,}\"", "“166”，“29”和“1930”" });
            dgvQuantifiers.Rows.Add(new string[] { "{n,m}", "匹配上一个元素至少 n 次，但不多于 m 次。", "\"\\d{3,5}\"", "“166”、“17668” “193024”中的“19302”" });
            dgvQuantifiers.Rows.Add(new string[] { "*?", "匹配上一个元素零次或多次，但次数尽可能少。", "\\d*?\\.\\d", "“.0”，“19.9”和“219.9”" });
            dgvQuantifiers.Rows.Add(new string[] { "+?", "匹配上一个元素一次或多次，但次数尽可能少。", "\"be+?\"", "“been”中的“be”，“bent”中的“be”" });
            dgvQuantifiers.Rows.Add(new string[] { "??", "匹配上一个元素零次或一次，但次数尽可能少。", "\"rai??n\"", "“ran”和“rain”" });
            dgvQuantifiers.Rows.Add(new string[] { "{n}?", "匹配前导元素恰好 n 次。", "\",\\d{3}?\"", "“1,043.6”中的“,043”，“9,876,543,210”中的“,876”、“,543”和“,210”" });
            dgvQuantifiers.Rows.Add(new string[] { "{n,}?", "匹配上一个元素至少 n 次，但次数尽可能少。", "\"\\d{2,}?\"", "“166”，“29”和“1930”" });
            dgvQuantifiers.Rows.Add(new string[] { "{n ,m}?", "匹配上一个元素的次数介于 n 和 m 之间，但次数尽可能少。", "\"\\d{3,5}?\"", "“166”、“17668” “193024”中的“193”、“024” " });

            dgvBackreference.Rows.Add(new string[] { @"\number", "后向引用。 匹配编号子表达式的值。", @"(\w)\1", "“seek”中的“ee”" });
            dgvBackreference.Rows.Add(new string[] { @"\k<name>", "命名后向引用。 匹配命名表达式的值。", @"(?<char>\w)\k<char>", "“seek”中的“ee” " });

            dgbAlternationConstruct.Rows.Add(new string[] { @"|", "匹配以竖线 (|) 字符分隔的任何一个元素。", "th(e|is|at)", "“this is the day.”中的“the”和“this””" });
            dgbAlternationConstruct.Rows.Add(new string[] { @"(?(expression) yes | no )", "如果正则表达式模式由 expression 匹配指定，则匹配 yes；否则匹配可选 no 部件。 expression 被解释为零宽度断言。", "(?(A)A\\d{2}\\b|\\b\\d{3}\\b)", "“A10 C103 910”中的“A10”和“910”" });
            dgbAlternationConstruct.Rows.Add(new string[] { @"(?(name) yes | no )", "如果 name 或已命名或已编号的捕获组具有匹配，则匹配 yes；否则匹配可选 no。", "(?<quoted>\")?(?(quoted).+?\"|\\S+\\s)", "“Dogs.jpg \"Yiska playing.jpg\"”中的 Dogs.jpg 和 \"Yiska playing.jpg\" " });

            dgbAlternation.Rows.Add(new string[] { "$number", "替换按组 number 匹配的子字符串。", @"\b(\w+)(\s)(\w+)\b", "$3$2$1", "\"one two\"", "\"two one\"" });
            dgbAlternation.Rows.Add(new string[] { "${name}", "替换按命名组 name 匹配的子字符串。", @"\b(?<word1>\w+)(\s)(?<word2>\w+)\b", "${word2} ${word1}", "\"one two\"", "\"two one\"" });
            dgbAlternation.Rows.Add(new string[] { "$$", "替换字符“$”。", @"\b(\d+)\s?USD", "$$$1", "“103 USD”", "“$103”" });
            dgbAlternation.Rows.Add(new string[] { "$&", "替换整个匹配项的一个副本。", @"(\$*(\d*(\.+\d+)?){1})", "**$&", "“$1.30”", "“**$1.30**”" });
            dgbAlternation.Rows.Add(new string[] { "$`", "替换匹配前的输入字符串的所有文本。", "B+", "$`", "“AABBCC”", "“AAAACC”" });
            dgbAlternation.Rows.Add(new string[] { "$'", "替换匹配后的输入字符串的所有文本。", "B+", "$'", "“AABBCC”", "“AACCCC”" });
            dgbAlternation.Rows.Add(new string[] { "$+", "替换最后捕获的组。", "B+(C+)", "$+", "“AABBCCDD”", "AACCDD" });
            dgbAlternation.Rows.Add(new string[] { "$_", "替换整个输入字符串。", "B+", "$_", "“AABBCC”", "“AAAABBCCCC” " });

            dgvGroupingConstruct.Rows.Add(new string[] { "(subexpression)", "捕获匹配的子表达式并将其分配到一个从零开始的序号中。", @"(\w)\1", "“deep”中的“ee”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?<name>subexpression)", "将匹配的子表达式捕获到一个命名组中。", @"(?<double>\w)\k<double>", "“deep”中的“ee”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?<name1-name2>subexpression)", "定义平衡组定义。 有关更多信息，请参见正则表达式中的分组构造中的“平衡组定义”部分。", @"(((?'Open'\()[^\(\)]*)+((?'Close-Open'\))[^\(\)]*)+)*(?(Open)(?!))$", "“3+2^((1-3)*(3-1))”中的“((1-3)*(3-1))”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?:subexpression)", "定义非捕获组。", "Write(?:Line)?", "“Console.WriteLine()”中的“WriteLine”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?imnsx-imnsx:subexpression)", "应用或禁用 subexpression 中指定的选项。 有关更多信息，请参见正则表达式选项。", @"A\d{2}(?i:\w+)\b", "“A12xl A12XL a12xl”中的“A12xl”和“A12XL”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?=subexpression)", "零宽度正预测先行断言。", @"\w+(?=\.)", "“He is. The dog ran. The sun is out.”中的“is”、“ran”和“out”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?!subexpression)", "零宽度负预测先行断言。", @"\b(?!un)\w+\b", "“unsure sure unity used”中的“sure”和“used”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?<=subexpression)", "零宽度正回顾后发断言。", @"(?<=19)\d{2}\b", "“1851 1999 1950 1905 2003”中的“99”、“50”和“05”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?<!subexpression)", "零宽度负回顾后发断言。", @"(?<!19)\d{2}\b", "“1851 1999 1950 1905 2003”中的“51”和“03”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?>subexpression)", "非回溯（也称为“贪婪”）子表达式。", "[13579](?>A+B+)", "“1ABB 3ABBC 5AB 5AC”中的“1ABB”、“3ABB”和“5AB” " });
        
        }
    }
}
