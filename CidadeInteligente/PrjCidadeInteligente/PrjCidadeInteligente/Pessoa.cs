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
    public partial class Pessoa : Form
    {
        public Pessoa()
        {
            InitializeComponent();
        }
        private void Pessoa_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
          private void CadastrarPessoa(string NM_Pessoa, string DS_Endereco, string Est_Civil, DateTime DT_Nascimento,string RG, string CPF, string RESERVISTA, string CTPS,string CNH  )
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=False;User ID=sa;Initial Catalog=SGCidadeInteligente;Data Source=LAB-06-18";
            /*String de Conexao com o Meu Servidor
             * Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SGCidadeInteligente;Data Source=PC-QUARTO\SQLEXPRESS*/


            //abrir conexão
            conexao.Open();

            //inseri texto de insert
            string InsertPessoa = string.Concat("insert into TB_Pessoa values ('", NM_Pessoa, "', '", DS_Endereco, "', '", Est_Civil, "', '", DT_Nascimento, "')");
            string InsertDocumento = string.Concat("insert into TB_Documento values ('", RG, "', '", CPF, "', '", RESERVISTA, "', '", CTPS, "', '", CNH, "')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(InsertPessoa, conexao);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }

        private void LimparCampos()
        {
            txtNmCliente.Text = ""; 
            txtEndereco.Text = ""; 
            txtEstadoCivil.Text = "";
            txtDtNacimento.Text = "";
            txtcpts.Text="";
            txtcnh.Text="";
            txtcpf.Text="";
            txtreservista.Text="";
            txtrg.Text="";
        }     

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            CadastrarPessoa(txtNmCliente.Text, txtEndereco.Text, txtEstadoCivil.Text,DateTime.Parse( txtDtNacimento.Text),txtrg.Text, txtcpf.Text, txtreservista.Text , txtreservista.Text, txtcnh.Text);
            LimparCampos();
            MessageBox.Show("Registro cadastrado", "@Duraes");
        }

        private void CarregarGrid()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=False;User ID=sa;Initial Catalog=SGCidadeInteligente;Data Source=LAB-06-18";
            conexao.Open();

            string comandosql = "select * from TB_Pessoa,TB_Documento ";
            SqlCommand sqlcommand = new SqlCommand(comandosql, conexao);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DGVPessoas.DataSource = dt;
            conexao.Close();
        }
            
  
        private void bntSalvar_Click(object sender, EventArgs e)
        {

        }

        private void DGVPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNmCliente.Text = DGVPessoas.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEndereco.Text = DGVPessoas.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEstadoCivil.Text = DGVPessoas.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDtNacimento.Text = DGVPessoas.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtrg.Text = DGVPessoas.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtcpf.Text = DGVPessoas.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtreservista.Text = DGVPessoas.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtcpts.Text = DGVPessoas.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtcnh.Text = DGVPessoas.Rows[e.RowIndex].Cells[10].Value.ToString();
           
            MessageBox.Show(DGVPessoas.Rows[e.RowIndex].Cells[0].Value.ToString()); 
        }    

        
    }
}
