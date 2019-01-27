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
    public partial class NovaAgenda : Form
    {
        public NovaAgenda()
        {
            InitializeComponent();
        }

        private void Cadastrarconsulta(string ID_Cliente, string ID_Funcionario, DateTime DT_Consulta, string NM_Medico)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=aula2708;Data Source=PC-QUARTO";

            //abrir conexão
            conexao.Open();

            //inseri texto de insert
            string InsertConsulta = string.Concat("insert into TB_Agendamento values ('", ID_Cliente, "','", ID_Funcionario, "','", DT_Consulta, "','", NM_Medico, "')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(InsertConsulta, conexao);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cadastrarconsulta(txtidcliente.Text, txtidfun.Text, DateTime.Parse(txtdata.Text), txtnomemedico.Text);
            //limparcampos();
            MessageBox.Show("Cadastrado");
        }   

    }
}
