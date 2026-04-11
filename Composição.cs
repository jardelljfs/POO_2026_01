using System;
using System.ComponentModel;
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
    public List<Pagina> paginas = new List<Pagina>();

    public Livro(string titulo, int ISBN, int nPag)
    {
        this.titulo = titulo;
        this.ISBN = ISBN;
        this.nPag = nPag;
        for(int i=0; i < nPag; i++)
        {
            string conteudo = "Conteúdo da Página " + (i+1);
            this.paginas.Add(new Pagina(i+1, conteudo));
        }
    }

    public void imprimirLivro() { 
        Console.WriteLine("\n\nTitulo: " + this.titulo + " ISBN: " + this.ISBN + " nPag: " + this.nPag); 
        foreach(Pagina pagina in paginas)
        {
            pagina.imprimirPagina();
        }
    }
}

class Pagina
{
    public int numero;
    public string conteudo;

    public Pagina(int numero, string conteudo)
    {
        this.numero = numero;
        this.conteudo = conteudo;
    }

    public void imprimirPagina() { Console.WriteLine("Página: "+ this.numero + " Conteúdo: " + this.conteudo);}
}

class Program
{
    public static void Main()
    {
        Biblioteca bib = new Biblioteca();

        Livro l1 = new Livro("O grande mentecapto", 123456, 2);
        Livro l2 = new Livro("O mundo Assombrado pelos demônios", 654321, 5);

        bib.inserirLivros(l1);
        bib.inserirLivros(l2);

        bib.imprimirBib();
    }
}
