using System;

public abstract class Pedido
{
	protected Plano plano;

	protected DateTime dt_ret;

	protected DateTime dt_dev;

	protected Double desc;

	protected long id_vec;

	protected long id_cli;

	public abstract void registraPedido();

	public abstract void cancelaPedido();

}

