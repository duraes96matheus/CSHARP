﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Etec.consultoriomedico.IU
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrodealuno novoAluno   = new Cadastrodealuno();
            novoAluno.Show();
        }

        private void cadastroDeEleitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrodeEleitor novoEleitor = new CadastrodeEleitor();
            novoEleitor.Show();
        }

        private void cadastroDeCanditadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrodeCanditado novoCanditado= new CadastrodeCanditado();
            novoCanditado.Show();
        }
    }
}
