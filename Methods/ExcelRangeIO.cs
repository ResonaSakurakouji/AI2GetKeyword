using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Hrz_ExcelRangeIO
{
    public class RobustMethod
    {
        public static void SaveAsBackup()
        {
            try
            {
                Excel.Application excelApp = Marshal.GetActiveObject("Excel.Application") as Excel.Application;
                Excel.Workbook activeWorkbook = excelApp.ActiveWorkbook;

                // 获取当前文件全名（包括拓展名）
                string fileName = activeWorkbook.FullName;
                string extension = Path.GetExtension(fileName);

                // 生成备份文件，并以"_Hbkup结尾"
                string backupFileName = Path.Combine(Path.GetDirectoryName(fileName), Path.GetFileNameWithoutExtension(fileName) + "_Hbkup" + extension);
                activeWorkbook.SaveCopyAs(backupFileName);
            }
            catch (Exception ex)
            {
                // MessageBox.Show("保存备份出现故障: " + ex.Message);
            }
        }
        public static void SaveAsBackup(string tail)
        {
            try
            {
                Excel.Application excelApp = Marshal.GetActiveObject("Excel.Application") as Excel.Application;
                Excel.Workbook activeWorkbook = excelApp.ActiveWorkbook;

                // 获取当前文件全名（包括拓展名）
                string fileName = activeWorkbook.FullName;
                string extension = Path.GetExtension(fileName);

                // 生成备份文件，并以"_Hbkup结尾"
                string backupFileName = Path.Combine(Path.GetDirectoryName(fileName), Path.GetFileNameWithoutExtension(fileName) + tail + extension);
                activeWorkbook.SaveCopyAs(backupFileName);
            }
            catch (Exception ex)
            {
                // MessageBox.Show("保存备份出现故障: " + ex.Message);
            }
        }
    }
    public class RegexMethod
    {
        public static string Match4WinPath(string file_class)
        {
            string classText = file_class;
            if (file_class == "img")
            {
                classText = "png|jpg|jpeg|gif|bmp";
            }
            string matchBody = "[a-zA-Z]:(\\\\)[^/^;^*^\"^<^>^\\|]+.("+ classText +")";
            return matchBody;
        }
        public static string Head2Match4Url(string text)
        {
            string result = "^(" + text + ")://(\\w|-|\\.|~|!|\\*|'|\\(|\\)|@|&|=|\\+|\\$|/|\\?|#|\\[|\\]|%)+";
            return result;
        }
    }
    public class IOMethod
    {
        public static int IOMcount = 0;
        public static void Urls2imgs(Excel.Range target_cell, bool compatibility_mode, string[] url_list)
        {
            IOMcount += 1;
            if (IOMcount % 5 == 0) { RobustMethod.SaveAsBackup(); }
            int pic_count = url_list.Length;
            bool stop_flag = false;
            for (int i = 0; i < pic_count; i += 1)
            {
                if (stop_flag) { break; }
                try
                {
                    try
                    {
                        Excel.Shape picture = target_cell.Worksheet.Shapes.AddPicture(
                            url_list[i],
                            Microsoft.Office.Core.MsoTriState.msoFalse,
                            Microsoft.Office.Core.MsoTriState.msoCTrue,
                            target_cell.Left + i * target_cell.Width / pic_count, target_cell.Top, target_cell.Width / pic_count, target_cell.Height
                        );
                        // 将图片内嵌到单元格中
                        picture.LockAspectRatio = Microsoft.Office.Core.MsoTriState.msoTrue;
                    }
                    catch (Exception ex) 
                    {
                        if (compatibility_mode)
                        {
                            target_cell.Clear();
                            string xmlStr = "<table>";
                            for (int j = 0; j < pic_count; j += 1)  // 一旦获取失败则清空并全部使用html文本实现
                            {
                                xmlStr += $"<img src='{url_list[j]}' width='{target_cell.Width / pic_count * 1.33}' height='{target_cell.Height * 1.33}'>";
                            }
                            xmlStr += $"</table>";
                            Clipboard.SetText(xmlStr);
                            target_cell.PasteSpecial();
                            Clipboard.Clear();
                        }
                        else
                        {
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    target_cell.Value += $"由于网络原因获取失败，或者【{url_list[i]}】不是一个合法的图片url\r\n";
                }
            }
            return;
        }
    }
}