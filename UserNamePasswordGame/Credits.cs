using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserNamePasswordGame
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is in its early stage and you found a cool Easter egg");
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for Playing");
            System.Threading.Thread.Sleep(2000);
            Application.Exit();
        }
    }
}
