using System;
public abstract class Pessoa
{

	protected string nome;

	protected string email;

	protected Endereco end;

    protected DateTime dt_nasc;

    protected string rg;

    protected string cpf_cnpj;

    protected string telefone;

    public abstract bool cadastrar();

}

