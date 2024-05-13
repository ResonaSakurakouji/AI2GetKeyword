namespace AI2GetKeyword
{
    partial class MainRibbon_Sub : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MainRibbon_Sub()
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
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl19 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl20 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl21 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl22 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl23 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl24 = this.Factory.CreateRibbonDropDownItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRibbon_Sub));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.Start = this.Factory.CreateRibbonGroup();
            this.help_btn = this.Factory.CreateRibbonButton();
            this.dim_btn = this.Factory.CreateRibbonButton();
            this.set_btn = this.Factory.CreateRibbonButton();
            this.url2img = this.Factory.CreateRibbonGroup();
            this.accurateMode_chb = this.Factory.CreateRibbonCheckBox();
            this.splitSymbol_ipt = this.Factory.CreateRibbonEditBox();
            this.urlHead_islt = this.Factory.CreateRibbonComboBox();
            this.getPicExe_btn = this.Factory.CreateRibbonButton();
            this.Regex = this.Factory.CreateRibbonGroup();
            this.RegexInput = this.Factory.CreateRibbonButton();
            this.NLP_Get = this.Factory.CreateRibbonGroup();
            this.get_type_slct = this.Factory.CreateRibbonComboBox();
            this.precise_chb = this.Factory.CreateRibbonCheckBox();
            this.overwrite_chb = this.Factory.CreateRibbonCheckBox();
            this.execute_btn = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.Start.SuspendLayout();
            this.url2img.SuspendLayout();
            this.Regex.SuspendLayout();
            this.NLP_Get.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.Start);
            this.tab1.Groups.Add(this.url2img);
            this.tab1.Groups.Add(this.Regex);
            this.tab1.Groups.Add(this.NLP_Get);
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
            this.help_btn.SuperTip = "点击以查看帮助信息";
            this.help_btn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.HELP_btn_Click);
            // 
            // dim_btn
            // 
            this.dim_btn.Label = "定义数据区域";
            this.dim_btn.Name = "dim_btn";
            this.dim_btn.SuperTip = "将所选区域设置为数据源，区域必须连续";
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
            // url2img
            // 
            this.url2img.Items.Add(this.accurateMode_chb);
            this.url2img.Items.Add(this.splitSymbol_ipt);
            this.url2img.Items.Add(this.urlHead_islt);
            this.url2img.Items.Add(this.getPicExe_btn);
            this.url2img.Label = "批量获取图片";
            this.url2img.Name = "url2img";
            // 
            // accurateMode_chb
            // 
            this.accurateMode_chb.Label = "严格模式";
            this.accurateMode_chb.Name = "accurateMode_chb";
            this.accurateMode_chb.ScreenTip = "启用严格模式";
            this.accurateMode_chb.SuperTip = "如果你需要获取的url有多种协议，可以启用这个严格模式；\n但是！务必确保单元格中不包括任何其他信息！\n\n开启后将无法从单元格中识别url文本段！";
            this.accurateMode_chb.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.accurateMode_chb_Click);
            // 
            // splitSymbol_ipt
            // 
            this.splitSymbol_ipt.Label = "分隔";
            this.splitSymbol_ipt.Name = "splitSymbol_ipt";
            this.splitSymbol_ipt.ScreenTip = "分隔符";
            this.splitSymbol_ipt.SuperTip = "如果同一个单元格内有多个图片URL，请指定这些URL的分隔符，否则会造成无法正常提取";
            this.splitSymbol_ipt.Text = null;
            this.splitSymbol_ipt.Visible = false;
            // 
            // urlHead_islt
            // 
            ribbonDropDownItemImpl1.Label = "https";
            ribbonDropDownItemImpl1.ScreenTip = "Web加密标准协议";
            ribbonDropDownItemImpl1.SuperTip = "可能是中国互联网最广泛使用的协议；\n如果你的链接是https开头，请选择这个选项。";
            ribbonDropDownItemImpl2.Label = "http";
            ribbonDropDownItemImpl2.ScreenTip = "Web标准协议";
            ribbonDropDownItemImpl2.SuperTip = "这是最普通的Web标准协议；\n如果你希望使用私人服务器并没有ssl证书，可以使用这个选项。";
            ribbonDropDownItemImpl3.Label = "file";
            ribbonDropDownItemImpl3.ScreenTip = "本地文件协议";
            ribbonDropDownItemImpl3.SuperTip = "如果你的路径是\n\"C:\\Users\\...\"\n之类的完整的路径文本，请使用本地文件协议。\n文件层级表示必须使用Windows系统指定的反斜杠\\。";
            ribbonDropDownItemImpl4.Label = "data";
            ribbonDropDownItemImpl4.ScreenTip = "数据协议";
            ribbonDropDownItemImpl4.SuperTip = "如果你拥有目标图片的完整编码信息并以类似\n\"data:image/png;base64...\"\n这样的文本开头，那么使用数据协议可以轻而易举的将这团“乱码”转化为" +
    "可视图片。\n请注意这个协议下不支持自动识别，仅支持识别base64编码，同时也无法做到分割单元格内的多个base64字符串；\n注意excel单个单元格可能无法保" +
    "存完整的base64代码(1024个字符)从而导致图片损坏！";
            ribbonDropDownItemImpl5.Label = "ftp";
            ribbonDropDownItemImpl5.ScreenTip = "文件传输标准协议";
            ribbonDropDownItemImpl5.SuperTip = "曾经极为流行的网络文件传输标准协议；\n但是现在并不算特别常见了。";
            ribbonDropDownItemImpl6.Label = "RURL";
            ribbonDropDownItemImpl6.ScreenTip = "相对路径协议";
            ribbonDropDownItemImpl6.SuperTip = "如果你真的需要使用相对路径，请你清洗自己的数据后使用严格模式和分隔符进行图片获取，这个软件没有能力自动识别相对路径。";
            this.urlHead_islt.Items.Add(ribbonDropDownItemImpl1);
            this.urlHead_islt.Items.Add(ribbonDropDownItemImpl2);
            this.urlHead_islt.Items.Add(ribbonDropDownItemImpl3);
            this.urlHead_islt.Items.Add(ribbonDropDownItemImpl4);
            this.urlHead_islt.Items.Add(ribbonDropDownItemImpl5);
            this.urlHead_islt.Items.Add(ribbonDropDownItemImpl6);
            this.urlHead_islt.Label = "协议";
            this.urlHead_islt.Name = "urlHead_islt";
            this.urlHead_islt.ScreenTip = "协议名";
            this.urlHead_islt.SuperTip = "这个选框将帮助你自动识别单元格内的“可能是URL的信息”并获取图片；\n绝大多数情况下，这个选项应该和你的链接开头字母一致；当然你也可以自定协议。如果你什么都不写，" +
    "那么将默认使用https格式";
            this.urlHead_islt.Text = null;
            this.urlHead_islt.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.urlHead_islt_TextChanged);
            // 
            // getPicExe_btn
            // 
            this.getPicExe_btn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.getPicExe_btn.Enabled = false;
            this.getPicExe_btn.Image = global::AI2GetKeyword.Properties.Resources.url2img;
            this.getPicExe_btn.Label = "执行获取";
            this.getPicExe_btn.Name = "getPicExe_btn";
            this.getPicExe_btn.ScreenTip = "点击执行";
            this.getPicExe_btn.ShowImage = true;
            this.getPicExe_btn.SuperTip = "执行期间excel会发生假死，请不要一次性执行过多的任务";
            this.getPicExe_btn.Visible = false;
            this.getPicExe_btn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.getPicExe_btn_Click);
            // 
            // Regex
            // 
            this.Regex.Items.Add(this.RegexInput);
            this.Regex.Label = "Regex";
            this.Regex.Name = "Regex";
            // 
            // RegexInput
            // 
            this.RegexInput.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.RegexInput.Image = global::AI2GetKeyword.Properties.Resources.Regex;
            this.RegexInput.Label = "正则输入";
            this.RegexInput.Name = "RegexInput";
            this.RegexInput.ShowImage = true;
            this.RegexInput.SuperTip = "单击以显示或隐藏正则输入窗口";
            this.RegexInput.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.regex_btn_Click);
            // 
            // NLP_Get
            // 
            this.NLP_Get.Items.Add(this.get_type_slct);
            this.NLP_Get.Items.Add(this.precise_chb);
            this.NLP_Get.Items.Add(this.overwrite_chb);
            this.NLP_Get.Items.Add(this.execute_btn);
            this.NLP_Get.Label = "NLP提词";
            this.NLP_Get.Name = "NLP_Get";
            this.NLP_Get.Visible = false;
            // 
            // get_type_slct
            // 
            ribbonDropDownItemImpl7.Label = "人名字号";
            ribbonDropDownItemImpl7.ScreenTip = "现实人名和虚拟人名";
            ribbonDropDownItemImpl7.SuperTip = "People, including fictional";
            ribbonDropDownItemImpl7.Tag = "PERSON";
            ribbonDropDownItemImpl8.Label = "宗教政治";
            ribbonDropDownItemImpl8.ScreenTip = "国籍，宗教或政治团体";
            ribbonDropDownItemImpl8.SuperTip = "Nationalities or religious or political groups";
            ribbonDropDownItemImpl8.Tag = "NORP";
            ribbonDropDownItemImpl9.Label = "基建设施";
            ribbonDropDownItemImpl9.ScreenTip = "建筑，公路，桥梁等";
            ribbonDropDownItemImpl9.SuperTip = "Buildings, airports, highways, bridges,etc.";
            ribbonDropDownItemImpl9.Tag = "FAC";
            ribbonDropDownItemImpl10.Label = "组织机构";
            ribbonDropDownItemImpl10.ScreenTip = "公司、机构、机关等";
            ribbonDropDownItemImpl10.SuperTip = "Companies,agencies,institutions,etc.";
            ribbonDropDownItemImpl10.Tag = "ORG";
            ribbonDropDownItemImpl11.Label = "省份城市";
            ribbonDropDownItemImpl11.ScreenTip = "国家、省份、城市";
            ribbonDropDownItemImpl11.SuperTip = "Countries, cities, states";
            ribbonDropDownItemImpl11.Tag = "GPE";
            ribbonDropDownItemImpl12.Label = "山脉水域";
            ribbonDropDownItemImpl12.ScreenTip = "非GPE位置、山脉、水体。";
            ribbonDropDownItemImpl12.SuperTip = "Non-GPE locations, mountain ranges, bodies of water.";
            ribbonDropDownItemImpl12.Tag = "LOC";
            ribbonDropDownItemImpl13.Label = "实体对象";
            ribbonDropDownItemImpl13.ScreenTip = "物品、车辆、食品等（不包括服务）";
            ribbonDropDownItemImpl13.SuperTip = "objects, vehicles, foods,etc.(NOT services)";
            ribbonDropDownItemImpl13.Tag = "PRODUCT";
            ribbonDropDownItemImpl14.Label = "重点事件";
            ribbonDropDownItemImpl14.ScreenTip = "灾害，战争，赛事";
            ribbonDropDownItemImpl14.SuperTip = "Named hurricanes, battls, wars, sports events, etc.";
            ribbonDropDownItemImpl14.Tag = "EVENT";
            ribbonDropDownItemImpl15.Label = "作品名称";
            ribbonDropDownItemImpl15.ScreenTip = "书名、歌曲等";
            ribbonDropDownItemImpl15.SuperTip = "Titles of books, songs, etc.";
            ribbonDropDownItemImpl15.Tag = "WORK_OF_ART";
            ribbonDropDownItemImpl16.Label = "法律文件";
            ribbonDropDownItemImpl16.ScreenTip = "成文的法律";
            ribbonDropDownItemImpl16.SuperTip = "Named documents made into laws.";
            ribbonDropDownItemImpl16.Tag = "LAW";
            ribbonDropDownItemImpl17.Label = "命名语言";
            ribbonDropDownItemImpl17.ScreenTip = "任何命名语言";
            ribbonDropDownItemImpl17.SuperTip = "Any named language";
            ribbonDropDownItemImpl17.Tag = "LANGUAGE";
            ribbonDropDownItemImpl18.Label = "时期日期";
            ribbonDropDownItemImpl18.ScreenTip = "绝对或相对日期或时期";
            ribbonDropDownItemImpl18.SuperTip = "Absolute or relative dates or periods";
            ribbonDropDownItemImpl18.Tag = "DATE";
            ribbonDropDownItemImpl19.Label = "时间片段";
            ribbonDropDownItemImpl19.ScreenTip = "不到一天的时间";
            ribbonDropDownItemImpl19.SuperTip = "Times smaller than a day";
            ribbonDropDownItemImpl19.Tag = "TIME";
            ribbonDropDownItemImpl20.Label = "百分比值";
            ribbonDropDownItemImpl20.ScreenTip = "百分比，包括“%”";
            ribbonDropDownItemImpl20.SuperTip = "percentage, including \"%\"";
            ribbonDropDownItemImpl20.Tag = "PERCENT";
            ribbonDropDownItemImpl21.Label = "金钱价值";
            ribbonDropDownItemImpl21.ScreenTip = "货币价值，包括单位价值";
            ribbonDropDownItemImpl21.SuperTip = "Monetary values, including unit";
            ribbonDropDownItemImpl21.Tag = "MONEY";
            ribbonDropDownItemImpl22.Label = "单位度量";
            ribbonDropDownItemImpl22.ScreenTip = "测量单位，如重量或距离";
            ribbonDropDownItemImpl22.SuperTip = "Measurements, as of weight or distance";
            ribbonDropDownItemImpl22.Tag = "QUANTITY";
            ribbonDropDownItemImpl23.Label = "序数词语";
            ribbonDropDownItemImpl23.ScreenTip = "第一、第二等序数词";
            ribbonDropDownItemImpl23.SuperTip = "\"first\",\"second\",etc";
            ribbonDropDownItemImpl23.Tag = "ORDINAL";
            ribbonDropDownItemImpl24.Label = "无型数字";
            ribbonDropDownItemImpl24.ScreenTip = "不属于其他类型的数字";
            ribbonDropDownItemImpl24.SuperTip = "Numerals that do not fall under another type";
            ribbonDropDownItemImpl24.Tag = "CARDINAL";
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
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl19);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl20);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl21);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl22);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl23);
            this.get_type_slct.Items.Add(ribbonDropDownItemImpl24);
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
            // MainRibbon_Sub
            // 
            this.Name = "MainRibbon_Sub";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.Start.ResumeLayout(false);
            this.Start.PerformLayout();
            this.url2img.ResumeLayout(false);
            this.url2img.PerformLayout();
            this.Regex.ResumeLayout(false);
            this.Regex.PerformLayout();
            this.NLP_Get.ResumeLayout(false);
            this.NLP_Get.PerformLayout();
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
        internal Microsoft.Office.Tools.Ribbon.RibbonButton getPicExe_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup url2img;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox splitSymbol_ipt;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox urlHead_islt;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox accurateMode_chb;
    }

    partial class ThisRibbonCollection
    {
        internal MainRibbon_Sub Ribbon1
        {
            get { return this.GetRibbon<MainRibbon_Sub>(); }
        }
    }
}
