using System;

public abstract class Pedido
{
    #region  Atributos

   

	protected DateTime dt_ret;

	protected DateTime dt_dev;

	protected Double desco;

	protected long codVec;

	protected long copCli;

    #endregion

    #region M�todos
    public abstract void registraPedido();

	public abstract void cancelaPedido();
    #endregion
}

