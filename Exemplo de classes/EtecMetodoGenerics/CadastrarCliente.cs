using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Classes;

namespace EtecMetodoGenerics
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();

        }
        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            inserir();
            carregargrid();
        }
           

        
        List<Cliente> listaClientesCadastrados = new List<Cliente>();

        private void btncadastrar_click(object sender, EventArgs e )

        {   Cliente clientecadastro = new Cliente();
            clientecadastro.codigoCliente = Convert.ToInt32(txtCodigoCliente.Text);
            clientecadastro.nmCliente = txtNome.Text;
            clientecadastro.dtNascimento = Convert.ToDateTime(txtNasc.Text);

            listaClientesCadastrados.Add(clientecadastro);

        }
                
        private void inserir()
        {
            Cliente clienteteste1 = new Cliente();

            clienteteste1.codigoCliente = Convert.ToInt32(01);
            clienteteste1.nmCliente ="Matheus";
            clienteteste1.dtNascimento = Convert.ToDateTime("19/03/1996");
            clienteteste1.endereco = "Rua1";
            clienteteste1.nrTelefone = "022288887";

            listaClientesCadastrados.Add(clienteteste1);
            
            
        }        
        private void carregargrid()
        {
            DGVcliente.DataSource= null;
            DGVcliente.DataSource = listaClientesCadastrados;

            
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.codigoCliente = Convert.ToInt32(txtCodigoCliente.Text);
            cliente.nmCliente = (txtNome.Text);
            cliente.dtNascimento = Convert.ToDateTime(txtNasc.Text);
            cliente.endereco = (txtendereco.Text);
            cliente.nrTelefone=(txtFone.Text);

            listaClientesCadastrados.Add(cliente);
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            List<Cliente> listaclientes = new List<Cliente>();
            listaclientes = listaClientesCadastrados;

            listaclientes = listaclientes.Where(i => i.nmCliente.Contains(txtpesquisarnome.Text)&& i.nrTelefone.Contains(txtdatacliente.Text)).ToList();
            DGVcliente.DataSource = null;
            DGVcliente.DataSource = listaclientes;
        }

        private void txtlimpar_Click(object sender, EventArgs e)
        {
            txtCodigoCliente.Clear();
            txtNome.Clear();
            txtendereco.Clear();
            txtdatacliente.Clear();
            txtFone.Clear();
            txtdatacliente.Clear();
            carregargrid();
            DGVcliente.DataSource = null;
        }

        

        
       
    }
}
