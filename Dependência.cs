using System;
#pragma warning disable

class Impressora
{
    public void imprimirDocumento(Documento doc)
    {
        Console.WriteLine("\n\n****Imprindo documento: " + doc.nome + "\n");
        Console.WriteLine(doc.conteudo);
    }
}

class Documento
{
    public string nome;
    public string conteudo;

    public Documento(string nome, string conteudo)
    {
        this.nome = nome;
        this.conteudo = conteudo;
    }
}

class Program
{
    public static void Main()
    {
        Impressora print = new Impressora();
        Documento doc = new Documento("pdf", "Este é o conteúdo do pdf");      
        print.imprimirDocumento(doc);
    }
}