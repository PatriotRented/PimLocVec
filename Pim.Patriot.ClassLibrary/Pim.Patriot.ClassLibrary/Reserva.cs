using System;

public class Reserva : Pedido
{
    #region Atributos
    private long cod_res;
    #endregion

    public override void cancelaPedido()
    {
        throw new NotImplementedException();
    }

    public override void registraPedido()
    {
        throw new NotImplementedException();
    }

   
}

