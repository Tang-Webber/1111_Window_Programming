namespace hw6_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.BPM = new System.Windows.Forms.Label();
            this.BPMcontrol = new System.Windows.Forms.TrackBar();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Control = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.options = new System.Windows.Forms.ComboBox();
            this.four = new System.Windows.Forms.RadioButton();
            this.eight = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.BPMcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(393, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "BPM";
            // 
            // BPM
            // 
            this.BPM.AutoSize = true;
            this.BPM.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BPM.Location = new System.Drawing.Point(311, 32);
            this.BPM.Name = "BPM";
            this.BPM.Size = new System.Drawing.Size(91, 50);
            this.BPM.TabIndex = 2;
            this.BPM.Text = "120";
            // 
            // BPMcontrol
            // 
            this.BPMcontrol.Location = new System.Drawing.Point(175, 109);
            this.BPMcontrol.Maximum = 180;
            this.BPMcontrol.Minimum = 60;
            this.BPMcontrol.Name = "BPMcontrol";
            this.BPMcontrol.Size = new System.Drawing.Size(456, 69);
            this.BPMcontrol.TabIndex = 3;
            this.BPMcontrol.Value = 120;
            this.BPMcontrol.Scroll += new System.EventHandler(this.BPMcontrol_Scroll);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.min.Location = new System.Drawing.Point(121, 109);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(36, 25);
            this.min.TabIndex = 4;
            this.min.Text = "60";
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.max.Location = new System.Drawing.Point(637, 109);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(48, 25);
            this.max.TabIndex = 5;
            this.max.Text = "180";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::hw6_1.Properties.Resources.quavers;
            this.pictureBox2.Location = new System.Drawing.Point(454, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 135);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hw6_1.Properties.Resources.quarternote;
            this.pictureBox1.Location = new System.Drawing.Point(248, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 123);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Control
            // 
            this.Control.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Control.Location = new System.Drawing.Point(350, 446);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(104, 39);
            this.Control.TabIndex = 8;
            this.Control.Text = "Start";
            this.Control.UseVisualStyleBackColor = true;
            this.Control.Click += new System.EventHandler(this.Control_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(544, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(271, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Beat Emphasis";
            // 
            // options
            // 
            this.options.FormattingEnabled = true;
            this.options.Location = new System.Drawing.Point(435, 407);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(117, 26);
            this.options.TabIndex = 14;
            this.options.SelectedIndexChanged += new System.EventHandler(this.options_SelectedIndexChanged);
            // 
            // four
            // 
            this.four.AutoSize = true;
            this.four.Checked = true;
            this.four.Location = new System.Drawing.Point(299, 369);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(21, 20);
            this.four.TabIndex = 15;
            this.four.TabStop = true;
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // eight
            // 
            this.eight.AutoSize = true;
            this.eight.Location = new System.Drawing.Point(509, 369);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(21, 20);
            this.eight.TabIndex = 16;
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 525);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.four);
            this.Controls.Add(this.options);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.BPMcontrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BPM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BPMcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BPM;
        private System.Windows.Forms.TrackBar BPMcontrol;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Control;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox options;
        private System.Windows.Forms.RadioButton four;
        private System.Windows.Forms.RadioButton eight;
    }
}

