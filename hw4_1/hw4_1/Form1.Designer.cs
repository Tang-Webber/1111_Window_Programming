namespace hw4_1
{
    partial class Form1
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
            this.Title = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.cont = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Restart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nameuser = new System.Windows.Forms.TextBox();
            this.billiboard = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(177, 40);
            this.Title.TabIndex = 0;
            this.Title.Text = "翻牌小遊戲";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start.Location = new System.Drawing.Point(861, 50);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(115, 49);
            this.start.TabIndex = 1;
            this.start.Text = "開始遊戲";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // cont
            // 
            this.cont.Enabled = false;
            this.cont.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cont.Location = new System.Drawing.Point(861, 128);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(115, 49);
            this.cont.TabIndex = 2;
            this.cont.Text = "繼續";
            this.cont.UseVisualStyleBackColor = true;
            this.cont.Click += new System.EventHandler(this.cont_Click);
            // 
            // end
            // 
            this.end.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.end.Location = new System.Drawing.Point(861, 494);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(115, 49);
            this.end.TabIndex = 3;
            this.end.Text = "離開遊戲";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(19, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 731);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Nameuser);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Score);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Restart);
            this.tabPage1.Controls.Add(this.start);
            this.tabPage1.Controls.Add(this.end);
            this.tabPage1.Controls.Add(this.cont);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1024, 695);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "遊玩區";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.billiboard);
            this.tabPage2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1024, 695);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "歷史紀錄區";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Restart
            // 
            this.Restart.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Restart.Location = new System.Drawing.Point(861, 203);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(115, 49);
            this.Restart.TabIndex = 4;
            this.Restart.Text = "重新開始";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "分數：";
            // 
            // Score
            // 
            this.Score.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Score.Location = new System.Drawing.Point(92, 18);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(85, 35);
            this.Score.TabIndex = 6;
            this.Score.Text = "100";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(183, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "名稱：";
            // 
            // Nameuser
            // 
            this.Nameuser.Location = new System.Drawing.Point(258, 18);
            this.Nameuser.Name = "Nameuser";
            this.Nameuser.Size = new System.Drawing.Size(170, 31);
            this.Nameuser.TabIndex = 8;
            // 
            // billiboard
            // 
            this.billiboard.BackColor = System.Drawing.Color.White;
            this.billiboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.billiboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billiboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.billiboard.Location = new System.Drawing.Point(21, 22);
            this.billiboard.Name = "billiboard";
            this.billiboard.Padding = new System.Windows.Forms.Padding(1);
            this.billiboard.Size = new System.Drawing.Size(978, 654);
            this.billiboard.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 814);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button cont;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nameuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label billiboard;
    }
}

