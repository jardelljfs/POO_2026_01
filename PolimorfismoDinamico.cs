using System;
#pragma warning disable

abstract class Forma
{
    public string Cor {get; set;}
    public double Area {get; set;}
    public virtual void Desenhar() => Console.Write("Desenhando um ... ");
    public abstract void CalcularArea();
}

class Circulo:Forma
{
    public double Raio {get;set;} public double Diametro {get;set;}
    public override void Desenhar() {base.Desenhar(); Console.WriteLine("Circulo");}
    public override void CalcularArea() => this.Area = Math.PI * Math.Pow(this.Raio,2);
    public void CalcularDiametro() => this.Diametro = 2 * this.Raio;
}

class Quadrado:Forma
{
    public double Lado {get;set;}
    public override void Desenhar() {base.Desenhar(); Console.WriteLine("Quadrado");}
    public override void CalcularArea() => this.Area = Math.Pow(this.Lado,2);
}

class Triangulo:Forma
{
    public double L1 {get;set;} public double L2 {get;set;} public double L3 {get;set;}
    public override void Desenhar() {base.Desenhar(); Console.WriteLine("Triangulo");}
    public override void CalcularArea()
    {
       double s = (L1 + L2 + L3) / 2;
       this.Area = Math.Sqrt(s * (s-L1) * (s-L2) * (s-L3));
    }
}

class Program
{
    public static void Main()
    {
        List<Forma> formas = new List<Forma>
        {
            new Circulo{Cor = "Amarelo", Raio = 5},
            new Circulo{Cor = "Verde", Raio = 10},
            new Circulo{Cor = "Branco", Raio = 15},
            new Quadrado{Cor="Preto", Lado = 4},
            new Quadrado{Cor="Azul", Lado =8},
            new Triangulo{Cor="Amarelo", L1=6, L2=6, L3=6} 
        };

        foreach(var forma in formas)
        {
            forma.Desenhar();
            forma.CalcularArea();
            Console.WriteLine("Area da forma é:" + forma.Area);

            if(forma is Circulo c)
            {
                c.CalcularDiametro();
                Console.WriteLine("Diametro do Circulo: " + c.Diametro);
            }
            
            Console.WriteLine();
        }
    }
}