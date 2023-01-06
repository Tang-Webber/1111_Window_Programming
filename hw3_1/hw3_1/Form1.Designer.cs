namespace hw3_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchResult = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.RiskAccount = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.Pass = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.Link = new System.Windows.Forms.TextBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.Userlabel = new System.Windows.Forms.Label();
            this.Linklabal = new System.Windows.Forms.Label();
            this.Statusbar = new System.Windows.Forms.Label();
            this.AddDelete = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "密碼管理員";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(91, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "搜尋列";
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Searchlabel.Location = new System.Drawing.Point(91, 192);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(82, 23);
            this.Searchlabel.TabIndex = 2;
            this.Searchlabel.Text = "搜尋結果";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(515, 29);
            this.textBox1.TabIndex = 3;
            // 
            // SearchResult
            // 
            this.SearchResult.BackColor = System.Drawing.SystemColors.Window;
            this.SearchResult.Location = new System.Drawing.Point(92, 219);
            this.SearchResult.Name = "SearchResult";
            this.SearchResult.Size = new System.Drawing.Size(665, 232);
            this.SearchResult.TabIndex = 4;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.Window;
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Search.Location = new System.Drawing.Point(692, 41);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(65, 33);
            this.Search.TabIndex = 5;
            this.Search.Text = "搜尋";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // RiskAccount
            // 
            this.RiskAccount.BackColor = System.Drawing.SystemColors.Window;
            this.RiskAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RiskAccount.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RiskAccount.Location = new System.Drawing.Point(95, 114);
            this.RiskAccount.Name = "RiskAccount";
            this.RiskAccount.Size = new System.Drawing.Size(662, 31);
            this.RiskAccount.TabIndex = 6;
            this.RiskAccount.Text = "風險帳號";
            this.RiskAccount.UseVisualStyleBackColor = false;
            this.RiskAccount.Click += new System.EventHandler(this.RiskAccount_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.delete.Location = new System.Drawing.Point(549, 411);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 32);
            this.delete.TabIndex = 32;
            this.delete.Text = "刪除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.add.Location = new System.Drawing.Point(449, 411);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 32);
            this.add.TabIndex = 31;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = true;
            this.add.Visible = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(280, 367);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(344, 29);
            this.Pass.TabIndex = 30;
            this.Pass.Visible = false;
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(280, 319);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(344, 29);
            this.User.TabIndex = 29;
            this.User.Visible = false;
            // 
            // Link
            // 
            this.Link.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Link.Location = new System.Drawing.Point(280, 267);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(344, 29);
            this.Link.TabIndex = 28;
            this.Link.Visible = false;
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Passwordlabel.Location = new System.Drawing.Point(206, 370);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(46, 23);
            this.Passwordlabel.TabIndex = 27;
            this.Passwordlabel.Text = "密碼";
            this.Passwordlabel.Visible = false;
            // 
            // Userlabel
            // 
            this.Userlabel.AutoSize = true;
            this.Userlabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Userlabel.Location = new System.Drawing.Point(206, 322);
            this.Userlabel.Name = "Userlabel";
            this.Userlabel.Size = new System.Drawing.Size(64, 23);
            this.Userlabel.TabIndex = 26;
            this.Userlabel.Text = "使用者";
            this.Userlabel.Visible = false;
            // 
            // Linklabal
            // 
            this.Linklabal.AutoSize = true;
            this.Linklabal.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Linklabal.Location = new System.Drawing.Point(206, 270);
            this.Linklabal.Name = "Linklabal";
            this.Linklabal.Size = new System.Drawing.Size(46, 23);
            this.Linklabal.TabIndex = 25;
            this.Linklabal.Text = "連結";
            this.Linklabal.Visible = false;
            // 
            // Statusbar
            // 
            this.Statusbar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Statusbar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Statusbar.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Statusbar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Statusbar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Statusbar.Location = new System.Drawing.Point(206, 219);
            this.Statusbar.Name = "Statusbar";
            this.Statusbar.Size = new System.Drawing.Size(418, 25);
            this.Statusbar.TabIndex = 24;
            this.Statusbar.Text = "我是狀態列";
            this.Statusbar.Visible = false;
            // 
            // AddDelete
            // 
            this.AddDelete.BackColor = System.Drawing.SystemColors.Window;
            this.AddDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddDelete.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AddDelete.Location = new System.Drawing.Point(579, 168);
            this.AddDelete.Name = "AddDelete";
            this.AddDelete.Size = new System.Drawing.Size(178, 32);
            this.AddDelete.TabIndex = 33;
            this.AddDelete.Text = "新增或刪除";
            this.AddDelete.UseVisualStyleBackColor = false;
            this.AddDelete.Click += new System.EventHandler(this.AddDelete_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Window;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Back.Location = new System.Drawing.Point(579, 168);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(178, 32);
            this.Back.TabIndex = 34;
            this.Back.Text = "回主畫面";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Visible = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(95, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(581, 29);
            this.textBox2.TabIndex = 35;
            this.textBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(824, 489);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AddDelete);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.Userlabel);
            this.Controls.Add(this.Linklabal);
            this.Controls.Add(this.Statusbar);
            this.Controls.Add(this.RiskAccount);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Searchlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SearchResult;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button RiskAccount;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Link;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label Userlabel;
        private System.Windows.Forms.Label Linklabal;
        private System.Windows.Forms.Label Statusbar;
        private System.Windows.Forms.Button AddDelete;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox textBox2;
    }
}

