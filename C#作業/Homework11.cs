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
    public partial class Homework11 : Form
    {
        int stepX = 6, stepY = 8;//控制水平與垂直的移動距離(跳5個像素)

       public Homework11()
        {
            InitializeComponent();
      }
        int X = System.Windows.Forms.Cursor.Position.X;
        int Y = System.Windows.Forms.Cursor.Position.Y;

        private void Homework11_MouseMove(object sender, MouseEventArgs e)
        {
            if (X != System.Windows.Forms.Cursor.Position.X || Y != System.Windows.Forms.Cursor.Position.Y)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((pictureBox1.Location.X + pictureBox1.Width) > this.ClientSize.Width || pictureBox1.Location.X < 0)
                stepX =  -stepX;
            if ((pictureBox1.Location.Y + pictureBox1.Height) > this.ClientSize.Height || pictureBox1.Location.Y < 0)
                stepY = -stepY;

            pictureBox1.Location = new Point(pictureBox1.Location.X + stepX, pictureBox1.Location.Y + stepY);
        }
    }

}
