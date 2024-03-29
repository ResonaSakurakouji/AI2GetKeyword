﻿namespace AI2GetKeyword
{
    internal class RightForm
    {
        private static Microsoft.Office.Tools.CustomTaskPane CustomTask;
        // 创建显示用户窗体的方法，并对外暴露 关键字 public
        public void ShowCustomTask_Regex()
        {
            // 每次调用，若用户窗体不存在则创建，若存在则隐藏
            if (CustomTask == null)
            {
                // new一个用户窗体GetWorkbookData
                RegexMatch_Sub userControl1 = new RegexMatch_Sub();
                /*
                Globals.ThisAddIn表示对于当前的VSTO插件的引用，
                CustomTaskPanes是一个属性，它提供了对VSTO插件中自定义任务窗格的访问。
                .Add(userControl1, "正则输入框")是在自定义任务窗格集合中添加新的任务窗格的方法。其中，
                    userControl1是一个自定义的用户控件，将用于承载在任务窗格中显示的内容，"任务窗格"是任务窗格的标题。
                通过调用这个方法，你可以将自定义的用户控件添加到VSTO插件的自定义任务窗格中，从而实现在Excel应用程序中显示自定义的内容。
                 */
                CustomTask = Globals.ThisAddIn.CustomTaskPanes.Add(userControl1, "正则输入框");
                // 设置该任务窗格可见
                CustomTask.Visible = true;
            }
            else
            {
                if (CustomTask.Visible == true)
                {
                    CustomTask.Visible = false;
                }
                else { CustomTask.Visible = true; }
            }

        }
        // 创建写入用户窗体的文本
        public void WriteText(string str)
        {
            // 若任务窗口不存在则创建并写入用户窗体的富文本框，否则直接覆写
            if (CustomTask == null)
            {
                ShowCustomTask_Regex();
            }
            CustomTask.Control.Controls["richTextBox1"].Text = str;
        }
    }
}
