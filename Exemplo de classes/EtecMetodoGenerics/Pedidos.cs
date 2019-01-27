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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            inserirpedido();
            carregargrid();
            
        }
        List<ClientePedido> lista_pedido = new List<ClientePedido>();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            
          // MessageBox.Show(lista_pedido.Count.ToString());    

            List<ClientePedido> listapesquisa = new List<ClientePedido>();
            listapesquisa = lista_pedido;

            listapesquisa = listapesquisa.Where(i => i.nmProduto.Contains(txtPesquisar.Text) && i.marca.Contains(txtmarca.Text)).ToList();
            gdvPedidos.DataSource = null;
            gdvPedidos.DataSource = listapesquisa;


        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtmarca.Text =string.Empty;
            txtPesquisar.Text = string.Empty;
            carregargrid();
            gdvPedidos.DataSource = null;
        }
        private void carregargrid()
        {
            gdvPedidos.DataSource=null;          

            gdvPedidos.DataSource = lista_pedido;

        }private void inserirpedido()
        {
            ClientePedido pedido1 = new ClientePedido();
            pedido1.idPedido = 1;
            pedido1.nmProduto = "lapis";
            pedido1.marca = "bic";
            pedido1.dtPedido = Convert.ToDateTime("2018-08-10");
            pedido1.preco = "0.60";

            lista_pedido.Add(pedido1);

            ClientePedido pedido2 = new ClientePedido();
            pedido2.idPedido = 2;
            pedido2.nmProduto = "borracha";
            pedido2.marca = "faber castell";
            pedido2.dtPedido = Convert.ToDateTime("2018-08-11");
            pedido2.preco = "1.50";

            lista_pedido.Add(pedido2);

            ClientePedido pedido3 = new ClientePedido();
            pedido3.idPedido = 3;
            pedido3.nmProduto = "caneta";
            pedido3.marca = "bic";
            pedido3.dtPedido = Convert.ToDateTime("2018-08-11");
            pedido3.preco = "1.20";

            lista_pedido.Add(pedido3);

            ClientePedido pedido4 = new ClientePedido();
            pedido4.idPedido = 4;
            pedido4.nmProduto = "apontador";
            pedido4.marca = "faber castell";
            pedido4.dtPedido = Convert.ToDateTime("2018-08-10");
            pedido4.preco = "2.00";

            lista_pedido.Add(pedido4);

            ClientePedido pedido5 = new ClientePedido();
            pedido5.idPedido = 5;
            pedido5.nmProduto = "pasta";
            pedido5.marca = "dac";
            pedido5.dtPedido = Convert.ToDateTime("2018-08-11");
            pedido5.preco = "2.50";

            lista_pedido.Add(pedido5);
    
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ClientePedido pedido = new ClientePedido();

            
            pedido.nmProduto = (txtnome.Text);
            pedido.marca= (txtmarcaNova.Text);
            pedido.dtPedido = Convert.ToDateTime(txtData.Text);
            pedido.preco=(txtpreço.Text);
            lista_pedido.Add(pedido);
        }

      
     

   
    }
}
