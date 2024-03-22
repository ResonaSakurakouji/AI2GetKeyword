using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AI2GetKeyword
{
    public partial class RegexMatch_Sub : UserControl
    {
        private bool[,] regex_resultsB = null;
        private string[,] regex_resultsS = null;

        public static string BooleanArrayToString(bool[,] array)
        {
            StringBuilder sb = new StringBuilder();
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sb.Append(array[i, j] ? 'T' : 'F'); // 用 'T' 表示 true，用 'F' 表示 false
                }
                sb.AppendLine(); // 每行结束后添加换行符
            }

            return sb.ToString();
        }
        public RegexMatch_Sub()
        {
            InitializeComponent();
        }

        private void GetWorkbookData_Load(object sender, EventArgs e)
        {
            return;
        }

        private void Regex_InputTitle_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Regex_InputBox_Changed(object sender, EventArgs e)
        {
            this.Regex_Return_btn.Visible = false;
            return;
        }

        private void Regex_Check_btn_Click(object sender, EventArgs e)
        {
            string regex_text = this.Regex_InputBox.Text;
            if (regex_text != string.Empty)
            {
                try
                {
                    Regex.IsMatch(string.Empty, regex_text);
                    regex_resultsB = new bool[MainRibbon_Sub.rowCount, MainRibbon_Sub.columnCount];
                    regex_resultsS = new string[MainRibbon_Sub.rowCount, MainRibbon_Sub.columnCount];
                    if (MainRibbon_Sub.sourceValues != null)
                    {
                        for (int row = 0; row < MainRibbon_Sub.sourceValues.GetLength(0); row += 1)
                        {
                            for (int col = 0; col < MainRibbon_Sub.sourceValues.GetLength(1); col += 1)
                            {
                                if (Regex_rbtn_CheckMod.Checked)
                                {
                                    regex_resultsB[row, col] = Regex.IsMatch(MainRibbon_Sub.sourceValues[row, col], regex_text);
                                }
                                else if (Regex_rbtn_FilterMod.Checked)
                                {
                                    // 使用 StringBuilder 来构建结果字符串
                                    StringBuilder sb = new StringBuilder();
                                    MatchCollection matches = Regex.Matches(MainRibbon_Sub.sourceValues[row, col], regex_text);
                                    // 遍历 MatchCollection
                                    foreach (Match match in matches)
                                    {
                                        // 将每个匹配项添加到 StringBuilder，并以制表符为分隔符
                                        sb.Append(match.Value);
                                        if (match != matches[matches.Count - 1]) // 如果不是最后一个匹配项，则添加制表符
                                        {
                                            sb.Append("\t");
                                        }
                                    }
                                    regex_resultsS[row, col] = sb.ToString();
                                }
                                else if (Regex_rbtn_ReplaceMod.Checked)
                                {
                                    regex_resultsS[row, col] = Regex.Replace(MainRibbon_Sub.sourceValues[row, col], regex_text, this.Regex_Input_new2replace.Text);
                                }
                            }
                        }
                        // MessageBox.Show(BooleanArrayToString(regex_results));
                        if (Regex_rbtn_CheckMod.Checked || Regex_rbtn_FilterMod.Checked || Regex_rbtn_ReplaceMod.Checked)
                        {
                            this.Regex_Return_btn.Text = "获取结果";
                            this.Regex_Return_btn.Enabled = true;
                            this.Regex_Return_btn.Visible = true;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("你输入了非法的正则表达式，请重新输入！", "语法错误的正则");
                }
            }
            else
            {
                MessageBox.Show("请输入正则表达式！", "空输入正则");
            }
            return;
        }

        private void Regex_Return_btn_Click(object sender, EventArgs e)
        {
            for (int row = 1; row <= MainRibbon_Sub.rowCount; row += 1)
            {
                for (int column = 1; column <= MainRibbon_Sub.columnCount; column += 1)
                {
                    Excel.Range cell = MainRibbon_Sub.targetRange.Cells[row, column];
                    if (cell.Value == null)
                    {
                        if (this.Regex_rbtn_CheckMod.Checked)
                        {
                            cell.Value = regex_resultsB[row - 1, column - 1];
                        }
                        else if (this.Regex_rbtn_FilterMod.Checked || this.Regex_rbtn_ReplaceMod.Checked)
                        {
                            cell.Value = regex_resultsS[row - 1, column - 1];
                        }
                    }
                    else if (Regex_OverWrite_chb.Checked)
                    {
                        if (this.Regex_rbtn_CheckMod.Checked)
                        {
                            cell.Value = regex_resultsB[row - 1, column - 1];
                        }
                        else if (this.Regex_rbtn_FilterMod.Checked || this.Regex_rbtn_ReplaceMod.Checked)
                        {
                            cell.Value = regex_resultsS[row - 1, column - 1];
                        }
                    }
                    cell.WrapText = false;
                }
                this.Regex_Return_btn.Enabled = false;
                this.Regex_Return_btn.Text = "结束";
            }
            return;
        }

        private void Regex_rbtn_Replace_CheckedChanged(object sender, EventArgs e)
        {
            if (Regex_rbtn_ReplaceMod.Checked)
            {
                Regex_Input_new2replace.Visible = true;
                Regex_label_replace.Visible = true;
            }
            else
            {
                Regex_Input_new2replace.Visible = false;
                Regex_label_replace.Visible = false;
            }
        }

        private void Regex_OverWrite_chb_CheckedChanged(object sender, EventArgs e)
        {
            return;
        }

        private void Regex_rbtn_CheckMod_CheckedChanged(object sender, EventArgs e)
        {
            return;
        }

        private void Regex_Input_new2replace_TextChanged(object sender, EventArgs e)
        {
            return;
        }
    }
}
