using System;

class Veiculo
{
    // ATRIBUTOS PRIVADOS (encapsulamento)
    private string placa;
    private string modelo;
    private int horaEntrada;
    private bool estacionado;

    // ATRIBUTO ESTÁTICO (compartilhado por todos os objetos)
    private static int totalVeiculos = 0;

    // CONSTRUTOR
    public Veiculo(string placa, string modelo, int horaEntrada)
    {
        // USO DO THIS → diferenciar atributo de parâmetro
        this.placa = placa;
        this.modelo = modelo;
        this.horaEntrada = horaEntrada;

        // TODO veículo começa estacionado
        this.estacionado = true;

        // IMPORTANTE: atributo estático é incrementado a cada novo objeto
        totalVeiculos++;
    }

    // ===================== GETTERS =====================
    public string getPlaca()
    {
        return placa;
    }

    public string getModelo()
    {
        return modelo;
    }

    public int getHoraEntrada()
    {
        return horaEntrada;
    }

    public bool getStatus()
    {
        return estacionado;
    }

    // ===================== SETTERS =====================
    public void setModelo(string modelo)
    {
        // Atualiza o modelo do veículo
        this.modelo = modelo;
    }

    public void setHoraEntrada(int horaEntrada)
    {
        this.horaEntrada = horaEntrada;
    }

    // ===================== MÉTODOS DA CLASSE =====================

    public void registrarSaida()
    {
        // ALTERA O ESTADO DO VEÍCULO
        estacionado = false;
    }

    public void mostrarDados()
    {
        Console.WriteLine($"Placa: {placa}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Hora de Entrada: {horaEntrada}");

        // USO DE CONDIÇÃO PARA EXIBIR STATUS
        if (estacionado)
        {
            Console.WriteLine("Status: Estacionado");
        }
        else
        {
            Console.WriteLine("Status: Saiu");
        }

        Console.WriteLine("-------------------------");
    }

    // MÉTODO ESTÁTICO PARA ACESSAR O TOTAL
    public static int getTotalVeiculos()
    {
        return totalVeiculos;
    }
}

class Program
{
    static void Main()
    {
        // CRIAÇÃO DOS OBJETOS (instanciando a classe)
        Veiculo v1 = new Veiculo("ABC-1234", "Gol", 8);
        Veiculo v2 = new Veiculo("DEF-5678", "Onix", 9);
        Veiculo v3 = new Veiculo("GHI-9999", "HB20", 10);

        // EXIBINDO DADOS INICIAIS
        Console.WriteLine("=== VEÍCULOS CADASTRADOS ===");
        v1.mostrarDados();
        v2.mostrarDados();
        v3.mostrarDados();

        // REGISTRANDO SAÍDA DE UM VEÍCULO
        // IMPORTANTE: altera apenas o estado do objeto v2
        v2.registrarSaida();

        // EXIBINDO DADOS ATUALIZADOS
        Console.WriteLine("=== APÓS SAÍDA DE UM VEÍCULO ===");
        v1.mostrarDados();
        v2.mostrarDados();
        v3.mostrarDados();

        // MOSTRANDO TOTAL DE VEÍCULOS
        // OBS: acesso via classe, pois é estático
        Console.WriteLine("Total de veículos cadastrados: " + Veiculo.getTotalVeiculos());
    }
}