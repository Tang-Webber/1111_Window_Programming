using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw7_1
{
    public partial class Form1 : Form
    {
        bool saved = false;
        string theFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            saveFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saved = false;
            List.Text = "";
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                theFile = openFileDialog1.FileName;
                List.Text = System.IO.File.ReadAllText(theFile);
                saved = true;
            }
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved)
            {
                File.WriteAllText(theFile, List.Text);
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, List.Text);
                    theFile = saveFileDialog1.FileName;
                    saved = true;
                }
            }

        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, List.Text);
                theFile = saveFileDialog1.FileName;
                saved = true;
            }

        }

        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 字型大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                List.Font = fontDialog1.Font;
                List.ForeColor = fontDialog1.Color;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            AddItem open = new AddItem();
            open.FormClosed += new FormClosedEventHandler(open_FormClosed);
            this.Enabled = false;
            AddTextbox.add = false;
            open.ShowDialog();
        }
        private void open_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            if (AddTextbox.add)
            {
                if (List.Text == "")
                {
                    List.AppendText(AddTextbox.todo);
                }
                else
                {
                    List.AppendText(Environment.NewLine);
                    List.AppendText(AddTextbox.todo);
                }
            }

        }
    }
}
