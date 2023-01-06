using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw3_1
{
    public partial class Form1 : Form
    {
        List<Account> alist = new List<Account>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void AddDelete_Click(object sender, EventArgs e)
        {
            label2.Enabled = false;
            Search.Enabled = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = true;

            RiskAccount.Enabled = false;
            SearchResult.Visible = false;
            Searchlabel.Visible = false;
            AddDelete.Visible = false;

            textBox1.Text = "";
            Back.Enabled = true;
            Back.Visible = true;
            Link.Visible = true;
            Link.Text = "";
            User.Visible = true;
            User.Text = "";
            Pass.Visible = true;
            Pass.Text = "";
            Linklabal.Visible = true;
            Userlabel.Visible = true;
            Passwordlabel.Visible = true;
            add.Visible = true;
            delete.Visible = true;

            Statusbar.Visible = true;
            Statusbar.Text = "我是狀態列";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            label2.Enabled = true;
            Search.Enabled = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = false;
           
            RiskAccount.Enabled = true;
            SearchResult.Visible = true;
            Searchlabel.Visible = true;
            AddDelete.Visible = true;

            SearchResult.Text = "";
            textBox1.Text = "";

            Back.Enabled = false;
            Back.Visible = false;
            Link.Visible = false;
            User.Visible = false;
            Pass.Visible = false;
            Linklabal.Visible = false;
            Userlabel.Visible = false;
            Passwordlabel.Visible = false;
            add.Visible = false;
            delete.Visible = false;
            Statusbar.Visible = false;

        }

        private void add_Click(object sender, EventArgs e)
        {
            bool CanAdd = true;
            for (int i = 0; i < alist.Count; i++)
            {
                if (alist[i].link == Link.Text && alist[i].user == User.Text)
                {

                    CanAdd = false;
                    break;
                }
            }
            if(CanAdd == true)
            {
                alist.Add(new Account(Link.Text, User.Text, Pass.Text));
                Statusbar.Text = "新增完成";
                Link.Clear();
                User.Clear();
                Pass.Clear();
            }
            else
                Statusbar.Text = "帳號已存在";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            bool CanDelete = false;
            int i;
            for (i = 0; i < alist.Count; i++)
            {
                if (alist[i].link == Link.Text && alist[i].user == User.Text && alist[i].pass == Pass.Text)
                {
                    CanDelete = true;
                    break;
                }
            }
            if (CanDelete == true)
            {
                alist.RemoveAt(i);
                Statusbar.Text = "刪除完成";
                Link.Clear();
                User.Clear();
                Pass.Clear();
            }
            else
                Statusbar.Text = "帳號不存在或密碼錯誤";
        }

        private void RiskAccount_Click(object sender, EventArgs e)
        {
            SearchResult.Text = "" ;
            bool dudu; // duplicate duplicate
            List<string> duplicate = new List<string>();
            for (int i = 0; i < alist.Count; i++)
            {
                for (int j = i+1; j < alist.Count; j++)
                {
                    if (alist[i].pass == alist[j].pass)
                    {
                        dudu = false;
                        for (int k = 0; k < duplicate.Count; k++)
                        {
                            if (duplicate[k] == alist[i].pass)
                                dudu = true;
                        }
                        if (dudu == false)
                            duplicate.Add(alist[i].pass);
                    }
                }
            }

            for (int i = 0; i < duplicate.Count; i++)
            {
                for (int j = 0; j < alist.Count; j++)
                {
                    if (duplicate[i] == alist[j].pass)
                    {
                        SearchResult.Text += "連結: " + alist[j].link + "\n" + "使用者: " + alist[j].user + "\n" + "密碼: " + alist[j].pass + "\n" + "===========================\n";
                    }
                }
            }


        }

        private void Search_Click(object sender, EventArgs e)
        {
            string target = textBox1.Text;
            SearchResult.Text = "";
            for (int i = 0; i < alist.Count; i++) 
            {
                if(alist[i].link.Contains(target) == true)
                {
                    SearchResult.Text += "連結: " + alist[i].link + "\n" + "使用者: " + alist[i].user + "\n" + "密碼: " + alist[i].pass + "\n" + "===========================\n";
                }

            }


        }
    }
}
