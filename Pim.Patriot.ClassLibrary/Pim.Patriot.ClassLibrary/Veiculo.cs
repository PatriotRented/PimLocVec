using System.Collections.Generic;

public class Veiculo
{
	private long id_vec;

	private string modelo;

	private string marca;

	private string cor;

	private string placa;

	private string categoria;

	private char status;

	private List<Acessorio> aces;

	public void cadVec(string _cor, string _placa, string _categoria)
	{
        aces = new List<Acessorio>();
        this.status = 'D';
        
	}

	public void delVec(long _id)
	{
        
	}

}

