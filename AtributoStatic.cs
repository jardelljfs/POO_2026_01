using System;

class Pessoa
{
    public static int quantidade_pessoa;
    
    public string nome = "Maria";
    public int matricula;

    public Pessoa()
    {
        quantidade_pessoa++;
    }

    ~Pessoa()
    {
        
    }

    public void IncrementarPessoa()
    {
        quantidade_pessoa++;
    }

    public int QuantidadePessoas()
    {
        return quantidade_pessoa;
    }
}

class Program
{
    public static void Main()
    {
        Pessoa aluno = new Pessoa();
        Pessoa professor = new Pessoa();

        Console.WriteLine("Quantidade de pessoas: " + Pessoa.quantidade_pessoa);

        Console.WriteLine("\nAluna: " + aluno.nome + "\nProfessora: " + professor.nome);
        aluno.nome = "Fernanda";
        Console.WriteLine("\nAluna: " + aluno.nome + "\nProfessora: " + professor.nome);

        aluno.IncrementarPessoa();
        Console.WriteLine("Quantidade de pessoas: " + aluno.QuantidadePessoas());

    }
}