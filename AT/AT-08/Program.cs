using System;

// Classe base Funcionario
public class Funcionario
{
    // Propriedades do funcionário
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public double SalarioBase { get; set; }

    // Construtor da classe Funcionario
    public Funcionario(string nome, string cargo, double salarioBase)
    {
        Nome = nome;
        Cargo = cargo;
        SalarioBase = salarioBase;
    }

    // Método virtual para calcular o salário (pode ser sobrescrito em subclasses)
    public virtual double CalcularSalario()
    {
        return SalarioBase;
    }

    // Método para exibir os dados do funcionário
    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salário: R$ {CalcularSalario():N2}");
    }
}

// Subclasse Gerente, que herda de Funcionario
public class Gerente : Funcionario
{
    // Construtor da classe Gerente, chamando o construtor da classe base
    public Gerente(string nome, string cargo, double salarioBase) : base(nome, cargo, salarioBase) { }

    // Sobrescrita do método CalcularSalario para incluir o bônus de 20%
    public override double CalcularSalario()
    {
        return SalarioBase * 1.20; // 20% de bônus
    }
}

// Classe principal do programa
public class Program
{
    public static void Main(string[] args)
    {
        // Cria um objeto Funcionario
        Funcionario funcionario = new Funcionario("João da Silva", "Analista", 3000.00);
        // Cria um objeto Gerente
        Gerente gerente = new Gerente("Maria Souza", "Gerente de Projetos", 5000.00);

        // Exibe os dados do funcionário
        Console.WriteLine("Dados do Funcionário:");
        funcionario.ExibirDados();

        // Exibe os dados do gerente
        Console.WriteLine("\nDados do Gerente:");
        gerente.ExibirDados();
    }
}