using System;

public static class Calculadora
{
    public static double Somar(double a, double b)
    {
        return a + b;
    }

    public static double Subtrair(double a, double b)
    {
        return a - b;
    }

    public static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public static double Dividir(double a, double b)
    {
        return a / b;
    }
}

class Program
{
    public static void Main()
    {
        Saudacao();
        Console.WriteLine("A soma é: " + Calculadora.Somar(1.0, 2.3));
    }

    public static void Saudacao()
    {
        Console.WriteLine("Hello World!!!");
    }
}
