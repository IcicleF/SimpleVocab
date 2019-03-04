namespace SimpleVocab
{
    partial class WordCheckForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWord = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.chkHard = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("更纱黑体 SC", 27.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWord.Location = new System.Drawing.Point(60, 54);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(62, 88);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "/";
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("更纱黑体 SC", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnYes.Location = new System.Drawing.Point(75, 189);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(228, 58);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "认识";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("更纱黑体 SC", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNo.Location = new System.Drawing.Point(350, 189);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(228, 58);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "不认识";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // chkHard
            // 
            this.chkHard.AutoSize = true;
            this.chkHard.Font = new System.Drawing.Font("更纱黑体 SC", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkHard.Location = new System.Drawing.Point(630, 199);
            this.chkHard.Name = "chkHard";
            this.chkHard.Size = new System.Drawing.Size(93, 40);
            this.chkHard.TabIndex = 3;
            this.chkHard.Text = "困难";
            this.chkHard.UseVisualStyleBackColor = true;
            // 
            // WordCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 307);
            this.Controls.Add(this.chkHard);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WordCheckForm";
            this.Text = "WordCheckForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.CheckBox chkHard;
    }
}