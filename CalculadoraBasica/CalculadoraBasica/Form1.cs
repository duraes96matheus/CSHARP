using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsomar_Click(object sender, EventArgs e)
        {
            if (txbValor1.Text == "" || txbValor2.Text == "") 
            lblResultado.Text = "Preencha os dois valores porra";

            else
            {
                double valor1 = System.Convert.ToDouble(txbValor1.Text);
                double valor2 = System.Convert.ToDouble(txbValor2.Text);
                lblResultado.Text = valor1 + valor2 + "";
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txbValor1.Text == "" || txbValor2.Text == "") 
            {
            lblResultado.Text = "Preencha os dois valores porra";
            }

            else{
                double valor1 = System.Convert.ToDouble(txbValor1.Text);
                double valor2 = System.Convert.ToDouble(txbValor2.Text);
                lblResultado.Text = valor1 * valor2 + "";
            }
        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            if (txbValor1.Text == "" || txbValor2.Text == "") 
            lblResultado.Text = "Preencha os dois valores porra";

            else
            {
                double valor1 = System.Convert.ToDouble(txbValor1.Text);
                double valor2 = System.Convert.ToDouble(txbValor2.Text);
                lblResultado.Text = valor1 - valor2 + "";
            }
        }


        private void btnDividir_Click(object sender, EventArgs e)
        {
             if (txbValor1.Text == "" || txbValor2.Text == "") 
            lblResultado.Text = "Preencha os dois valores porra";

             else
             {
                 double valor1 = System.Convert.ToDouble(txbValor1.Text);
                 double valor2 = System.Convert.ToDouble(txbValor2.Text);
                 lblResultado.Text = valor1 / valor2 + "";
             }
        }
    }
}
