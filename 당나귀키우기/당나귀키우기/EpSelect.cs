using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 당나귀키우기
{
    public partial class EpSelect : Form
    {
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
            Data.Class1.Exp += exp.Next(3, 10);
        }
    }
}
