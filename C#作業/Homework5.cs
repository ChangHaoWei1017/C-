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
    public partial class Homework5 : Form
    {
        public Homework5()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ClassScore score;
            if (txtName.Text == string.Empty)
            {
                string title = "警告!";
                MessageBox.Show("請輸入姓名。", title); return;
            }
            else if (txtchi.Text == string.Empty)
            {
                string title = "警告!";
                MessageBox.Show("請輸入國文成績。", title); return;
            }
            else if (txteng.Text == string.Empty)
            {
                string title = "警告!";
                MessageBox.Show("請輸入英文成績。", title);
                return;
            }
            else if (txtmath.Text == string.Empty)
            {
                string title = "警告!";
                MessageBox.Show("請輸入數學成績。", title);
                return;
            }
            score.Chinese = double.Parse(txtchi.Text);
            score.English = double.Parse(txteng.Text);
            score.Math = double.Parse(txtmath.Text);

            string[] subject = new string[] { "國文", "英文", "數學" };
            double[] Scores = new double[] { score.Chinese, score.English, score.Math };
            score.Sum = Scores.Sum();
            score.Average = Scores.Average();
            double Highscore = Scores[0];
            int j = 0;
            for (int i = 0; i < 3; i++)
            {
                if (Scores[i] > Highscore)
                {
                    Highscore = Scores[i];
                    j = i;
                }
            }
            double lowscore = Scores[0];
            int L = 0;

            for (int X = 0; X < 3; X++)
            {
                if (Scores[X] < lowscore)
                {
                    lowscore = Scores[X];
                    L = X;
                }
            }
            ListViewItem lvi = new ListViewItem(txtName.Text);
            lvi.SubItems.Add(score.Chinese.ToString());
            lvi.SubItems.Add(score.English.ToString());
            lvi.SubItems.Add(score.Math.ToString());
            lvi.SubItems.Add(score.Sum.ToString());
            lvi.SubItems.Add(score.Average.ToString());
            lvi.SubItems.Add(subject[L] + lowscore);
            lvi.SubItems.Add(subject[j] + Highscore);

            listView1.Items.Add(lvi);
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btnrandom_Click(object sender, EventArgs e)
        {
            ClassScore SC;
            Random myObject = new Random();
            int C = myObject.Next(0, 100);
            SC.Chinese = Convert.ToDouble(C);
            int E = myObject.Next(0, 100);
            SC.English = Convert.ToDouble(E);
            int M = myObject.Next(0, 100);
            SC.Math = Convert.ToDouble(M);

            string[] subject = new string[] { "國文", "英文", "數學" };
            double[] Scores = new double[] { SC.Chinese, SC.English, SC.Math };
            SC.Sum = Scores.Sum();
            SC.Average = Scores.Average();
            double Highscore = Scores[0];
            int j = 0;
            for (int i = 0; i < 3; i++)
            {
                if (Scores[i] > Highscore)
                {
                    Highscore = Scores[i];
                    j = i;
                }
            }
            double lowscore = Scores[0];
            int L = 0;

            for (int X = 0; X < 3; X++)
            {
                if (Scores[X] < lowscore)
                {
                    lowscore = Scores[X];
                    L = X;
                }
            }

            ListViewItem lvi = new ListViewItem((listView1.Items.Count + 1).ToString());
            lvi.SubItems.Add(SC.Chinese.ToString());
            lvi.SubItems.Add(SC.English.ToString());
            lvi.SubItems.Add(SC.Math.ToString());
            lvi.SubItems.Add(SC.Sum.ToString());
            lvi.SubItems.Add(SC.Average.ToString());
            lvi.SubItems.Add(subject[L] + lowscore);
            lvi.SubItems.Add(subject[j] + Highscore);

            listView1.Items.Add(lvi);
        }

        private void btn20random_Click(object sender, EventArgs e)
        {
            for (int R = 0; R < 20; R++)
            {
                ClassScore Random;
                Random myObject = new Random(Guid.NewGuid().GetHashCode());
                int C = myObject.Next(0, 100);
                Random.Chinese = Convert.ToDouble(C);
                int E = myObject.Next(0, 100);
                Random.English = Convert.ToDouble(E);
                int M = myObject.Next(0, 100);
                Random.Math = Convert.ToDouble(M);

                string[] subject = new string[] { "國文", "英文", "數學" };
                double[] Scores = new double[] { Random.Chinese, Random.English, Random.Math };
                Random.Sum = Scores.Sum();
                Random.Average = Scores.Average();
                double Highscore = Scores[0];
                int j = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (Scores[i] > Highscore)
                    {
                        Highscore = Scores[i];
                        j = i;
                    }
                }
                double lowscore = Scores[0];
                int L = 0;

                for (int X = 0; X < 3; X++)
                {
                    if (Scores[X] < lowscore)
                    {
                        lowscore = Scores[X];
                        L = X;
                    }
                }
                ListViewItem lvi = new ListViewItem((listView1.Items.Count + 1).ToString());
                lvi.SubItems.Add(Random.Chinese.ToString());
                lvi.SubItems.Add(Random.English.ToString());
                lvi.SubItems.Add(Random.Math.ToString());
                lvi.SubItems.Add(Random.Sum.ToString());
                lvi.SubItems.Add(Random.Average.ToString());
                lvi.SubItems.Add(subject[L] + lowscore);
                lvi.SubItems.Add(subject[j] + Highscore);

                listView1.Items.Add(lvi);

            }
        }
    }
}
