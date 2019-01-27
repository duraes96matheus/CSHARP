using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrjCidadeInteligente
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            CarregarGrid();

        }
        private void CarregarGrid()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=False;User ID=sa;Initial Catalog=SGCidadeInteligente;Data Source=LAB-06-18";
            conexao.Open();

            string comandosql = "select * from TB_Funcionario";
            SqlCommand sqlcommand = new SqlCommand(comandosql, conexao);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DGVFuncionario.DataSource = dt;
            conexao.Close();

        }

        private void DGVFuncionario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCargo.Text = DGVFuncionario.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSalario.Text = DGVFuncionario.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRamal.Text= DGVFuncionario.Rows[e.RowIndex].Cells[4].Value.ToString();
            MessageBox.Show(DGVFuncionario.Rows[e.RowIndex].Cells[0].Value.ToString()); 
        }  

         private void CadastrarCliente(string DS_Cargo, string DS_Salario, string Ramal)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=False;User ID=sa;Initial Catalog=SGCidadeInteligente;Data Source=LAB-06-18";
            /* String de Conexao com o meu servidor
             Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SGCidadeInteligente;Data Source=PC-QUARTO\SQLEXPRESS*/


            //abrir conexão
            conexao.Open();

            //inseri texto de insert
            string InsertFuncionario = string.Concat("insert into TB_Funcionario values (  '", DS_Cargo, "', '", DS_Salario, "', '", Ramal, "')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(InsertFuncionario, conexao);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }

        private void LimparCampos()
        {
            txtCargo.Text="";
            txtRamal.Text="";
            txtSalario.Text="";
                     
        }     

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            CadastrarCliente( txtCargo.Text,txtRamal.Text, txtSalario.Text);
            LimparCampos();
            MessageBox.Show("Registro cadastrado", "Etec ZL");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
        
        }
    }
}
