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
            string cpf_cnpj = "";
            foreach (char c in _cpf_cnpj)
            {
                if (char.IsDigit(c))
                {
                    cpf_cnpj += c;
                }
            }

            string rg = "";
            foreach (char c in _rg)
            {
                if (char.IsDigit(c))
                {
                    rg += c;
                }
            }

            ConnectionFactory conn = new ConnectionFactory();
            SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

            SqlCommand cmdInsert = conexao.CreateCommand();
            cmdInsert.CommandText =
                @"Insert into Cliente
                    (cnpj_cpf, rg, nomeCli, emailCli, dt_nasc, cnh, tel, codEnd)
                values
                    (@cnpj_cpf, @rg, @nomeCli, @emailCli, @dt_nasc, @cnh, @tel, @codEnd);";

            cmdInsert.Parameters.AddWithValue("@cnpj_cpf", cpf_cnpj);
            cmdInsert.Parameters.AddWithValue("@rg", rg);
            cmdInsert.Parameters.AddWithValue("@nomeCli", _nome);
            cmdInsert.Parameters.AddWithValue("@emailCli", _email);
            cmdInsert.Parameters.AddWithValue("@dt_nasc", _dt_nasc);
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