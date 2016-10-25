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
        SqlConnection conexao = new SqlConnection();

        /// <summary>
        /// Lista os nomes dos acessorios e os concatenam com o codigo e os grava em um DataTable
        /// </summary>
        /// <returns>retorna um DataTable com os acessorio cadastrados no BD </returns>
        public DataTable listaAce()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select concat codAce+'-'+ nomeAce  from Acessorio";
            conexao.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conexao.Close();
            return dt;
        }
    }
}
