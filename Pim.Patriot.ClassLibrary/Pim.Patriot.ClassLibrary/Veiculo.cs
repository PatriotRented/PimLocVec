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

	private string categoria;

    private List<Acessorio> acessorios;

	private char status;

	public void cadVec(string _modelo, string _marca, string _cor, string _placa, string _categoria = "Sem categoria")
	{
        this.modelo = _modelo;
        this.marca = _marca;
        this.cor = _cor;
        this.placa = _placa;
        this.categoria = _categoria;

        VeiculoDAO vecDAO = new VeiculoDAO();
        vecDAO.insertVeiculo();
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
    public void incluiAce(List<Acessorio> _aces)
    {
        acessorios = new List<Acessorio>();
        acessorios = _aces;
    }

}

