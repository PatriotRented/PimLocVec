using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Patriot.DataAccess.ClassesDAO
{
    /// <summary>
    /// Classe de acesso ao banco de dados dos objetos veículos
    /// </summary>
    public class VeiculoDAO
    {
        SqlConnection conexao = new SqlConnection();

        #region Metodos

        /// <summary>
        /// Insere um registro a partir do objeto veículo na tabela veiculo do banco de dados 
        /// </summary>
        /// <returns></returns>
        public object insertVeiculo()
        {
            /*SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Veiculo (modelo, marca, cor, placa, )";*/
            throw new NotImplementedException();
        }
        
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
        public void selectAllVec()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from veiculos";
        }
        #endregion
    }
}
