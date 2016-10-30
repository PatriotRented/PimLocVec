using Pim.Patriot.DataAccess;
using Pim.Patriot.DataAccess.ClassesDAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Acessorio
{
	private long codAce;

	private string nomeAce;

	private double precoAce;

	public void IncluirAce(string _nomeAce, double _precoAce)
	{
        try
        {

            ConnectionFactory conn = new ConnectionFactory();
            SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

            SqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText =
                @"insert into Acessorio (nomeAce, precoAce) values (@nomeAce,@precoAce)";
            cmd.Parameters.AddWithValue("@nomeAce", _nomeAce);
            cmd.Parameters.AddWithValue("@precoAce", _precoAce);

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
        try
        {
            ConnectionFactory conn = new ConnectionFactory();
            SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQl"));
            SqlCommand cmdInsert = conexao.CreateCommand();

            cmdInsert.CommandText =
                @"Insert into vecXace (codVec,codAce) values (@_codVec,@_codAce)";
            cmdInsert.Parameters.AddWithValue("@_codVec", _codVec);
            cmdInsert.Parameters.AddWithValue("@_codAce", _codAce);

            conexao.Open();

            cmdInsert.ExecuteNonQuery();

            conexao.Close();
        }
        catch (SqlException ex)
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

