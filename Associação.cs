using System;
#pragma warning disable

class Carro
{
    public string modelo;
    public Piloto condutor;

    public Carro(string modelo, Piloto condutor)
    {
        this.modelo = modelo;
        this.condutor = condutor;
    }

    public void conduzir()
    {
        Console.WriteLine("O carro está sendo conduzido pelo condutor " + this.condutor.nome);
    }
}

class Piloto
{
    public string nome;
    public Piloto(string nome)
    {
        this.nome = nome;
    }
}

class Program
{
    public static void Main()
    {
        Piloto piloto = new Piloto("Ayrton Senna");
        Carro carro = new Carro("Uno", piloto);

        carro.conduzir();
    }
}