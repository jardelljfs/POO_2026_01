using System;

class Program
{
    static void Main()
    {
        try
        {
            int numero1 = 10;
            int numero2 = 0;

            int resultado = numero1 / numero2;

            Console.WriteLine("Resultado: " + resultado);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Erro: não é possível dividir por zero.");
            Console.WriteLine("Mensagem da exceção: " + ex.Message);
        }
    }
}
