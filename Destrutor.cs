using System;

class Arquivo
{
    public string Nome;

    public Arquivo(string nome)
    {
        Nome = nome;
        Console.WriteLine($"Objeto {Nome} criado.");
    }

    ~Arquivo()
    {
        Console.WriteLine($"Objeto {Nome} destruído.");
    }
}

class Program
{
    public static void Main()
    {
        CriarObjeto();
        Arquivo a1 = new Arquivo("relatorio.txt");
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine("Fim do programa.");
    }

    public static void CriarObjeto()
    {
        Arquivo a1 = new Arquivo("relatorio.txt");
    }
}