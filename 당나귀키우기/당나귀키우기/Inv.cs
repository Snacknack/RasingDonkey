using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace 당나귀키우기
{
    public partial class Inv : Form
    {
        private Point mousePoint;
        public Inv()
        {
            InitializeComponent();
            Refresh.Enabled = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data.Class2.InvIsOpened = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Refresh_Tick(object sender, EventArgs e)
        {

                label2.Text = Convert.ToString(Data.Class4.item1);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(Data.Class4.item1 >= 1 )
            {
                Data.Class4.item1--;
                Data.Class1.Exp = Data.Class1.RequiredExp;
            }
            
        }
    }
}
