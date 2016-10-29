using Pim.Patriot.DataAccess;
using Pim.Patriot.DataAccess.ClassesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Veiculo
{
    #region atributos
    private int codVec;

	private string modelo;

	private string marca;

	private string cor;

	private string placa;

	private int categoria;

   // private List<Acessorio> acessorios;

	private char status;
    #endregion

    #region Metodos
    public int cadVec(string _modelo, string _marca, string _cor, string _placa, int _codcat )
	{
        try
        {
            this.modelo = _modelo;
            this.marca = _marca;
            this.cor = _cor;
            this.placa = _placa;
            this.categoria = _codcat;

            ConnectionFactory conn = new ConnectionFactory();
            SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

            SqlCommand cmdInsert = conexao.CreateCommand();
            cmdInsert.CommandText =
                @"Insert into Veiculo 
                    (codCat, modelo, marca,cor, placa, statusVec)
                values
                    (@codCat,@modelo,@marca,@cor,upper(@placa),@statusVec);";

            cmdInsert.Parameters.AddWithValue("@codcat", _codcat);
            cmdInsert.Parameters.AddWithValue("@modelo", _modelo);
            cmdInsert.Parameters.AddWithValue("@marca", _marca);
            cmdInsert.Parameters.AddWithValue("@cor", _cor);
            cmdInsert.Parameters.AddWithValue("@placa", _placa);
            cmdInsert.Parameters.AddWithValue("@statusVec", 'D');

            SqlCommand cmdSmax = conexao.CreateCommand();
            cmdSmax.CommandText =
                @"SELECT MAX(codVec) FROM Veiculo";

            conexao.Open();

            cmdInsert.ExecuteNonQuery();
            this.codVec = Convert.ToInt32(cmdSmax.ExecuteScalar());

            conexao.Close();

            return this.codVec;
        }
        catch
        {
            Exception ex = new Exception();
            MessageBox.Show(Convert.ToString(ex),"Erro", MessageBoxButtons.OK);
            throw ex;
        }

    }

	public void delVec()
	{
        throw new NotImplementedException();
	}

	public void alteraStVec()
	{
        throw new NotImplementedException();
	}

    /// <summary>
    /// Incluiu os acessorios no veiculo 
    /// </summary>
    /*  public void incluiAce(List<Acessorio> _aces) provavelmente vai para outro lugar
      {
          acessorios = new List<Acessorio>();
          acessorios = _aces;
      }
      */
    #endregion
}

