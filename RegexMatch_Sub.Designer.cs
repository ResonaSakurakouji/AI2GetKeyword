namespace AI2GetKeyword
{
    partial class RegexMatch_Sub
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.Regex_InputTitle = new System.Windows.Forms.Label();
            this.Regex_Check_btn = new System.Windows.Forms.Button();
            this.Regex_InputBox = new System.Windows.Forms.TextBox();
            this.Regex_Return_btn = new System.Windows.Forms.Button();
            this.Regex_OverWrite_chb = new System.Windows.Forms.CheckBox();
            this.Regex_rbtn_CheckMod = new System.Windows.Forms.RadioButton();
            this.Regex_rbtn_FilterMod = new System.Windows.Forms.RadioButton();
            this.Regex_rbtn_ReplaceMod = new System.Windows.Forms.RadioButton();
            this.Regex_Input_new2replace = new System.Windows.Forms.TextBox();
            this.Regex_label_replace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Regex_InputTitle
            // 
            this.Regex_InputTitle.AutoSize = true;
            this.Regex_InputTitle.Font = new System.Drawing.Font("黑体", 13F);
            this.Regex_InputTitle.ForeColor = System.Drawing.Color.Black;
            this.Regex_InputTitle.Location = new System.Drawing.Point(3, 7);
            this.Regex_InputTitle.Name = "Regex_InputTitle";
            this.Regex_InputTitle.Size = new System.Drawing.Size(188, 18);
            this.Regex_InputTitle.TabIndex = 1;
            this.Regex_InputTitle.Text = "请在此粘贴正则表达式";
            this.Regex_InputTitle.Click += new System.EventHandler(this.Regex_InputTitle_Click);
            // 
            // Regex_Check_btn
            // 
            this.Regex_Check_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Regex_Check_btn.ForeColor = System.Drawing.Color.Black;
            this.Regex_Check_btn.Location = new System.Drawing.Point(144, 32);
            this.Regex_Check_btn.Name = "Regex_Check_btn";
            this.Regex_Check_btn.Size = new System.Drawing.Size(47, 21);
            this.Regex_Check_btn.TabIndex = 2;
            this.Regex_Check_btn.Text = "校验";
            this.Regex_Check_btn.UseVisualStyleBackColor = false;
            this.Regex_Check_btn.Click += new System.EventHandler(this.Regex_Check_btn_Click);
            // 
            // Regex_InputBox
            // 
            this.Regex_InputBox.AllowDrop = true;
            this.Regex_InputBox.ForeColor = System.Drawing.Color.Black;
            this.Regex_InputBox.Location = new System.Drawing.Point(7, 32);
            this.Regex_InputBox.Name = "Regex_InputBox";
            this.Regex_InputBox.Size = new System.Drawing.Size(128, 21);
            this.Regex_InputBox.TabIndex = 3;
            this.Regex_InputBox.TextChanged += new System.EventHandler(this.Regex_InputBox_Changed);
            // 
            // Regex_Return_btn
            // 
            this.Regex_Return_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.Regex_Return_btn.ForeColor = System.Drawing.Color.Black;
            this.Regex_Return_btn.Location = new System.Drawing.Point(7, 108);
            this.Regex_Return_btn.Name = "Regex_Return_btn";
            this.Regex_Return_btn.Size = new System.Drawing.Size(181, 23);
            this.Regex_Return_btn.TabIndex = 4;
            this.Regex_Return_btn.Text = "获取结果";
            this.Regex_Return_btn.UseVisualStyleBackColor = false;
            this.Regex_Return_btn.Visible = false;
            this.Regex_Return_btn.Click += new System.EventHandler(this.Regex_Return_btn_Click);
            // 
            // Regex_OverWrite_chb
            // 
            this.Regex_OverWrite_chb.AutoSize = true;
            this.Regex_OverWrite_chb.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Regex_OverWrite_chb.ForeColor = System.Drawing.Color.Black;
            this.Regex_OverWrite_chb.Location = new System.Drawing.Point(7, 137);
            this.Regex_OverWrite_chb.Name = "Regex_OverWrite_chb";
            this.Regex_OverWrite_chb.Size = new System.Drawing.Size(82, 18);
            this.Regex_OverWrite_chb.TabIndex = 5;
            this.Regex_OverWrite_chb.Text = "覆盖生成";
            this.Regex_OverWrite_chb.UseVisualStyleBackColor = true;
            this.Regex_OverWrite_chb.CheckedChanged += new System.EventHandler(this.Regex_OverWrite_chb_CheckedChanged);
            // 
            // Regex_rbtn_CheckMod
            // 
            this.Regex_rbtn_CheckMod.AutoSize = true;
            this.Regex_rbtn_CheckMod.ForeColor = System.Drawing.Color.Black;
            this.Regex_rbtn_CheckMod.Location = new System.Drawing.Point(6, 59);
            this.Regex_rbtn_CheckMod.Name = "Regex_rbtn_CheckMod";
            this.Regex_rbtn_CheckMod.Size = new System.Drawing.Size(47, 16);
            this.Regex_rbtn_CheckMod.TabIndex = 6;
            this.Regex_rbtn_CheckMod.TabStop = true;
            this.Regex_rbtn_CheckMod.Text = "验证";
            this.Regex_rbtn_CheckMod.UseVisualStyleBackColor = true;
            this.Regex_rbtn_CheckMod.CheckedChanged += new System.EventHandler(this.Regex_rbtn_CheckMod_CheckedChanged);
            // 
            // Regex_rbtn_FilterMod
            // 
            this.Regex_rbtn_FilterMod.AutoSize = true;
            this.Regex_rbtn_FilterMod.ForeColor = System.Drawing.Color.Black;
            this.Regex_rbtn_FilterMod.Location = new System.Drawing.Point(78, 59);
            this.Regex_rbtn_FilterMod.Name = "Regex_rbtn_FilterMod";
            this.Regex_rbtn_FilterMod.Size = new System.Drawing.Size(47, 16);
            this.Regex_rbtn_FilterMod.TabIndex = 7;
            this.Regex_rbtn_FilterMod.TabStop = true;
            this.Regex_rbtn_FilterMod.Text = "提取";
            this.Regex_rbtn_FilterMod.UseVisualStyleBackColor = true;
            // 
            // Regex_rbtn_ReplaceMod
            // 
            this.Regex_rbtn_ReplaceMod.AutoSize = true;
            this.Regex_rbtn_ReplaceMod.ForeColor = System.Drawing.Color.Black;
            this.Regex_rbtn_ReplaceMod.Location = new System.Drawing.Point(141, 59);
            this.Regex_rbtn_ReplaceMod.Name = "Regex_rbtn_ReplaceMod";
            this.Regex_rbtn_ReplaceMod.Size = new System.Drawing.Size(47, 16);
            this.Regex_rbtn_ReplaceMod.TabIndex = 8;
            this.Regex_rbtn_ReplaceMod.TabStop = true;
            this.Regex_rbtn_ReplaceMod.Text = "替换";
            this.Regex_rbtn_ReplaceMod.UseVisualStyleBackColor = true;
            this.Regex_rbtn_ReplaceMod.CheckedChanged += new System.EventHandler(this.Regex_rbtn_Replace_CheckedChanged);
            // 
            // Regex_Input_new2replace
            // 
            this.Regex_Input_new2replace.Location = new System.Drawing.Point(88, 81);
            this.Regex_Input_new2replace.Name = "Regex_Input_new2replace";
            this.Regex_Input_new2replace.Size = new System.Drawing.Size(100, 21);
            this.Regex_Input_new2replace.TabIndex = 9;
            this.Regex_Input_new2replace.Visible = false;
            this.Regex_Input_new2replace.TextChanged += new System.EventHandler(this.Regex_Input_new2replace_TextChanged);
            // 
            // Regex_label_replace
            // 
            this.Regex_label_replace.AutoSize = true;
            this.Regex_label_replace.Font = new System.Drawing.Font("黑体", 10F);
            this.Regex_label_replace.ForeColor = System.Drawing.Color.Black;
            this.Regex_label_replace.Location = new System.Drawing.Point(19, 83);
            this.Regex_label_replace.Name = "Regex_label_replace";
            this.Regex_label_replace.Size = new System.Drawing.Size(63, 14);
            this.Regex_label_replace.TabIndex = 10;
            this.Regex_label_replace.Text = "替换为：";
            this.Regex_label_replace.Visible = false;
            // 
            // RegexMatch_Sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(4, 4);
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Regex_label_replace);
            this.Controls.Add(this.Regex_Input_new2replace);
            this.Controls.Add(this.Regex_rbtn_ReplaceMod);
            this.Controls.Add(this.Regex_rbtn_FilterMod);
            this.Controls.Add(this.Regex_rbtn_CheckMod);
            this.Controls.Add(this.Regex_OverWrite_chb);
            this.Controls.Add(this.Regex_Return_btn);
            this.Controls.Add(this.Regex_InputBox);
            this.Controls.Add(this.Regex_Check_btn);
            this.Controls.Add(this.Regex_InputTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "RegexMatch_Sub";
            this.Size = new System.Drawing.Size(202, 497);
            this.Load += new System.EventHandler(this.GetWorkbookData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Regex_InputTitle;
        private System.Windows.Forms.Button Regex_Check_btn;
        private System.Windows.Forms.TextBox Regex_InputBox;
        private System.Windows.Forms.Button Regex_Return_btn;
        private System.Windows.Forms.CheckBox Regex_OverWrite_chb;
        private System.Windows.Forms.RadioButton Regex_rbtn_CheckMod;
        private System.Windows.Forms.RadioButton Regex_rbtn_FilterMod;
        private System.Windows.Forms.RadioButton Regex_rbtn_ReplaceMod;
        private System.Windows.Forms.TextBox Regex_Input_new2replace;
        private System.Windows.Forms.Label Regex_label_replace;
    }
}
