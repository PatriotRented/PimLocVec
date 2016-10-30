using Pim.Patriot.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim.Patriot.ClassLibrary
{
    public class Categoria
    {
        int codCat; 
	    string nomeCat;
        double precoCat;

        public void insereCat(string _nomeCat, double _precoCat)
        {
            try
            {
                ConnectionFactory conn = new ConnectionFactory();
                SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));
                SqlCommand cmd = conexao.CreateCommand();

                cmd.CommandText = (@"Insert into Categoria (nomeCat, precoCat) values (@nomeCat, @precoCat)");
                cmd.Parameters.AddWithValue("@nomeCat", _nomeCat);
                cmd.Parameters.AddWithValue("@precoCat", _precoCat);

                conexao.Open();

                cmd.ExecuteNonQuery();

                conexao.Close();
            }
            catch(SqlException ex)
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
            }
            
        }
    }
}
