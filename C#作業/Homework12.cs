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

namespace C_作業
{
    public partial class Homework12 : Form
    {
        public Homework12()
        {
            InitializeComponent();
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
                }
                else
                {
                    File.WriteAllText(openFileDialog1.FileName, textBox1.Text, Encoding.Default);
                }
                saveFileDialog1.ShowDialog(this);
            }
        }

        private void tsmiFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog(this);
        }

        private void tsmiColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(this);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            關於 T = new 關於();
            T.ShowDialog();
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);

            }
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            textBox1.Clear();
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void tsmiUndo_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void tsmiNUndo_Click(object sender, EventArgs e)
        {
            textBox1.ClearUndo();
        }

        private void Homework12_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
        }

        

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            textBox1.Clear();
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
           關於 T =new 關於();
            T.ShowDialog();
        }

        private void 紅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void gerrnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("tt HH:mm:ss");
        }
    }
}
