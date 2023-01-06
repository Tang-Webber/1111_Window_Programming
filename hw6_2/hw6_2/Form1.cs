using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw6_2
{
    public partial class Form1 : Form
    {
        Button[,] key = new Button[5, 3];
        bool call = false;
        bool telephone = true;
        bool keying = true;
        bool work = false;
        public void playmedia(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            int i = clicked.Name[0] - '0';
            int j = clicked.Name[1] - '0';
            switch (i)
            {
                case 0:
                    MediaPlayer1.URL = @"697.wav";
                    MediaPlayer1.Ctlcontrols.play();
                    break;
                case 1:
                    MediaPlayer1.URL = @"770.wav";
                    MediaPlayer1.Ctlcontrols.play();
                    break;
                case 2:
                    MediaPlayer1.URL = @"852.wav";
                    MediaPlayer1.Ctlcontrols.play();
                    break;
                case 3:
                    MediaPlayer1.URL = @"941.wav";
                    MediaPlayer1.Ctlcontrols.play();
                    break;
            }
            if (i <= 3)
            {
                switch (j)
                {
                    case 0:
                        MediaPlayer2.URL = @"1209.wav";
                        MediaPlayer2.Ctlcontrols.play();
                        break;
                    case 1:
                        MediaPlayer2.URL = @"1336.wav";
                        MediaPlayer2.Ctlcontrols.play();
                        break;
                    case 2:
                        MediaPlayer2.URL = @"1477.wav";
                        MediaPlayer2.Ctlcontrols.play();
                        break;
                }
                if (Status.Text == "Telephone")
                    Status.Text = "";
                Status.Text += clicked.Text;
            }
            if (i == 4 && j == 0)
            {
                Status.Text = "";
            }
            if (i == 4 && j == 1)
            {
                if (call == false)
                {
                    for (int a = 0; a < 5; a++)
                    {
                        for (int b = 0; b < 3; b++)
                        {
                            key[a, b].Enabled = false;
                        }
                    }
                    clicked.Enabled = true;
                    clicked.Text = "📵";
                    call = true;
                }
                else
                {
                    for (int a = 0; a < 5; a++)
                    {
                        for (int b = 0; b < 3; b++)
                        {
                            key[a, b].Enabled = true;
                        }
                    }
                    clicked.Text = "📱";
                    log.Text += Status.Text + "\n";
                    Status.Text = "Telephone";
                    call = false;
                }
            }
            if (i == 4 && j == 2)
            {
                if (Status.Text != "Telephone")
                {
                    Status.Text = Status.Text.Remove(Status.Text.Length - 1);
                }
            }
        }
        public void stopmedia(object sender, EventArgs e)
        {
            MediaPlayer1.Ctlcontrols.stop();
            MediaPlayer2.Ctlcontrols.stop();
        }
        public void enter(object sender, PreviewKeyDownEventArgs e) // 焦點在button上
        {
            work = true;
            timer1.Enabled = true;
            if (e.KeyCode == Keys.Enter)
            {
                if (call == false)
                {
                    for (int a = 0; a < 5; a++)
                    {
                        for (int b = 0; b < 3; b++)
                        {
                            key[a, b].Enabled = false;
                        }
                    }
                    key[4, 1].Enabled = true;
                    key[4, 1].Text = "📵";
                    call = true;
                }
                else
                {
                    for (int a = 0; a < 5; a++)
                    {
                        for (int b = 0; b < 3; b++)
                        {
                            key[a, b].Enabled = true;
                        }
                    }
                    key[4, 1].Text = "📱";
                    log.Text += Status.Text + "\n";
                    Status.Text = "Telephone";
                    call = false;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MediaPlayer1.settings.setMode("loop", true);
            MediaPlayer2.settings.setMode("loop", true);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    key[i, j] = new Button();
                    key[i, j].SetBounds(160 + 45 * j, 50 + 45 * i, 35, 35);
                    key[i, j].Name = i.ToString() + j.ToString();
                    tabPage1.Controls.Add(key[i, j]);
                    key[i, j].Font = new System.Drawing.Font("Microsoft JhengHei UI", 16, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    if (i < 3)
                        key[i, j].Text = (3 * i + j + 1).ToString();
                    key[i, j].MouseDown += new MouseEventHandler(playmedia);
                    key[i, j].MouseUp += new MouseEventHandler(stopmedia);
                    key[i, j].PreviewKeyDown += new PreviewKeyDownEventHandler(enter); 
                }
            }
            key[3, 0].Text = "*";
            key[3, 1].Text = "0";
            key[3, 2].Text = "#";
            key[4, 0].Text = "❌";
            key[4, 1].Text = "📱"; //📵
            key[4, 2].Text = "⬅️";
            this.KeyPreview = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && work == false)
            {
                if (call == false)
                {
                    for (int a = 0; a < 5; a++)
                    {
                        for (int b = 0; b < 3; b++)
                        {
                            key[a, b].Enabled = false;
                        }
                    }
                    key[4, 1].Enabled = true;
                    key[4, 1].Text = "📵";
                    call = true;
                }
                else
                {
                    for (int a = 0; a < 5; a++)
                    {
                        for (int b = 0; b < 3; b++)
                        {
                            key[a, b].Enabled = true;
                        }
                    }
                    key[4, 1].Text = "📱";
                    log.Text += Status.Text + "\n";
                    Status.Text = "Telephone";
                    call = false;
                }
            }
            if (telephone == true && call == false)
            {
                char keyboard = (char)e.KeyCode; //keyboard input

                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    if ((keyboard == '3' || keyboard == '8'))
                    {
                        if (Status.Text == "Telephone")
                            Status.Text = "";
                    }
                    if (keying == true)
                    {
                        if (keyboard == '8')
                        {
                            MediaPlayer1.URL = @"941.wav";
                            MediaPlayer1.Ctlcontrols.play();
                            MediaPlayer2.URL = @"1209.wav";
                            MediaPlayer2.Ctlcontrols.play();
                            Status.Text += '*';
                        }
                        else if (keyboard == '3')
                        {
                            MediaPlayer1.URL = @"941.wav";
                            MediaPlayer1.Ctlcontrols.play();
                            MediaPlayer2.URL = @"1477.wav";
                            MediaPlayer2.Ctlcontrols.play();
                            Status.Text += '#';
                        }
                    }
                    if ((keyboard == '3' || keyboard == '8'))
                    {
                        keying = false;
                    }
                }
                else
                {
                    if (keying == true)
                    {
                        if (e.KeyCode == Keys.Back)
                        {
                            if (Status.Text != "Telephone" && Status.Text.Length != 0)
                                Status.Text = Status.Text.Remove(Status.Text.Length - 1);
                        }
                        if ((keyboard >= '0' && keyboard <= '9'))
                        {
                            if (Status.Text == "Telephone")
                                Status.Text = "";
                        }
                        if (keyboard == '1')
                        {
                            MediaPlayer1.URL = @"697.wav";
                            MediaPlayer1.Ctlcontrols.play();
                            MediaPlayer2.URL = @"1209.wav";
                            MediaPlayer2.Ctlcontrols.play();
                            Status.Text += '1';
                        }
                        else if (keyboard == '2')
                        {
                            MediaPlayer1.URL = @"697.wav";
                            MediaPlayer1.Ctlcontrols.play();
                            MediaPlayer2.URL = @"1336.wav";
                            MediaPlayer2.Ctlcontrols.play();
                            Status.Text += '2';
                        }
                        else if (keyboard == '3')
                        {
                            MediaPlayer1.URL = @"697.wav";
                            MediaPlayer1.Ctlcontrols.play();
                            MediaPlayer2.URL = @"1477.wav";
                            MediaPlayer2.Ctlcontrols.play();
                            Status.Text += '3';
                        }
                        else if (keyboard == '4')
                        {
                            MediaPlayer1.URL = @"770.wav";
                            MediaPlayer1.Ctlcontrols.play();
                            MediaPlayer2.URL = @"1209.wav";
                            MediaPlayer2.Ctlcontrols.play();
                            Status.Text += '4';
                        }
                        else if (keyboard == '5')
                        {
                            MediaPlayer1.URL = @"770.wav";
                            MediaPlayer1.Ctlcontrols.play();
                            MediaPlayer2.URL = @"1336.wav";
                            MediaPlayer2.Ctlcontrols.play();
                            Status.Text += '5';
                        }
                        else if (keyboard == '6')
                        {
                            MediaPlayer1.URL = @"770.wav";
                            MediaPlayer1.Ctlcontrols.play();
                            MediaPlayer2.URL = @"1477.wav";
                            MediaPlayer2.Ctlcontrols.play();
                            Status.Text += '6';
                        }
                        else if (keyboard == '7')
                        {
                            MediaPlayer1.URL = @"852.wav";
                            MediaPlayer1.Ctlcontrols.play();
                            MediaPlayer2.URL = @"1209.wav";
                            MediaPlayer2.Ctlcontrols.play();
                            Status.Text += '7';
                        }
                        else if (keyboard == '8')
                        {
                            MediaPlayer1.URL = @"852.wav";
                            MediaPlayer1.Ctlcontrols.play();
                            MediaPlayer2.URL = @"1336.wav";
                            MediaPlayer2.Ctlcontrols.play();
                            Status.Text += '8';
                        }
                        else if (keyboard == '9')
                        {
                            MediaPlayer1.URL = @"852.wav";
                            MediaPlayer1.Ctlcontrols.play();
                            MediaPlayer2.URL = @"1477.wav";
                            MediaPlayer2.Ctlcontrols.play();
                            Status.Text += '9';
                        }
                        else if (keyboard == '0')
                        {
                            MediaPlayer1.URL = @"941.wav";
                            MediaPlayer1.Ctlcontrols.play();
                            MediaPlayer2.URL = @"1336.wav";
                            MediaPlayer2.Ctlcontrols.play();
                            Status.Text += '0';
                        }
                    }
                    keying = false;
                }
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            MediaPlayer1.Ctlcontrols.stop();
            MediaPlayer2.Ctlcontrols.stop();
            keying = true;
        }
        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (telephone == true)
            {
                telephone = false;
            }
            else
            {
                telephone = true;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string path = Path.Text;
            if (path == "")
            {
                MessageBox.Show("Empty String", "", MessageBoxButtons.OK);
            }
            else
            {
                FileInfo finfo = new FileInfo(path);
                if (File.Exists(finfo.FullName))
                {
                    StreamWriter sw = finfo.AppendText();
                    sw.Write(log.Text);
                    sw.Flush();
                    sw.Close();
                    MessageBox.Show("Done\n" + finfo.FullName, "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Directory Not Found", "", MessageBoxButtons.OK);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            work = false;
            timer1.Enabled = false;
        }
    }
}
