using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PIM__FolhaDePagamento.Utilitarios
{
    public class Conexao
    {
        SqlConnection conexao = new SqlConnection();
        public Conexao()
        {
            conexao.ConnectionString = @"Data Source=PC-CAIKE;Initial Catalog=PIM;Integrated Security=True";
        }

        public static string StrCon
        {
            get { return @"Data Source=PC-CAIKE;Initial Catalog=PIM;Integrated Security=True"; }
        }
        

        public SqlConnection Conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }

        public void Desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}