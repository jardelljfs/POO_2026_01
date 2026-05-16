class Funcionario {
    protected string nome;
    protected double salario;

    public Funcionario(string nome, double salario) {
        this.nome    = nome;
        this.salario = salario;
    }

    public virtual void ExibirInfo() { Console.Write( $"Funcionário: {nome}" + $" | Salário: R$ {salario}"); }
}

class Gerente : Funcionario {
    private string departamento;

    public Gerente(string nome, double salario, string departamento) : base(nome, salario) {
        this.departamento = departamento;
    }

    public override void ExibirInfo() {
        base.ExibirInfo();
        Console.WriteLine($" | Depto: {departamento}");
    }
}

class Programa {
    static void Main() {
        Funcionario g = new Gerente("Ana", 8000, "TI");
        g.ExibirInfo();
    }
}