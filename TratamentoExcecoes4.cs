using System;
using System.IO;

// Exceção personalizada para erro de login
public class LoginInvalidoException : Exception
{
    public LoginInvalidoException(string mensagem) : base(mensagem)
    {
    }
}

class Program
{
    static void Main()
    {
        // Simulando dados válidos
        string usuarioValido = "admin";
        string senhaValida = "1234";

        try
        {
            // Solicita o nome de usuário
            Console.Write("Usuário: ");
            string usuario = Console.ReadLine();

            // Solicita a senha
            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            // Verifica se os campos estão vazios
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                throw new ArgumentException("Usuário e senha não podem estar vazios.");
            }

            // Verifica se usuário e senha estão corretos
            if (usuario != usuarioValido || senha != senhaValida)
            {
                throw new LoginInvalidoException("Usuário ou senha inválidos.");
            }

            // Login bem-sucedido
            Console.WriteLine("Login realizado com sucesso!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro de entrada: {ex.Message}");
            LogErro(ex);
        }
        catch (LoginInvalidoException ex)
        {
            Console.WriteLine($"Erro de autenticação: {ex.Message}");
            LogErro(ex);
        }
        catch (Exception ex)
        {
            // Captura qualquer outra exceção não prevista
            Console.WriteLine("Ocorreu um erro inesperado.");
            LogErro(ex);
        }
        finally
        {
            Console.WriteLine("Processo de login finalizado.");
        }
    }

    // Função para registrar logs de erro em um arquivo de texto
    static void LogErro(Exception ex)
    {
        string caminhoLog = "erros_login.log";
        string mensagem = $"{DateTime.Now} - {ex.GetType().Name}: {ex.Message}\n";

        File.AppendAllText(caminhoLog, mensagem);
    }
}
