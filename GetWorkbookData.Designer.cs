namespace AI2GetKeyword
{
    partial class GetWorkbookData
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
            this.Regex_Check_btn.Location = new System.Drawing.Point(141, 32);
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
            this.Regex_InputBox.Text = "//";
            this.Regex_InputBox.TextChanged += new System.EventHandler(this.Regex_InputBox_Changed);
            // 
            // Regex_Return_btn
            // 
            this.Regex_Return_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.Regex_Return_btn.ForeColor = System.Drawing.Color.Black;
            this.Regex_Return_btn.Location = new System.Drawing.Point(7, 59);
            this.Regex_Return_btn.Name = "Regex_Return_btn";
            this.Regex_Return_btn.Size = new System.Drawing.Size(181, 23);
            this.Regex_Return_btn.TabIndex = 4;
            this.Regex_Return_btn.Text = "将结果返回至设定好的生成区域";
            this.Regex_Return_btn.UseVisualStyleBackColor = false;
            this.Regex_Return_btn.Visible = false;
            this.Regex_Return_btn.Click += new System.EventHandler(this.Regex_Return_btn_Click);
            // 
            // GetWorkbookData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(4, 4);
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.Regex_Return_btn);
            this.Controls.Add(this.Regex_InputBox);
            this.Controls.Add(this.Regex_Check_btn);
            this.Controls.Add(this.Regex_InputTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "GetWorkbookData";
            this.Size = new System.Drawing.Size(200, 495);
            this.Load += new System.EventHandler(this.GetWorkbookData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Regex_InputTitle;
        private System.Windows.Forms.Button Regex_Check_btn;
        private System.Windows.Forms.TextBox Regex_InputBox;
        private System.Windows.Forms.Button Regex_Return_btn;
    }
}
