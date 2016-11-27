using Pim.Patriot.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim.Patriot.ClassLibrary.ClassesDAO
{
    public class ClienteDAO
    {


        /// <summary>
        /// Faz o update de um registro no banco de dados a partir do seu id
        /// </summary>
        /// <returns></returns>
        public object updateCliente(long id) //Esse método só será implementado na tela de consulta de veículos (for now...)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz o select de todos os dados da tabela
        /// </summary>
        public DataTable selectAllCli(string _parametro)
        {
            try
            {
                ConnectionFactory conn = new ConnectionFactory();
                SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));
                SqlCommand cmd = conexao.CreateCommand();
                int numero = 0; int.TryParse(_parametro, out numero);

                if (numero != 0)
                {
                    cmd.CommandText =
                     @"select * from Cliente
                         where  
                     codCli = convert (int,@parametro) or   cnpj_cpf  = @parametro or rg = @parametro or cnh = @parametro";

                    cmd.Parameters.AddWithValue("@parametro", _parametro);
                }
                else
                {
                    cmd.CommandText =
                    @"select * from Cliente
                         where   
                   nomeCli = @parametro ";

                    cmd.Parameters.AddWithValue("@parametro", _parametro);
                }


                DataTable dt = new DataTable();

                conexao.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                conexao.Close();
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erros se vire \n" + Convert.ToString(ex));
                throw ex;
            }

        }


    }
}
