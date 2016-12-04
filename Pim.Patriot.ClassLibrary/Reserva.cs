using Pim.Patriot.DataAccess;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

public class Reserva : Pedido
{
    #region Atributos
    private long cod_res;
    #endregion

    public override void cancelaPedido()
    {
        throw new NotImplementedException();
    }

    public override void registraPedido()
    {
        throw new NotImplementedException();
    }

    public int registraRes(int _codCli, int _codFun, int _codVec, int _tipoPlan,
        double _total, string _dt_ret, string _dt_dev)
    {
        try
        {

            ConnectionFactory conn = new ConnectionFactory();
            SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

            SqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = @"insert into 
	        Reserva (codCli, codFun, codVec, tipoPlan, total, dt_ret,dt_dev)
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
                @"SELECT MAX(codRes) FROM Reserva";

            SqlCommand cmdSt = conexao.CreateCommand();

            cmdSt.CommandText = @"update Veiculo set statusVec = 'L' where codVec = @codVec;";
            cmdSt.Parameters.AddWithValue("@codVec", _codVec);
            conexao.Open();

            cmd.ExecuteNonQuery();
            int cod = Convert.ToInt32(cmdSmax.ExecuteScalar());
            cmdSt.ExecuteNonQuery();

            conexao.Close();

            return cod;
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Erros se vire \n" + Convert.ToString(ex));
            throw ex;
        }

    }

   
}

