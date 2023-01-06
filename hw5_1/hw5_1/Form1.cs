using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw5_1
{
    public partial class Form1 : Form
    {
        Button[] letter = new Button[26];
        String Answer;
        int wrongtime;
        int right;
        public void Win()
        {
            timer1.Enabled = false;	     // 暫停計時器
            MessageBox.Show("花費時間:" + Time.Text + "\n猜錯 " + wrongtime + " 次", "You Win !", MessageBoxButtons.OK);
            Reset();
        }
        public void Lose()
        {
            timer1.Enabled = false;
            MessageBox.Show("You Lose!", "", MessageBoxButtons.OK);
            Reset();
        }
        public void Reset()
        {
            for(int i = 0; i < 26; i++)
            {
                Controls.Remove(letter[i]);
                letter[i].Dispose();
            }
            timer1.Enabled = Time.Visible = TimeLabel.Visible = WrongTime.Visible = WrongTimeLabel.Visible = CorrectWord.Visible = false;
            Title.Visible = Word.Visible = Start.Visible = label1.Visible =  Start.Enabled = Word.Enabled = true;
            Word.Text = "";
            this.KeyPreview = false;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            Time.Text = (int.Parse(Time.Text) + 1).ToString();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            char atoz = 'A';
            for (int i = 0; i < 26; i++)
            {
                letter[i] = new Button();
                if (i < 20)
                    letter[i].SetBounds(60 + 35 * (i % 10), 25 + 35 * (i / 10), 30, 30);
                else
                    letter[i].SetBounds(60 + 35 * (i % 10 + 2), 25 + 35 * (i / 10), 30, 30);
                letter[i].Font = new System.Drawing.Font("Microsoft JhengHei UI", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                letter[i].FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                letter[i].BackColor = Color.White;
                letter[i].Text = atoz.ToString();
                Controls.Add(letter[i]);
                atoz++;
            }
            //建立_ _ _ _ _
            CorrectWord.Text = "";
            for (int i = 0; i < Word.Text.Length - 1; i++)
                CorrectWord.Text += "_ ";
            CorrectWord.Text += "_";
            //切換視窗
            timer1.Enabled = Time.Visible = TimeLabel.Visible = WrongTime.Visible = WrongTimeLabel.Visible = CorrectWord.Visible = true;
            Title.Visible = Word.Visible = Start.Visible = label1.Visible = Start.Enabled = Word.Enabled = false;
            //初始化
            Answer = Word.Text.ToUpper();
            right = Answer.Length;
            wrongtime = 0;
            this.KeyPreview = true;
        }

        private void Word_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 'A' && e.KeyChar <= 'Z' ) || (e.KeyChar >= 'a' && e.KeyChar <= 'z' ) || e.KeyChar == (char)Keys.Back);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            char key = (char)e.KeyCode; //keyboard input
            Console.WriteLine(key);
            if (key >= 'A' && key <= 'Z')
            {
                if (Answer.IndexOf(key) != -1)
                {
                    letter[key - 'A'].BackColor = Color.LightGreen;
                    while (Answer.IndexOf(key) != -1)
                    {
                        CorrectWord.Text = CorrectWord.Text.Remove(2 * Answer.IndexOf(key), 1);
                        CorrectWord.Text = CorrectWord.Text.Insert(2 * Answer.IndexOf(key), key.ToString());
                        Answer = Answer.Remove(Answer.IndexOf(key), 1).Insert(Answer.IndexOf(key), "0");
                        right--;
                    }
                }
                else if (letter[key - 'A'].Visible != false)
                {
                    letter[key - 'A'].Visible = false;
                    wrongtime++;
                    WrongTime.Text = wrongtime + "次";
                }
                if (wrongtime == 6) Lose();
                if (right == 0) Win();
            }
        }
    }
}
