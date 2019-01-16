using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnnovofun_Click(object sender, EventArgs e)
        {
            NovoFuncionario novofun = new NovoFuncionario();
            novofun.Show();

        }

        private void btnnovocli_Click(object sender, EventArgs e)
        {
            NovoCliente cliente = new NovoCliente();
            cliente.Show();
        }

        private void novoagendamento_Click(object sender, EventArgs e)
        {
            NovaAgenda agenda = new NovaAgenda();
            agenda.Show();

        }
    }
}
