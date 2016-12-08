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
    public class ReservaDAO
    {
        public DataTable selAllLoca(string _cli, string _res)
        {
            try
            {
                int cli = 0, loc = 0;
                ConnectionFactory conn = new ConnectionFactory();
                SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = @"select * from selAllRes where codCli = @cli or codLoc = @loc 
                or codVec = @vec";

                int.TryParse(_cli, out cli);
                int.TryParse(_res, out loc);
                

                cmd.Parameters.AddWithValue("@cli", cli);
                cmd.Parameters.AddWithValue("@res", loc);
                

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
