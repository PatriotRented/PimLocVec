using Pim.Patriot.DataAccess.ClassesDAO;
using System;
using System.Collections.Generic;

public class Veiculo
{
	private long codVec;

	private string modelo;

	private string marca;

	private string cor;

	private string placa;

	private int categoria;

    private List<Acessorio> acessorios;

	private char status;

	public void cadVec(string _modelo, string _marca, string _cor, string _placa, int _categoria )
	{
        this.modelo = _modelo;
        this.marca = _marca;
        this.cor = _cor;
        this.placa = _placa;
        this.categoria = _categoria;

        VeiculoDAO vecDAO = new VeiculoDAO();
        vecDAO.insertVeiculo(@"Data Source=LUC-VAIO\SQLEXPRESS;Initial Catalog=BDlocadora;Integrated Security=True");
	}

	public void delVec()
	{
        throw new NotImplementedException();
	}

	public void alteraStVec()
	{
        throw new NotImplementedException();
	}

    /// <summary>
    /// Incluiu os acessorios no veiculo 
    /// </summary>
  /*  public void incluiAce(List<Acessorio> _aces) provavelmente vai para outro lugar
    {
        acessorios = new List<Acessorio>();
        acessorios = _aces;
    }
    */
}

