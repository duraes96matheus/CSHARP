using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Ativiade1 : Form
    {
                 
        public Ativiade1()
        {
            InitializeComponent();
        }
        
        private void Ativiade1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         double valor2 = System.Convert.ToDouble(txtvalor2.Text);
         double valor1 = System.Convert.ToDouble(txtvalor1.Text);
         double acumula = valor2 + valor1;


         if (acumula >= 20)
         {
             lblresultado.Text += acumula + 8;
         }
         else
         {
             lblresultado.Text += acumula - 5;
         }


        }

        private void lblresultado_Click(object sender, EventArgs e)
        {
            
        }

        private void txtvalor1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtvalor2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblresultado.Text = "";
            txtvalor1.Clear();
            txtvalor2.Clear();
        }
    }
}
