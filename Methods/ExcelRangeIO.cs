using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Hrz_ExcelRangeIO
{
    public class IOMethod
    {
        public static void urls2imgs(Excel.Range target_cell, bool compatibility_mode, string[] url_list)
        {
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