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

namespace hw7_2
{
    public partial class Form1 : Form
    {
        bool saved = false;
        bool hide = false;
        string theFile;
        string[] lines;
        string[] temp;
        int num = 0;
        AddItem open = new AddItem();

        public void RefreshList()
        {
            List.Text = "";
            for(int i = 0; i < num; i++)
            {
                if (lines[i][0] == '-')
                {
                    List.AppendText(" [ ] ");
                }
                if (lines[i][0] == '+')
                {
                    List.AppendText(" [√] ");
                }
                List.AppendText(lines[i].Remove(0,1));
                List.AppendText(Environment.NewLine);
            }
        }

        public void HideComplete()
        {
            List.Text = "";
            for (int i = 0; i < num; i++)
            {
                if (lines[i][0] == '-')
                {
                    List.AppendText(" [ ] ");
                    List.AppendText(lines[i].Remove(0, 1));
                    List.AppendText(Environment.NewLine);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            saveFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            open.FormClosed += new FormClosedEventHandler(open_FormClosed);
            新增事項ToolStripMenuItem.Click += new System.EventHandler(save_Click);
            完成事項ToolStripMenuItem.Click += new System.EventHandler(complete_Click);
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saved = false;
            List.Text = "";
            num = 0;
            lines = null;
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                theFile = openFileDialog1.FileName;
                temp = File.ReadAllLines(theFile);
                num = temp.Count();
                Array.Resize(ref lines, temp.Length);
                for(int i = 0; i < num; i++)
                {
                    lines[i] = temp[i];
                }
                if (hide)
                    HideComplete();
                else
                    RefreshList();
                saved = true;
            }
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved)
            {
                File.WriteAllLines(theFile, lines);
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    theFile = saveFileDialog1.FileName;
                    File.WriteAllLines(theFile, lines);
                    saved = true;
                }
            }

        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                theFile = saveFileDialog1.FileName;
                File.WriteAllLines(theFile, lines);
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
            this.Enabled = false;
            AddTextbox.success = false;
            AddTextbox.function = 1;
            open.ShowDialog();
        }

        private void complete_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            AddTextbox.success = false;
            AddTextbox.function = 2;
            open.ShowDialog();
        }

        private void 刪除事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            AddTextbox.success = false;
            AddTextbox.function = 3;
            open.ShowDialog();
        }

        private void 尋找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            AddTextbox.success = false;
            AddTextbox.function = 4;
            open.ShowDialog();
        }

        private void open_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            if (AddTextbox.success)
            {
                if (AddTextbox.function == 1)                               //add tack
                {
                    if (lines == null)
                    {
                        lines = new string[1];
                        lines[0] = "-" + AddTextbox.todo;
                        num++;
                    }
                    else
                    {
                        Array.Resize(ref lines, lines.Length + 1);
                        lines[num] = "-" + AddTextbox.todo;
                        num++;
                    }
                    if (hide)
                        HideComplete();
                    else
                        RefreshList();
                }                                                          
                else if (AddTextbox.function == 2)                          //complete
                {
                    for(int i = 0; i < num; i++)
                    {
                        if(lines[i].Remove(0,1) == AddTextbox.todo)
                        {
                            lines[i] = '+' + lines[i].Remove(0, 1);
                            if (hide)
                                HideComplete();
                            else
                                RefreshList();
                        }
                    }
                }
                else if (AddTextbox.function == 3)                          //delete
                {
                    for (int i = 0; i < num; i++)
                    {
                        if (lines[i].Remove(0, 1) == AddTextbox.todo)
                        {
                            num--;
                            for (int j = i; j < num; j++)
                            {
                                lines[j] = lines[j + 1];
                            }
                            Array.Resize(ref lines, lines.Length - 1);
                            if (hide)
                                HideComplete();
                            else
                                RefreshList();
                        }
                    }
                }
                else if (AddTextbox.function == 4)                          //find
                {
                    List.Text = "";
                    if (hide)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            if (lines[i].Contains(AddTextbox.todo) && lines[i][0] == '-')
                            {
                                List.AppendText(" [ ] ");
                                List.AppendText(lines[i].Remove(0, 1));
                                List.AppendText(Environment.NewLine);
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < num; i++)
                        {
                            if (lines[i].Contains(AddTextbox.todo))
                            {
                                if (lines[i][0] == '-')
                                    List.AppendText(" [ ] ");
                                if (lines[i][0] == '+')
                                    List.AppendText(" [√] ");
                                List.AppendText(lines[i].Remove(0, 1));
                                List.AppendText(Environment.NewLine);
                            }
                        }
                    }
                    close.Visible = true;
                    save.Visible = complete.Visible = false;
                    menuStrip1.Enabled = false;
                }
            }
        }

        private void 隱藏完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideComplete();
            hide = true;
        }

        private void 顯示完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshList();
            hide = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            close.Visible = false;
            save.Visible = complete.Visible = true;
            menuStrip1.Enabled = true;
            if (hide)
                HideComplete();
            else
                RefreshList();
        }
    }
}
