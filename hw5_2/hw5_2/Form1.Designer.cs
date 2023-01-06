namespace hw5_2
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
            this.Start = new System.Windows.Forms.Button();
            this.Phase = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.Label();
            this.p1w = new System.Windows.Forms.Button();
            this.p2w = new System.Windows.Forms.Button();
            this.p1r = new System.Windows.Forms.Button();
            this.p1m = new System.Windows.Forms.Button();
            this.p2m = new System.Windows.Forms.Button();
            this.p2r = new System.Windows.Forms.Button();
            this.p2current = new System.Windows.Forms.Label();
            this.p1current = new System.Windows.Forms.Label();
            this.p1state = new System.Windows.Forms.Label();
            this.p2state = new System.Windows.Forms.Label();
            this.p1attack = new System.Windows.Forms.Button();
            this.p1standby = new System.Windows.Forms.Button();
            this.p1skill = new System.Windows.Forms.Button();
            this.p1move = new System.Windows.Forms.Button();
            this.p1end = new System.Windows.Forms.Button();
            this.p2end = new System.Windows.Forms.Button();
            this.p2move = new System.Windows.Forms.Button();
            this.p2skill = new System.Windows.Forms.Button();
            this.p2standby = new System.Windows.Forms.Button();
            this.p2attack = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Start.Location = new System.Drawing.Point(360, 241);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(171, 76);
            this.Start.TabIndex = 0;
            this.Start.Text = "開始遊戲";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Phase
            // 
            this.Phase.AutoSize = true;
            this.Phase.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Phase.Location = new System.Drawing.Point(364, 9);
            this.Phase.Name = "Phase";
            this.Phase.Size = new System.Drawing.Size(145, 40);
            this.Phase.TabIndex = 1;
            this.Phase.Text = "準備階段";
            this.Phase.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Time.Location = new System.Drawing.Point(364, 49);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(145, 40);
            this.Time.TabIndex = 2;
            this.Time.Text = "10";
            this.Time.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Time.Visible = false;
            // 
            // P2
            // 
            this.P2.AutoSize = true;
            this.P2.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P2.Location = new System.Drawing.Point(724, 93);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(55, 40);
            this.P2.TabIndex = 3;
            this.P2.Text = "P2";
            this.P2.Visible = false;
            // 
            // P1
            // 
            this.P1.AutoSize = true;
            this.P1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P1.Location = new System.Drawing.Point(78, 93);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(55, 40);
            this.P1.TabIndex = 4;
            this.P1.Text = "P1";
            this.P1.Visible = false;
            // 
            // p1w
            // 
            this.p1w.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p1w.Location = new System.Drawing.Point(62, 200);
            this.p1w.Name = "p1w";
            this.p1w.Size = new System.Drawing.Size(112, 35);
            this.p1w.TabIndex = 5;
            this.p1w.Text = "戰士: 1 顆";
            this.p1w.UseVisualStyleBackColor = true;
            this.p1w.Visible = false;
            this.p1w.Click += new System.EventHandler(this.p1w_Click);
            // 
            // p2w
            // 
            this.p2w.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p2w.Location = new System.Drawing.Point(695, 200);
            this.p2w.Name = "p2w";
            this.p2w.Size = new System.Drawing.Size(112, 35);
            this.p2w.TabIndex = 8;
            this.p2w.Text = "戰士: 1 顆";
            this.p2w.UseVisualStyleBackColor = true;
            this.p2w.Visible = false;
            this.p2w.Click += new System.EventHandler(this.p2w_Click);
            // 
            // p1r
            // 
            this.p1r.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p1r.Location = new System.Drawing.Point(62, 324);
            this.p1r.Name = "p1r";
            this.p1r.Size = new System.Drawing.Size(112, 35);
            this.p1r.TabIndex = 9;
            this.p1r.Text = "遊俠: 1 顆";
            this.p1r.UseVisualStyleBackColor = true;
            this.p1r.Visible = false;
            this.p1r.Click += new System.EventHandler(this.p1r_Click);
            // 
            // p1m
            // 
            this.p1m.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p1m.Location = new System.Drawing.Point(62, 263);
            this.p1m.Name = "p1m";
            this.p1m.Size = new System.Drawing.Size(112, 35);
            this.p1m.TabIndex = 10;
            this.p1m.Text = "法師: 1 顆";
            this.p1m.UseVisualStyleBackColor = true;
            this.p1m.Visible = false;
            this.p1m.Click += new System.EventHandler(this.p1m_Click);
            // 
            // p2m
            // 
            this.p2m.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p2m.Location = new System.Drawing.Point(695, 263);
            this.p2m.Name = "p2m";
            this.p2m.Size = new System.Drawing.Size(112, 35);
            this.p2m.TabIndex = 11;
            this.p2m.Text = "法師: 1 顆";
            this.p2m.UseVisualStyleBackColor = true;
            this.p2m.Visible = false;
            this.p2m.Click += new System.EventHandler(this.p2m_Click);
            // 
            // p2r
            // 
            this.p2r.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p2r.Location = new System.Drawing.Point(695, 324);
            this.p2r.Name = "p2r";
            this.p2r.Size = new System.Drawing.Size(112, 35);
            this.p2r.TabIndex = 12;
            this.p2r.Text = "遊俠: 1 顆";
            this.p2r.UseVisualStyleBackColor = true;
            this.p2r.Visible = false;
            this.p2r.Click += new System.EventHandler(this.p2r_Click);
            // 
            // p2current
            // 
            this.p2current.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p2current.Location = new System.Drawing.Point(697, 145);
            this.p2current.Name = "p2current";
            this.p2current.Size = new System.Drawing.Size(112, 40);
            this.p2current.TabIndex = 13;
            this.p2current.Text = "戰士";
            this.p2current.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p2current.Visible = false;
            // 
            // p1current
            // 
            this.p1current.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p1current.Location = new System.Drawing.Point(52, 145);
            this.p1current.Name = "p1current";
            this.p1current.Size = new System.Drawing.Size(112, 40);
            this.p1current.TabIndex = 14;
            this.p1current.Text = "戰士";
            this.p1current.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p1current.Visible = false;
            // 
            // p1state
            // 
            this.p1state.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p1state.Location = new System.Drawing.Point(56, 185);
            this.p1state.Name = "p1state";
            this.p1state.Size = new System.Drawing.Size(155, 136);
            this.p1state.TabIndex = 15;
            this.p1state.Text = "HP: 100\r\nMP: 15\r\nATK: 30 \r\nATK Range: 1\r\nMOVE Range: 2\r\n\r\n";
            this.p1state.Visible = false;
            // 
            // p2state
            // 
            this.p2state.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p2state.Location = new System.Drawing.Point(709, 185);
            this.p2state.Name = "p2state";
            this.p2state.Size = new System.Drawing.Size(164, 136);
            this.p2state.TabIndex = 18;
            this.p2state.Text = "HP: 100\r\nMP: 15\r\nATK: 30 \r\nATK Range: 1\r\nMOVE Range: 2\r\n\r\n";
            this.p2state.Visible = false;
            // 
            // p1attack
            // 
            this.p1attack.BackColor = System.Drawing.SystemColors.Window;
            this.p1attack.Enabled = false;
            this.p1attack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p1attack.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p1attack.Location = new System.Drawing.Point(45, 347);
            this.p1attack.Name = "p1attack";
            this.p1attack.Size = new System.Drawing.Size(67, 44);
            this.p1attack.TabIndex = 21;
            this.p1attack.Text = "攻擊";
            this.p1attack.UseVisualStyleBackColor = false;
            this.p1attack.Visible = false;
            this.p1attack.Click += new System.EventHandler(this.p1attack_Click);
            // 
            // p1standby
            // 
            this.p1standby.BackColor = System.Drawing.SystemColors.Window;
            this.p1standby.Enabled = false;
            this.p1standby.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p1standby.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p1standby.Location = new System.Drawing.Point(134, 409);
            this.p1standby.Name = "p1standby";
            this.p1standby.Size = new System.Drawing.Size(67, 44);
            this.p1standby.TabIndex = 22;
            this.p1standby.Text = "待機";
            this.p1standby.UseVisualStyleBackColor = false;
            this.p1standby.Visible = false;
            this.p1standby.Click += new System.EventHandler(this.p1standby_Click);
            // 
            // p1skill
            // 
            this.p1skill.BackColor = System.Drawing.SystemColors.Window;
            this.p1skill.Enabled = false;
            this.p1skill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p1skill.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p1skill.Location = new System.Drawing.Point(45, 409);
            this.p1skill.Name = "p1skill";
            this.p1skill.Size = new System.Drawing.Size(67, 44);
            this.p1skill.TabIndex = 23;
            this.p1skill.Text = "技能";
            this.p1skill.UseVisualStyleBackColor = false;
            this.p1skill.Visible = false;
            this.p1skill.Click += new System.EventHandler(this.p1skill_Click);
            // 
            // p1move
            // 
            this.p1move.BackColor = System.Drawing.SystemColors.Window;
            this.p1move.Enabled = false;
            this.p1move.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p1move.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p1move.Location = new System.Drawing.Point(134, 347);
            this.p1move.Name = "p1move";
            this.p1move.Size = new System.Drawing.Size(67, 44);
            this.p1move.TabIndex = 24;
            this.p1move.Text = "移動";
            this.p1move.UseVisualStyleBackColor = false;
            this.p1move.Visible = false;
            this.p1move.Click += new System.EventHandler(this.p1move_Click);
            // 
            // p1end
            // 
            this.p1end.BackColor = System.Drawing.SystemColors.Window;
            this.p1end.Enabled = false;
            this.p1end.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p1end.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p1end.Location = new System.Drawing.Point(45, 471);
            this.p1end.Name = "p1end";
            this.p1end.Size = new System.Drawing.Size(156, 44);
            this.p1end.TabIndex = 25;
            this.p1end.Text = "結束";
            this.p1end.UseVisualStyleBackColor = false;
            this.p1end.Visible = false;
            this.p1end.Click += new System.EventHandler(this.p1end_Click);
            // 
            // p2end
            // 
            this.p2end.BackColor = System.Drawing.SystemColors.Window;
            this.p2end.Enabled = false;
            this.p2end.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p2end.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p2end.Location = new System.Drawing.Point(698, 471);
            this.p2end.Name = "p2end";
            this.p2end.Size = new System.Drawing.Size(156, 44);
            this.p2end.TabIndex = 30;
            this.p2end.Text = "結束";
            this.p2end.UseVisualStyleBackColor = false;
            this.p2end.Visible = false;
            this.p2end.Click += new System.EventHandler(this.p2end_Click);
            // 
            // p2move
            // 
            this.p2move.BackColor = System.Drawing.SystemColors.Window;
            this.p2move.Enabled = false;
            this.p2move.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p2move.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p2move.Location = new System.Drawing.Point(787, 347);
            this.p2move.Name = "p2move";
            this.p2move.Size = new System.Drawing.Size(67, 44);
            this.p2move.TabIndex = 29;
            this.p2move.Text = "移動";
            this.p2move.UseVisualStyleBackColor = false;
            this.p2move.Visible = false;
            this.p2move.Click += new System.EventHandler(this.p2move_Click);
            // 
            // p2skill
            // 
            this.p2skill.BackColor = System.Drawing.SystemColors.Window;
            this.p2skill.Enabled = false;
            this.p2skill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p2skill.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p2skill.Location = new System.Drawing.Point(698, 409);
            this.p2skill.Name = "p2skill";
            this.p2skill.Size = new System.Drawing.Size(67, 44);
            this.p2skill.TabIndex = 28;
            this.p2skill.Text = "技能";
            this.p2skill.UseVisualStyleBackColor = false;
            this.p2skill.Visible = false;
            this.p2skill.Click += new System.EventHandler(this.p2skill_Click);
            // 
            // p2standby
            // 
            this.p2standby.BackColor = System.Drawing.SystemColors.Window;
            this.p2standby.Enabled = false;
            this.p2standby.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p2standby.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p2standby.Location = new System.Drawing.Point(787, 409);
            this.p2standby.Name = "p2standby";
            this.p2standby.Size = new System.Drawing.Size(67, 44);
            this.p2standby.TabIndex = 27;
            this.p2standby.Text = "待機";
            this.p2standby.UseVisualStyleBackColor = false;
            this.p2standby.Visible = false;
            this.p2standby.Click += new System.EventHandler(this.p2standby_Click);
            // 
            // p2attack
            // 
            this.p2attack.BackColor = System.Drawing.SystemColors.Window;
            this.p2attack.Enabled = false;
            this.p2attack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p2attack.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p2attack.Location = new System.Drawing.Point(698, 347);
            this.p2attack.Name = "p2attack";
            this.p2attack.Size = new System.Drawing.Size(67, 44);
            this.p2attack.TabIndex = 26;
            this.p2attack.Text = "攻擊";
            this.p2attack.UseVisualStyleBackColor = false;
            this.p2attack.Visible = false;
            this.p2attack.Click += new System.EventHandler(this.p2attack_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 622);
            this.Controls.Add(this.p2end);
            this.Controls.Add(this.p2move);
            this.Controls.Add(this.p2skill);
            this.Controls.Add(this.p2standby);
            this.Controls.Add(this.p2attack);
            this.Controls.Add(this.p1end);
            this.Controls.Add(this.p1move);
            this.Controls.Add(this.p1skill);
            this.Controls.Add(this.p1standby);
            this.Controls.Add(this.p1attack);
            this.Controls.Add(this.p2state);
            this.Controls.Add(this.p1state);
            this.Controls.Add(this.p1current);
            this.Controls.Add(this.p2current);
            this.Controls.Add(this.p2r);
            this.Controls.Add(this.p2m);
            this.Controls.Add(this.p1m);
            this.Controls.Add(this.p1r);
            this.Controls.Add(this.p2w);
            this.Controls.Add(this.p1w);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Phase);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Phase;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.Button p1w;
        private System.Windows.Forms.Button p2w;
        private System.Windows.Forms.Button p1r;
        private System.Windows.Forms.Button p1m;
        private System.Windows.Forms.Button p2m;
        private System.Windows.Forms.Button p2r;
        private System.Windows.Forms.Label p2current;
        private System.Windows.Forms.Label p1current;
        private System.Windows.Forms.Label p1state;
        private System.Windows.Forms.Label p2state;
        private System.Windows.Forms.Button p1attack;
        private System.Windows.Forms.Button p1standby;
        private System.Windows.Forms.Button p1skill;
        private System.Windows.Forms.Button p1move;
        private System.Windows.Forms.Button p1end;
        private System.Windows.Forms.Button p2end;
        private System.Windows.Forms.Button p2move;
        private System.Windows.Forms.Button p2skill;
        private System.Windows.Forms.Button p2standby;
        private System.Windows.Forms.Button p2attack;
        private System.Windows.Forms.Timer timer2;
    }
}

