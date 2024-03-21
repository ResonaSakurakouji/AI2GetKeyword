namespace AI2GetKeyword
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl5 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl6 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl7 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl8 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl9 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl10 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl11 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl12 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl13 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl14 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl15 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl16 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl17 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl18 = this.Factory.CreateRibbonDropDownItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.Start = this.Factory.CreateRibbonGroup();
            this.help_btn = this.Factory.CreateRibbonButton();
            this.dim_btn = this.Factory.CreateRibbonButton();
            this.set_btn = this.Factory.CreateRibbonButton();
            this.NLP_Get = this.Factory.CreateRibbonGroup();
            this.get_type_slct = this.Factory.CreateRibbonComboBox();
            this.precise_chb = this.Factory.CreateRibbonCheckBox();
            this.overwrite_chb = this.Factory.CreateRibbonCheckBox();
            this.execute_btn = this.Factory.CreateRibbonButton();
            this.Regex = this.Factory.CreateRibbonGroup();
            this.RegexInput = this.Factory.CreateRibbonButton();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.finalExe_btn = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.Start.SuspendLayout();
            this.NLP_Get.SuspendLayout();
            this.Regex.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.Start);
            this.tab1.Groups.Add(this.NLP_Get);
            this.tab1.Groups.Add(this.Regex);
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "Hrz Getter";
            this.tab1.Name = "tab1";
            // 
            // Start
            // 
            this.Start.Items.Add(this.help_btn);
            this.Start.Items.Add(this.dim_btn);
            this.Start.Items.Add(this.set_btn);
            this.Start.Label = "区域定义";
            this.Start.Name = "Start";
            // 
            // help_btn
            // 
            this.help_btn.Label = "【帮助信息】";
            this.help_btn.Name = "help_btn";
            this.help_btn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.RegexInput_Click);
            // 
            // dim_btn
            // 
            this.dim_btn.Label = "定义数据区域";
            this.dim_btn.Name = "dim_btn";
            this.dim_btn.SuperTip = "将所选区域设置为数据源，区域必须连续，否则极易出现问题";
            this.dim_btn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dim_btn_Click);
            // 
            // set_btn
            // 
            this.set_btn.Label = "定义生成区域";
            this.set_btn.Name = "set_btn";
            this.set_btn.SuperTip = "指定一个区域用于输出提取后的数据，必须与数据源区域大小相等！";
            this.set_btn.Visible = false;
            this.set_btn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.set_btn_Click);
            // 
            // NLP_Get
            // 
            this.NLP_Get.Items.Add(this.get_type_slct);
            this.NLP_Get.Items.Add(this.precise_chb);
            this.NLP_Get.Items.Add(this.overwrite_chb);
            this.NLP_Get.Items.Add(this.execute_btn);
            this.NLP_Get.Label = "NLP提词";
            this.NLP_Get.Name = "NLP_Get";
            // 
            // get_type_slct
            // 
            ribbonDropDownItemImpl1.Label = "人名字号";
            ribbonDropDownItemImpl1.ScreenTip = "现实人名和虚拟人名";
            ribbonDropDownItemImpl1.SuperTip = "People, including fictional";
            ribbonDropDownItemImpl1.Tag = "PERSON";
            ribbonDropDownItemImpl2.Label = "宗教政治";
            ribbonDropDownItemImpl2.ScreenTip = "国籍，宗教或政治团体";
            ribbonDropDownItemImpl2.SuperTip = "Nationalities or religious or political groups";
            ribbonDropDownItemImpl2.Tag = "NORP";
            ribbonDropDownItemImpl3.Label = "基建设施";
            ribbonDropDownItemImpl3.ScreenTip = "建筑，公路，桥梁等";
            ribbonDropDownItemImpl3.SuperTip = "Buildings, airports, highways, bridges,etc.";
            ribbonDropDownItemImpl3.Tag = "FAC";
            ribbonDropDownItemImpl4.Label = "组织机构";
            ribbonDropDownItemImpl4.ScreenTip = "公司、机构、机关等";
            ribbonDropDownItemImpl4.SuperTip = "Companies,agencies,institutions,etc.";
            ribbonDropDownItemImpl4.Tag = "ORG";
            ribbonDropDownItemImpl5.Label = "省份城市";
            ribbonDropDownItemImpl5.ScreenTip = "国家、省份、城市";
            ribbonDropDownItemImpl5.SuperTip = "Countries, cities, states";
            ribbonDropDownItemImpl5.Tag = "GPE";
            ribbonDropDownItemImpl6.Label = "山脉水域";
            ribbonDropDownItemImpl6.ScreenTip = "非GPE位置、山脉、水体。";
            ribbonDropDownItemImpl6.SuperTip = "Non-GPE locations, mountain ranges, bodies of water.";
            ribbonDropDownItemImpl6.Tag = "LOC";
            ribbonDropDownItemImpl7.Label = "实体对象";
            ribbonDropDownItemImpl7.ScreenTip = "物品、车辆、食品等（不包括服务）";
            ribbonDropDownItemImpl7.SuperTip = "objects, vehicles, foods,etc.(NOT services)";
            ribbonDropDownItemImpl7.Tag = "PRODUCT";
            ribbonDropDownItemImpl8.Label = "重点事件";
            ribbonDropDownItemImpl8.ScreenTip = "灾害，战争，赛事";
            ribbonDropDownItemImpl8.SuperTip = "Named hurricanes, battls, wars, sports events, etc.";
            ribbonDropDownItemImpl8.Tag = "EVENT";
            ribbonDropDownItemImpl9.Label = "作品名称";
            ribbonDropDownItemImpl9.ScreenTip = "书名、歌曲等";
            ribbonDropDownItemImpl9.SuperTip = "Titles of books, songs, etc.";
            ribbonDropDownItemImpl9.Tag = "WORK_OF_ART";
            ribbonDropDownItemImpl10.Label = "法律文件";
            ribbonDropDownItemImpl10.ScreenTip = "成文的法律";
            ribbonDropDownItemImpl10.SuperTip = "Named documents made into laws.";
            ribbonDropDownItemImpl10.Tag = "LAW";
            ribbonDropDownItemImpl11.Label = "命名语言";
            ribbonDropDownItemImpl11.ScreenTip = "任何命名语言";
            ribbonDropDownItemImpl11.SuperTip = "Any named language";
            ribbonDropDownItemImpl11.Tag = "LANGUAGE";
            ribbonDropDownItemImpl12.Label = "时期日期";
            ribbonDropDownItemImpl12.ScreenTip = "绝对或相对日期或时期";
            ribbonDropDownItemImpl12.SuperTip = "Absolute or relative dates or periods";
            ribbonDropDownItemImpl12.Tag = "DATE";
            ribbonDropDownItemImpl13.Label = "时间片段";
            ribbonDropDownItemImpl13.ScreenTip = "不到一天的时间";
            ribbonDropDownItemImpl13.SuperTip = "Times smaller than a day";
            ribbonDropDownItemImpl13.Tag = "TIME";
            ribbonDropDownItemImpl14.Label = "百分比值";
            ribbonDropDownItemImpl14.ScreenTip = "百分比，包括“%”";
            ribbonDropDownItemImpl14.SuperTip = "percentage, including \"%\"";
            ribbonDropDownItemImpl14.Tag = "PERCENT";
            ribbonDropDownItemImpl15.Label = "金钱价值";
            ribbonDropDownItemImpl15.ScreenTip = "货币价值，包括单位价值";
            ribbonDropDownItemImpl15.SuperTip = "Monetary values, including unit";
            ribbonDropDownItemImpl15.Tag = "MONEY";
            ribbonDropDownItemImpl16.Label = "单位度量";
            ribbonDropDownItemImpl16.ScreenTip = "测量单位，如重量或距离";
            ribbonDropDownItemImpl16.SuperTip = "Measurements, as of weight or distance";
            ribbonDropDownItemImpl16.Tag = "QUANTITY";
            ribbonDropDownItemImpl17.Label = "序数词语";
            ribbonDropDownItemImpl17.ScreenTip = "第一、第二等序数词";
            ribbonDropDownItemImpl17.SuperTip = "\"first\",\"second\",etc";
            ribbonDropDownItemImpl17.Tag = "ORDINAL";
            ribbonDropDownItemImpl18.Label = "无型数字";
            ribbonDropDownItemImpl18.ScreenTip = "不属于其他类型的数字";
            ribbonDropDownItemImpl18.SuperTip = "Numerals that do not fall under another type";
            ribbonDropDownItemImpl18.Tag = "CARDINAL";
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl1);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl2);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl3);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl4);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl5);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl6);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl7);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl8);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl9);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl10);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl11);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl12);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl13);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl14);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl15);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl16);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl17);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl18);
            this.get_type_slct.Label = "目标";
            this.get_type_slct.Name = "get_type_slct";
            this.get_type_slct.SuperTip = "指定要提取的文本类型";
            this.get_type_slct.Text = "人名字号";
            this.get_type_slct.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.get_type_slct_TextChanged);
            // 
            // precise_chb
            // 
            this.precise_chb.Checked = true;
            this.precise_chb.Label = "精度优先";
            this.precise_chb.Name = "precise_chb";
            this.precise_chb.ScreenTip = "使结果更可靠，以牺牲识别成功率为代价";
            this.precise_chb.SuperTip = "勾选后，提取的数据精细度会上升，但识别成功率会下降，无法识别的时将输出空值等待手工填写。（建议开启）";
            this.precise_chb.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.precise_chb_Click);
            // 
            // overwrite_chb
            // 
            this.overwrite_chb.Label = "覆盖生成";
            this.overwrite_chb.Name = "overwrite_chb";
            this.overwrite_chb.ScreenTip = "生成内容将直接覆盖原有内容";
            this.overwrite_chb.SuperTip = "勾选后，生成内容将直接覆盖原有内容，此覆盖很可能无法撤销！\n若取消勾选，生成结果不会覆盖已有数据的区域，但是对于无法识别出结果的内容，多次识别并不会提高成功率";
            this.overwrite_chb.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.overwrite_chb_Click);
            // 
            // execute_btn
            // 
            this.execute_btn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.execute_btn.Image = ((System.Drawing.Image)(resources.GetObject("execute_btn.Image")));
            this.execute_btn.ImageName = "Qarmy";
            this.execute_btn.Label = "执行";
            this.execute_btn.Name = "execute_btn";
            this.execute_btn.ShowImage = true;
            this.execute_btn.Visible = false;
            this.execute_btn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.execute_btn_Click);
            // 
            // Regex
            // 
            this.Regex.Items.Add(this.RegexInput);
            this.Regex.Label = "正则表达式";
            this.Regex.Name = "Regex";
            // 
            // RegexInput
            // 
            this.RegexInput.Label = "正则输入框";
            this.RegexInput.Name = "RegexInput";
            this.RegexInput.SuperTip = "单击以显示或隐藏窗口";
            this.RegexInput.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.help_btn_Click);
            // 
            // group1
            // 
            this.group1.Items.Add(this.finalExe_btn);
            this.group1.Label = "没想好怎么写";
            this.group1.Name = "group1";
            this.group1.Visible = false;
            // 
            // finalExe_btn
            // 
            this.finalExe_btn.Image = ((System.Drawing.Image)(resources.GetObject("finalExe_btn.Image")));
            this.finalExe_btn.Label = "执行填充";
            this.finalExe_btn.Name = "finalExe_btn";
            this.finalExe_btn.ShowImage = true;
            this.finalExe_btn.Visible = false;
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.Start.ResumeLayout(false);
            this.Start.PerformLayout();
            this.NLP_Get.ResumeLayout(false);
            this.NLP_Get.PerformLayout();
            this.Regex.ResumeLayout(false);
            this.Regex.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Regex;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton RegexInput;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton dim_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton set_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup NLP_Get;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox get_type_slct;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox precise_chb;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox overwrite_chb;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Start;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton help_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton execute_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton finalExe_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
