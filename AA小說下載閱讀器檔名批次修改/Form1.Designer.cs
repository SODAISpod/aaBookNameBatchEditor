namespace AA小說下載閱讀器檔名批次修改
{
    partial class AA修改器
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.loadFile_cmd = new System.Windows.Forms.Button();
            this.loadFile_txt = new System.Windows.Forms.TextBox();
            this.prefixDigist = new System.Windows.Forms.CheckBox();
            this.combineTXT = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loadFile_cmd
            // 
            this.loadFile_cmd.Font = new System.Drawing.Font("jf open 粉圓 1.1", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loadFile_cmd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadFile_cmd.Location = new System.Drawing.Point(199, 62);
            this.loadFile_cmd.Name = "loadFile_cmd";
            this.loadFile_cmd.Size = new System.Drawing.Size(164, 90);
            this.loadFile_cmd.TabIndex = 0;
            this.loadFile_cmd.Text = "開啟\r\n並編輯";
            this.loadFile_cmd.UseVisualStyleBackColor = true;
            this.loadFile_cmd.Click += new System.EventHandler(this.loadFile_cmd_Click);
            // 
            // loadFile_txt
            // 
            this.loadFile_txt.Location = new System.Drawing.Point(59, 62);
            this.loadFile_txt.Name = "loadFile_txt";
            this.loadFile_txt.Size = new System.Drawing.Size(47, 22);
            this.loadFile_txt.TabIndex = 1;
            this.loadFile_txt.Visible = false;
            // 
            // prefixDigist
            // 
            this.prefixDigist.AutoSize = true;
            this.prefixDigist.Font = new System.Drawing.Font("Taipei Sans TC Beta", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.prefixDigist.Location = new System.Drawing.Point(199, 158);
            this.prefixDigist.Name = "prefixDigist";
            this.prefixDigist.Size = new System.Drawing.Size(147, 21);
            this.prefixDigist.TabIndex = 2;
            this.prefixDigist.Text = "檔名前綴羅馬數字";
            this.prefixDigist.UseVisualStyleBackColor = true;
            // 
            // combineTXT
            // 
            this.combineTXT.AutoSize = true;
            this.combineTXT.Font = new System.Drawing.Font("Taipei Sans TC Beta", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combineTXT.Location = new System.Drawing.Point(199, 180);
            this.combineTXT.Name = "combineTXT";
            this.combineTXT.Size = new System.Drawing.Size(84, 21);
            this.combineTXT.TabIndex = 2;
            this.combineTXT.Text = "合併TXT";
            this.combineTXT.UseVisualStyleBackColor = true;
            // 
            // AA修改器
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 238);
            this.Controls.Add(this.combineTXT);
            this.Controls.Add(this.prefixDigist);
            this.Controls.Add(this.loadFile_txt);
            this.Controls.Add(this.loadFile_cmd);
            this.Name = "AA修改器";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFile_cmd;
        private System.Windows.Forms.TextBox loadFile_txt;
        private System.Windows.Forms.CheckBox prefixDigist;
        private System.Windows.Forms.CheckBox combineTXT;
    }
}

