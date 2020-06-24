using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 당나귀키우기
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            this.Hide();
            mainform.Show();

        }

        private void First_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
