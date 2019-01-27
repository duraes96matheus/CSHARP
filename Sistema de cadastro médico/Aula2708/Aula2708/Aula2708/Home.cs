using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula2708
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            CadastraFun novofuncionario = new CadastraFun();
            novofuncionario.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CadastrarClie novocliente = new CadastrarClie();
            novocliente.Show();

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            NovaConsulta novaconsulta = new NovaConsulta();
            novaconsulta.Show();
        }

        
    }
}
