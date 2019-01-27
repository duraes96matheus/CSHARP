using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;



namespace PrjCliente_conexao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD__ClienteDataSet.TB_cliente' table. You can move, or remove it, as needed.
            this.tB_clienteTableAdapter.Fill(this.bD__ClienteDataSet.TB_cliente);

        }
        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConexao();
        //Declare o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_clientes;
        //Declare o BindingSource -- tabela virtual editável
        BindingSource bs_clientes = new BindingSource();
        // cria a variavel que receberá a query (comando sql)
        String _query;

        private void carregar_grid()
        {
            //Determine a query desejada
            _query = "Select * from clientes";
            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            //execute o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_clientes = _dataCommand.ExecuteReader();
            //Teste para verificar se retornaram linhas
            if (dr_clientes.HasRows == true)
            {
                bs_clientes.DataSource = dr_clientes;
                dataGridView1.DataSource = bs_clientes;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos clientes cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void igualar_text()
        {
            lblMatricula.DataBindings.Add("Text", bs_clientes, "Matricula");
            lblMatricula.DataBindings.Clear();
            txt_Nome.DataBindings.Add("Text", bs_clientes, "Nome");
            txt_Nome.DataBindings.Clear();
            txt_endereco.DataBindings.Add("Text", bs_clientes, "Endereco");
            txt_endereco.DataBindings.Clear();
            txt_numero.DataBindings.Add("Text", bs_clientes, "numero");
            txt_numero.DataBindings.Clear();
            msk_cep.DataBindings.Add("Text", bs_clientes, "cep");
            msk_cep.DataBindings.Clear();
            dtp_nasc.DataBindings.Add("Text", bs_clientes, "Nasc");
            dtp_nasc.DataBindings.Clear();
        }

        private void frm_Cadastro_Load(object sender, EventArgs e)
        {
            // alimenta o datagridview com dados
            carregar_grid();
        }
        private void dgv_clientes_Click(object sender, EventArgs e)
        {
            igualar_text();
        }


        private void dgv_clientes_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void txt_Pesquisar_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from Clientes where nome like '" + txt_Pesquisar.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_clientes = _dataCommand.ExecuteReader();

            if (dr_clientes.HasRows == true)
            {
                bs_clientes.DataSource = dr_clientes;
            }
            else
            {
                MessageBox.Show("Não temos cliente cadastrado com este nome !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Pesquisar.Text = "";
            }
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }

       




    }
}
