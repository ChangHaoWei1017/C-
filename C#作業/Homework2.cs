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
    public partial class Homework2 : Form
    {
        public Homework2()
        {
            InitializeComponent();
        }
        

        

       

       

        private void btn總付款_Click(object sender, EventArgs e)
        {
            double money = double.Parse(txtloan.Text);//貸款金額
            double theterm = double.Parse(txtyear.Text);//期限
            double percen = double.Parse(txtpercen.Text);//利率
            double Top = double.Parse(txtTop.Text);//頭期款

            double month_theterm = theterm * 12;//期限(年)
            double month_percen = (percen * 0.01) / 12;

            double PMT = (Math.Pow(1 + (month_percen), month_theterm) * month_percen) / (Math.Pow(1 + (month_percen), month_theterm) - 1);//月付額算法
            double result = (money - Top) * PMT;//總付款(貸款金額-頭期款)*月付款

            double INT = Math.Round(result, 0);

            MessageBox.Show("總付款 " + INT * month_theterm);//月付*期限(年)
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            double money = double.Parse(txtloan.Text);//貸款金額
            double theterm = double.Parse(txtyear.Text);//期限
            double percen = double.Parse(txtpercen.Text);//利率
            double Top = double.Parse(txtTop.Text);//頭期款

            double month_theterm = theterm * 12;//期限(年)
            double month_percen = (percen * 0.01) / 12;

            double PMT = (Math.Pow(1 + (month_percen), month_theterm) * month_percen) / (Math.Pow(1 + (month_percen), month_theterm) - 1);
            double result = (money - Top) * PMT;

            var INT = Math.Round(result, 0);
            double total = INT * month_theterm;//總額=四捨五入總付款*期限(年)
            HW2Report Frm_report = new HW2Report(txtloan.Text, txtyear.Text, txtpercen.Text, INT.ToString(), total.ToString());
            Frm_report.ShowDialog();//ShowDialog回傳Report
        }

        private void btnpmt_Click(object sender, EventArgs e)
        {
            double money = double.Parse(txtloan.Text);//貸款金額
            double theterm = double.Parse(txtyear.Text);//期限
            double percen = double.Parse(txtpercen.Text);//利率
            double Top = double.Parse(txtTop.Text);//頭期款

            //每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
            // (公式中：月利率 ＝ 年利率／12 ； 月數 = 貸款年期 ｘ 12)

            double month_theterm = theterm * 12;//期限(年)
            double month_percen = (percen * 0.01) / 12;

            double PMT = (Math.Pow(1 + (month_percen), month_theterm) * month_percen) / (Math.Pow(1 + (month_percen), month_theterm) - 1);
            double result = (money - Top) * PMT;

            double INT = Math.Round(result, 0);//四捨五入

            MessageBox.Show("月付額 : " + INT);
        }
    }
}
