using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aula2708
{
    public partial class CadastraFun : Form
    {
        public CadastraFun()
        {
            InitializeComponent();        
        }
        private void CadastraFun_Load(object sender, EventArgs e)
        {

        }
        private void cadastraFuncionario(string NM_Funcionario, string NR_Telefone, DateTime nascF, string DT_Nasc, string DS_Endereco, string DS_Email, string Sexo, string DS_Cargo)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211; Persist Security Info=true; User ID=sa;Initial Catalog=aula2708;Data Source=LAB-08-20";

            //abrir conexão
            conexao.Open();

            //inseri texto de insert
            string cadastraFuncionario = string.Concat("insert into TB_Funcionario values ('", NM_Funcionario, "', '", NR_Telefone, "','", DT_Nasc, "','", DS_Endereco, "','", DS_Email, "','", Sexo, "','", DS_Cargo, "')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(cadastraFuncionario, conexao);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }


       

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            cadastraFuncionario (txtnome.Text, txttelefone.Text,DateTime.Parse(txtnasc.Text), txtnasc.Text, txtendereco.Text, txtemail.Text, txtsexo.Text, txtcargo.Text);

            //LimparCampos();
            MessageBox.Show("Registro cadastrado", "Etec ZL");

        }
    }
}
