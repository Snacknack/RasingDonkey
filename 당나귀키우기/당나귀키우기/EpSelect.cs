using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 당나귀키우기
{
    public partial class EpSelect : Form
    {
        private Point mousePoint;
        public EpSelect()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data.Class2.EpStIsOpened = false;
        }

        private void EpSelect_Load(object sender, EventArgs e)
        {

        }

        private void Tracking_Tick(object sender, EventArgs e)
        {  
        }

        private void DonkeyFarm_Click(object sender, EventArgs e)
        {
            Random exp = new Random();
            Random gold = new Random();
            int getExp = exp.Next(3, 10);
            int getGold = gold.Next(100, 500);
            Data.Class3.Log += getExp + " 만큼의 경험치 획득" + "\n" + getGold + "원을 획득" + "\n";
            Data.Class3.LogOnOff = true;
            if (!Data.Class3.LogOnOff)
            {
                Data.Class3.Log = "";
            }
            Data.Class1.Exp += getExp;
            Data.Class1.Gold += getGold;
        }

        private void EpSelect_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void EpSelect_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }
    }
}
