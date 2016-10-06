using System;

public class Reserva : Pedido
{
	private long cod_res;

    public override void cancelaPedido()
    {
        throw new NotImplementedException();
    }

    public override void registraPedido()
    {
        throw new NotImplementedException();
    }
}

