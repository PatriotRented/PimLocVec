using Pim.Patriot.DataAccess;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Cliente : Pessoa
{



    private int codCli;

    private string cnh;



    public override bool cadastrar()
    {
        throw new NotImplementedException();
    }

    public void alugarVec()
    {
        throw new NotImplementedException();
    }



    public void cadCli(string _nome, string _email, string _cnh, string _tel, int _codEnd, string _cpf_cnpj, string _dt_nasc)


    {
        try
        {
            ConnectionFactory conn = new ConnectionFactory();
            SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

            SqlCommand cmdInsert = conexao.CreateCommand();
            cmdInsert.CommandText =
                @"Insert into Cliente 
                    ( cnpj_cpf,nomeCli, emailCli, dt_nasc, cnh, tel, codEnd)
                values
                   (@cnpj_cpf,@nomeCli,@emailCli,@dt_nasc,@cnh,@tel,@codEnd);";

            cmdInsert.Parameters.AddWithValue("@cnpj_cpf", _cpf_cnpj);
            cmdInsert.Parameters.AddWithValue("@nomeCli", _nome);
            cmdInsert.Parameters.AddWithValue("@emailCli", _email);
            cmdInsert.Parameters.AddWithValue("@dt_nasc",_dt_nasc);
            cmdInsert.Parameters.AddWithValue("@cnh", _cnh);
            cmdInsert.Parameters.AddWithValue("@tel", _tel);
            cmdInsert.Parameters.AddWithValue("@codEnd", _codEnd);

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
}