using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Classes;
namespace WindowsFormsApplication1
{
    public partial class CadastrarClientes : Form
    {
        List<Cliente> listadeclientescadastrados= new List<Cliente>();

        public CadastrarClientes()
        {
            InitializeComponent();
        }

        private void BTNcadastrar_Click(object sender, EventArgs e)
        {
            Cliente clientecadastrado = new Cliente();
            clientecadastrado.codigoCliente = Convert.ToInt32(TXTCodigo.Text);
            clientecadastrado.nomeCliente = (TXTnome.Text);
            clientecadastrado.DTnasCliente = Convert.ToDateTime (TXTdatanascimento.Text);
            listadeclientescadastrados.Add(clientecadastrado);
   
            


            DGVclientecadastrado.DataSource = null;
            DGVclientecadastrado.DataSource =listadeclientescadastrados;

        }

        

        
    }
}
