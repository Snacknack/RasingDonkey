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
    }
}
