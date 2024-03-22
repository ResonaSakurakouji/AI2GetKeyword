using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AI2GetKeyword
{
    public partial class RegexMatch_Sub : UserControl
    {
        private Boolean[,] regex_results = null;

        public static string BooleanArrayToString(Boolean[,] array)
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
                    regex_results = new bool[MainRibbon_Sub.rowCount, MainRibbon_Sub.columnCount];
                    if (MainRibbon_Sub.sourceValues != null)
                    {
                        for (int row = 0; row < MainRibbon_Sub.sourceValues.GetLength(0); row += 1)
                        {
                            for (int col = 0; col < MainRibbon_Sub.sourceValues.GetLength(1); col += 1)
                            {
                                regex_results[row, col] = Regex.IsMatch(MainRibbon_Sub.sourceValues[row, col], regex_text);
                            }
                        }                    
                        // MessageBox.Show(BooleanArrayToString(regex_results));
                        this.Regex_Return_btn.Visible = true;
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
                        cell.Value = regex_results[row - 1, column - 1];
                    }
                    else if (Regex_OverWrite_chb.Checked)
                    {
                        cell.Value = regex_results[row - 1, column - 1];
                    }
                    cell.WrapText = false;
                }
            }
            return;
        }

        private void Regex_OverWrite_chb_CheckedChanged(object sender, EventArgs e)
        {
            return;
        }
    }
}
