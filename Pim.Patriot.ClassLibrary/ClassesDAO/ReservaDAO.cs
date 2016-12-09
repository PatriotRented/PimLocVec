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
        public DataTable selAllres(string _cli, string _res, string dt_ret , string dt_dev )
        {
            try
            {
                int cli = 0, loc = 0;
                ConnectionFactory conn = new ConnectionFactory();
                SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

                SqlCommand cmd = conexao.CreateCommand();

                if(dt_ret != "/" && dt_dev != "/")
                {
                    cmd.CommandText = @"select * from selAllRes where codCli = @cli or codLoc = @loc 
                or codVec = @vec or ret between @de and @ate or dev between @de and @ate ";
                    cmd.Parameters.AddWithValue("@de", dt_ret);
                    cmd.Parameters.AddWithValue("@ate", dt_dev);
                }
                else
                {
                    cmd.CommandText = @"select * from selAllRes where codCli = @cli or codLoc = @loc 
                or codVec = @vec";
                }

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
