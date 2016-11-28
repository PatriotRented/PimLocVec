using Pim.Patriot.DataAccess;
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
                MessageBox.Show("Erros se vire \n"+ Convert.ToString(ex));
                throw ex;
            }
            
        }

        /// <summary>
        /// Metodo utilizado para pesquisa especifica
        /// </summary>
        /// <returns></returns>
        public DataTable pesquisaAvancadaSelect(int _ctrl1,int _ctrl2, int _ctrl3, Veiculo vec, string _de, string _ate)
        {
            try
            {
                string sec1 = "", sec2 = "", sec3 = "";
                ConnectionFactory conn = new ConnectionFactory();
                SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));
                SqlCommand cmd = conexao.CreateCommand();

                #region Construcao do SqlCommand
                switch (_ctrl1)
                {
                    case 0:
                        sec1 = "";
                        break;
                    case 1:
                        sec1 = "modelo = @modelo and marca = @marca";
                        break;
                    case 2:
                        sec1 = "modelo = @modelo";
                        break;
                    case 3:
                        sec1 = "marca = @marca";
                        break;
                }

                switch (_ctrl2)
                {

                    case 0:
                        sec2 = "";
                        break;
                    case 1:
                        sec2 = "categoria = @categoria and status = @status";
                        break;
                    case 2:
                        sec2 = "categoria = @categoria";
                        break;
                    case 3:
                        sec2 = "status = @status";
                        break;
                }

                switch (_ctrl3)
                {
                    case 0:
                        sec3 = "";
                        break;
                    case 1:
                        sec3 = "ano between @de and @ate";
                        break;
                }
                string con1 = "", con2 = "";

                if (_ctrl2 > 0 && _ctrl3 > 0)
                {
                     con2 = "and";
                }
                else
                {
                    if (_ctrl2 == 0 && _ctrl3 > 0)
                    {
                        con2 = "";
                    }
                    else
                    {
                        con2 = "";
                    }
                }

                if(_ctrl1 > 0 && _ctrl2 > 0)
                {
                    con1 = "and";
                }
                else
                {
                    if(_ctrl1 > 0 && _ctrl3 >0)
                    {
                        con1 = "and";
                    }else
                    {
                        con1 = "";
                    }
                    
                }


                #endregion
                cmd.CommandText =
                    @"select 
                        	*
                      from
	                        selAllVec
                      where " + sec1 + " " + con1 + " " + sec2 + " " + con2 + " " + sec3;
                cmd.Parameters.AddWithValue("@modelo", vec.Modelo);
                cmd.Parameters.AddWithValue("@marca", vec.Marca);
                cmd.Parameters.AddWithValue("@categoria", vec.Categoria);
                cmd.Parameters.AddWithValue("@status", vec.Status);
                cmd.Parameters.AddWithValue("@de", _de);
                cmd.Parameters.AddWithValue("@Ate", _ate);

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

        public int pegaCodVec(string _placa)
        {
            ConnectionFactory conn = new ConnectionFactory();
            SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select codVec from Veiculo where placa = @placa";

            cmd.Parameters.AddWithValue("@placa", _placa);

            int retorno;
            conexao.Open();

            retorno = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Close();

            return retorno;
        }

        public double pegaValorTotal(string _placa, int _tipoPlan)
        {
            try
            {
                double valor;
                ConnectionFactory conn = new ConnectionFactory();
                SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));
                SqlCommand cmd = conexao.CreateCommand();

                cmd.CommandText = @"SELECT precoBase from selAllVec
                    where Placa = @placa";
                cmd.Parameters.AddWithValue("@placa", _placa);

                conexao.Open();
                valor = Convert.ToDouble(cmd.ExecuteScalar());
                conexao.Close();

                if (_tipoPlan == 1)
                {
                    return valor = valor * 0.3;

                }
                else
                {
                    return valor = valor * 0.15;
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erros se vire \n" + Convert.ToString(ex));
                throw ex;
            }
        }

        #endregion
    }
}
