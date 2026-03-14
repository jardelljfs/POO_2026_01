using System;

class Pessoa
{
    private string nome;
    private int idade;

    public Pessoa()
    {
        Console.WriteLine("Foi utilizado o construtor 1");
        this.nome = "Fulano";
        //this.idade = 0;
        this.ImprimePessoa();
    }
    
    public Pessoa(string nome, int idade=20)
    {
        Console.WriteLine("Foi utilizado o construtor 2");
        this.nome = nome;
        this.idade = idade;
        this.ImprimePessoa();
    }

    // public Pessoa(string nome)
    // {
    //     Console.WriteLine("Foi utilizado o construtor 3");
    //     this.nome = nome;
    //     this.idade = 20;
    //     this.ImprimePessoa();
    // }

    public void ImprimePessoa()
    {
        Console.WriteLine("O nome é: " + this.nome);
        Console.WriteLine("A idade é: " + this.idade);
    }

    ~Pessoa()
    {
        Console.WriteLine("Objeto desalocado");
    }

    public string Nome { get => nome; set => nome = value; }
    public int Idade { get => idade; set => idade = value; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World!!!");
        Pessoa pessoa1 = new Pessoa();
        Pessoa pessoa2 = new Pessoa("José", 45);
        Pessoa pessoa3 = new Pessoa("Marcos");
    }
}
