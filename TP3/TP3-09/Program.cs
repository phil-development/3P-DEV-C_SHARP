namespace TP3_09;

public class Program
{
    public static void Main(string[] args)
    {

        Matricula matricula = new Matricula();

        matricula.NomeDoAluno = "João da Silva";
        matricula.Curso = "Ciência da Computação";
        matricula.NumeroMatricula = 12345;
        matricula.DataInicial = "2023-08-01";
        matricula.Situacao = "Ativa";

        Console.WriteLine("Informações iniciais da matrícula:");
        matricula.ExibirInformacoes();

        matricula.Trancar();

        Console.WriteLine("\nInformações após trancar a matrícula:");
        matricula.ExibirInformacoes();

        matricula.Reativar();

        Console.WriteLine("\nInformações após reativar a matrícula:");
        matricula.ExibirInformacoes();
    }
}

public class Matricula
{
    public string NomeDoAluno;
    public string Curso;
    public int NumeroMatricula;
    public string Situacao;
    public string DataInicial;

    public void Trancar()
    {
        Situacao = "Trancada";
    }

    public void Reativar()
    {
        Situacao = "Ativa";
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do Aluno: {NomeDoAluno}");
        Console.WriteLine($"Curso: {Curso}");
        Console.WriteLine($"Número da Matrícula: {NumeroMatricula}");
        Console.WriteLine($"Situação: {Situacao}");
        Console.WriteLine($"Data Inicial: {DataInicial}");
    }
}