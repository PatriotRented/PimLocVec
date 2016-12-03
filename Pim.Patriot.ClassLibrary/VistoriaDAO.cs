using Pim.Patriot.DataAccess;
using System.Data.SqlClient;
using System;

public class VistoriaDAO
{
	private long cod_vis;

	private long id_vec;

	private long id_tec;

	private bool status;



    public void MudaStatus(int _st, int _codLoc)
    {
    ConnectionFactory conn = new ConnectionFactory();
    SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));
    SqlCommand cmd = conexao.CreateCommand();
        switch (_st)
        {
            case 1:
                cmd.CommandText =
                    @"insert into Vistoria (codLoc,statusVis) values (@codLoc, @st)";
                cmd.Parameters.AddWithValue("@codLoc", _codLoc);
                cmd.Parameters.AddWithValue("@st", _st);

                conexao.Open();

                cmd.ExecuteNonQuery();

                conexao.Close();
                break;
            case 2:

                cmd.CommandText =
                    @"insert into Vistoria (codLoc,statusVis) values (@codLoc, @st)";
                cmd.Parameters.AddWithValue("@codLoc", _codLoc);
                cmd.Parameters.AddWithValue("@st", _st);

                conexao.Open();

                cmd.ExecuteNonQuery();

                conexao.Close();
                break;
        }
    }
}

