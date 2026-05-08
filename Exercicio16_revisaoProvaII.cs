#pragma warning disable

class Transporte
{
	protected string modelo;
	protected int capacidade;

    public Transporte(string modelo, int capacidade)
	{
		this.modelo = modelo;
		this.capacidade = capacidade;
	}

    public virtual void Mover() { Console.WriteLine("O transporte está se Movendo"); }

	public virtual void Exibir()
	{
		Console.WriteLine("Modelo: " + this.modelo);
		Console.WriteLine("Capacidade: " + this.capacidade);
	}
}

class Carro : Transporte, IManutencao
{
	protected string combustivel;

    public Carro(string modelo, int capacidade, string combustivel) : base(modelo, capacidade)
	{
		this.combustivel = combustivel;
	}

    public override void Mover()
    {
        base.Mover();
		Console.WriteLine("Através de Combustão!");
    }

    public void RealizarManutencao()
    {
        Console.WriteLine("Realizando Manutenção");
    }

    public override void Exibir()
    {
        base.Exibir();
		Console.WriteLine("Combustivel: " + this.combustivel);
    }
}

class Bicicleta : Transporte
{
	protected string tipo;

    public Bicicleta(string modelo, int capacidade, string tipo) : base(modelo, capacidade)
	{
		this.tipo = tipo;
	}

    public override void Mover()
    {
        base.Mover();
		Console.WriteLine("Através de Energia Mecanica");
    }

	public override void Exibir()
    {
        base.Exibir();
		Console.WriteLine("Combustivel: " + this.tipo);
    }
}

interface IManutencao
{
	void RealizarManutencao();
}

class Garagem
{
	public List<Transporte> listaTransporte = new List<Transporte>();

	public void adicionarTransporte(Transporte transporte)
	{
		this.listaTransporte.Add(transporte);
	}

	public void exibirLista()
	{
		foreach(Transporte transporte in this.listaTransporte)
		{
			transporte.Exibir();
			Console.WriteLine();
		}
		
	}
}

class Program
{
	public static void Main()
	{
		Carro carro = new Carro("Uno", 5, "Gasolina");
		Bicicleta bike = new Bicicleta("Caloi", 1, "Speed");

		Garagem garagem = new Garagem();

		garagem.adicionarTransporte(carro);
		garagem.adicionarTransporte(bike);

		garagem.exibirLista();

		foreach(Transporte transporte in garagem.listaTransporte)
		{
			transporte.Mover();
			Console.WriteLine();
			
			if(transporte is Carro carroManutencao)
			{
				carroManutencao.RealizarManutencao();
			}

			Console.WriteLine();
		}
	}
}