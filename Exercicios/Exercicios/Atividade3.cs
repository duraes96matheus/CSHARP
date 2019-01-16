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
    public partial class Atividade3 : Form
    {
        public Atividade3()
        {
            InitializeComponent();
        }

        private void Atividade3_FormClosing(object sender, FormClosingEventArgs e)
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
            double l1 =System.Convert.ToDouble(textBox1.Text);
            double l2 =System.Convert.ToDouble(textBox2.Text);
            double l3 =System.Convert.ToDouble(textBox3.Text);

            if (l1 == l2 && l2 == l3 && l3 == l1) 
            {
               textBox4.Text = "O triângulo é Equilátero, possui os três lados com a mesma medida";
            }
            else if (l1 == l2 || l2 == l3 || l3 == l1)
            {
                textBox4.Text = "Triângulo Isóceles, possui dois lados com a mesma medida";
            }
            else if (l1 != l2 && l2 != l3 && l3 != l1)
            {
                textBox4.Text = "Triângulo Escaleno, todos os lados diferentes";
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Atividade3_Load(object sender, EventArgs e)
        {

        }
    }
}
