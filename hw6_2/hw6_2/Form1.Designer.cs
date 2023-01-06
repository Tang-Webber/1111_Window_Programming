namespace hw6_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.MediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Status = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.log = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(671, 462);
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MediaPlayer2);
            this.tabPage1.Controls.Add(this.MediaPlayer1);
            this.tabPage1.Controls.Add(this.Status);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(663, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Telephone";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MediaPlayer2
            // 
            this.MediaPlayer2.Enabled = true;
            this.MediaPlayer2.Location = new System.Drawing.Point(186, 42);
            this.MediaPlayer2.Name = "MediaPlayer2";
            this.MediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer2.OcxState")));
            this.MediaPlayer2.Size = new System.Drawing.Size(271, 378);
            this.MediaPlayer2.TabIndex = 2;
            this.MediaPlayer2.Visible = false;
            // 
            // MediaPlayer1
            // 
            this.MediaPlayer1.Enabled = true;
            this.MediaPlayer1.Location = new System.Drawing.Point(186, 42);
            this.MediaPlayer1.Name = "MediaPlayer1";
            this.MediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer1.OcxState")));
            this.MediaPlayer1.Size = new System.Drawing.Size(271, 378);
            this.MediaPlayer1.TabIndex = 1;
            this.MediaPlayer1.Visible = false;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Status.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Status.Location = new System.Drawing.Point(6, 3);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(221, 50);
            this.Status.TabIndex = 0;
            this.Status.Text = "Telephone";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.log);
            this.tabPage2.Controls.Add(this.save);
            this.tabPage2.Controls.Add(this.Path);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(663, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // log
            // 
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.log.Location = new System.Drawing.Point(43, 81);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(593, 330);
            this.log.TabIndex = 3;
            // 
            // save
            // 
            this.save.AutoSize = true;
            this.save.Location = new System.Drawing.Point(561, 30);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 33);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(101, 32);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(437, 31);
            this.Path.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Save";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 479);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Label label2;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer1;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer2;
        private System.Windows.Forms.Timer timer1;
    }
}

