using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw6_1
{
    public partial class Form1 : Form
    {
        SoundPlayer player1 = new SoundPlayer(@"..\..\..\6-1\audio\ding.wav");
        SoundPlayer player2 = new SoundPlayer(@"..\..\..\6-1\audio\dong.wav");
        SoundPlayer player3 = new SoundPlayer(@"..\..\..\6-1\audio\doo.wav");
        bool doub = false;
        bool fourpi = true;
        bool Start = true;
        int beat = 0;
        Button[] light = new Button[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            options.Items.Add("4");
            options.Items.Add("8");
            options.Text = "4 ";
            player1.Load();
            player2.Load();
            player3.Load();

            for (int i = 0; i < 8; i++)
            {
                light[i] = new Button();
                light[i].SetBounds(90 + 55 * i, 120, 30, 30);
                if (i % 2 == 1)
                {
                    light[i].Visible = false;
                }
                light[i].Enabled = false;
                light[i].Name = i.ToString();
                Controls.Add(light[i]);
            }
        }
        private void Control_Click(object sender, EventArgs e)
        {
            if (Start == true)
            {
                Start = false;
                timer1.Enabled = true;
                timer1.Interval = 500 * 60 / BPMcontrol.Value; //一秒一次 1000 / (120/60 )
                Control.Text = "Stop";
            }
            else
            {
                Start = true;
                timer1.Enabled = false;
                Control.Text = "Start";
            }
        }
        private void BPMcontrol_Scroll(object sender, EventArgs e)
        {
            BPM.Text = BPMcontrol.Value.ToString();
            timer1.Interval = 500 * 60 / BPMcontrol.Value ;
        }
        private void options_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (options.Text == "4" && options.Text != "4 ")
            {
                if (fourpi == false)
                {
                    fourpi = true;
                    
                    for (int i = 0; i < 8; i++)
                    {
                        if (i % 2 == 1)
                            light[i].Visible = false;
                        light[i].SetBounds(90 + 55 * i, 120, 30, 30);
                    }
                }
            }
            if (options.Text == "8")
            {
                if (fourpi == true)
                {
                    for(int i = 0; i < 8; i++)
                    {
                        light[i].BackColor = Color.LightGray;
                    }
                    beat = 0;
                    fourpi = false;
                    
                    for (int i = 0; i < 8; i++)
                    {
                        light[i].Visible = true;
                        light[i].SetBounds(90 + 47 * i, 120, 30, 30);
                    }
                }
            }
        }
        private void four_Click(object sender, EventArgs e)
        {
            four.Checked = true;
            eight.Checked = false;
            doub = false;
        }
        private void eight_Click(object sender, EventArgs e)
        {
            if (eight.Checked == true)
            {
                four.Checked = false;
                eight.Checked = true;
                doub = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(beat + " " + doub + " " + fourpi);
            if (fourpi == true)
            {
                light[beat % 8].BackColor = Color.LightGreen;
                if (beat == 0 || beat == 8)
                {
                    light[7].BackColor = Color.LightGray;
                    player1.Play();
                }
                else
                {
                    light[(beat % 8) - 1].BackColor = Color.LightGray;
                    if (doub == true)
                    {
                        if (beat % 2 == 1)
                            player3.Play();
                        if (beat % 2 == 0)
                            player2.Play();
                    }
                    else
                    {
                        if (beat % 2 == 0)
                            player3.Play();
                    }
                }
            }
            else
            {
                light[beat / 2].BackColor = Color.LightGreen;
                if (beat == 0)
                {
                    light[7].BackColor = Color.LightGray;
                    player1.Play();
                }
                else
                {
                    if(beat != 1)
                        light[(beat /2) -1].BackColor = Color.LightGray;
                    if (doub == true)
                    {
                        if (beat % 2 == 1)
                            player3.Play();
                        if (beat % 2 == 0)
                            player2.Play();
                    }
                    else
                    {
                        if (beat % 2 == 0)
                            player3.Play();
                    }
                }
            }
            beat++;
            if (beat == 16)
                beat = 0;
        }
    }
}
