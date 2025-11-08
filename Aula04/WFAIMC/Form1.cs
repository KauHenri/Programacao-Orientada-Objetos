using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (txbPeso.Text == "" || txbAltura.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            else
            {
                double peso, altura, imc;

                peso = Convert.ToDouble(txbPeso.Text);

                altura = Convert.ToDouble(txbAltura.Text);

                imc = peso / (altura * altura);

                txbIMC.Text = Convert.ToString(imc);
            }
        }
    }
}
