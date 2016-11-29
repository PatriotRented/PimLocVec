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
    }
}
