using System;

public class ClientePF : Cliente
{
    #region atributos
    private int codCli;

    private string nomeCli;

    private string emailCli;
     
    private string rg;

	private string cpf;

    private string cnh;

	private DateTime dt_nasc;
    #endregion

    public override bool cadastrar()
	{
        throw new NotImplementedException();
    }

    public override void alugarVec()
    {
        throw new NotImplementedException();
    }
}

#region Metodos
public int cadCli(string _nomecli, string _email, string _cnh, string _cnpj_cpf, int _codEnd,
    int _codTel,DateTime _dt_nasc )
{
    try
    {
        this.nomecli = _nomecli;
        this.email = _email;
        this.cnh = _cnh;
        this.cnpj_cpf = _cnpj_cpf;
        this.codEnd = _codEnd;
        this.codTel = _codTel;

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
        MessageBox.Show(Convert.ToString(ex));
        throw ex;
    }

}