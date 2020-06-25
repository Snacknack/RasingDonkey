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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            
        }

        private void Shop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Data.Class2.ShopIsOpened = false;
        }
    }
}
