using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace prj_cliente
{
    class Conexao
    {
        private static string connString = @"Provider=Microsoft.Ace.OLEDB.12.0; Data Source= bd_cliente.accdb";
        private static OleDbConnection conn = null;
            public static OleDbConnection obterConexao()
        {
            // vamos criar a conexão
            conn = new OleDbConnection(connString);

            // a conexão foi feita com sucesso?
            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (Exception)
            {
                conn = null;
                MessageBox.Show("Conexão não estabelecida!");
            }

            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
