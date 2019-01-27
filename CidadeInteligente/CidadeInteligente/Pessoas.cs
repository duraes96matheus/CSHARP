using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Classes;

namespace CidadeInteligente
{
    public partial class Pessoas : Form
    {
        public Pessoas()
        {
            InitializeComponent();
        }

        List<Pessoa> lista_pessoas = new List<Pessoa>();

        private void Pessoas_Load(object sender, EventArgs e)
        {
            retornarPessoas();

        }

      

        private void retornarPessoas()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LAB-06-21";
            conexao.Open();

            string comandoSQL = "SELECT cdPessoa 'Código Pessoa', nmPessoa 'Nome da Pessoa' FROM TB_PESSOAS";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            grvPessoa.DataSource = dt;

            conexao.Close();

        }

        private void inserirPessoa()
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nmPessoa = txbNome.Text;
            pessoa1.dsEndereco = txbEndereco.Text;
            pessoa1.dsEstadoCivil = txbEstadoCivil.Text;
            pessoa1.dtNascimento = Convert.ToDateTime(txbDtNascimento.Text);
            

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LAB-06-21";

            conexao.Open();

            string insertPessoa = string.Concat("insert into tb_pessoas (nmPessoa,dtNascimento,dsEstadoCivil,dsEndereco) values ('",pessoa1.nmPessoa,"','",pessoa1.dtNascimento,"','",pessoa1.dsEstadoCivil,"','",pessoa1.dsEndereco,"');");
        
            SqlCommand comandoSQL = new SqlCommand(insertPessoa, conexao);
           
            comandoSQL.ExecuteNonQuery();

            conexao.Close();
        }

 
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
            txbEndereco.Text = "";
            txbEstadoCivil.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {   
            inserirPessoa();
            retornarPessoas();
            MessageBox.Show("Pessoa Cadastrada", "ETEC ZL");
        }
    }
}
