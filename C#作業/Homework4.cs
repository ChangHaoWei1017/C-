using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C_作業
{
    public partial class Homework4 : Form
    {
        public Homework4()
        {
            InitializeComponent();
        }
        成績 point = new 成績();

        private void btn儲存_Click(object sender, EventArgs e)
        {
            point.Name = txtName.Text;
            point.Chinese = int.Parse(txtchi.Text);
            point.English = int.Parse(txteng.Text);
            point.Math = int.Parse(txtmath.Text);
        }

        private void btn顯示_Click(object sender, EventArgs e)
        {
            txtshow.Text = "姓名 : " + point.Name + Environment.NewLine + "國文 : " + point.Chinese + "分" + Environment.NewLine + "英文 : " + point.English + "分" + Environment.NewLine + "數學 : " + point.Math + "分";
        }

        private void btnMaxMini_Click(object sender, EventArgs e)
        {
            string[] subject = new string[] { "國文", "英文", "數學" };
            int[] scores = new int[] { point.Chinese, point.English, point.Math };
            int Highscore = scores[0];
            int j = 0;
            for (int i = 0; i < 3; i++)
            {
                if (scores[i] > Highscore)
                {
                    Highscore = scores[i];
                    j = i;
                }
                int lowscore = scores[0];
                int L = 0;
                for (int X = 0; X < 3; X++)
                {
                    if (scores[X] < lowscore)
                    {
                        lowscore = scores[X];
                        L = X;
                    }
                }
                txtshow2.Text = "最高科目成績為 :" + subject[j] + Highscore + "分" + Environment.NewLine + "最低科目成績為 :" + subject[L] + lowscore + "分";
            }
        }
    }
}
