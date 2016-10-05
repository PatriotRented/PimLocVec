using System.Collections.Generic;

protected abstract class Pessoa
{
	protected long id;

	protected string nome;

	protected string email;

	protected Endereco end;

	protected char status;

	protected List<Telefone> telefone;

	public abstract bool cadastrar();

}

