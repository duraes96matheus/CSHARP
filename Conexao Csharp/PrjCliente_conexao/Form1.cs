using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace PrjCliente_conexao
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = Conexao.obterConexao();

        OleDbDataReader dr_clientes;

        BindingSource bs_clientes = new BindingSource();

        String _query = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void carregar_grid()
        {
            _query = "select * from tb_cliente";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);


            dr_clientes = _dataCommand.ExecuteReader();

            if (dr_clientes.HasRows == true)
            {
                bs_clientes.DataSource = dr_clientes;
                dgv_clientes.DataSource = bs_clientes;
                igualar_text();
            }
            else 
            {
                MessageBox.Show("Não temos clientes cadastrados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void igualar_text() {
           
            lblSMatricula.DataBindings.Add("Text", bs_clientes, "Matricula");
            lblSMatricula.DataBindings.Clear();

            txtNome.DataBindings.Add("Text", bs_clientes, "Nome");
            txtNome.DataBindings.Clear();

            txtEndereco.DataBindings.Add("Text", bs_clientes, "Endereco");
            txtEndereco.DataBindings.Clear();

            txtNumero.DataBindings.Add("Text", bs_clientes, "Numero");
            txtNumero.DataBindings.Clear();

            mskCep.DataBindings.Add("Text", bs_clientes, "CEP");
            mskCep.DataBindings.Clear();

            dtNasc.DataBindings.Add("Text", bs_clientes, "Nasc");
            dtNasc.DataBindings.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            _query = "select * from tb_cliente where nome like '" + txtPesquisa.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_clientes = _dataCommand.ExecuteReader();

            if (dr_clientes.HasRows == true)
            {
                bs_clientes.DataSource = dr_clientes;
            }
            else {
                MessageBox.Show("Não temos clientes com este nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPesquisa.Text = "";
            }

        }

        /*private void btIncluir_Click(object sender, EventArgs e)
        {
            _query = "insert into tb_cliente (nome, nasc, endereco, numero, cep) values ('"+txtNome.Text+"', '"+dtNasc.Text+"','"+txtEndereco.Text+"','"+txtNumero.Text+"','"+mskCep.Text+"',)";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_clientes = _dataCommand.ExecuteReader();

            if (dr_clientes.HasRows == true)
            {
                bs_clientes.DataSource = dr_clientes;
            }
            else
            {
                MessageBox.Show("Não temos clientes com este nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPesquisa.Text = "";
            }
        }*/
        

    }
}
