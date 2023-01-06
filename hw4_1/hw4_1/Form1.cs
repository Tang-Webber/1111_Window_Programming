using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw4_1
{
    public partial class Form1 : Form
    {
        Button[] card = new Button[16];
        Random rnd = new Random();
        int[] repeat = new int[16];
        public bool pairing = true;
        public int openIndex = 16;
        public int pairIndex;
        public int check = 0;
        public Button one;
        public Button two;
        public string username;
        public void SetPicture(Button B)
        {
            if (B.Name == "0" || B.Name == "8")
                B.Image = hw4_1.Properties.Resources._08;
            if (B.Name == "1" || B.Name == "9")
                B.Image = hw4_1.Properties.Resources._01;
            if (B.Name == "2" || B.Name == "10")
                B.Image = hw4_1.Properties.Resources._02;
            if (B.Name == "3" || B.Name == "11")
                B.Image = hw4_1.Properties.Resources._03;
            if (B.Name == "4" || B.Name == "12")
                B.Image = hw4_1.Properties.Resources._04;
            if (B.Name == "5" || B.Name == "13")
                B.Image = hw4_1.Properties.Resources._05;
            if (B.Name == "6" || B.Name == "14")
                B.Image = hw4_1.Properties.Resources._06;
            if (B.Name == "7" || B.Name == "15")
                B.Image = hw4_1.Properties.Resources._07;
        }
        public void Open(object sender, EventArgs e)
        {
            Button clickCard = (Button)sender;
            int n = int.Parse(clickCard.Name);
            if (pairing != false)
            {
                SetPicture(clickCard);
                if (openIndex == 16)
                    openIndex = n;
                else
                {
                    pairIndex = n;
                    if (openIndex % 8 == pairIndex % 8)
                    {
                        card[openIndex].Enabled = false;
                        card[pairIndex].Enabled = false;
                        
                        openIndex = 16;
                        pairIndex = 16;
                        Score.Text = (int.Parse(Score.Text) + 10).ToString();
                        check++;
                        if (check == 8)
                            Endgame();
                    }
                    else
                    {
                        pairing = false;
                        cont.Enabled = true;
                        Score.Text = (int.Parse(Score.Text) - 5).ToString();
                    }
                }
            }
        }
        public void Endgame()
        {
            DialogResult retry = MessageBox.Show("分數：" + Score.Text, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
            if(retry == DialogResult.Retry)
            {
                for (int i = 0; i < 16; i++)
                {
                    card[i].Visible = false;
                    repeat[i] = 0;
                }
                start.Enabled = true;
                Nameuser.Enabled = true;
            }
            billiboard.Text += username + " 得分為：" + Score.Text + "\n\n";
            Nameuser.Enabled = true;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(750, 600);
            
        }
        private void start_Click(object sender, EventArgs e)
        {
            
            check = 0;
            username = Nameuser.Text;
            if(username != "" && username.Length >= 3 && username.Length <= 10)
            {
                start.Enabled = false;
                Nameuser.Enabled = false;
                Score.Text = 100.ToString();
                cont.Enabled = false;
                pairing = true;
                openIndex = 16;
                int Index;
                for (int i = 0; i < 16; i++)
                {
                    Index = rnd.Next(16);
                    while (repeat[Index] == 1)
                        Index = rnd.Next(16);
                    card[Index] = new Button();
                    card[Index].SetBounds(50 + 100 * (i / 4), 50 + 100 * (i % 4), 70, 100);
                    card[Index].Name = Index.ToString();
                    tabPage1.Controls.Add(card[Index]);
                    card[Index].Click += new EventHandler(Open);
                    card[Index].Image = hw4_1.Properties.Resources.card;
                    repeat[Index] = 1;
                }
            }
            else if(username == "")
            {
                MessageBox.Show("名稱不能為空白", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else {
                MessageBox.Show("名稱不合格式 ( >= 3 && <= 10 )", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void cont_Click(object sender, EventArgs e)
        {
            card[openIndex].Image = hw4_1.Properties.Resources.card;
            card[pairIndex].Image = hw4_1.Properties.Resources.card;
            pairing = true;
            openIndex = 16;
            pairIndex = 16;
            cont.Enabled = false;
        }
        private void end_Click(object sender, EventArgs e)
        {
            DialogResult retry = MessageBox.Show("確定要離開遊戲嗎?", "離開遊戲", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (retry == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }

        }

        private void Restart_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 16; i++)
                {
                    card[i].Visible = false;
                    repeat[i] = 0;
                }
                start.Enabled = true;
                Nameuser.Enabled = true;
                Nameuser.Text = "";
                Score.Text = "100";
            }
            catch {}
        }
    }
}
