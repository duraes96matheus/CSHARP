using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*6. Entrar com o número de vezes que se deseja imprimir a palavra “Brasil”. (Usar Loop – For / While / Do While) */

namespace Exercicios
{
    public partial class Atividade6 : Form
    {
        public Atividade6()
        {
            InitializeComponent();
        }

        private void Atividade6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void Atividade6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = System.Convert.ToDouble(textBox1.Text);

           {
                double i = 1;
                do
                {
                    richTextBox1.Text += i.ToString() +"Brasil"+"\n";
                    i++;
                }
                while (i <= valor);
            }
        }

    }
}
