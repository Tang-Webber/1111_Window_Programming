namespace hw5_1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.WrongTimeLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.WrongTime = new System.Windows.Forms.Label();
            this.CorrectWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Title.Location = new System.Drawing.Point(292, 53);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(221, 92);
            this.Title.TabIndex = 0;
            this.Title.Text = "猜英文單字\r\n6次猜錯機會\r\n";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(300, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "請輸入要猜的單字:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Word
            // 
            this.Word.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Word.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Word.Location = new System.Drawing.Point(305, 217);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(189, 31);
            this.Word.TabIndex = 2;
            this.Word.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Word_KeyPress);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.Control;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Start.Location = new System.Drawing.Point(336, 271);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(128, 60);
            this.Start.TabIndex = 3;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Time.Location = new System.Drawing.Point(675, 44);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(18, 20);
            this.Time.TabIndex = 4;
            this.Time.Text = "0";
            this.Time.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Time.Visible = false;
            // 
            // WrongTimeLabel
            // 
            this.WrongTimeLabel.AutoSize = true;
            this.WrongTimeLabel.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WrongTimeLabel.Location = new System.Drawing.Point(633, 73);
            this.WrongTimeLabel.Name = "WrongTimeLabel";
            this.WrongTimeLabel.Size = new System.Drawing.Size(77, 20);
            this.WrongTimeLabel.TabIndex = 5;
            this.WrongTimeLabel.Text = "猜錯次數:";
            this.WrongTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WrongTimeLabel.Visible = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeLabel.Location = new System.Drawing.Point(633, 44);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(45, 20);
            this.TimeLabel.TabIndex = 6;
            this.TimeLabel.Text = "時間:";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TimeLabel.Visible = false;
            // 
            // WrongTime
            // 
            this.WrongTime.AutoSize = true;
            this.WrongTime.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WrongTime.Location = new System.Drawing.Point(706, 73);
            this.WrongTime.Name = "WrongTime";
            this.WrongTime.Size = new System.Drawing.Size(34, 20);
            this.WrongTime.TabIndex = 7;
            this.WrongTime.Text = "0次";
            this.WrongTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WrongTime.Visible = false;
            // 
            // CorrectWord
            // 
            this.CorrectWord.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CorrectWord.Location = new System.Drawing.Point(102, 272);
            this.CorrectWord.Name = "CorrectWord";
            this.CorrectWord.Size = new System.Drawing.Size(576, 45);
            this.CorrectWord.TabIndex = 8;
            this.CorrectWord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CorrectWord.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WrongTime);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.WrongTimeLabel);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CorrectWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label WrongTimeLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label WrongTime;
        private System.Windows.Forms.Label CorrectWord;
    }
}

