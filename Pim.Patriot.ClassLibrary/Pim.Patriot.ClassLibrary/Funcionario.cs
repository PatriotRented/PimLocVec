using Pim.Patriot.DataAccess;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Funcionario : Pessoa
{

    private string cpf;

	private string cargo;

	private string dt_admissao;

	public bool validaFuncio()
	{
        throw new NotImplementedException();
    }

	
    public override bool cadastrar()
    {
        throw new NotImplementedException();
    }

    public void cadFun(string _nome, string _email, string _cargo, string _tel, int _codEnd, string _cpf, string _dt_nasc, string _dt_admissao)
    {
        try
        {
            string cpf = "";
            foreach (char c in _cpf)
            {
                if (char.IsDigit(c))
                {
                    cpf += c;
                }
            }

          

            ConnectionFactory conn = new ConnectionFactory();
            SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

            SqlCommand cmdInsert = conexao.CreateCommand();
            cmdInsert.CommandText =
                @"Insert into Funcionario
                    (cargo, dt_admissao, cpf, nomeFun, emailFun, dt_nasc, tel, codEnd)
                values
                    (@cargo,@dt_admissao,@cpf, @nomeFun, @emailFun, @dt_nasc, @tel, @codEnd);";

            cmdInsert.Parameters.AddWithValue("@cargo", _cargo);         
            cmdInsert.Parameters.AddWithValue("@dt_admissao", _dt_admissao);
            cmdInsert.Parameters.AddWithValue("@cpf", cpf);
            cmdInsert.Parameters.AddWithValue("@nomeFun", _nome);
            cmdInsert.Parameters.AddWithValue("@emailFun", _email);
            cmdInsert.Parameters.AddWithValue("@dt_nasc", _dt_nasc);
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

