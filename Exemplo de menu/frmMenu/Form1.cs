using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmMenu
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

        private void teste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeste1 tst1 = new frmTeste1();
            tst1.MdiParent = this;
            tst1.Show();
        }
        private void frmTeste1_formClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void teste2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeste2 tst2 = new frmTeste2();
            tst2.MdiParent = this;
            tst2.Show();

        }
        private void frmTeste2_formClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
