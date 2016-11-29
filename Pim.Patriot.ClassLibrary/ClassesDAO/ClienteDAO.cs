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

        public string selCliPorCpfCnpj(string _cpfCnpj)
        {
            try
            {
                ConnectionFactory conn = new ConnectionFactory();
                SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText =

                    @"select nomeCli from Cliente
                        where
                     cnpj_cpf like @cpfCnpj + '%';";

               cmd.Parameters.AddWithValue("@cpfCnpj", _cpfCnpj);


                string ret;

                conexao.Open();

                ret = Convert.ToString(cmd.ExecuteScalar());
                
                conexao.Close();

                return ret;
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    String erroMessages;
                    erroMessages = ("Index #" + i + "\n" +
                    "Message: " + ex.Errors[i].Message + "\n" +
                    "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                    "Source: " + ex.Errors[i].Source + "\n" +
                    "Procedure: " + ex.Errors[i].Procedure + "\n");
                    MessageBox.Show(erroMessages);
                }
                throw ex;
            }

        }

        public int pegaCodCli(string _cpfCnpj)
        {
            try
            {
                ConnectionFactory conn = new ConnectionFactory();
                SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = @"select codCli from Cliente where cnpj_cpf = @cnpj_cpf";

                cmd.Parameters.AddWithValue("@cnpj_cpf", _cpfCnpj);

                int retorno;
                conexao.Open();

                retorno = Convert.ToInt32(cmd.ExecuteScalar());

                conexao.Close();

                return retorno;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erros se vire \n" + Convert.ToString(ex));
                throw ex;
            }
        }
    }
}
