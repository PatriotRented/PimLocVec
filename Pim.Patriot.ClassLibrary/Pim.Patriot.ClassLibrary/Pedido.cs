using System;

public abstract class Pedido
{
	protected Plano plano;

	protected DateTime dt_ret;

	protected DateTime dt_dev;

	protected Double desc;

	public abstract void registraPedido();

}

