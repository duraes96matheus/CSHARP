using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Estados.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void carregarEstados()
        {
            
            DataSet ds = new DataSet();
            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection("Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=Cidade;Data Source=LAB-08-20");
                conexao.Open();
                SqlCommand cmd = new SqlCommand("sp_RetornaEstados", conexao);


                cmd.CommandType = CommandType.StoredProcedure;

                if (txtEstado.Text != "")
                {
                    cmd.Parameters.AddWithValue("@nmEstado", txtEstado.Text);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);

                dgvestado.DataSource = ds.Tables[0]; 


            }

            catch (Exception ex)
            {
                MessageBox.Show("Contate o Administrador Agora FDp!!!!");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarEstados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvestado.DataSource = null;
            carregarEstados();
            
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvestado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
