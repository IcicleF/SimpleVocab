namespace SimpleVocab
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.optExhausive = new System.Windows.Forms.RadioButton();
            this.optDefault = new System.Windows.Forms.RadioButton();
            this.optCustom = new System.Windows.Forms.RadioButton();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.optIgnoredWords = new System.Windows.Forms.RadioButton();
            this.optHardWords = new System.Windows.Forms.RadioButton();
            this.optAllWords = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustom);
            this.groupBox1.Controls.Add(this.optCustom);
            this.groupBox1.Controls.Add(this.optDefault);
            this.groupBox1.Controls.Add(this.optExhausive);
            this.groupBox1.Font = new System.Drawing.Font("更纱黑体 SC", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(30, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模式";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optIgnoredWords);
            this.groupBox2.Controls.Add(this.optHardWords);
            this.groupBox2.Controls.Add(this.optAllWords);
            this.groupBox2.Font = new System.Drawing.Font("更纱黑体 SC", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(366, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 401);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "单词集";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("更纱黑体 SC", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(709, 37);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(275, 64);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("更纱黑体 SC", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(709, 117);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(275, 64);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // optExhausive
            // 
            this.optExhausive.AutoSize = true;
            this.optExhausive.Location = new System.Drawing.Point(43, 80);
            this.optExhausive.Name = "optExhausive";
            this.optExhausive.Size = new System.Drawing.Size(92, 40);
            this.optExhausive.TabIndex = 0;
            this.optExhausive.TabStop = true;
            this.optExhausive.Text = "穷尽";
            this.optExhausive.UseVisualStyleBackColor = true;
            // 
            // optDefault
            // 
            this.optDefault.AutoSize = true;
            this.optDefault.Location = new System.Drawing.Point(43, 159);
            this.optDefault.Name = "optDefault";
            this.optDefault.Size = new System.Drawing.Size(144, 40);
            this.optDefault.TabIndex = 1;
            this.optDefault.TabStop = true;
            this.optDefault.Text = "默认抽查";
            this.optDefault.UseVisualStyleBackColor = true;
            // 
            // optCustom
            // 
            this.optCustom.AutoSize = true;
            this.optCustom.Location = new System.Drawing.Point(43, 236);
            this.optCustom.Name = "optCustom";
            this.optCustom.Size = new System.Drawing.Size(170, 40);
            this.optCustom.TabIndex = 2;
            this.optCustom.TabStop = true;
            this.optCustom.Text = "自定义抽查";
            this.optCustom.UseVisualStyleBackColor = true;
            // 
            // txtCustom
            // 
            this.txtCustom.Location = new System.Drawing.Point(73, 310);
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(187, 41);
            this.txtCustom.TabIndex = 3;
            // 
            // optIgnoredWords
            // 
            this.optIgnoredWords.AutoSize = true;
            this.optIgnoredWords.Location = new System.Drawing.Point(41, 236);
            this.optIgnoredWords.Name = "optIgnoredWords";
            this.optIgnoredWords.Size = new System.Drawing.Size(170, 40);
            this.optIgnoredWords.TabIndex = 5;
            this.optIgnoredWords.TabStop = true;
            this.optIgnoredWords.Text = "学会的单词";
            this.optIgnoredWords.UseVisualStyleBackColor = true;
            // 
            // optHardWords
            // 
            this.optHardWords.AutoSize = true;
            this.optHardWords.Location = new System.Drawing.Point(41, 159);
            this.optHardWords.Name = "optHardWords";
            this.optHardWords.Size = new System.Drawing.Size(170, 40);
            this.optHardWords.TabIndex = 4;
            this.optHardWords.TabStop = true;
            this.optHardWords.Text = "困难的单词";
            this.optHardWords.UseVisualStyleBackColor = true;
            // 
            // optAllWords
            // 
            this.optAllWords.AutoSize = true;
            this.optAllWords.Location = new System.Drawing.Point(41, 80);
            this.optAllWords.Name = "optAllWords";
            this.optAllWords.Size = new System.Drawing.Size(144, 40);
            this.optAllWords.TabIndex = 3;
            this.optAllWords.TabStop = true;
            this.optAllWords.Text = "全部单词";
            this.optAllWords.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 475);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optCustom;
        private System.Windows.Forms.RadioButton optDefault;
        private System.Windows.Forms.RadioButton optExhausive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.RadioButton optIgnoredWords;
        private System.Windows.Forms.RadioButton optHardWords;
        private System.Windows.Forms.RadioButton optAllWords;
    }
}

