using System;

public class Locacao : Pedido
{
	private long codLoc;

	private MetodoPagamento forma_pag;

	public override void registraPedido()
	{
        throw new NotImplementedException();
    }

	public double calAcrescimo(double  op)
	{
        throw new NotImplementedException();
    }

    public override void cancelaPedido()
    {
        throw new NotImplementedException();
    }
}

