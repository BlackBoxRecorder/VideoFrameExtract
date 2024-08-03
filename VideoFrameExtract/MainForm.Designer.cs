namespace VideoFrameExtract
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextVideoFile = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextImageDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbImageFormat = new System.Windows.Forms.ComboBox();
            this.TextFrameCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextTotalFrame = new System.Windows.Forms.TextBox();
            this.CkbTotalFrame = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextSkipFrame = new System.Windows.Forms.TextBox();
            this.CkbSkipFrame = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TextStopAfterSecond = new System.Windows.Forms.TextBox();
            this.CkbStopAfterSecond = new System.Windows.Forms.CheckBox();
            this.BtnExtract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "视频文件";
            // 
            // TextVideoFile
            // 
            this.TextVideoFile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextVideoFile.Location = new System.Drawing.Point(88, 23);
            this.TextVideoFile.Name = "TextVideoFile";
            this.TextVideoFile.Size = new System.Drawing.Size(370, 26);
            this.TextVideoFile.TabIndex = 1;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(388, 195);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(70, 24);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "图片目录";
            // 
            // TextImageDir
            // 
            this.TextImageDir.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextImageDir.Location = new System.Drawing.Point(88, 64);
            this.TextImageDir.Name = "TextImageDir";
            this.TextImageDir.Size = new System.Drawing.Size(370, 26);
            this.TextImageDir.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "图片格式";
            // 
            // CmbImageFormat
            // 
            this.CmbImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbImageFormat.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmbImageFormat.FormattingEnabled = true;
            this.CmbImageFormat.Location = new System.Drawing.Point(337, 108);
            this.CmbImageFormat.Name = "CmbImageFormat";
            this.CmbImageFormat.Size = new System.Drawing.Size(121, 24);
            this.CmbImageFormat.TabIndex = 3;
            // 
            // TextFrameCount
            // 
            this.TextFrameCount.AutoSize = true;
            this.TextFrameCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextFrameCount.Location = new System.Drawing.Point(277, 157);
            this.TextFrameCount.Name = "TextFrameCount";
            this.TextFrameCount.Size = new System.Drawing.Size(77, 12);
            this.TextFrameCount.TabIndex = 4;
            this.TextFrameCount.Text = "已提取：0 帧";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "抽取";
            // 
            // TextTotalFrame
            // 
            this.TextTotalFrame.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextTotalFrame.Location = new System.Drawing.Point(90, 108);
            this.TextTotalFrame.Name = "TextTotalFrame";
            this.TextTotalFrame.Size = new System.Drawing.Size(55, 26);
            this.TextTotalFrame.TabIndex = 1;
            // 
            // CkbTotalFrame
            // 
            this.CkbTotalFrame.AutoSize = true;
            this.CkbTotalFrame.Location = new System.Drawing.Point(30, 115);
            this.CkbTotalFrame.Name = "CkbTotalFrame";
            this.CkbTotalFrame.Size = new System.Drawing.Size(15, 14);
            this.CkbTotalFrame.TabIndex = 5;
            this.CkbTotalFrame.UseVisualStyleBackColor = true;
            this.CkbTotalFrame.CheckedChanged += new System.EventHandler(this.CkbTotalFrame_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "帧后停止";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "每隔";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "帧抽取一帧";
            // 
            // TextSkipFrame
            // 
            this.TextSkipFrame.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextSkipFrame.Location = new System.Drawing.Point(90, 150);
            this.TextSkipFrame.Name = "TextSkipFrame";
            this.TextSkipFrame.Size = new System.Drawing.Size(55, 26);
            this.TextSkipFrame.TabIndex = 1;
            // 
            // CkbSkipFrame
            // 
            this.CkbSkipFrame.AutoSize = true;
            this.CkbSkipFrame.Location = new System.Drawing.Point(30, 157);
            this.CkbSkipFrame.Name = "CkbSkipFrame";
            this.CkbSkipFrame.Size = new System.Drawing.Size(15, 14);
            this.CkbSkipFrame.TabIndex = 5;
            this.CkbSkipFrame.UseVisualStyleBackColor = true;
            this.CkbSkipFrame.CheckedChanged += new System.EventHandler(this.CkbSkipFrame_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "执行";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "秒后停止";
            // 
            // TextStopAfterSecond
            // 
            this.TextStopAfterSecond.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextStopAfterSecond.Location = new System.Drawing.Point(90, 193);
            this.TextStopAfterSecond.Name = "TextStopAfterSecond";
            this.TextStopAfterSecond.Size = new System.Drawing.Size(55, 26);
            this.TextStopAfterSecond.TabIndex = 1;
            // 
            // CkbStopAfterSecond
            // 
            this.CkbStopAfterSecond.AutoSize = true;
            this.CkbStopAfterSecond.Location = new System.Drawing.Point(30, 200);
            this.CkbStopAfterSecond.Name = "CkbStopAfterSecond";
            this.CkbStopAfterSecond.Size = new System.Drawing.Size(15, 14);
            this.CkbStopAfterSecond.TabIndex = 5;
            this.CkbStopAfterSecond.UseVisualStyleBackColor = true;
            this.CkbStopAfterSecond.CheckedChanged += new System.EventHandler(this.CkbStopAfterMinute_CheckedChanged);
            // 
            // BtnExtract
            // 
            this.BtnExtract.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnExtract.Location = new System.Drawing.Point(279, 195);
            this.BtnExtract.Name = "BtnExtract";
            this.BtnExtract.Size = new System.Drawing.Size(70, 24);
            this.BtnExtract.TabIndex = 2;
            this.BtnExtract.Text = "提取";
            this.BtnExtract.UseVisualStyleBackColor = true;
            this.BtnExtract.Click += new System.EventHandler(this.BtnExtract_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 252);
            this.Controls.Add(this.CkbStopAfterSecond);
            this.Controls.Add(this.CkbSkipFrame);
            this.Controls.Add(this.CkbTotalFrame);
            this.Controls.Add(this.TextFrameCount);
            this.Controls.Add(this.CmbImageFormat);
            this.Controls.Add(this.BtnExtract);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TextStopAfterSecond);
            this.Controls.Add(this.TextSkipFrame);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextTotalFrame);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextImageDir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextVideoFile);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "视频帧提取";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextVideoFile;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextImageDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbImageFormat;
        private System.Windows.Forms.Label TextFrameCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextTotalFrame;
        private System.Windows.Forms.CheckBox CkbTotalFrame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextSkipFrame;
        private System.Windows.Forms.CheckBox CkbSkipFrame;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextStopAfterSecond;
        private System.Windows.Forms.CheckBox CkbStopAfterSecond;
        private System.Windows.Forms.Button BtnExtract;
    }
}

