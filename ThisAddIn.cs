namespace AI2GetKeyword
{
    public partial class ThisAddIn
    {
        public static bool pauseState0 = false;
        public static void PAUSE0()
        {
            pauseState0 = true;
        }
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //实现不了，TMLGB的
            //Globals.ThisAddIn.Application.OnKey("p", "PAUSE0");
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
