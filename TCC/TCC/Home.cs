using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCC
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void criarUmNovoPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeladeCadastroSolicitante novaform = new TeladeCadastroSolicitante();
            novaform.Show();
        }

        private void fazerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginSolicitante loginsoli = new LoginSolicitante();
            loginsoli.Show();
        }

        private void criarUmNovoPerfilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Teladecadastroprestador novopresta = new Teladecadastroprestador();
            novopresta.Show();
        }

        private void fazerLoginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginSolicitante editardados = new LoginSolicitante();
            editardados.Show();
        }
    }
}
