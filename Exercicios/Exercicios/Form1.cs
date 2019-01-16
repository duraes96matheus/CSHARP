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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ativiade1 atv1 = new Ativiade1();
            atv1.MdiParent = this;
            atv1.Show();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade2 atv2 = new Atividade2();
            atv2.MdiParent = this;
            atv2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade3 atv3 = new Atividade3();
            atv3.MdiParent = this;
            atv3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade4 atv4 = new Atividade4();
            atv4.MdiParent = this;
            atv4.Show();

        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade5 atv5 = new Atividade5();
            atv5.MdiParent = this;
            atv5.Show();

        }

        private void exercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade6 atv6 = new Atividade6();
            atv6.MdiParent = this;
            atv6.Show();

        }

        private void exercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade7 atv7 = new Atividade7();
            atv7.MdiParent = this;
            atv7.Show();

        }
    }
}
