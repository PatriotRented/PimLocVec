using System;

public class Locacao : Pedido
{
	private long cod_loc;

	private MetodoPagamento forma_pag;


	public double calAcrescimo(int  op)
	{
        throw new NotImplementedException();
    }

    public override void registraPedido()
    {
        throw new NotImplementedException();
    }

    public override void cancelaPedido()
    {
        throw new NotImplementedException();
    }
}

