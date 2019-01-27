using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Etec.consultoriomedico.IU
{
    public partial class Cadastrodealuno : Form
    {
        public Cadastrodealuno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtrmAluno.Clear();
            txtNomeAluno.Clear();
            txtResponsavelAluno.Clear();
            txtSexoAluno.Clear();
            txtTelefoneAluno.Clear();
            txtenderecoAluno.Clear();
        }

    }
}
