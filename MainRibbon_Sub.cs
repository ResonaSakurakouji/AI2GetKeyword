using Microsoft.Office.Tools.Ribbon;
using stdole;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AI2GetKeyword
{
    public partial class MainRibbon_Sub
    {
        string pyPath = @"C:\HrzMethods\AI2GetKeyword\AI2GetKeyword.py";
        string newDirectory = @"C:\HrzMethods\AI2GetKeyword\";
        string pyFileName = @"AI2GetKeyword.py";
        string pyArgFileName = @"Arg.txt";
        string pyResultFileName = @"Result.txt";

        public static Excel.Application Excelapp;
        RightForm common = new RightForm();
        public static Excel.Range targetRange;
        public static string[,] sourceValues = null;
        private string[,] pyResultValues = null;
        public static int globalRowCount;
        public static int globalColumnCount;
        private string ent_label_ = "PERSON"; // 要提取的类型
        private string precise_mode = "1"; // 1：开启精确模式
        private bool overwrite_mode = false; // true: 开启覆写模式

        private static string[,] sourcePicURLs = null;

        public override string ToString()
        {
            string cellValues_str = "null";
            if (sourceValues != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine();
                for (int i = 0; i < sourceValues.GetLength(0); i++)
                {
                    for (int j = 0; j < sourceValues.GetLength(1); j++)
                    {
                        sb.Append(sourceValues[i, j]);
                        sb.Append("\t");
                        if (j > 2)
                        {
                            sb.Append("...");
                            break;
                        }
                    }
                    sb.AppendLine();
                    if (i > 4)
                    {
                        sb.Append("...");
                        break;
                    }
                }
                cellValues_str = sb.ToString();
            }
            string result = $"cellValue: {cellValues_str}\n";
            result += $"ent_label_: {ent_label_}\n";
            result += $"precise_mode: {precise_mode}\n";
            result += $"overwrite_mode: {overwrite_mode}\n";
            return result;
        }
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            /*
            将当前VSTO插件中的Excel应用程序对象赋值给 Excelapp 变量。这样就可以在代码的其他部分使用 Excelapp 变量来操作Excel应用程序。
            */
            Excelapp = Globals.ThisAddIn.Application;
            urlHead_islt.Text = "https";
            CratePyFile();
        }

        private void help_btn_Click(object sender, RibbonControlEventArgs e)
        {
            common.ShowCustomTask_Regex();
        }
        private void dim_btn_Click(object sender, RibbonControlEventArgs e)
        {
            // 获取当前选中的单元格集合
            Excel.Range selectedRange = Globals.ThisAddIn.Application.Selection as Excel.Range;
            if (selectedRange != null)
            {
                globalRowCount = selectedRange.Rows.Count;
                globalColumnCount = selectedRange.Columns.Count;
                sourceValues = new string[globalRowCount, globalColumnCount];
                // 遍历选中的单元格，将值保存到二维数组中
                for (int row = 1; row <= globalRowCount; row += 1)
                {
                    for (int column = 1; column <= globalColumnCount; column += 1)
                    {
                        Excel.Range cell = selectedRange.Cells[row, column];
                        object cellValue = cell.Value;
                        if (cellValue != null)
                        {
                            // 将单元格的值强制转换为字符串
                            sourceValues[row - 1, column - 1] = cellValue.ToString();
                        }
                        else
                        {
                            sourceValues[row - 1, column - 1] = string.Empty;
                        }
                    }
                }
                MessageBox.Show($"选中的区域【{globalRowCount}】行【{globalColumnCount}】列\n数据源区域的值已成功保存", "数据源设置成功");
                dim_btn.Label = "重设数据区域";
                set_btn.Label = "生成数据区域";
                set_btn.Visible = true;
                execute_btn.Visible = false;
                execute_btn.Enabled = false;
                getPicExe_btn.Visible = false;
                getPicExe_btn.Enabled = false;
            }
        }
        private void set_btn_Click(object sender, RibbonControlEventArgs e)
        {
            if (sourceValues == null)
            {
                MessageBox.Show("在设定生成区域之前，请先设置数据源区域！", "无效的设置");
            }
            bool passFlag = false;
            // 获取当前选中的单元格集合
            Excel.Range saveedRange = Globals.ThisAddIn.Application.Selection as Excel.Range;
            if (saveedRange != null)
            {
                int set_rowCount = saveedRange.Rows.Count;
                int set_columnCount = saveedRange.Columns.Count;
                if ((set_rowCount == globalRowCount) && (set_columnCount == globalColumnCount))
                {
                    targetRange = saveedRange;
                    passFlag = true;
                } 
                else if((set_rowCount == 1) && (set_columnCount == 1))
                {
                    targetRange = saveedRange.Resize[globalRowCount, globalColumnCount];
                    passFlag = true;
                }
                else
                {
                    MessageBox.Show($"请选择【{globalRowCount}】行，【{globalColumnCount}】列的区域，或者指定目标区域的左上角", "无效的生成区域");
                    return;
                }
                
                if (passFlag)
                {
                    MessageBox.Show("生成区域已经指定成功\n参数配置完成后即可执行", "操作成功");
                    set_btn.Label = "重设生成区域";
                    execute_btn.Label = "开始执行";
                    execute_btn.Visible = true;
                    execute_btn.Enabled = true;
                    getPicExe_btn.Visible = true;
                    getPicExe_btn.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show($"请选择【{globalRowCount}】行，【{globalColumnCount}】列的区域，或者指定目标区域的左上角", "未选择区域");
                return;
            }
        }

        // 精准模式
        private void precise_chb_Click(object sender, RibbonControlEventArgs e)
        {
            precise_mode = precise_chb.Checked ? "1" : "3";
        }

        // 覆写模式
        private void overwrite_chb_Click(object sender, RibbonControlEventArgs e)
        {
            overwrite_mode = overwrite_chb.Checked;
        }

        // 获取类型
        private void get_type_slct_TextChanged(object sender, RibbonControlEventArgs e)
        {
            // 获取下拉选框对象
            RibbonComboBox comboBox = (RibbonComboBox)sender;
            // 获取选中项对象
            string ram_text = comboBox.Text;
            if (ram_text != null)
            {
                foreach (var item in comboBox.Items)
                {
                    if (item.Label.ToString() == ram_text)
                    {
                        ent_label_ = item.Tag as string;
                        break;
                    }
                }
            }
            // MessageBox.Show(ent_label_);
        }

        private async void execute_btn_Click(object sender, RibbonControlEventArgs e)
        {
            // MessageBox.Show(this.ToString());
            execute_btn.Enabled = false;
            execute_btn.Label = "执行中...";
            Globals.ThisAddIn.Application.EnableEvents = false;
            Globals.ThisAddIn.Application.DisplayAlerts = false;
            // 接下来调用py
            string cellValuesArg = string.Empty;
            for (int row = 0; row < sourceValues.GetLength(0); row += 1)
            {
                for (int col = 0; col < sourceValues.GetLength(1); col += 1)
                {
                    cellValuesArg += sourceValues[row, col];
                    if (col != sourceValues.GetLength(1) - 1)
                    {
                        cellValuesArg += "~^_^~";
                    }
                }
                if (row != sourceValues.GetLength(0) - 1)
                {
                    cellValuesArg += "~^_^~";
                }
            }
            string finalArg = cellValuesArg + @"~^__^~" + precise_mode + @"~^__^~" + ent_label_;
            finalArg = finalArg.Replace('（', '(').Replace('）', ')');
            string finalArg2Path = newDirectory + pyArgFileName;
            // 将字符串使用UTF-8编码写入文件
            File.WriteAllText(finalArg2Path, finalArg, Encoding.UTF8);

            string result_listr = string.Empty;
            Task taskPy = new Task(() => result_listr = CallPytonExe(finalArg).Result);
            taskPy.Start();
            taskPy.Wait();
            Globals.ThisAddIn.Application.EnableEvents = true;
            Globals.ThisAddIn.Application.DisplayAlerts = true;
            SetResultRangeValues(result_listr);
            execute_btn.Label = "执行完毕";
            await Task.Delay(3000);
            execute_btn.Enabled = true;
        }
        private async Task<string> CallPytonExe(string argText)
        {
            string result;
            string rubbish;

            // 创建一个新的进程
            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = "python.exe",
                Arguments = "\"" + pyPath + "\"", // 按照规定py会读取 pyArgFileName 然后输出到 pyResultFileName
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true // 不显示窗口
            };
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    rubbish = await reader.ReadToEndAsync(); // 读取 Python 脚本的输出
                    string finalResultPath = newDirectory + pyResultFileName;
                    result = File.ReadAllText(finalResultPath);
                }
            }
            return result;
        }
        private void SetResultRangeValues(string resultStr)
        {
            string resultCellValue;
            if (resultStr == null || resultStr.Equals(""))
            {
                MessageBox.Show("文件组件缺失，无法提取", "发现异常");
            }
            else
            {
                pyResultValues = new string[globalRowCount, globalColumnCount];
                string resultStr2 = resultStr.Replace("[[", "");
                resultStr2 = resultStr2.Replace("]]", "");
                resultStr2 = resultStr2.Replace("'\\ufeff", "'"); // 处理零宽度空格的问题
                string[] resultList2 = resultStr2.Replace("], [", "⛵").Split('⛵');
                long resultList2Index = 0;
                for (int row = 0; row < globalRowCount; row += 1)
                {
                    for (int column = 0; column < globalColumnCount; column += 1)
                    {
                        resultCellValue = resultList2[resultList2Index].Replace(@"'", @"");
                        resultCellValue = resultCellValue.Replace(@",", @" ");
                        pyResultValues[row, column] = resultCellValue;
                        resultList2Index += 1;
                    }
                }
                for (int row = 1; row <= globalRowCount; row += 1)
                {
                    for (int column = 1; column <= globalColumnCount; column += 1)
                    {
                        Excel.Range cell = targetRange.Cells[row, column];
                        if (cell.Value == null)
                        {
                            cell.Value = pyResultValues[row - 1, column - 1];
                        }
                        else if (overwrite_mode)
                        {
                            cell.Value = pyResultValues[row - 1, column - 1];
                        }
                        cell.WrapText = false;
                    }
                }
            }
        }

        private void CratePyFile()
        {
            string dataToWrite;
            if (true)
            {
                dataToWrite = "# -*- coding=utf-8 -*-\r\n" +
                    "import spacy\r\n" +
                    "import time\r\n" +
                    "argFilePath = rf\"C:\\HrzMethods\\AI2GetKeyword\\Arg.txt\"\r\n" +
                    "resultFilePath = rf\"C:\\HrzMethods\\AI2GetKeyword\\Result.txt\"\r\n" +
                    "def getTypeWord(text_list, level, type_word):\r\n" +
                    "    nlp0 = spacy.load(\"zh_core_web_lg\")\r\n" +
                    "    nlp1 = spacy.load(\"zh_core_web_trf\")\r\n" +
                    "    nlp2 = spacy.load(\"zh_core_web_md\")\r\n" +
                    "    nlp3 = spacy.load(\"zh_core_web_sm\")\r\n" +
                    "    result_list = []\r\n" +
                    "    for text in text_list:\r\n" +
                    "        doc0 = nlp0(text)\r\n" +
                    "        company_names = []\r\n" +
                    "        for ent in doc0.ents:\r\n" +
                    "            if ent.label_ == type_word:\r\n" +
                    "                company_names.append(ent.text)\r\n" +
                    "        if company_names == [] and level >= 1:\r\n" +
                    "            doc1 = nlp1(text)\r\n" +
                    "            for ent in doc1.ents:\r\n" +
                    "                if ent.label_ == type_word:\r\n" +
                    "                    company_names.append(ent.text)\r\n" +
                    "            if company_names == [] and level >= 2:\r\n" +
                    "                doc2 = nlp2(text)\r\n" +
                    "                for ent in doc2.ents:\r\n" +
                    "                    if ent.label_ == type_word:\r\n" +
                    "                        company_names.append(ent.text)\r\n" +
                    "                if company_names == [] and level >= 3:\r\n" +
                    "                    doc3 = nlp3(text)\r\n" +
                    "                    for ent in doc3.ents:\r\n" +
                    "                        if ent.label_ == type_word:\r\n" +
                    "                            company_names.append(ent.text)\r\n" +
                    "        result_list.append(company_names)\r\n" +
                    "    return result_list\r\n" +
                    "if __name__ == '__main__':\r\n" +
                    "    with open(argFilePath, 'r', encoding='utf-8') as fileA:\r\n" +
                    "        textArgs = fileA.read()\r\n" +
                    "    getArgs = textArgs.split(\"~^__^~\")\r\n" +
                    "    main_text0 = str(getArgs[0])\r\n" +
                    "    main_level = str(getArgs[1])\r\n" +
                    "    main_type = str(getArgs[2])\r\n" +
                    "    main_text = main_text0.split(\"~^_^~\")\r\n" +
                    "    main_level = int(main_level)\r\n" +
                    "    main_type = main_type.upper()\r\n" +
                    "    output = getTypeWord(main_text, main_level, main_type)\r\n" +
                    "    with open(resultFilePath, \"w\", encoding=\"utf-8\") as fileR:\r\n" +
                    "        fileR.write(str(output))\r\n" +
                    "    print(\" \")\r\n" +
                    "    time.sleep(1)";
            }
            if (!Directory.Exists(newDirectory))
            {
                Directory.CreateDirectory(newDirectory);
            }
            if (!File.Exists(pyPath))
            {
                File.Create(pyPath).Close();
                using (StreamWriter writer = new StreamWriter(pyPath, false))
                {
                    writer.Write(dataToWrite);
                    writer.WriteLine();
                }
            }
        }

        private void HELP_btn_Click(object sender, RibbonControlEventArgs e)
        {
            string MainHelp = "在您使用Hrz Getter的时候，请遵循以下顺序:\r\n" +
                "1. 在【区域定义】子选项卡中定义或重设数据区域;\r\n" +
                "2. 在【区域定义】子选项卡中定义或重设生成数据区域;\r\n" +
                "3. 进行后续其他选项卡的操作;\r\n" +
                "在进行定义的时候请务必注意源区域与目标区域的大小必须一致;\r\n" +
                "您也可以通过在按钮上悬停鼠标来尝试获取更多帮助信息;\r\n";
            MessageBox.Show(MainHelp, "帮助简介");
        }

        // 以下是根据URL获取图片的部分模块
        private void getPicExe_btn_Click(object sender, RibbonControlEventArgs e)
        {
            string value_i;
            string[] values_i;
            sourcePicURLs = new string[globalRowCount, globalColumnCount];
            // 遍历数据源二维数组，将值保存到URL二维数组中
            for (int row = 1; row <= globalRowCount; row += 1)
            {
                for (int column = 1; column <= globalColumnCount; column += 1)
                {
                    value_i = sourceValues[row - 1, column - 1];
                    // sourcePicURLs[row - 1, column - 1] = $"<table><img src='{value_i}' width='128' height='128'/></table>";
                    // 检查是否开启了严格模式
                    if (accurateMode_chb.Checked)  // 开启状态
                    {
                        if (!string.IsNullOrEmpty(value_i))
                        {
                            Excel.Range cell = targetRange.Cells[row, column];
                            cell.Clear();
                            if (splitSymbol_ipt.Text.Equals(""))
                            {
                                values_i = new string[] { value_i };
                            }
                            else
                            {
                                char[] value_chars = splitSymbol_ipt.Text.ToCharArray();
                                values_i = value_i.Split(value_chars, System.StringSplitOptions.RemoveEmptyEntries);
                            }
                            int pic_count = values_i.Length;
                            for (int i = 0; i < pic_count; i += 1)
                            {
                                try
                                {
                                    Excel.Shape picture = cell.Worksheet.Shapes.AddPicture(
                                        values_i[i],
                                        Microsoft.Office.Core.MsoTriState.msoFalse,
                                        Microsoft.Office.Core.MsoTriState.msoCTrue,
                                        cell.Left + i * cell.Width / pic_count, cell.Top, cell.Width / pic_count, cell.Height
                                    );
                                    // 将图片内嵌到单元格中
                                    picture.LockAspectRatio = Microsoft.Office.Core.MsoTriState.msoTrue;
                                }
                                catch
                                {
                                    cell.Value += $"\n【{values_i[i]}】不是一个合法的图片url";
                                }
                            }
                        }
                    }
                }
            }
            
        }

        private void urlHead_islt_TextChanged(object sender, RibbonControlEventArgs e)
        {
            return;
        }

        private void accurateMode_chb_Click(object sender, RibbonControlEventArgs e)
        {
            urlHead_islt.Visible = !accurateMode_chb.Checked;
            return;
        }
    }
}
