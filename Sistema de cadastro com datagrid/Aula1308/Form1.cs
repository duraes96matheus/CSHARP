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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Cliente> lista = new List<Cliente>();

            Cliente cliente1 = new Cliente();
            cliente1.codigoCliente = 01;
            cliente1.nomeCliente = "Matheus";
         // Cliente1.DTnasCliente = ; 
            cliente1.endereco="Rua 1";
            lista.Add(cliente1);

            Cliente cliente2 = new Cliente();
            cliente2.codigoCliente = 02;
            cliente2.nomeCliente = "Vinicius";
        //  cliente2.DTnasCliente= null;
            cliente2.endereco="Rua 2";
            lista.Add(cliente2);

            List<ClienteDocumento> listadocumentos = new List<ClienteDocumento>();

            ClienteDocumento clientedoc1 = new ClienteDocumento();
            clientedoc1.CPF = 4455475;
            clientedoc1.CNH = "4555456545";
            clientedoc1.reservista = "5456456464";
            clientedoc1.RG = "4456a46dsad";
            listadocumentos.Add(clientedoc1);


            ClienteDocumento clientedoc2 = new ClienteDocumento();
            clientedoc1.CPF = 44554456;
            clientedoc1.CNH = "455545654565445";
            clientedoc1.reservista = "545645644645664";
            clientedoc1.RG = "4456a56456446dsad";
            listadocumentos.Add(clientedoc2);


            List<ClientePedido> listapedidos = new List<ClientePedido>();

            ClientePedido pedido1 = new ClientePedido();
            pedido1.NumPedido = 01;
            pedido1.NMClienteComprador = "Matheus";
            pedido1.DTPedido=Convert.ToDateTime("05/05/2018");
            pedido1.NMVendedor = "Lucas";            
            listapedidos.Add(pedido1);


            ClientePedido pedido2 = new ClientePedido();
            pedido1.NumPedido = 01;
            pedido1.NMClienteComprador = "Vinicius";
            pedido1.DTPedido=Convert.ToDateTime("05/05/2018");
            pedido1.NMVendedor = "Neymar";          
            listapedidos.Add(pedido2);


            DGVclientes.DataSource = lista.Where(i =>i.codigoCliente ==1).ToList();
            DVG2.DataSource = listadocumentos;
            DVG3.DataSource = listapedidos;

           
        }

        private void DGVclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DVG2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DVG3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCadastrarNovos_Click(object sender, EventArgs e)
        {
            CadastrarClientes cadastronovo = new CadastrarClientes();
            cadastronovo.Show();
        }

    

       
       
    }
}
