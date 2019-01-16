using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class NovoFuncionario : Form
    {
        public NovoFuncionario()
        {
            InitializeComponent(); //txtcargo.Text, txtemail.Text,txtfone.Text,txtnascimento.Text,txtnome.Text,txtsexo.Text
        }
        private void Cadastrarfuncionario(string NM_Funcionario, string NR_Telefone, DateTime DT_Nasc, string DS_Endereco , string DS_Email, string SEXO, string DS_Cargo)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=aula2708;Data Source=PC-QUARTO";

            //abrir conexão
            conexao.Open();

            //inseri texto de insert
            string InsertFuncionario = string.Concat("insert into TB_funcinoario values ('", NM_Funcionario, "','", NR_Telefone, "','", DT_Nasc, "','", DS_Endereco, "','", DS_Email,"','", SEXO, "','", DS_Cargo, "')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(InsertFuncionario, conexao);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cadastrarfuncionario(txtnome.Text, txtfone.Text, DateTime.Parse(txtnascimento.Text), txtende.Text, txtemail.Text, txtsexo.Text, txtcargo.Text);
            //limparcampos();
            MessageBox.Show("Cadastrado");
        }
       
    }
}
