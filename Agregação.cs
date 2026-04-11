using System;
#pragma warning disable

class Biblioteca
{
    public List<Livro> livros = new List<Livro>();
    
    public void imprimirBib() { foreach(Livro livro in this.livros) { livro.imprimirLivro(); } }

    public void inserirLivros(Livro livro) { this.livros.Add(livro); }
}

class Livro
{
    public string titulo;
    public int ISBN;
    public int nPag;

    public Livro(string titulo, int ISBN, int nPag)
    {
        this.titulo = titulo;
        this.ISBN = ISBN;
        this.nPag = nPag;
    }

    public void imprimirLivro() { Console.WriteLine("Titulo: " + this.titulo + " ISBN: " + this.ISBN + " nPag: " + this.nPag); }
}

class Program
{
    public static void Main()
    {
        Biblioteca bib = new Biblioteca();

        Livro l1 = new Livro("O grande mentecapto", 123456, 254);
        Livro l2 = new Livro("O mundo Assombrado pelos demônios", 654321, 509);

        bib.inserirLivros(l1);
        bib.inserirLivros(l2);

        bib.imprimirBib();
    }
}
