using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 당나귀키우기
{
    public partial class Shop : Form
    {
            public Shop()
        {
            InitializeComponent();
            Refresh.Enabled = true;
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            
        }

        private void Shop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Data.Class2.ShopIsOpened = false;
        }

        private void Refresh_Tick(object sender, EventArgs e)
        {
            CurrentMoney.Text = "골드 : " +  Convert.ToString(Data.Class1.Gold) + "원";
        }

        private void CurrentMoney_Click(object sender, EventArgs e)
        {
            
        }

        private void BuyBtn1_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn2_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn3_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn4_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn5_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn6_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn7_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn14_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn13_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn12_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn11_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn10_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn9_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn8_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn15_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn16_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn17_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn18_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn19_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn20_Click(object sender, EventArgs e)
        {

        }

        private void BuyBtn21_Click(object sender, EventArgs e)
        {

        }
    }
}
