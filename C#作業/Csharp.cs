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
    public partial class Csharp : Form
    {
        public Csharp()
        {
            InitializeComponent();
        }

        private void btnHW1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework1 HW1 = new Homework1();
            HW1.TopLevel = false;
            HW1.Parent = this;
            HW1.Show();
            splitContainer2.Panel2.Controls.Add(HW1 );

        }

        private void btnHW2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework2 HW2 = new Homework2();
            HW2 .TopLevel = false;
            HW2.Parent = this;
            HW2.Show();
            splitContainer2.Panel2.Controls.Add(HW2);
        }

        private void btnHW3_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework3 HW3 = new Homework3();
            HW3.TopLevel = false;
            HW3.Parent = this;
            HW3.Show();
            splitContainer2.Panel2.Controls.Add(HW3);
        }

        private void btnHW4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework4 HW4 = new Homework4();
            HW4.TopLevel = false;
            HW4.Parent = this;
            HW4.Show();
            splitContainer2.Panel2.Controls.Add(HW4);
        }

        private void btnHW8_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework8 HW8 = new Homework8();
            HW8.TopLevel = false;
            HW8.Parent = this;
            HW8.Show();
            splitContainer2.Panel2.Controls.Add(HW8);
        }

        private void btnHW11_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework11 HW11 = new Homework11();
            HW11.TopLevel = false;
            HW11.Parent = this;
            HW11.Show();
            splitContainer2.Panel2.Controls.Add(HW11);
        }

        private void btnHW12_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework12 HW12 = new Homework12();
            HW12.TopLevel = false;
            HW12.Parent = this;
            HW12.Show();
            splitContainer2.Panel2.Controls.Add(HW12);
        }

        private void HWAlarm_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework_Alarm AL = new Homework_Alarm();
            AL.TopLevel = false;
            AL.Parent = this;
            AL.Show();
            splitContainer2.Panel2.Controls.Add(AL);
        }

        private void HW13_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework13 HW13 = new Homework13();
            HW13.TopLevel = false;
            HW13.Parent = this;
            HW13.Show();
            splitContainer2.Panel2.Controls.Add(HW13);
        }

        private void btnHW5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework5 HW5 = new Homework5();
            HW5.TopLevel = false;
            HW5.Parent = this;
            HW5.Show();
            splitContainer2.Panel2.Controls.Add(HW5);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework_Guess HWGu = new Homework_Guess();
            HWGu.TopLevel = false;
            HWGu.Parent = this;
            HWGu.Show();
            splitContainer2.Panel2.Controls.Add(HWGu);
        }

        private void btnHW10_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework10 HW10 = new Homework10();
            HW10.TopLevel = false;
            HW10.Parent = this;
            HW10.Show();
            splitContainer2.Panel2.Controls.Add(HW10);
        }
    }
}
