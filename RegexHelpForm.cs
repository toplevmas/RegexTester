using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegexTester
{
    public partial class RegexHelpForm : Form
    {
        public RegexHelpForm()
        {
            InitializeComponent();

            InitQuickRef();
            /*
            dgvAlternation.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);
            dgvAlternationConstruct.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);
            dgvAssertion.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);
            dgvBackreference.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);
            dgvCharactorClass.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);
            dgvGroupingConstruct.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);
            dgvQuantifiers.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);*/
        }

        private void RegexHelpForm_Load(object sender, EventArgs e)
        {
            
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

        /*
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
        */

        private void RegexHelpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

    }
}
