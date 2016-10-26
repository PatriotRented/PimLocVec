using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Patriot.DataAccess.ClassesDAO
{
    public class AcessorioDAO
    {

        SqlConnection conexao;

        /// <summary>
        /// Lista os nomes dos acessorios e os concatenam com o codigo e os grava em um DataTable
        /// </summary>
        /// <returns>retorna um DataTable com os acessorio cadastrados no BD </returns>
        public DataTable listaAce(string _conn)
        {
            conexao = new SqlConnection(_conn);
            SqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = /*"select nomeAce  from Acessorio"*/"select CONCAT (codAce,' |  ', nomeAce) as mostraAce from Acessorio ";
            conexao.Open();

            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);
            conexao.Close();
            return dt;
        }
    }
}
