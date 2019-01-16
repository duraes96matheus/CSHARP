using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Desafio
{
    public partial class Form1 : Form
    {
        double valor1 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            {
                operacao = "*";
            }
            valor1 = System.Convert.ToDouble(txtvisor.Text);
            txtvisor.Text = "";
            operacao = "*";


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text == ""||txtvisor.Text=="0")
                txtvisor.Text = "1";

            else
            {
                txtvisor.Text=(txtvisor.Text)+"1" ;
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                valor1 += double.Parse(txtvisor.Text);
                txtvisor.Text = valor1.ToString();
            }
            else if (operacao == "-")
            {
                valor1 -= double.Parse(txtvisor.Text);
                txtvisor.Text = valor1.ToString();
            }
            else if(operacao=="*")
            {
                valor1 *= double.Parse(txtvisor.Text);
                txtvisor.Text = valor1.ToString();
            }
            else if(operacao=="/")
            {
                (valor1 )/=double.Parse(txtvisor.Text);
                txtvisor.Text = valor1.ToString();
            }
                
      
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            {
                operacao = "+";
            }
            valor1 = System.Convert.ToDouble(txtvisor.Text);
            txtvisor.Text = "";
            operacao = "+";

           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text == "" || txtvisor.Text == "0")
                txtvisor.Text = "2";

            else
            {
                txtvisor.Text = (txtvisor.Text) + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text == "" || txtvisor.Text == "0")
                txtvisor.Text = "3";

            else
            {
                txtvisor.Text = (txtvisor.Text) + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text == "" || txtvisor.Text == "0")
                txtvisor.Text = "4";

            else
            {
                txtvisor.Text = (txtvisor.Text) + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text == "" || txtvisor.Text == "0")
                txtvisor.Text = "5";

            else
            {
                txtvisor.Text = (txtvisor.Text) + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text == "" || txtvisor.Text == "0")
                txtvisor.Text = "6";

            else
            {
                txtvisor.Text = (txtvisor.Text) + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text == "" || txtvisor.Text == "0")
                txtvisor.Text = "7";

            else
            {
                txtvisor.Text = (txtvisor.Text) + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text == "" || txtvisor.Text == "0")
                txtvisor.Text = "8";

            else
            {
                txtvisor.Text = (txtvisor.Text) + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text == "" || txtvisor.Text == "0")
                txtvisor.Text = "9";

            else
            {
                txtvisor.Text = (txtvisor.Text) + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text == "")
                txtvisor.Text = "0";

            else
            {
                txtvisor.Text = (txtvisor.Text) + "0";
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            {
                operacao = "-";
            }
            valor1 = System.Convert.ToDouble(txtvisor.Text);
            txtvisor.Text = "";
            operacao = "-";

        }

        private void btndivi_Click(object sender, EventArgs e)
        {
            {
                operacao = "/";
            }
            valor1 = System.Convert.ToDouble(txtvisor.Text);
            txtvisor.Text = "";
            operacao = "/";

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtvisor.Text="0";
        }

       
    }
}
