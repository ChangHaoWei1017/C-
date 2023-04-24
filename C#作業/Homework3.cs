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
    public partial class Homework3 : Form
    {
        public Homework3()
        {
            InitializeComponent();
        }
        HW3List menulist = new HW3List();

        private void bntbeer_Click(object sender, EventArgs e)
        {
            menulist.beer += 120;
            menulist.啤酒 += 1;
            txttotalprice.Text = menulist.beer.ToString();
            txtlistshow.Text = menulist.啤酒.ToString();
            int Total = menulist.beer + menulist.Wine + menulist.Tequila + menulist.Whisky;
            txttotalprice.Text = "NT$ " + Total;
        }

        private void bntTequila_Click(object sender, EventArgs e)
        {
            menulist.Tequila += 180;
            menulist.龍舌蘭 += 1;
            txtlistshow.Text = menulist.龍舌蘭.ToString();
            txttotalprice.Text = menulist.Tequila.ToString();
            int Total = menulist.beer + menulist.Wine + menulist.Tequila + menulist.Whisky;
            txttotalprice.Text = "NT$ " + Total;
        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            menulist.Whisky += 350;
            menulist.威士忌 += 1;
            txttotalprice.Text = menulist.Whisky.ToString();
            txtlistshow.Text = menulist.威士忌.ToString();
            int Total = menulist.beer + menulist.Wine + menulist.Tequila + menulist.Whisky;
            txttotalprice.Text = "NT$ " + Total;
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            menulist.Wine += 320;
            menulist.紅酒 += 1;
            txttotalprice.Text = menulist.Wine.ToString();
            txtlistshow.Text = menulist.紅酒.ToString();
            int Total = menulist.beer + menulist.Wine + menulist.Tequila + menulist.Whisky;
            txttotalprice.Text = "NT$ " + Total;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            menulist.beer = 0;
            menulist.Wine = 0;
            menulist.Tequila = 0;
            menulist.Whisky = 0;
            menulist.啤酒 = 0;
            menulist.威士忌 = 0;
            menulist.紅酒 = 0;
            menulist.龍舌蘭 = 0;
            txtlistshow.Text = "";
            txtlistshow.Text = "尚未點餐";
            txttotalprice.Text = "";
            txttotalprice.Text = "NT$ 0";
        }

        private void bntCash_Click(object sender, EventArgs e)
        {
            int Total = menulist.beer + menulist.Wine + menulist.Tequila + menulist.Whisky;
            if (Total == 0)
            {
                string title = "確認付款";
                MessageBox.Show("尚未點餐 !", title);
            }
            else
            {
                txttotalprice.Text ="NT$"+ Total.ToString();
                string title = "確認付款";
                MessageBox.Show("總金額 : " + "NT$" + Total, title);
            }
        }

        private void bntcreditcard_Click(object sender, EventArgs e)
        {
            int Total = menulist.beer + menulist.Wine + menulist.Tequila + menulist.Whisky;
            if (Total == 0)
            {
                string title = "確認付款";
                MessageBox.Show("尚未點餐 !", title);
            }
            else
            {
                int 打折 = (int)((menulist.beer + menulist.Tequila + menulist.Whisky + menulist.Wine) * 0.9);
                txttotalprice.Text = "NT$" + 打折.ToString();
                string title = "確認付款";
                MessageBox.Show("總金額 : " + "NT$" + Total + "\n折扣後金額 : " + "NT$" + 打折, title);
            }
        }

        private void txtlistshow_TextChanged(object sender, EventArgs e)
        {
            string All;
            if (menulist.beer + menulist.Tequila + menulist.Whisky + menulist.Wine == 0)
            {
                All = "尚未點餐";
            }
            else
            {

                string Showbeer;
                if (menulist.beer >= 1)
                {
                    Showbeer = "啤酒Beer x" + menulist.啤酒 + ",共 NT$" + menulist.beer + "元" + Environment.NewLine;
                }
                else
                {
                    Showbeer = string.Empty;
                }

                string ShowTequila;
                if (menulist.Tequila >= 1)
                {
                    ShowTequila = "龍舌蘭Tequila x" + menulist.龍舌蘭 + ",共 NT$" + menulist.Tequila + "元" + Environment.NewLine;
                }
                else
                {
                    ShowTequila = string.Empty;
                }

                string ShowWhisky;
                if (menulist.Whisky >= 1)
                {
                    ShowWhisky = "威士忌Whisky x" + menulist.威士忌 + ",共 NT$" + menulist.Whisky + "元" + Environment.NewLine;
                }
                else
                {
                    ShowWhisky = string.Empty;
                }

                string ShowWine;
                if (menulist.Wine >= 1)
                {
                    ShowWine = "紅酒Wine x" + menulist.紅酒 + ",共 NT$" + menulist.Wine + "元" + Environment.NewLine;
                }
                else
                {
                    ShowWine = string.Empty;
                }
                All = Showbeer + ShowTequila + ShowWhisky + ShowWine;
            }
            txtlistshow.Text = All;
        }
    }
    }
