using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Maiorde3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if (txbValor1.Text == "" || txbValor2.Text == "" || txbValor3.Text == "")
            {
                lblResposta.Text = "Preencha todos os campos";
            }
            else
            {

                double valora = System.Convert.ToDouble(txbValor1.Text);
                double valorb = System.Convert.ToDouble(txbValor2.Text);
                double valorc = System.Convert.ToDouble(txbValor3.Text);


                if (valora > valorb && valora > valorc)
                {
                    lblResposta.Text = "O valor de A é maior";
                }
                else if (valorb > valora && valorb > valorc)
                {
                    lblResposta.Text = "O valor de B é maior";
                }
                else if (valorc > valora && valorc > valorb)
                {
                    lblResposta.Text = "O valor de C é maior";
                }
                else if (valora == valorb || valora == valorc || valorb == valorc)
                {
                    lblResposta.Text = "Valores iguais";
                }

            }
        }
        
    }
}
