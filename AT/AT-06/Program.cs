namespace AT_06;

using System;
public class Aluno
{
    // Propriedades da classe Aluno
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public string Curso { get; set; }
    public double MediaNotas { get; set; }

    // Método para exibir os dados do aluno
    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Curso: {Curso}");
        Console.WriteLine($"Média das Notas: {MediaNotas}");
    }

    // Método para verificar se o aluno está aprovado ou reprovado
    public string VerificarAprovacao()
    {
        // Retorna "Aprovado" se a média for maior ou igual a 7, senão retorna "Reprovado"
        return MediaNotas >= 7 ? "Aprovado" : "Reprovado";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Cria um objeto da classe Aluno com dados de exemplo
        Aluno aluno = new Aluno
        {
            Nome = "Filie",
            Matricula = "111.111.111-11",
            Curso = "Engenharia de software",
            MediaNotas = 8.5
        };

        // Chama o método ExibirDados() para mostrar os dados do aluno
        aluno.ExibirDados();

        // Chama o método VerificarAprovacao() para obter a situação do aluno e exibe no console
        Console.WriteLine($"Situação: {aluno.VerificarAprovacao()}");
    }
}