using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw5_2
{
    public partial class Form1 : Form
    {
        Warrior P1W = new Warrior(0);
        Warrior P2W = new Warrior(3);
        Magician P1M = new Magician(1);
        Magician P2M = new Magician(4);
        Ranger P1R = new Ranger(2);
        Ranger P2R = new Ranger(5);
        Button[,] board = new Button[6, 7];
        int[] buttunclick = new int[2];
        int[] no_chess = new int[7]; //放置 and 死人
        int preparing = 0;
        int round = -1;
        int action = 0; //攻擊:1 移動:2 技能:3 待機:4 
        int p1last = 3, p2last = 6;
        public void End()
        {
            if (no_chess[0] == 444 && no_chess[1] == 444 && no_chess[2] == 444)
            {
                timer2.Enabled = false;
                MessageBox.Show("P2贏了", "", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            if (no_chess[3] == 444 && no_chess[4] == 444 && no_chess[5] == 444)
            {
                timer2.Enabled = false;
                MessageBox.Show("P1贏了", "", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
        }
        public void Action(int action, object sender, object actionchess)
        {
            Button target = (Button)sender;
            Chess attacker = (Chess)actionchess;
            int ti = target.Name[0] - '0';
            int tj = target.Name[1] - '0';

            switch (action)
            {
                case 1:
                    if ((round <= 3 && target.BackColor != Color.LightPink) || (round > 3 && target.BackColor != Color.LightBlue))
                    {
                        return;
                    }
                    else
                    {
                        if (ti == attacker.i || tj == attacker.j)
                        {
                            if ((ti > attacker.i + attacker.atkRange) || (attacker.i > ti + attacker.atkRange) || (tj > attacker.j + attacker.atkRange) || (attacker.j > tj + attacker.atkRange))
                            {
                                MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {
                                Attack(attacker.atk, (round - 1) / 3, target.Name[2], target);

                                if (round == p1last)
                                {
                                    p1attack.Enabled = p1move.Enabled = p1skill.Enabled = p1standby.Enabled = false;
                                    p1end.Enabled = true;
                                }
                                else if (round == p2last)
                                {
                                    p2attack.Enabled = p2move.Enabled = p2skill.Enabled = p2standby.Enabled = false;
                                    p2end.Enabled = true;
                                }
                                else
                                {
                                    timer2.Enabled = true;
                                }

                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    break;
                case 2:
                    if (target.BackColor == Color.LightPink || target.BackColor == Color.LightBlue)
                    {
                        return;
                    }
                    if (ti == attacker.i || tj == attacker.j)
                    {
                        if ((ti > attacker.i + attacker.moveRange) || (attacker.i > ti + attacker.moveRange) || (tj > attacker.j + attacker.moveRange) || (attacker.j > tj + attacker.moveRange))
                        {
                            return;
                        }
                        else
                        {
                            //MOVE
                            board[ti, tj].BackColor = board[attacker.i, attacker.j].BackColor;
                            board[ti, tj].Text = board[attacker.i, attacker.j].Text;
                            board[ti, tj].Name = ti.ToString() + tj.ToString() + board[attacker.i, attacker.j].Name[2];
                            board[attacker.i, attacker.j].BackColor = Color.White;
                            board[attacker.i, attacker.j].Text = "";
                            board[attacker.i, attacker.j].Name = attacker.i.ToString() + attacker.j.ToString();
                            attacker.i = ti;
                            attacker.j = tj;

                            if (round == p1last)
                            {
                                p1attack.Enabled = p1move.Enabled = p1skill.Enabled = p1standby.Enabled = false;
                                p1end.Enabled = true;
                            }
                            else if (round == p2last)
                            {
                                p2attack.Enabled = p2move.Enabled = p2skill.Enabled = p2standby.Enabled = false;
                                p2end.Enabled = true;
                            }
                            else
                            {
                                timer2.Enabled = true;
                            }
                        }
                    }
                    else
                    {

                        return;
                    }
                    break;
                case 3:
                    if ((round <= 3 && target.BackColor != Color.LightPink) || (round > 3 && target.BackColor != Color.LightBlue))
                    {
                        return;
                    }
                    else
                    {
                        if (ti == attacker.i || tj == attacker.j)
                        {
                            if ((ti > attacker.i + attacker.atkRange) || (attacker.i > ti + attacker.atkRange) || (tj > attacker.j + attacker.atkRange) || (attacker.j > tj + attacker.atkRange))
                            {
                                MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {
                                switch (round)
                                {
                                    case 1:
                                        Attack(attacker.atk, 0, target.Name[2], target);
                                        attacker.hp += attacker.atk;
                                        break;
                                    case 2:
                                        Attack(attacker.atk * 2, 0, target.Name[2], target);
                                        break;
                                    case 3:
                                        Attack(attacker.atk, 0, target.Name[2], target);
                                        break;
                                    case 4:
                                        Attack(attacker.atk, 1, target.Name[2], target);
                                        attacker.hp += attacker.atk;
                                        break;
                                    case 5:
                                        Attack(attacker.atk * 2, 1, target.Name[2], target);
                                        break;
                                    case 6:
                                        Attack(attacker.atk, 1, target.Name[2], target);
                                        break;
                                }
                                if(round != p1last && round != p1last)
                                {
                                    timer2.Enabled = true;
                                }
                                if(round == p2last)
                                {
                                    p2attack.Enabled = p2move.Enabled = p2skill.Enabled = p2standby.Enabled = false;
                                    p2end.Enabled = true;
                                }
                                if (round == p1last)
                                {
                                    p1attack.Enabled = p1move.Enabled = p1skill.Enabled = p1standby.Enabled = false;
                                    p1end.Enabled = true;
                                }
                            }
                        }
                        else
                        {
                            return;
                        }
                        break;
                    }
            }
            return;
        }
        public void Attack(int damage, int victim, char prey, object a)
        {
            if(victim == 1)
            {
                switch (prey)
                {
                    case 'w':
                        P1W.hp -= damage;
                        P1W.CheckStatus(no_chess, (Button)a);
                        break;
                    case 'm':
                        P1M.hp -= damage;
                        P1M.CheckStatus(no_chess, (Button)a);
                        break;
                    case 'r':
                        P1R.hp -= damage;
                        P1R.CheckStatus(no_chess, (Button)a);
                        break;
                }
            }
            if(victim == 0)
            {
                switch (prey)
                {
                    case 'w':
                        P2W.hp -= damage;
                        P2W.CheckStatus(no_chess, (Button)a);
                        break;
                    case 'm':
                        P2M.hp -= damage;
                        P2M.CheckStatus(no_chess, (Button)a);
                        break;
                    case 'r':
                        P2R.hp -= damage;
                        P2R.CheckStatus(no_chess, (Button)a);
                        break;
                }
            }
            End();
            return;
        }
        public void Put(object sender, EventArgs e)
        {
            Button clickposition = (Button)sender;
            buttunclick[0] = clickposition.Name[0] - '0';
            buttunclick[1] = clickposition.Name[1] - '0';
            if (preparing <= 0)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (no_chess[i] == 1 && clickposition.Text == "")
                    {
                        switch (i)
                        {
                            case 0:
                                clickposition.Text = "戰士";
                                p1w.Enabled = false;
                                P1W.i = clickposition.Name[0] - '0';
                                P1W.j = clickposition.Name[1] - '0';
                                clickposition.Name += 'w';
                                break;
                            case 1:
                                clickposition.Text = "法師";
                                p1m.Enabled = false;
                                P1M.i = clickposition.Name[0] - '0';
                                P1M.j = clickposition.Name[1] - '0';
                                clickposition.Name += 'm';
                                break;
                            case 2:
                                clickposition.Text = "遊俠";
                                p1r.Enabled = false;
                                P1R.i = clickposition.Name[0] - '0';
                                P1R.j = clickposition.Name[1] - '0';
                                clickposition.Name += 'r';
                                break;
                            case 3:
                                clickposition.Text = "戰士";
                                p2w.Enabled = false;
                                P2W.i = clickposition.Name[0] - '0';
                                P2W.j = clickposition.Name[1] - '0';
                                clickposition.Name += 'w';
                                break;
                            case 4:
                                clickposition.Text = "法師";
                                p2m.Enabled = false;
                                P2M.i = clickposition.Name[0] - '0';
                                P2M.j = clickposition.Name[1] - '0';
                                clickposition.Name += 'm';
                                break;
                            case 5:
                                clickposition.Text = "遊俠";
                                p2r.Enabled = false;
                                P2R.i = clickposition.Name[0] - '0';
                                P2R.j = clickposition.Name[1] - '0';
                                clickposition.Name += 'r';
                                break;
                        }
                        if (i >= 3)
                            clickposition.BackColor = Color.LightPink;
                        else
                            clickposition.BackColor = Color.LightBlue;
                        no_chess[i] += 1;
                    }
                }
            }
            else
            {
                switch (round)
                {
                    case 1:
                        Action(action, clickposition, P1W);
                        break;
                    case 2:
                        Action(action, clickposition, P1M);
                        break;
                    case 3:
                        Action(action, clickposition, P1R);
                        break;
                    case 4:
                        Action(action, clickposition, P2W);
                        break;
                    case 5:
                        Action(action, clickposition, P2M);
                        break;
                    case 6:
                        Action(action, clickposition, P2R);
                        break;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Start.Visible = false;
            Phase.Visible = Time.Visible = P1.Visible = P2.Visible = p1w.Visible = p1m.Visible = p1r.Visible = p2w.Visible = p2m.Visible = p2r.Visible = true;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    board[i, j] = new Button();
                    board[i, j].SetBounds(140 + 50 * i, 60 + 50 * j, 50, 50);
                    board[i, j].BackColor = Color.White;
                    Controls.Add(board[i, j]);
                    board[i, j].Click += new EventHandler(Put);
                    board[i, j].Name = i.ToString() + j.ToString();
                }
            }
            timer1.Enabled = true;
            p2w.Enabled = p2m.Enabled = p2r.Enabled = false;
            p1current.Visible = true;
            for (int i = 3; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    board[i, j].Enabled = false;
                }
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            Time.Text = (int.Parse(Time.Text) - 1).ToString();
            if (Time.Text == "0" && preparing == 0)
            {
                int k = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (no_chess[i] <= 1)
                    {
                        while (board[0, k].BackColor == Color.LightBlue)
                            k++;
                        switch (i)
                        {
                            case 0:
                                board[0, k].Text = "戰士";
                                p1w.Enabled = false;
                                P1W.i = board[0, k].Name[0] - '0';
                                P1W.j = board[0, k].Name[1] - '0';
                                board[0, k].Name += 'w';
                                break;
                            case 1:
                                board[0, k].Text = "法師";
                                p1m.Enabled = false;
                                P1M.i = board[0, k].Name[0] - '0';
                                P1M.j = board[0, k].Name[1] - '0';
                                board[0, k].Name += 'm';
                                break;
                            case 2:
                                board[0, k].Text = "遊俠";
                                p1r.Enabled = false;
                                P1R.i = board[0, k].Name[0] - '0';
                                P1R.j = board[0, k].Name[1] - '0';
                                board[0, k].Name += 'r';
                                break;
                        }
                        board[0, k].BackColor = Color.LightBlue;
                        no_chess[i] = 2;
                    }
                }
                Time.Text = "10";
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (i < 3)
                            board[i, j].Enabled = false;
                        else
                            board[i, j].Enabled = true;
                    }
                }
                p1w.Enabled = p1m.Enabled = p1r.Enabled = false;
                p2w.Enabled = p2m.Enabled = p2r.Enabled = true;
                p2current.Visible = true;
                preparing--;
            }
            else if (Time.Text == "0" && preparing == -1)
            {
                int k = 0;
                for (int i = 3; i < 6; i++)
                {
                    while (board[5, k].BackColor == Color.LightPink)
                        k++;
                    if (no_chess[i] <= 1)
                    {
                        switch (i)
                        {
                            case 3:
                                board[5, k].Text = "戰士";
                                p2w.Enabled = false;
                                P2W.i = board[5, k].Name[0] - '0';
                                P2W.j = board[5, k].Name[1] - '0';
                                board[5, k].Name += 'w';
                                break;
                            case 4:
                                board[5, k].Text = "法師";
                                p2m.Enabled = false;
                                P2M.i = board[5, k].Name[0] - '0';
                                P2M.j = board[5, k].Name[1] - '0';
                                board[5, k].Name += 'm';
                                break;
                            case 5:
                                board[5, k].Text = "遊俠";
                                p2r.Enabled = false;
                                P2R.i = board[5, k].Name[0] - '0';
                                P2R.j = board[5, k].Name[1] - '0';
                                board[5, k].Name += 'r';
                                break;
                        }
                        board[5, k].BackColor = Color.LightPink;
                        no_chess[i] = 2;
                    }
                }
                Time.Visible = false;
                for (int i = 0; i < 6; i++)
                    for (int j = 0; j < 7; j++)
                        board[i, j].Enabled = true;
                p1w.Visible = p1m.Visible = p1r.Visible = p2w.Visible = p2m.Visible = p2r.Visible = false;
                preparing = 1;
                p1state.Visible = p2state.Visible = true;
                p1attack.Visible = p1move.Visible = p1skill.Visible = p1standby.Visible = p1end.Visible = true;
                p2attack.Visible = p2move.Visible = p2skill.Visible = p2standby.Visible = p2end.Visible = true;
                p1attack.Enabled = p1move.Enabled = p1skill.Enabled = p1standby.Enabled = true;
                Phase.Text = "P1 Turn";
                round = 0;
                timer2.Enabled = true;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1;
            timer2.Enabled = false;
            round++;
            if (no_chess[round - 1] == 444)  //die
            {
                timer2.Enabled = true;
                return;
            }
            switch (round)
            {
                case 1:
                    p1current.Text = "戰士";
                    P1W.RefreshStateMessage(1, p1state);
                    break;
                case 2:
                    p1current.Text = "法師";
                    P1M.RefreshStateMessage(1, p1state);
                    break;
                case 3:
                    p1current.Text = "遊俠";
                    P1R.RefreshStateMessage(1, p1state);
                    break;
                case 4:
                    p2current.Text = "戰士";
                    P2W.RefreshStateMessage(2, p2state);
                    break;
                case 5:
                    p2current.Text = "法師";
                    P2M.RefreshStateMessage(2, p2state);
                    break;
                case 6:
                    p2current.Text = "遊俠";
                    P2R.RefreshStateMessage(2, p2state);
                    break;
            }
            action = 0;
            for(int i = 0; i < 3; i++)
            {
                if(no_chess[i] != 444)
                {
                    p1last = i + 1;
                }
                if (no_chess[i+3] != 444)
                {
                    p2last = 4 + i;
                }
            }
            End();
        }
        private void p1w_Click(object sender, EventArgs e)
        {
            no_chess[0] = 1;
            p1current.Text = "戰士";
        }
        private void p1m_Click(object sender, EventArgs e)
        {
            no_chess[1] = 1;
            p1current.Text = "法師";
        }
        private void p1r_Click(object sender, EventArgs e)
        {
            no_chess[2] = 1;
            p1current.Text = "遊俠";
        }
        private void p2w_Click(object sender, EventArgs e)
        {
            no_chess[3] = 1;
            p2current.Text = "戰士";
        }
        private void p2m_Click(object sender, EventArgs e)
        {
            no_chess[4] = 1;
            p2current.Text = "法師";
        }
        private void p2r_Click(object sender, EventArgs e)
        {
            no_chess[5] = 1;
            p2current.Text = "遊俠";
        }
        private void p1attack_Click(object sender, EventArgs e)
        {
            action = 1;
        }
        private void p1move_Click(object sender, EventArgs e)
        {
            action = 2;
        }
        private void p1skill_Click(object sender, EventArgs e)
        {
            switch (round)
            {
                case 1:
                    if (P1W.mp >= 10)
                    {
                        action = 3;
                        P1W.mp -= 10;
                    }
                    
                    break;
                case 2:
                    if (P1M.mp >= 10)
                    {
                        action = 3;
                        P1M.mp -= 10; ;
                    }
                    break;
                case 3:
                    if (P1R.mp >= 10)
                    {
                        action = 3;
                        P1R.mp -= 10;
                        P1R.atkRange++;
                    }
                    break;
            }
        }
        private void p1standby_Click(object sender, EventArgs e)
        {
            if(round == p1last)
            {
                p1attack.Enabled = p1move.Enabled = p1skill.Enabled = p1standby.Enabled  =  false;
                p1end.Enabled = true;
            }
            else
            {
                timer2.Enabled = true;
            }
            //待機
        }
        private void p1end_Click(object sender, EventArgs e)
        {
            p1attack.Enabled = p1move.Enabled = p1skill.Enabled = p1standby.Enabled = p1end.Enabled = p2end.Enabled = false;
            p2attack.Enabled = p2move.Enabled = p2skill.Enabled = p2standby.Enabled = true;
            Phase.Text = "P2 Turn";
            timer2.Enabled = true;
        }
        private void p2attack_Click(object sender, EventArgs e)
        {
            action = 1;
        }
        private void p2move_Click(object sender, EventArgs e)
        {
            action = 2;
        }
        private void p2skill_Click(object sender, EventArgs e)
        {
            switch (round)
            {
                case 4:
                    if (P2W.mp >= 10)
                    {
                        action = 3;
                        P2W.mp -= 10;
                    }
                    break;
                case 5:
                    if (P2M.mp >= 10)
                    {
                        P2M.mp -= 10;
                        action = 3;
                    }
                    break;
                case 6:
                    if (P1R.mp >= 10)
                    {
                        P2R.atkRange++;
                        P2R.mp -= 10;
                        action = 3;
                    }
                    break;
            }
            
        }
        private void p2standby_Click(object sender, EventArgs e)
        {
            if (round == p2last)
            {
                p2attack.Enabled = p2move.Enabled = p2skill.Enabled = p2standby.Enabled = false;
                p2end.Enabled = true;
            }
            else
            {
                timer2.Enabled = true;
            }
        }
        private void p2end_Click(object sender, EventArgs e)
        {
            p1attack.Enabled = p1move.Enabled = p1skill.Enabled = p1standby.Enabled = true;
            p2attack.Enabled = p2move.Enabled = p2skill.Enabled = p2standby.Enabled = p2end.Enabled = p1end.Enabled = false;
            Phase.Text = "P1 Turn";
            timer2.Enabled = true;
            round = 0;
        }

    }
}
