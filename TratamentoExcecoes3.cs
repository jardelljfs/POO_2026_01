using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter arquivo = null;

        try
        {
            arquivo = new StreamWriter("log.txt");

            Console.WriteLine("Arquivo aberto.");
            arquivo.WriteLine("Iniciando gravação no arquivo...");

            // Erro proposital
            int numero1 = 10;
            int numero2 = 0;
            int resultado = numero1 / numero2;

            if (arquivo != null)
            {
                arquivo.Close();
                Console.WriteLine("Arquivo fechado pelo try.");
            }

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Erro: divisão por zero.");
            Console.WriteLine("Mensagem: " + ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Erro: o arquivo não foi encontrado.");
            Console.WriteLine("Mensagem: " + ex.Message);
        }
        finally
        {
            if (arquivo != null)
            {
                arquivo.Close();
                Console.WriteLine("Arquivo fechado pelo finally.");
            }
        }
    }
}
