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
    public partial class Homework1 : Form
    {
        public Homework1()
        {
            InitializeComponent();
        }
        
        private void btnHi_Click(object sender, EventArgs e)
        {
            string Name = TxtName.Text;
            string EnglishName = TxtEnName.Text;
            string Gender = TxtGender.Text;
            string constellation = TxtConstellation.Text;
            MessageBox.Show("Hi! , 我是" + Name + Environment.NewLine + "英文名字是" + EnglishName + Environment.NewLine + "性別是" + Gender + Environment.NewLine + "星座是" + constellation + Environment.NewLine + "很高興認識你。");
            //Environment.NewLine用於MessageBox.Show 換行用
            MessageBox.Show("Hi! , 我是" + Name + "\n英文名字是" + EnglishName + "\n性別是" + Gender + "\n星座是" + constellation + "\n很超性認識你。");

        }

      

        private void btnHi_Click_1(object sender, EventArgs e)
        {
            string Name = TxtName.Text;
            string EnglishName = TxtEnName.Text;
            string Gender = TxtGender.Text;
            string constellation = TxtConstellation.Text;
            MessageBox.Show("Hi! , 我是" + Name + "\n英文名字是" + EnglishName + "\n性別是" + Gender + "\n星座是" + constellation + "\n很超性認識你。");
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string Name = TxtName.Text;
            string EnglishName = TxtEnName.Text;
            string Gender = TxtGender.Text;
            string constellation = TxtConstellation.Text;
            MessageBox.Show("Hello! , 我是" + Name + Environment.NewLine + "英文名字是" + EnglishName + Environment.NewLine + "性別是" + Gender + Environment.NewLine + "星座是" + constellation + Environment.NewLine + "很高興認識你。");
        }
    }
}
