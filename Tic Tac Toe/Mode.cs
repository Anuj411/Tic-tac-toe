using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdoEasy.Checked == true)
            {
                this.Hide();
                Easy e1 = new Easy();
                e1.Show();
            }
            else
            {
                this.Hide();
                Hard h1 = new Hard();
                h1.Show();
            }
        }
    }
}
