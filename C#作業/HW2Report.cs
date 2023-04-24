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
    public partial class HW2Report : Form
    {
        public HW2Report()
        {
            InitializeComponent();
        }
        public HW2Report(string HW1, string HW2, string HW3, string HW5, string HW6)//對應Homework2的ShowDialog
        {
            InitializeComponent();
            label6.Text = HW1;
            label5.Text = HW2;
            label4.Text = HW3;
            label2.Text = HW5;
            label1.Text = HW6;
        }
    }
}
