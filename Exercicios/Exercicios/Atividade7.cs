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
    public partial class Atividade7 : Form
    {
        public Atividade7()
        {
            InitializeComponent();
        }

        double arlindo = 1.50;
        double manoel = 1.10;

        private void Atividade7_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Atividade7_Load(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            arlindo = System.Convert.ToDouble(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            

            int i = 0;

            for (int j = 1; manoel < arlindo; j++ )
            {
                arlindo += 0.02;
                manoel += 0.03;
                i++;
            }

            
            lblresposta.Text = i+" Anos"+"";

         }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            manoel = System.Convert.ToDouble(textBox2.Text);
        }


        }
    }

