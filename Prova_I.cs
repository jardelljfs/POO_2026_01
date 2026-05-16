using System;

#pragma warning disable

class Aluno
{
    private string nome;
    private double nota;

    public Aluno(string nome, double nota)
    {
        this.nome = nome;
        this.nota = nota;
    }

    public string getNome()
    {
        return this.nome;
    }

    public double getNota()
    {
        return this.nota;
    }

    public void setNota(double nota)
    {
        if(nota >= 0){
            this.nota = nota;
        }
        else{
            Console.WriteLine("A nota precisa ser maior que 0");        
        }
    }

    public void exibirAluno()
    {
        Console.WriteLine("\nNome do aluno: " + this.nome);
        Console.WriteLine("Nota do aluno: " + this.nota);
    }
	
}
				
class Program{
	public static void Main(){
        Aluno a1 = new Aluno("José", 7.0);
        Aluno a2 = new Aluno("Maria", 8.0);

        a1.setNota(9.0);

        a1.exibirAluno();
        a2.exibirAluno();
	}
}