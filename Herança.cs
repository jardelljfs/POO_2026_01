using System;
# pragma warning disable

class Veiculo
{
    protected string marca;
    protected string modelo;
    protected int ano;

    public Veiculo(string marca, string modelo, int ano)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.ano = ano;
    }

    public void exibirInformacoes() { Console.WriteLine($"Marca: {marca} - Modelo: {modelo} - Ano: {ano}"); }
}

class Carro : Veiculo
{
    public int quantPortas;

    public Carro(string marca, string modelo, int ano, int quantPortas) : base(marca, modelo, ano)
    {
        this.quantPortas = quantPortas;
    }
}

class Moto : Veiculo
{
    public int cilindradas;

    public Moto(string marca, string modelo, int ano, int cilindradas) : base(marca, modelo, ano)
    {
        this.cilindradas = cilindradas; // Classe MOTO
    }
}

class MotoEletrica : Moto
{
public int bateria;

    public MotoEletrica(string marca, string modelo, int ano, int cilindradas, int bateria) : base(marca, modelo, ano, cilindradas)
    {
        this.bateria = bateria;   
    }
}

class Program
{
    public static void Main()
    {
        Veiculo veiculo = new Veiculo("SemMarca", "SemModelo", 1500);
        Carro carro = new Carro("FIAT", "UNO", 1500, 4);
        Moto moto = new Moto("Honda", "Sahara", 2026, 300);

        Console.WriteLine();
        veiculo.exibirInformacoes();
        Console.WriteLine();
        carro.exibirInformacoes();
        Console.WriteLine();
        moto.exibirInformacoes();
        Console.WriteLine();
    }
}