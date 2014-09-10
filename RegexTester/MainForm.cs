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
using QWhale.Editor.TextSource;
using QWhale.Editor;
using QWhale.Syntax;
namespace RegexTester
{
    [DesignerGenerated]
    public partial class MainForm : Form
    {


        //[AccessedThroughProperty("mnuFileNew")]
        //private ToolStripMenuItem _mnuFileNew;

        internal Regex re;
        internal ProjectOptions Options;

        internal CompileForm CompileForm;

        public MainForm()
        {
            base.Load += new EventHandler(this.MainForm_Load);
            this.Options = new ProjectOptions();
            this.InitializeComponent();
            RefreshOptionsState();
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

            checked
            {
                int num2 = list.Count - 1;
                for (int i = 0; i <= num2; i++)
                {
                    Match match = list[i];
                    string nodeText = "";
                    if (match.Value.Length > 512)
                    {
                        nodeText = match.Value.Substring(0, 512);
                    }
                    else
                    {
                        nodeText = match.Value;
                    }
                    TreeNode treeNode = this.tvwResults.Nodes.Add(nodeText);
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
                    tableLayoutPanel1.RowStyles[1].Height = 50;
                    //Control arg_350_0 = this.rtbRegex;
                    Size size = new Size(this.rtbRegex.Width, this.rtbReplace.Top - this.rtbRegex.Top - 10);
                    this.rtbRegex.Size = size;
                    this.rtbReplace.Visible = true;
                    this.lblReplace.Visible = true;
                }
                else
                {
                    tableLayoutPanel1.RowStyles[1].Height = 1;

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
                    //this.rtbSource.ScrollBars = RichTextBoxScrollBars.Vertical;
                    this.rtbResults.ScrollBars = RichTextBoxScrollBars.Vertical;
                }
                else
                {
                    this.rtbRegex.ScrollBars = RichTextBoxScrollBars.Both;
                    this.rtbReplace.ScrollBars = RichTextBoxScrollBars.Both;
                    //this.rtbSource.ScrollBars = RichTextBoxScrollBars.Both;
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

            //this.rtbSource.Select(nodeInfo.Item.Index, nodeInfo.Item.Length);
            //this.rtbSource.ScrollToCaret();
            //this.rtbSource.Focus();
            var position = this.rtbSource.Source.AbsolutePositionToTextPoint(nodeInfo.Item.Index);
            var len = nodeInfo.Item.Length;
            this.rtbSource.Source.BeginUpdate(QWhale.Editor.TextSource.UpdateReason.Navigate);
            try
            {
                ITextSource source = this.rtbSource.Source;
                source.State |= NotifyState.CenterLine;
                //if ((QWhale.Editor.TextSource.SearchOptions.BackwardSearch & options) != QWhale.Editor.TextSource.SearchOptions.None)
                //{
                this.rtbSource.Source.Position = position;
                //}
                //else
                //{
                //    this.rtbSource.Source.Position = new Point(position.X + len, position.Y);
                //}
            }
            finally
            {
                this.rtbSource.Source.EndUpdate();
            }
            if (this.rtbSource.Selection.UpdateCount == 0)
            {
                this.rtbSource.Selection.UpdateSelStart(position);
                this.rtbSource.Selection.SetSelection(SelectionType.Stream, new Rectangle(position.X, position.Y, len, 0));
                // if (multiline)
                {
                    this.rtbSource.Selection.SelectionLength = len;
                }

            }
            //this.rtbSource.MoveTo(p);
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



        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var dataGridView = sender as DataGridView;
                if (dataGridView.SelectedCells[0].ColumnIndex == 0)
                {
                    //rtbRegex.Text = rtbRegex.Text + dataGridView.SelectedCells[0].Value.ToString();
                    string text = dataGridView.SelectedCells[0].Value.ToString();
                    int index = rtbRegex.SelectionStart;

                    if (index < 0 || index > rtbRegex.Text.Length)
                    {
                        return;
                    }
                    if (rtbRegex.SelectionLength > 0)
                    {
                        rtbRegex.Text = rtbRegex.Text.Remove(index, rtbRegex.SelectionLength);
                    }
                    rtbRegex.Text = rtbRegex.Text.Insert(index, text);
                    rtbRegex.Select(index, text.Length);
                }
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
            dgvAlternation.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);
            dgvAlternationConstruct.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);
            dgvAssertion.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);
            dgvBackreference.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);
            dgvCharactorClass.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);
            dgvGroupingConstruct.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);
            dgvQuantifiers.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);


            /*
            QWhale.Syntax.HtmlParser _htmlParser = new HtmlParser();
            
            rtbSource.Lexer = _htmlParser;
            this.rtbSource.BackColor = System.Drawing.SystemColors.Window;
            this.rtbSource.Braces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rtbSource.Cursor = System.Windows.Forms.Cursors.IBeam;
            //this.rtbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSource.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));

            this.rtbSource.Outlining.AllowOutlining = false;
            this.rtbSource.Gutter.BrushColor = System.Drawing.SystemColors.Window;
            this.rtbSource.Gutter.LineNumbersBackColor = System.Drawing.SystemColors.GrayText;

            this.rtbSource.Gutter.WrapImageIndex = -1;
            this.rtbSource.Gutter.Options=QWhale.Editor.GutterOptions.None;
            this.rtbSource.Gutter.Options = ((QWhale.Editor.GutterOptions)(((QWhale.Editor.GutterOptions.PaintLinesOnGutter | QWhale.Editor.GutterOptions.PaintBookMarks)
                        | QWhale.Editor.GutterOptions.PaintLineModificators | GutterOptions.PaintLineNumbers)));
            this.rtbSource.LineSeparator.Options = QWhale.Editor.SeparatorOptions.None;//.SeparateContent;
            */
            QWhale.Syntax.HtmlParser csParser = new QWhale.Syntax.HtmlParser();
            csParser.Options = (SyntaxOptions.Outline | SyntaxOptions.SmartIndent | SyntaxOptions.CodeCompletion | SyntaxOptions.AutoComplete);
            //csParser.XmlScheme = componentResourceManager.GetString("jScriptNETParser1.XmlScheme");
            //  StreamReader streamReader = new StreamReader(sFilename, Encoding.UTF8, true);

            var docScript = new TextSource();
            docScript.BracesOptions = (BracesOptions.Highlight | BracesOptions.TempHighlight);
            docScript.HighlightHyperText = true;
            docScript.Lexer = csParser;
            docScript.Lines.UseSpaces = true;
            this.rtbSource.Source = docScript;
        }


        private void InitQuickRef()
        {


            dgvCharactorClass.Rows.Add(new string[] { "[char_group]", "匹配 char_group 中的任何单个字符。 默认情况下，匹配区分大小写。", "[ae]", "“gray”中的“a”“lane”中的“a”和“e”" });
            dgvCharactorClass.Rows.Add(new string[] { "[^char_group]", "非：与不在 char_group 中的任何单个字符匹配。 默认情况下，character_group 中的字符区分大小写。", "[^aei]", "“reign”中的“r”、“g”和“n”" });
            dgvCharactorClass.Rows.Add(new string[] { "[first-last]", "字符范围：与从 first 到 last 的范围中的任何单个字符匹配。", "[A-Z]", "“AB123”中的“A”和“B”" });
            dgvCharactorClass.Rows.Add(new string[] { ".", @"通配符：与除 \n 之外的任何单个字符匹配。若要匹配原意句点字符（.），您必须在该字符前面加上转义符 (\.)。", "a.e", "“nave”中的“ave”,“water”中的“ate”" });
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

            dgvAlternationConstruct.Rows.Add(new string[] { @"|", "匹配以竖线 (|) 字符分隔的任何一个元素。", "th(e|is|at)", "“this is the day.”中的“the”和“this””" });
            dgvAlternationConstruct.Rows.Add(new string[] { @"(?(expression) yes | no )", "如果正则表达式模式由 expression 匹配指定，则匹配 yes；否则匹配可选 no 部件。 expression 被解释为零宽度断言。", "(?(A)A\\d{2}\\b|\\b\\d{3}\\b)", "“A10 C103 910”中的“A10”和“910”" });
            dgvAlternationConstruct.Rows.Add(new string[] { @"(?(name) yes | no )", "如果 name 或已命名或已编号的捕获组具有匹配，则匹配 yes；否则匹配可选 no。", "(?<quoted>\")?(?(quoted).+?\"|\\S+\\s)", "“Dogs.jpg \"Yiska playing.jpg\"”中的 Dogs.jpg 和 \"Yiska playing.jpg\" " });

            dgvAlternation.Rows.Add(new string[] { "$number", "替换按组 number 匹配的子字符串。", @"\b(\w+)(\s)(\w+)\b", "$3$2$1", "\"one two\"", "\"two one\"" });
            dgvAlternation.Rows.Add(new string[] { "${name}", "替换按命名组 name 匹配的子字符串。", @"\b(?<word1>\w+)(\s)(?<word2>\w+)\b", "${word2} ${word1}", "\"one two\"", "\"two one\"" });
            dgvAlternation.Rows.Add(new string[] { "$$", "替换字符“$”。", @"\b(\d+)\s?USD", "$$$1", "“103 USD”", "“$103”" });
            dgvAlternation.Rows.Add(new string[] { "$&", "替换整个匹配项的一个副本。", @"(\$*(\d*(\.+\d+)?){1})", "**$&", "“$1.30”", "“**$1.30**”" });
            dgvAlternation.Rows.Add(new string[] { "$`", "替换匹配前的输入字符串的所有文本。", "B+", "$`", "“AABBCC”", "“AAAACC”" });
            dgvAlternation.Rows.Add(new string[] { "$'", "替换匹配后的输入字符串的所有文本。", "B+", "$'", "“AABBCC”", "“AACCCC”" });
            dgvAlternation.Rows.Add(new string[] { "$+", "替换最后捕获的组。", "B+(C+)", "$+", "“AABBCCDD”", "AACCDD" });
            dgvAlternation.Rows.Add(new string[] { "$_", "替换整个输入字符串。", "B+", "$_", "“AABBCC”", "“AAAABBCCCC” " });

            dgvGroupingConstruct.Rows.Add(new string[] { "(pattern)", "捕获匹配的子表达式并将其分配到一个从零开始的序号中。", @"(\w)\1", "“deep”中的“ee”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?<name>pattern)", "将匹配的子表达式捕获到一个命名组中。", @"(?<double>\w)\k<double>", "“deep”中的“ee”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?<name1-name2>pattern)", "定义平衡组定义。 有关更多信息，请参见正则表达式中的分组构造中的“平衡组定义”部分。", @"(((?'Open'\()[^\(\)]*)+((?'Close-Open'\))[^\(\)]*)+)*(?(Open)(?!))$", "“3+2^((1-3)*(3-1))”中的“((1-3)*(3-1))”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?:pattern)", "匹配pattern但不获取匹配的子字符串。", "Write(?:Line)?", "“Console.WriteLine()”中的“WriteLine”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?imnsx-imnsx:pattern)", "应用或禁用 pattern 中指定的选项。 有关更多信息，请参见正则表达式选项。", @"A\d{2}(?i:\w+)\b", "“A12xl A12XL a12xl”中的“A12xl”和“A12XL”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?=pattern)", "正向肯定预查，在任何匹配pattern的字符串开始处匹配查找字符串。", @"\w+(?=\.)", "“He is. The dog ran. The sun is out.”中的“is”、“ran”和“out”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?!pattern)", "正向否定预查，在任何不匹配pattern的字符串开始处匹配查找字符串。", @"\b(?!un)\w+\b", "“unsure sure unity used”中的“sure”和“used”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?<=pattern)", "反向肯定预查，与正向肯定预查类似，只是方向相反。。", @"(?<=95|98|NT|2000)Windows", "能匹配“2000Windows”中的“Windows”，但不能匹配“3.1Windows”中的“Windows”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?<!pattern)", "反向否定预查，与正向否定预查类似，只是方向相反。", @"(?<!95|98|NT|2000)Windows", "“(?<!95|98|NT|2000)Windows”能匹配“3.1Windows”中的“Windows”，但不能匹配“2000Windows”中的“Windows”" });
            dgvGroupingConstruct.Rows.Add(new string[] { "(?>pattern)", "非回溯（也称为“贪婪”）子表达式。", "[13579](?>A+B+)", "“1ABB 3ABBC 5AB 5AC”中的“1ABB”、“3ABB”和“5AB” " });
            //(pattern) 	匹配pattern并获取这一匹配的子字符串。该子字符串用于向后引用。所获取的匹配可以从产生的Matches集合得到，在VBScript中使用SubMatches集合，在JScript中则使用$0…$9属性。要匹配圆括号字符，请使用“\(”或“\)”。
            //(?:pattern) 	匹配pattern但不获取匹配的子字符串，也就是说这是一个非获取匹配，不存储匹配的子字符串用于向后引用。这在使用或字符“(|)”来组合一个模式的各个部分是很有用。例如“industr(?:y|ies)”就是一个比“industry|industries”更简略的表达式。
            //(?=pattern) 	正向肯定预查，在任何匹配pattern的字符串开始处匹配查找字符串。这是一个非获取匹配，也就是说，该匹配不需要获取供以后使用。例如，“Windows(?=95|98|NT|2000)”能匹配“Windows2000”中的“Windows”，但不能匹配“Windows3.1”中的“Windows”。预查不消耗字符，也就是说，在一个匹配发生后，在最后一次匹配之后立即开始下一次匹配的搜索，而不是从包含预查的字符之后开始。
            //(?!pattern) 	正向否定预查，在任何不匹配pattern的字符串开始处匹配查找字符串。这是一个非获取匹配，也就是说，该匹配不需要获取供以后使用。例如“Windows(?!95|98|NT|2000)”能匹配“Windows3.1”中的“Windows”，但不能匹配“Windows2000”中的“Windows”。预查不消耗字符，也就是说，在一个匹配发生后，在最后一次匹配之后立即开始下一次匹配的搜索，而不是从包含预查的字符之后开始
            //(?<=pattern) 	反向肯定预查，与正向肯定预查类似，只是方向相反。例如，“(?<=95|98|NT|2000)Windows”能匹配“2000Windows”中的“Windows”，但不能匹配“3.1Windows”中的“Windows”。
            //(?<!pattern) 	反向否定预查，与正向否定预查类似，只是方向相反。例如“(?<!95|98|NT|2000)Windows”能匹配“3.1Windows”中的“Windows”，但不能匹配“2000Windows”中的“Windows”。
        }


    }
}
