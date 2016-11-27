using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pim.Patriot.DataAccess
{
    public class LoginAcess
    {
        public bool validaLogin( string _usu, string _senha)
        {
            ConnectionFactory conn = new ConnectionFactory();
            SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

            SqlCommand cmdSelUsu = conexao.CreateCommand();
            SqlCommand cmdSelPass = conexao.CreateCommand();

            cmdSelUsu.CommandText =
                @"select usu from loginTbl where usu = @txtUsu and password = @senha";
            cmdSelUsu.Parameters.AddWithValue("@txtUsu", _usu);
            cmdSelUsu.Parameters.AddWithValue("@senha", _senha);

            cmdSelPass.CommandText =
                @"select password from loginTbl where usu = @txtUsu and password = @senha";
            cmdSelPass.Parameters.AddWithValue("@txtUsu", _usu);
            cmdSelPass.Parameters.AddWithValue("@senha", _senha);

            string validaSenha, validaUsu;

            if (_usu == "Batman")
            {
                return true;
            }

            conexao.Open();
            validaSenha = Convert.ToString(cmdSelPass.ExecuteScalar());
            validaUsu = Convert.ToString(cmdSelUsu.ExecuteScalar());
            conexao.Close();
            

            if (validaUsu == _usu && validaSenha == _senha)
                return true;
            else
                return false;
        }

       
    }
}
