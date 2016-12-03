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
    public class LocacaoDAO
    {
        public DataTable selAllLoca(string _cli,string _loc,string _vec)
        {
            try
            {
                int cli = 0 , loc = 0, vec = 0;
                ConnectionFactory conn = new ConnectionFactory();
                SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = @"select * from selAllLoc where codCli = @cli or codLoc = @loc 
                or codVec = @vec";

                int.TryParse(_cli,out cli);
                int.TryParse(_loc, out loc);
                int.TryParse(_vec,out vec);
                                
                cmd.Parameters.AddWithValue("@cli", cli);
                cmd.Parameters.AddWithValue("@loc", loc);
                cmd.Parameters.AddWithValue("@vec", vec);

                DataTable dt = new DataTable();

                conexao.Open();
                dt.Load(cmd.ExecuteReader());
                conexao.Close();
                return dt;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erros se vire \n" + Convert.ToString(ex));
                throw ex;
            }
        }

        public string selCliLoc
            ( int _codLoc = 0, int _codfun = 0)
        {
            try
            {
                ConnectionFactory conn = new ConnectionFactory();
                SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

                SqlCommand cmdCli = conexao.CreateCommand();
                cmdCli.CommandText = @"select nomeCli from selAllLoc where or codLoc = @loc 
                and codFun = @fun";
                cmdCli.Parameters.AddWithValue("@loc", _codLoc);
                cmdCli.Parameters.AddWithValue("@fun", _codfun);

                string cliente;
                conexao.Open();

                cliente = Convert.ToString(cmdCli.ExecuteScalar());

                conexao.Close();
                return cliente;


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erros se vire \n" + Convert.ToString(ex));
                throw ex;
            }
        }

        public string selPlacaLoc
           (int _codLoc = 0, int _codfun = 0)
        {
            try
            {
                ConnectionFactory conn = new ConnectionFactory();
                SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

                SqlCommand cmdPlaca = conexao.CreateCommand();
                cmdPlaca.CommandText = @"select placa from selAllLoc where or codLoc = @loc 
                and codFun = @fun";
                cmdPlaca.Parameters.AddWithValue("@loc", _codLoc);
                cmdPlaca.Parameters.AddWithValue("@fun", _codfun);

                string placa;
                conexao.Open();

                placa = Convert.ToString(cmdPlaca.ExecuteScalar());

                conexao.Close();

                return placa;


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erros se vire \n" + Convert.ToString(ex));
                throw ex;
            }
        }
    }
}
