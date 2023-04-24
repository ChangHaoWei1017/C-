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
    public partial class Homework13 : Form
    {
        public Homework13()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox2.BackColor = colorDialog1.Color;
        }
        int x0, y0;

        private void Homework13_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(1042, 621);
            Graphics G = Graphics.FromImage(pictureBox1.Image);
            G.Clear(Color.White);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics G = Graphics.FromImage(pictureBox1.Image);
                Pen P = new Pen(colorDialog1.Color, trackBar1.Value);
                G.DrawLine(P, x0, y0, e.X, e.Y);
                x0 = e.X; y0 = e.Y;
                pictureBox1.Refresh();

            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X; y0 = e.Y;
        }
    }
}
