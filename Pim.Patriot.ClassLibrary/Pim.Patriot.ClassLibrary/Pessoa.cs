public abstract class Pessoa
{
    #region Atributos
    protected string nome;

	protected string email;

	protected Endereco end;
    #endregion

    public abstract bool cadastrar();

}

