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
    public partial class Atividade5 : Form
    {
        public Atividade5()
        {
            InitializeComponent();
        }

        private void Atividade5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            double valor = System.Convert.ToDouble(textBox1.Text);
            
            if(valor<=50)
            {
                double i=1;
                do
                {
                    richTextBox1.Text+=i.ToString()+"\n";
                    i++;
                }
                while(i <=valor);
            }
            else{
                richTextBox1.Text="Maior que 50";
            }
        
        }
    }
}
