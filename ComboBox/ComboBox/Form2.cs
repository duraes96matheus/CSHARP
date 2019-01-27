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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            carregarComboEstado();
            carregarComboCidades();
        }
        private void carregarComboEstado()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexaoBD;
            conexao.Open();


            string comandoSQL = "SELECT * FROM Estados";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);

            DataTable dtFuncionariosBD = new DataTable();

            sda.Fill(dtFuncionariosBD);

            comboestados.DataSource = dtFuncionariosBD;

            comboestados.DisplayMember = "NomeEstado";



            conexao.Close();
        }

        private void carregarComboCidades()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexaoBD;
            conexao.Open();

            string comandoSQL = "SELECT * FROM Cidade where ID_Estado='"ID_estado"';";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);

            DataTable dtFuncionariosBD = new DataTable();

            sda.Fill(dtFuncionariosBD);

            combocidades.DataSource = dtFuncionariosBD;

            combocidades.DisplayMember = "NomeCidade";



            conexao.Close();
        }

        private void comboestados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combocidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
  
    }
}
