using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Patriot.DataAccess.ClassesDAO
{
    public class CategoriaDAO
    {
        SqlConnection conexao;

        /// <summary>
        /// Retorna um data table com o codigo e o nome da categoria
        /// </summary>
        /// <returns></returns>
        public DataTable listaCat()
        {
            try
            {
                ConnectionFactory conn = new ConnectionFactory();
                conexao = new SqlConnection(conn.pegaConexao("connSQL"));

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = @"select CONCAT(codCat,' -  ',nomeCat) as mostraCat from Categoria;";
                DataTable dt = new DataTable();
                conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conexao.Close();

                return dt;
            }
            catch
            {
                Exception ex = new Exception();
                throw ex;
            }
            

        }

       
    }
}
