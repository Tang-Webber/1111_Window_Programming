using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw7_1
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if(NewTodo.Text == "")
            {
                MessageBox.Show("請輸入事項", "", MessageBoxButtons.OK);
            }
            else
            {
                AddTextbox.todo = NewTodo.Text;
                AddTextbox.add = true;
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItem_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            this.Name = "新增待辦事項";
        }
    }
}
