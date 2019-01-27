using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjCliente_conexao
{
    class Conexao
    {
        private static string connString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = BD_Cliente.accdb";

        private static OleDbConnection conn = null;

        //OBTER CONEXAO
        public static OleDbConnection obterConexao()
        {
            conn = new OleDbConnection(connString);

            try
            {
                conn.Open();
            }

            catch (Exception)
            {
                conn = null;
                MessageBox.Show("Conexão não estabelecida");
            }

            return conn;
        }

        //----------------------------------------------------

        //FECHAR CONEXAO
        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
