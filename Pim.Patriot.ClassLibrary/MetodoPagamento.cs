using Pim.Patriot.DataAccess;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class MetodoPagamento
{
    #region Atributos
    private long codMet;

    private string bandeira;

	private long numero;

	private long codCli;
    #endregion

    #region CadCli
    public void cadastraPag(int _codCli, string _ban,string _num)
	{
        try
        {

            ConnectionFactory conn = new ConnectionFactory();
            SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

            SqlCommand cmdInsert = conexao.CreateCommand();
            cmdInsert.CommandText =
                @"Insert into MetodoPagamento 
                    (codCli,bandeira,numero)
                values
                    (@codCli,@ban,@num);";

            cmdInsert.Parameters.AddWithValue("@codCli", _codCli);
            cmdInsert.Parameters.AddWithValue("@ban", _ban);
            cmdInsert.Parameters.AddWithValue("@num", _num);
            


            conexao.Open();

            cmdInsert.ExecuteNonQuery();
         

            conexao.Close();

        }
        catch (SqlException ex)
        {

            MessageBox.Show(Convert.ToString(ex));
            throw ex;
        }
    }

	public void delPag()
	{
        throw new NotImplementedException();
    }
    #endregion
}

