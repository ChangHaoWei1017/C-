using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業
{
    public partial class Homework_Guess : Form
    {
        public Homework_Guess()
        {
            InitializeComponent();
            random();
            panel1.Visible = false;
        }
        int Answer = 100;
        void random()
        {
            Random random = new Random();
            Answer=random.Next(Answer);
        }
        
        private void btnGuess_Click(object sender, EventArgs e)
        {
            btnGuess.Enabled = false;
            panel1.Visible = true;
        }
        int min = 0;
        int max = 100;
       
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text ==string.Empty)
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            int Enter = int.Parse(textBox1.Text);
            if (Enter > min && Enter < max)
            {
                if (Answer > Enter)
                {
                    min = Enter;
                    labshow.Text = $"Too Small!!!!!\nBetween{Enter} to {max}";
                }
                else if (Answer < Enter)
                {
                    max = Enter;
                    labshow.Text = $"Too Lage!!!!!\nBetween{min} to {Enter}";
                }
                else if (Enter == Answer)
                {
                    MessageBox.Show("恭喜答對了~");
                }

            }
            else
            {
                MessageBox.Show("請輸入0~100之間的數字", "錯誤");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnGuess.Enabled = true;
            panel1.Visible=false;
            random();
            labshow.Text = $"Please Select A Number Between 1 to 100!!";
            min = 0; max = 100;
            textBox1.Clear();
        }

        private void btnanswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Answer.ToString());
        }

      
    }
}
