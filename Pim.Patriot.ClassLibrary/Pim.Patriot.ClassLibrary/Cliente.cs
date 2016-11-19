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



    public void cadCli(string _nome, string _email, string _cnh, string _tel, int _codEnd, string _cpf_cnpj, string _dt_nasc, string _rg)


    {
        try
        {
            ConnectionFactory conn = new ConnectionFactory();
            SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

            SqlCommand cmdInsert = conexao.CreateCommand();
            cmdInsert.CommandText =
                @"
                 EXEC	sp_cad_cli
	        	        @cnpj_cpf = @cnpj_cpf_p,
	                   	@rg = @rg_p',
		                @nomeCli = @nomeCli_p,
		                @emailCli = @emailCli_p,
		                @dt_nasc_string = @dt_nasc_p,
		                @cnh = @cnh_p,
		                @tel = @tel_p,
		                @codEnd = @codEnd_p ;
              ";

            cmdInsert.Parameters.AddWithValue("@cnpj_cpf_p", _cpf_cnpj);
            cmdInsert.Parameters.AddWithValue("@nomeCli_p", _nome);
            cmdInsert.Parameters.AddWithValue("@emailCli_p", _email);
            cmdInsert.Parameters.AddWithValue("@dt_nasc_p", _dt_nasc);
            cmdInsert.Parameters.AddWithValue("@cnh_p", _cnh);
            cmdInsert.Parameters.AddWithValue("@tel_p", _tel);
            cmdInsert.Parameters.AddWithValue("@codEnd_p", _codEnd);
            cmdInsert.Parameters.AddWithValue("@rg_p", _rg);
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