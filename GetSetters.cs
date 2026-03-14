using System;

class Casa1 // Em vez de criar um campo privado manualmente, podemos usar propriedades auto-implementadas
            //No exemplo, o método público Nome cria automaticamente a variável nome e a oculta. 
{
    //Atributos
    public int Numero {get; set;}

    //Métodos
    public void imprimirCasa()
    {
        Console.WriteLine("O número da casa é: " + Numero);
    }
}

class Casa2 // Criando o atributo cor e criando os metodos get e set de forma reduzida. Pode ocorrer especialização dos métodos
{
    //Atributos
    private string cor = "";

    public string Cor { get => cor; set => cor = value; }

    //Métodos
    public void imprimirCasa()
    {
        Console.WriteLine("A cor da casa é: " + Cor);
    }
}

class Casa3 // Criando o atributo cor e criando os metodos get e set de forma reduzida. Pode ocorrer especialização dos métodos
{
    //Atributos
    private string cor = "";

    public string Cor { 
                    get {return cor;} 
                    set {cor = value;} 
                }

    //Métodos
    public void imprimirCasa()
    {
        Console.WriteLine("A cor da casa é: " + Cor);
    }
}

class Casa4 // Criando o atributo cor e criando os metodos get e set de forma separada. Pode ocorrer especialização dos métodos
{
    //Atributos
    private string cor = "";

    public string getCor()
    {
        return cor;
    }

    public void setCor(string cor)
    {
        this.cor = cor.ToUpper();
    }

    //Métodos
    public void imprimirCasa()
    {
        Console.WriteLine("A cor da casa é: " + this.getCor());
    }
}

class Program
{
    static void Main()
    {
        Casa1 casa1 = new Casa1();
        casa1.Numero = 10;
        Console.WriteLine("O número da casa 1 é: " + casa1.Numero);

        Casa2 casa2 = new Casa2();
        casa2.Cor = "amarelo";
        Console.WriteLine("A cor da casa 2 é: " + casa2.Cor);

        Casa3 casa3 = new Casa3();
        casa3.Cor = "azul";
        Console.WriteLine("A cor da casa 3 é: " + casa3.Cor);

        Casa4 casa4 = new Casa4();
        casa4.setCor("verde");
        Console.WriteLine("A cor da casa 4 é: " + casa4.getCor());
    }
}