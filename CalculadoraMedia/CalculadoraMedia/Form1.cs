using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraMedia
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            if (txt1Bim.Text == "" || txt2Bim.Text == "" || txt3Bim.Text == "" || txt4Bim.Text == ""||txtNome.Text=="")
            {
                lblMedia.Text = "Preencha todos os campos";
            }
            else
            {

                double nota1 = System.Convert.ToDouble(txt1Bim.Text);
                double nota2 = System.Convert.ToDouble(txt2Bim.Text);
                double nota3 = System.Convert.ToDouble(txt3Bim.Text);
                double nota4 = System.Convert.ToDouble(txt4Bim.Text);

                lblMedia.Text = "O Aluno : " + txtNome.Text + "Teve a Média de : "+(nota1 + nota2 + nota3 + nota4) / 4 +"";
            }
        }
    }
}
