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
    public partial class Homework8 : Form
    {
        public Homework8()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text == string.Empty)
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if (txtnum2.Text == string.Empty)
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            double Num1 = double.Parse(txtnum1.Text);
            double Num2 = double.Parse(txtnum2.Text);

            double X = Num1 + Num2;
            string add = X.ToString();
            txtanswer.Text = add;
        }

        private void btnreduce_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text == string.Empty)
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if (txtnum2.Text == string.Empty)
            {
                MessageBox.Show("請輸入數值");
                return;
            }

            double Num1 = double.Parse(txtnum1.Text);
            double Num2 = double.Parse(txtnum2.Text);

            double L = Num1 - Num2;
            string reduce = L.ToString();
            txtanswer.Text = reduce;
        }

        private void btntake_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text == string.Empty)
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if (txtnum2.Text == string.Empty)
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            double Num1 = double.Parse(txtnum1.Text);
            double Num2 = double.Parse(txtnum2.Text);
            double T = Num1 * Num2;
            txtanswer.Text = T.ToString();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text == string.Empty)
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if (txtnum2.Text == string.Empty)
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            double Num1 = double.Parse(txtnum1.Text);
            double Num2 = double.Parse(txtnum2.Text);
            double R =Num1 / Num2;
            double T = Math.Round(R, 4, MidpointRounding.AwayFromZero);
            txtanswer.Text = T.ToString();
        }
    }
    }

