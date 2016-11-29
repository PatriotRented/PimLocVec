using Pim.Patriot.DataAccess;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Locacao : Pedido
{
	private int codLoc;

	private MetodoPagamento forma_pag;

	public override void registraPedido()
	{
        throw new NotImplementedException();
    }

	public double calAcrescimo(double  op)
	{
        throw new NotImplementedException();
    }

    public override void cancelaPedido()
    {
        throw new NotImplementedException();
    }

    public int registraLocacao(int _codCli, int _codFun, int _codVec, int _tipoPlan,
        double _total, string _dt_ret, string _dt_dev)
    {
        try
        {

            ConnectionFactory conn = new ConnectionFactory();
            SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

            SqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = @"insert into 
	        Locacao (codCli, codFun, codVec, tipoPlan, total, dt_ret,dt_dev)
             values
            (@codCli, @codFun, @codVec, @tipoPlan, @total, @dt_ret,@dt_dev)";
            cmd.Parameters.AddWithValue("@codCli", _codCli);
            cmd.Parameters.AddWithValue("@codFun", _codFun);
            cmd.Parameters.AddWithValue("@codVec", _codVec);
            cmd.Parameters.AddWithValue("@tipoPlan", _tipoPlan);
            cmd.Parameters.AddWithValue("@total", _total);
            cmd.Parameters.AddWithValue("@dt_ret", _dt_ret);
            cmd.Parameters.AddWithValue("@dt_dev", _dt_dev);

            SqlCommand cmdSmax = conexao.CreateCommand();
            cmdSmax.CommandText =
                @"SELECT MAX(codLoc) FROM Locacao";

            conexao.Open();

            cmd.ExecuteNonQuery();
            this.codLoc = Convert.ToInt32(cmdSmax.ExecuteScalar());

            conexao.Close();

            return this.codLoc;
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Erros se vire \n" + Convert.ToString(ex));
            throw ex;
        }
    }
}

