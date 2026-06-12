using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader arquivo = null;

        try
        {
            arquivo = new StreamReader("texto.txt");

            string conteudo = arquivo.ReadToEnd();

            Console.WriteLine(conteudo);
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
                Console.WriteLine("Arquivo fechado.");
            }
        }
    }
}
