using Pim.Patriot.DataAccess;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Endereco
{
    private string rua;

    private string bairro;

    private string uf;

    private string cidade;

    private string complemento;

    private string cep;

    private string numero;

    public int salvaEnd(string _rua, string _bairro, string _uf, string _cidade, string _cep, string _complemento, string _numero)


    {
        try
        {
            this.rua = _rua;
            this.bairro = _bairro;
            this.uf = _uf;
            this.cidade = _cidade;
            this.cep = _cep;
            this.complemento = _complemento;
            this.numero = _numero;

            string cep = "";
            foreach (char c in _cep)
            {
                if (char.IsDigit(c))
                {
                    cep += c;
                }
            }
            ConnectionFactory conn = new ConnectionFactory();
            SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

            SqlCommand cmdInsert = conexao.CreateCommand();
            cmdInsert.CommandText =
                @"Insert into Endereco 
                    ( rua, bairro, num, complemento, uf, cep, cidade)
                values
                    (@rua,@bairro,@num,@complemento,@uf,@cep,@cidade);";

            cmdInsert.Parameters.AddWithValue("@rua", _rua);
            cmdInsert.Parameters.AddWithValue("@bairro", _bairro);
            cmdInsert.Parameters.AddWithValue("@num", _numero);
            cmdInsert.Parameters.AddWithValue("@complemento", _complemento);
            cmdInsert.Parameters.AddWithValue("@uf", _uf);
            cmdInsert.Parameters.AddWithValue("@cep", _cep);
            cmdInsert.Parameters.AddWithValue("@cidade", _cidade);
            SqlCommand cmdSmax = conexao.CreateCommand();
            cmdSmax.CommandText =
                @"SELECT MAX(codEnd) FROM Endereco";

            conexao.Open();

            cmdInsert.ExecuteNonQuery();
            int retorna = Convert.ToInt32(cmdSmax.ExecuteScalar());

            conexao.Close();

            return retorna;
        }
        catch
        {
            Exception ex = new Exception();
            MessageBox.Show(Convert.ToString(ex));
            throw ex;
        }

    }




    public void atualizaEnd()
    {
        throw new NotImplementedException();
    }
}

