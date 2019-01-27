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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            CarregarGrid();


        }
        private void CarregarGrid()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=False;User ID=sa;Initial Catalog=SGCidadeInteligente;Data Source=LAB-06-18";
            conexao.Open();

            string comandosql = "select * from TB_Cliente";
            SqlCommand sqlcommand = new SqlCommand(comandosql, conexao);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DGVcliente.DataSource=dt;
            conexao.Close();

        }

        private void DGVcliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {  
            txtData.Text = DGVcliente.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtData.Text = DGVcliente.Rows[e.RowIndex].Cells[3].Value.ToString();
            MessageBox.Show(DGVcliente.Rows[e.RowIndex].Cells[0].Value.ToString());            
        }

      
        private void CadastrarCliente(DateTime DT_Incusao ,int  ID_Pessoa)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=False;User ID=sa;Initial Catalog=SGCidadeInteligente;Data Source=LAB-06-18";
            /*string de Conexao com o Meu banco
             * Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SGCidadeInteligente;Data Source=PC-QUARTO\SQLEXPRESS";*/
          
            //abrir conexão
            conexao.Open();

            //inseri texto de insert
            string InsertCliente = string.Concat("insert into TB_Cliente values ( '", DT_Incusao, "','", ID_Pessoa, "')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(InsertCliente, conexao);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }

        private void LimparCampos()
        {
            txtData.Text="";
            txidPessoa.Text="";
           
        }     

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            CadastrarCliente(DateTime.Parse(txtData.Text),int.Parse(txidPessoa.Text));
            LimparCampos();
            MessageBox.Show("Registro cadastrado", "@Duraes");
        }


    }
}
