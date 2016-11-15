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

	private int codCat;

    private string categoria;

	private char status;
    #endregion

    #region Metodos
    public int cadVec
        (string _modelo, string _marca, string _cor, string _placa, 
            int _codcat, string _ano, int _codAce1 = 0 , int _codAce2 = 0, int _codAce3 = 0)
	{
        try
        {
            this.modelo = _modelo;
            this.marca = _marca;
            this.cor = _cor;
            this.placa = _placa;
            this.codCat = _codcat;

            ConnectionFactory conn = new ConnectionFactory();
            SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

            SqlCommand cmdInsert = conexao.CreateCommand();
            cmdInsert.CommandText =
                @"Insert into Veiculo 
                    (codCat, modelo, marca,cor, placa, anoVec,codAce1,codAce2,codAce3, statusVec)
                values
                    (@codCat,@modelo,@marca,@cor,upper(@placa),@anoVec,@codAce1,@codAce2,@codAce3,@statusVec);";

            cmdInsert.Parameters.AddWithValue("@codcat", _codcat);
            cmdInsert.Parameters.AddWithValue("@modelo", _modelo);
            cmdInsert.Parameters.AddWithValue("@marca", _marca);
            cmdInsert.Parameters.AddWithValue("@cor", _cor);
            cmdInsert.Parameters.AddWithValue("@placa", _placa);
            cmdInsert.Parameters.AddWithValue("@anoVec", _ano);
            cmdInsert.Parameters.AddWithValue("@codAce1",_codAce1);
            cmdInsert.Parameters.AddWithValue("@codAce2",_codAce2);
            cmdInsert.Parameters.AddWithValue("@codAce3",_codAce3);
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
        catch(SqlException ex)
        {
            
            MessageBox.Show(Convert.ToString(ex));
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

    #endregion

    #region Geters e Seters
    public int CodVec { get; set; }
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public string Cor { get; set; }
    public string Placa { get; set; }
    public int CodCat { get; set; }
    public char Status { get; set; }
    public string Categoria { get; set; }
    #endregion
}

