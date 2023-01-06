using System;
using System.Drawing;
using System.Windows.Forms;

namespace hw3_2
{
    public partial class Form1 : Form
    {
        int status = 0; // 0:選取 1:放置
        int select;
        void end()
        {
            select1.Text = select2.Text = select3.Text = select4.Text = "贏";
            select1.Enabled = select2.Enabled = select3.Enabled = select4.Enabled = false;
            Statusbar2.Text = "你贏了";
        }
        void checkwin()
        {
            try
            {
                if(window1.Text == "")
                {
                    if (window2.Text[0] == window2.Text[2] && window2.Text[0] == window2.Text[4])
                        if (window3.Text[0] == window3.Text[2] && window3.Text[0] == window3.Text[4])
                            if (window4.Text[0] == window4.Text[2] && window4.Text[0] == window4.Text[4])
                                end();
                }
                if (window2.Text == "")
                {
                    if (window1.Text[0] == window1.Text[2] && window1.Text[0] == window1.Text[4])
                        if (window3.Text[0] == window3.Text[2] && window3.Text[0] == window3.Text[4])
                            if (window4.Text[0] == window4.Text[2] && window4.Text[0] == window4.Text[4])
                                end();
                }
                if (window3.Text == "")
                {
                    if (window2.Text[0] == window2.Text[2] && window2.Text[0] == window2.Text[4])
                        if (window1.Text[0] == window1.Text[2] && window1.Text[0] == window1.Text[4])
                            if (window4.Text[0] == window4.Text[2] && window4.Text[0] == window4.Text[4])
                                end();
                }
                if (window4.Text == "")
                {
                    if (window2.Text[0] == window2.Text[2] && window2.Text[0] == window2.Text[4])
                        if (window3.Text[0] == window3.Text[2] && window3.Text[0] == window3.Text[4])
                            if (window1.Text[0] == window1.Text[2] && window1.Text[0] == window1.Text[4])
                                end();
                }
            }
            catch
            {
                return;
            }
        }
        void changestatus()
        {
            if (status == 1)
            {
                if (window1.Text == "")
                    select1.Enabled = false;
                else
                    select1.Enabled = true;
                if (window2.Text == "")
                    select2.Enabled = false;
                else
                    select2.Enabled = true;
                if (window3.Text == "")
                    select3.Enabled = false;
                else
                    select3.Enabled = true;
                if (window4.Text == "")
                    select4.Enabled = false;
                else
                    select4.Enabled = true;
                

            }
            if(status == 0)
            {
                if (window1.Text.Length == 8)
                    select1.Enabled = false;
                else
                    select1.Enabled = true;
                if (window2.Text.Length == 8)
                    select2.Enabled = false;
                else
                    select2.Enabled = true;
                if (window3.Text.Length == 8)
                    select3.Enabled = false;
                else
                    select3.Enabled = true;
                if (window4.Text.Length == 8)
                    select4.Enabled = false;
                else
                    select4.Enabled = true;
            }
        }
        void put(int n) 
        {
            int temp = 0;
            if(select == 1)
            {
                temp = window1.Text[0] - '0';
                window1.Text = window1.Text.Remove(0, 2);
            }
            if (select == 2)
            {
                temp = window2.Text[0] - '0';
                window2.Text = window2.Text.Remove(0, 2);
            }
            if (select == 3)
            {
                temp = window3.Text[0] - '0';
                window3.Text = window3.Text.Remove(0, 2);
            }
            if (select == 4)
            {
                temp = window4.Text[0] - '0';
                window4.Text = window4.Text.Remove(0, 2);
            }
            if(n == 1)
                window1.Text =  temp + "\n" + window1.Text;
            if (n == 2)
                window2.Text = temp + "\n" + window2.Text;
            if (n == 3)
                window3.Text = temp + "\n" + window3.Text;
            if (n == 4)
                window4.Text = temp + "\n" + window4.Text;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(300, 310);
        }
        private void StartGame_Click(object sender, EventArgs e)
        {

            int[] sum = { 0, 0, 0 };
            bool start = true;
            window1.Text = window2.Text = window3.Text = window4.Text = "";
            string text1 = "", text2 = "", text3 = "", text4 = "";
            try
            {
                if (stack1.Text.Length <= 7)
                {
                    if (stack1.Text != "")
                    {
                        for (int i = 0; i <= stack1.Text.Length / 2; i++)
                        {
                            text1 += (stack1.Text[2 * i] - '0') + "\n";
                            sum[(stack1.Text[2 * i] - '1')]++;
                        }
                        text1 = text1.Remove(text1.Length - 1, 1);
                        text1.Insert(0, "\n");
                        char[] char1 = text1.ToCharArray();
                        Array.Reverse(char1);
                        window1.Text = new string(char1);
                        window1.Text += "\n";
                    }
                }
                else start = false;

                if (stack2.Text.Length <= 7)
                {
                    if (stack2.Text != "")
                    {
                        for (int i = 0; i <= stack2.Text.Length / 2; i++)
                        {
                            text2 += (stack2.Text[2 * i] - '0') + "\n";
                            sum[(stack2.Text[2 * i] - '1')]++;
                        }
                        text2 = text2.Remove(text2.Length - 1, 1);
                        text2.Insert(0, "\n");
                        char[] char2 = text2.ToCharArray();
                        Array.Reverse(char2);
                        window2.Text = new string(char2);
                        window2.Text += "\n";
                    }
                }
                else start = false;

                if (stack3.Text.Length <= 7)
                {
                    if (stack3.Text != "")
                    {
                        for (int i = 0; i <= stack3.Text.Length / 2; i++)
                        {
                            text3 += (stack3.Text[2 * i] - '0') + "\n";
                            sum[(stack3.Text[2 * i] - '1')]++;
                        }
                        text3 = text3.Remove(text3.Length - 1, 1);
                        text3.Insert(0, "\n");
                        char[] char3 = text3.ToCharArray();
                        Array.Reverse(char3);
                        window3.Text = new string(char3);
                        window3.Text += "\n";
                    }
                }
                else start = false;

                if (stack4.Text.Length <= 7)
                {
                    if (stack4.Text != "")
                    {
                        for (int i = 0; i <= stack4.Text.Length / 2; i++)
                        {
                            text4 += (stack4.Text[2 * i] - '0') + "\n";
                            sum[(stack4.Text[2 * i] - '1')]++;
                        }
                        text4 = text4.Remove(text4.Length - 1, 1);
                        text4.Insert(0, "\n");
                        char[] char4 = text4.ToCharArray();
                        Array.Reverse(char4);
                        window4.Text = new string(char4);
                        window4.Text += "\n";
                    }
                }
                else start = false;
            }
            catch
            {
                start = false;
            }
            if (sum[0] > 3 || sum[1] > 3 || sum[2] > 3) start = false;
            

            //load game
            if (start)
            {
                this.Size = new Size(300, 450);
                homes1.Visible = homes2.Visible = homes4.Visible = homes3.Visible = false;
                stack1.Visible = stack2.Visible = stack3.Visible = stack4.Visible = false;
                Statusbar1.Visible = false;
                StartGame.Visible = false;
                games1.Visible = games2.Visible = games3.Visible = games4.Visible = true;
                window1.Visible = window2.Visible = window3.Visible = window4.Visible = true;
                select1.Text = select2.Text = select3.Text = select4.Text = "選取";
                Statusbar1.Text = "...";
                status = 0;
                changestatus();
                checkwin();
            }
            else
                Statusbar1.Text = "測資錯誤";
        }
        private void home_Click(object sender, EventArgs e)
        {
            //initialize form
            this.Size = new Size(300, 310);
            homes1.Visible = homes2.Visible = homes4.Visible = homes3.Visible = true;
            stack1.Visible = stack2.Visible = stack3.Visible = stack4.Visible = true;
            Statusbar1.Visible = true;
            StartGame.Visible = true;
            games1.Visible = games2.Visible = games3.Visible = games4.Visible = false;
            window1.Visible = window2.Visible = window3.Visible = window4.Visible = false;
            stack1.Text = "1 1 2";
            stack2.Text = "2 2";
            stack3.Text = "";
            stack4.Text = "3 3 3 1";
            Statusbar1.Text = "請輸入測資";
            
        }
        private void select1_Click(object sender, EventArgs e)
        {
            if (status == 0) // 選取 -> 放置
            {
                select = 1;
                changestatus();
                status = 1;
                select1.Text = select2.Text = select3.Text = select4.Text = "放置";
                Statusbar2.Text = "你選了堆疊1";
            }
            else if(status == 1) // 放置 -> 選取
            {
                put(1); 
                changestatus(); // 選取暗掉
                status = 0;
                select1.Text = select2.Text = select3.Text = select4.Text = "選取";
                Statusbar2.Text = "...";
                checkwin();
            }

        }
        private void select2_Click(object sender, EventArgs e)
        {
            if (status == 0) // 選取 -> 放置
            {
                select = 2;
                changestatus();
                status = 1;
                select1.Text = select2.Text = select3.Text = select4.Text = "放置";
                Statusbar2.Text = "你選了堆疊2";
            }
            else if (status == 1) // 放置 -> 選取
            {
                put(2);
                changestatus(); // 選取暗掉
                status = 0;
                select1.Text = select2.Text = select3.Text = select4.Text = "選取";
                Statusbar2.Text = "...";
                checkwin();
            }
        }
        private void select3_Click(object sender, EventArgs e)
        {
            if (status == 0) // 選取 -> 放置
            {
                select = 3;
                changestatus();
                status = 1;
                select1.Text = select2.Text = select3.Text = select4.Text = "放置";
                Statusbar2.Text = "你選了堆疊3";
            }
            else if (status == 1) // 放置 -> 選取
            {
                put(3);
                changestatus(); // 選取暗掉
                status = 0;
                select1.Text = select2.Text = select3.Text = select4.Text = "選取";
                Statusbar2.Text = "...";
                checkwin();
            }
        }
        private void select4_Click(object sender, EventArgs e)
        {
            if (status == 0) // 選取 -> 放置
            {
                select = 4;
                changestatus();
                status = 1;
                select1.Text = select2.Text = select3.Text = select4.Text = "放置";
                Statusbar2.Text = "你選了堆疊4";
            }
            else if (status == 1) // 放置 -> 選取
            {
                put(4);
                changestatus(); // 選取暗掉
                status = 0;
                select1.Text = select2.Text = select3.Text = select4.Text = "選取";
                Statusbar2.Text = "...";
                checkwin();
            }
        }
    }
}
