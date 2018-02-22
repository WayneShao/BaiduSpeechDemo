namespace BaiduSpeechDemo
{
    partial class SpeechFrm
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
            this.tbLog = new System.Windows.Forms.TextBox();
            this.btnAsr = new System.Windows.Forms.Button();
            this.tbContext = new System.Windows.Forms.TextBox();
            this.btnTts = new System.Windows.Forms.Button();
            this.grpAsr = new System.Windows.Forms.GroupBox();
            this.grpTts = new System.Windows.Forms.GroupBox();
            this.cbPer = new System.Windows.Forms.ComboBox();
            this.lbPit = new System.Windows.Forms.Label();
            this.lbPer = new System.Windows.Forms.Label();
            this.lbVol = new System.Windows.Forms.Label();
            this.lbSpd = new System.Windows.Forms.Label();
            this.nudPit = new System.Windows.Forms.NumericUpDown();
            this.nudVol = new System.Windows.Forms.NumericUpDown();
            this.nudSpd = new System.Windows.Forms.NumericUpDown();
            this.grpAsr.SuspendLayout();
            this.grpTts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpd)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbLog.Location = new System.Drawing.Point(0, 166);
            this.tbLog.MaxLength = 0;
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(289, 72);
            this.tbLog.TabIndex = 6;
            // 
            // btnAsr
            // 
            this.btnAsr.Location = new System.Drawing.Point(19, 29);
            this.btnAsr.Name = "btnAsr";
            this.btnAsr.Size = new System.Drawing.Size(75, 23);
            this.btnAsr.TabIndex = 0;
            this.btnAsr.Text = "开始录音";
            this.btnAsr.UseVisualStyleBackColor = true;
            this.btnAsr.Click += new System.EventHandler(this.btnAsr_Click);
            // 
            // tbContext
            // 
            this.tbContext.Location = new System.Drawing.Point(5, 13);
            this.tbContext.Multiline = true;
            this.tbContext.Name = "tbContext";
            this.tbContext.Size = new System.Drawing.Size(283, 139);
            this.tbContext.TabIndex = 2;
            this.tbContext.Text = "你好，世界！";
            // 
            // btnTts
            // 
            this.btnTts.Location = new System.Drawing.Point(307, 13);
            this.btnTts.Name = "btnTts";
            this.btnTts.Size = new System.Drawing.Size(75, 23);
            this.btnTts.TabIndex = 3;
            this.btnTts.Text = "TTS";
            this.btnTts.UseVisualStyleBackColor = true;
            this.btnTts.Click += new System.EventHandler(this.btnTts_Click);
            // 
            // grpAsr
            // 
            this.grpAsr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpAsr.Controls.Add(this.btnAsr);
            this.grpAsr.Location = new System.Drawing.Point(295, 166);
            this.grpAsr.Name = "grpAsr";
            this.grpAsr.Size = new System.Drawing.Size(114, 72);
            this.grpAsr.TabIndex = 7;
            this.grpAsr.TabStop = false;
            this.grpAsr.Text = "ASR";
            // 
            // grpTts
            // 
            this.grpTts.Controls.Add(this.cbPer);
            this.grpTts.Controls.Add(this.lbPit);
            this.grpTts.Controls.Add(this.lbPer);
            this.grpTts.Controls.Add(this.lbVol);
            this.grpTts.Controls.Add(this.lbSpd);
            this.grpTts.Controls.Add(this.nudPit);
            this.grpTts.Controls.Add(this.nudVol);
            this.grpTts.Controls.Add(this.nudSpd);
            this.grpTts.Controls.Add(this.tbContext);
            this.grpTts.Controls.Add(this.btnTts);
            this.grpTts.Location = new System.Drawing.Point(1, 3);
            this.grpTts.Name = "grpTts";
            this.grpTts.Size = new System.Drawing.Size(408, 159);
            this.grpTts.TabIndex = 8;
            this.grpTts.TabStop = false;
            this.grpTts.Text = "TTS";
            // 
            // cbPer
            // 
            this.cbPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPer.FormattingEnabled = true;
            this.cbPer.Items.AddRange(new object[] {
            "普通女声",
            "普通男生",
            "度逍遥",
            "度丫丫"});
            this.cbPer.Location = new System.Drawing.Point(335, 131);
            this.cbPer.Name = "cbPer";
            this.cbPer.Size = new System.Drawing.Size(63, 20);
            this.cbPer.TabIndex = 6;
            // 
            // lbPit
            // 
            this.lbPit.AutoSize = true;
            this.lbPit.Location = new System.Drawing.Point(305, 78);
            this.lbPit.Name = "lbPit";
            this.lbPit.Size = new System.Drawing.Size(29, 12);
            this.lbPit.TabIndex = 5;
            this.lbPit.Text = "音调";
            // 
            // lbPer
            // 
            this.lbPer.AutoSize = true;
            this.lbPer.Location = new System.Drawing.Point(293, 135);
            this.lbPer.Name = "lbPer";
            this.lbPer.Size = new System.Drawing.Size(41, 12);
            this.lbPer.TabIndex = 5;
            this.lbPer.Text = "发言人";
            // 
            // lbVol
            // 
            this.lbVol.AutoSize = true;
            this.lbVol.Location = new System.Drawing.Point(304, 105);
            this.lbVol.Name = "lbVol";
            this.lbVol.Size = new System.Drawing.Size(29, 12);
            this.lbVol.TabIndex = 5;
            this.lbVol.Text = "音量";
            // 
            // lbSpd
            // 
            this.lbSpd.AutoSize = true;
            this.lbSpd.Location = new System.Drawing.Point(305, 53);
            this.lbSpd.Name = "lbSpd";
            this.lbSpd.Size = new System.Drawing.Size(29, 12);
            this.lbSpd.TabIndex = 5;
            this.lbSpd.Text = "语速";
            // 
            // nudPit
            // 
            this.nudPit.Location = new System.Drawing.Point(346, 76);
            this.nudPit.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudPit.Name = "nudPit";
            this.nudPit.Size = new System.Drawing.Size(42, 21);
            this.nudPit.TabIndex = 4;
            this.nudPit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudVol
            // 
            this.nudVol.Location = new System.Drawing.Point(346, 103);
            this.nudVol.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudVol.Name = "nudVol";
            this.nudVol.Size = new System.Drawing.Size(42, 21);
            this.nudVol.TabIndex = 4;
            this.nudVol.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudSpd
            // 
            this.nudSpd.Location = new System.Drawing.Point(346, 49);
            this.nudSpd.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudSpd.Name = "nudSpd";
            this.nudSpd.Size = new System.Drawing.Size(42, 21);
            this.nudSpd.TabIndex = 4;
            this.nudSpd.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // SpeechFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 238);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.grpAsr);
            this.Controls.Add(this.grpTts);
            this.Name = "SpeechFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "百度语音Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpeechFrm_FormClosing);
            this.Load += new System.EventHandler(this.SpeechFrm_Load);
            this.grpAsr.ResumeLayout(false);
            this.grpTts.ResumeLayout(false);
            this.grpTts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button btnAsr;
        private System.Windows.Forms.TextBox tbContext;
        private System.Windows.Forms.Button btnTts;
        private System.Windows.Forms.GroupBox grpAsr;
        private System.Windows.Forms.GroupBox grpTts;
        private System.Windows.Forms.ComboBox cbPer;
        private System.Windows.Forms.Label lbPit;
        private System.Windows.Forms.Label lbPer;
        private System.Windows.Forms.Label lbVol;
        private System.Windows.Forms.Label lbSpd;
        private System.Windows.Forms.NumericUpDown nudPit;
        private System.Windows.Forms.NumericUpDown nudVol;
        private System.Windows.Forms.NumericUpDown nudSpd;
    }
}

