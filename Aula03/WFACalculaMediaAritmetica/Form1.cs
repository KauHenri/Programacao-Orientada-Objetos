using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFACalculaMediaAritmetica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbMedia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            double n1, n2, media;

            n1 = Convert.ToDouble(txbNum1.Text);
            n2 = Convert.ToDouble(txbNum2.Text);

            media = (n1 + n2) / 2;

            txbMedia.Text = Convert.ToString(media);
        }

        private void txbNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
