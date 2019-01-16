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
    public partial class NovoCliente : Form
    {
        public NovoCliente()
        {
            InitializeComponent();
        }

        private void NovoCliente_Load(object sender, EventArgs e)
        {

        }
         private void cadastracliente(string NM_Cliente, DateTime DT_Nasc, string DS_Endereco ,string ID_Funcionario)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=aula2708;Data Source=PC-QUARTO";

            //abrir conexão
            conexao.Open();

            //inseri texto de insert
            string InsertClientes = string.Concat("insert into TB_funcinoario values ('", NM_Cliente, "','", DT_Nasc, "','", DS_Endereco, "','", DS_Endereco, "','", ID_Funcionario,"')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(InsertClientes, conexao);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cadastracliente(txtnome.Text,DateTime.Parse(txtnasci.Text),txtendereco.Text,txtid.Text);
            //limparcampos();
            MessageBox.Show("Cadastrado");
        }
       
    }
}


        


   
