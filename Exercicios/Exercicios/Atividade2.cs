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
    public partial class Atividade2 : Form
    {
        public Atividade2()
        {
            InitializeComponent();
        }

        private void Atividade2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            String divisiveis = "";

            if (divisiveis.Equals(""))
            {
                lblresposta.Text = "Não divisível";
            }
            else
            {
                lblresposta.Text = divisiveis;
            }

            if (Convert.ToDouble(textBox1.Text) % 2 == 0)
            {

                divisiveis += "2 ";

            }

            if (Convert.ToDouble(textBox1.Text) % 5 == 0)
            {

                divisiveis += "5 ";

            }

            if (Convert.ToDouble(textBox1.Text) % 10 == 0)
            {

                divisiveis += "10 ";

            }


        }
              
    }
    }
    


            