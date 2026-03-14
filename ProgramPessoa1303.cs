using System;

class Pessoa
{
    //atributos da classe
    private static int QuantidadePessoa = 0;

    public static int retornaQuantidade()
    {
        return QuantidadePessoa;
    }
    
    //atributos
    private string nome;
    private int matricula;
    private string curso;

    public Pessoa(string nome, int matricula, string curso = "teste") // string int string
    {
        QuantidadePessoa++;
        this.nome = nome;
        this.matricula = matricula;
        this.curso = curso;
        Console.WriteLine("Construtor 1");
    }

    public Pessoa(string nome, int matricula) // string int
    {
        QuantidadePessoa++;
        this.nome = nome;
        this.matricula = matricula;
        Console.WriteLine("Construtor 2");
    }

    public Pessoa(string nome)
    {
        QuantidadePessoa++;
        this.matricula = QuantidadePessoa;
        this.nome = nome;
        Console.WriteLine("Construtor 3");
    }

    ~Pessoa()
    {
        Console.WriteLine("Objeto destruido");
    }

    //get e set
    public string Nome { 
                        get => nome; 
                        set => nome = value.ToUpper(); 
    }

    public int Matricula { get => matricula; set => matricula = value; }
    public string Curso { get => curso; set => curso = value; }

    //método
    public void ExibirPessoa()
    {
        Console.WriteLine("\nNome: " + this.nome);
        Console.WriteLine("Matricula: " + this.matricula);
        Console.WriteLine("Curso: " + this.curso);
    }
}

class Program
{
    public static void Main()
    {
        bool var = true;
        
        Pessoa aluno = new Pessoa("José",100, "SI");
        Pessoa professor = new Pessoa("Maria", Pessoa.retornaQuantidade());
        Pessoa aluno2 = new Pessoa("Vitor");

        if(!var){
            aluno.ExibirPessoa();
            professor.ExibirPessoa();
            aluno2.ExibirPessoa();
        }

        Console.WriteLine("\nQuantidade Pessoas " + Pessoa.retornaQuantidade());
    }
}