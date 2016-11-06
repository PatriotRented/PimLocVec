using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim.Patriot.DataAccess.ClassesDAO
{
    /// <summary>
    /// Classe de acesso ao banco de dados dos objetos veículos apenas consultas (selects)
    /// </summary>
    public class VeiculoDAO
    {

        #region Metodos

        /// <summary>
        /// Faz o update de um registro no banco de dados a partir do seu id
        /// </summary>
        /// <returns></returns>
        public object updateVeiculo(long id) //Esse método só será implementado na tela de consulta de veículos (for now...)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Faz o select de todos os dados da tabela
        /// </summary>
        public DataTable selectAllVec(string _parametro)
        {
            try
            {
                ConnectionFactory conn = new ConnectionFactory();
                SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));
                SqlCommand cmd = conexao.CreateCommand();
                int numero = 0;int.TryParse(_parametro, out numero);

                if (numero != 0)
                {
                    cmd.CommandText = 
                     @"select * from selAllVec 
                         where  
                     codVec = convert (int,@parametro) or  Ano = @parametro";

                    cmd.Parameters.AddWithValue("@parametro", _parametro);
                }
                else
                {
                    cmd.CommandText =
                    @"select * from selAllVec 
                         where  
                    Placa = @parametro or Modelo = @parametro or categoria = @parametro";

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
                MessageBox.Show("erros se vire \n"+ Convert.ToString(ex));
                throw ex;
            }
            
        }

        #endregion
    }
}
