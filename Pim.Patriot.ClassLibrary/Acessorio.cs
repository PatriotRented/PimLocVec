using Pim.Patriot.DataAccess;
using System;
using System.Data.SqlClient;

public class Acessorio
{
	private long codAce;

	private string nomeAce;

	private double precoAce;

	public void IncluirAce()
	{
        throw new NotImplementedException();
	}

	public void excluirAce()
	{
        throw new NotImplementedException();
    }

	public void atualizaAce()
	{
        throw new NotImplementedException();
    }

    /// <summary>
    /// Associa um ou mais acessorios a um carro, insere na table do bd VecXace que lista 
    /// todos os carros com acessórios
    /// </summary>
    public void assosiaVecXace(int _codVec, int _codAce)
    {
        ConnectionFactory conn = new ConnectionFactory();
        SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQl"));
        SqlCommand cmdInsert = conexao.CreateCommand();

        cmdInsert.CommandText = 
            @"Insert into vecXace (codVec,codAce) values (@_codVec,@_codAce)";
        cmdInsert.Parameters.AddWithValue("@_codVec",_codVec);
        cmdInsert.Parameters.AddWithValue("@_codAce",_codAce);

        conexao.Open();

        cmdInsert.ExecuteNonQuery();

        conexao.Close();
    }
}

