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
    public partial class Atividade4 : Form
    {
        public Atividade4()
        {
            InitializeComponent();
        }

        private void Atividade4_FormClosing(object sender, FormClosingEventArgs e)
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
            int valor = System.Convert.ToInt16(textBox1.Text);
            if(valor<=12){

                switch (valor)
                {
                    case 1:
                        lblresposta.Text = "Janeiro";
                        break;

                    case 2: lblresposta.Text = "Fevereiro";
                        break;

                    case 3: lblresposta.Text = " Março";
                        break;

                    case 4: lblresposta.Text = "Abril";
                        break;

                    case 5: lblresposta.Text = "Maio";
                        break;

                    case 6: lblresposta.Text = "Junho";
                        break;

                    case 7: lblresposta.Text = "Julho";
                        break;

                    case 8: lblresposta.Text = "Agosto";
                        break;

                    case 9: lblresposta.Text = "Setembro";
                        break;

                    case 10: lblresposta.Text = "Outubro";
                        break;

                    case 11: lblresposta.Text = "Novembro";
                        break;

                    case 12: lblresposta.Text = "Dezembro";
                        break;
                }
            }
                else{
                    lblresposta.Text="Mês invalido";
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
