using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業
{
    public partial class Homework_Alarm : Form
    {
        public Homework_Alarm()
        {
            InitializeComponent();
        }

        private void Homework_Alarm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
        }
        bool b = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            if (b == false)
            {
                if (h == DateTime.Now.Hour)
                {
                    if (m == DateTime.Now.Minute)
                    {
                        if (s == DateTime.Now.Second)
                        {
                            b = true;
                            MessageBox.Show("時間到了!!!");
                        }
                    }
                }

            }
        }
        int h,m,s = 0;
        private void btntiming_Click(object sender, EventArgs e)
        {
            b = false;
            h = int.Parse(textBox1.Text);
            m = int.Parse(textBox2.Text);
            s = int.Parse(textBox3.Text);
        }
    }
}

