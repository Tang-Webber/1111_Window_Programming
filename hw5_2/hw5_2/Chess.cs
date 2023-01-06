using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace hw5_2
{
    class Chess
    {
        //Form1 form1 = new Form1();
        public int hp;
        public int mp;
        public int atk;
        public int atkRange;
        public int moveRange;
        public int i = -1, j = -1; //position
        public int player;

        public virtual void Skill() { }
        public void RefreshStateMessage(int p, object sender)
        {
            Label state = (Label)sender;
            if (p == 1)
            {
                state.Text = "HP: " + hp + "\nMP: " + mp + "\nATK: " + atk + "\nATK Range:" + atkRange + "\nMOVE Range: " + moveRange;
            }
            else
            {
                state.Text = "HP: " + hp + "\nMP: " + mp + "\nATK: " + atk + "\nATK Range:" + atkRange + "\nMOVE Range: " + moveRange;
            }
        }
        public void CheckStatus(int[] die, object but) {
            Button b = (Button)but;
            if(hp <= 0)
            {
                die[player] = 444;
                b.Name.Remove(b.Name.Length - 1);
                b.BackColor = Color.White;
                b.Text = "";
            }
            

        }
    }
    class Warrior : Chess
    {
        public Warrior(int p)
        {
            hp = 100;
            mp = 15;
            atk = 30;
            atkRange = 1;
            moveRange = 2;
            player = p;
        }
    }
    class Magician : Chess
    {
        public Magician(int p)
        {
            hp = 70;
            mp = 25;
            atk = 20;
            atkRange = 2;
            moveRange = 2;
            player = p;
        }
    }
    class Ranger : Chess
    {
        public Ranger(int p)
        {
            hp = 90;
            mp = 10;
            atk = 30;
            atkRange = 3;
            moveRange = 1;
            player = p;
        }
    }
    
}
