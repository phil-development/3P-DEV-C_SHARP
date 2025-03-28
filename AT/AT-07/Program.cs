namespace AT_07;

using System;

public class ContaBancaria
{
    public string Titular { get; set; }

    private decimal saldo;

    // Método para realizar um depósito na conta.
    public void Depositar(decimal valor)
    {
        // Verifica se o valor do depósito é positivo.
        if (valor > 0)
        {
            // Adiciona o valor ao saldo existente.
            saldo += valor;
            // Exibe uma mensagem de sucesso, formatando o valor como moeda.
            Console.WriteLine($"Depósito de R$ {valor:N2} realizado com sucesso!");
        }
        else
        {
            // Exibe uma mensagem de erro se o valor do depósito for negativo ou zero.
            Console.WriteLine("O valor do depósito deve ser positivo!");
        }
    }

    // Método para realizar um saque da conta.
    public void Sacar(decimal valor)
    {
        // Verifica se o saldo é suficiente para o saque.
        if (valor <= saldo)
        {
            // Subtrai o valor do saque do saldo existente.
            saldo -= valor;
            // Exibe uma mensagem de sucesso, formatando o valor como moeda.
            Console.WriteLine($"Saque de R$ {valor:N2} realizado com sucesso!");
        }
        else
        {
            // Exibe uma mensagem de erro se o saldo for insuficiente.
            Console.WriteLine("Saldo insuficiente para realizar o saque!");
        }
    }

    // Método para exibir o saldo atual da conta.
    public void ExibirSaldo()
    {
        // Exibe o saldo atual, formatando como moeda.
        Console.WriteLine($"Saldo atual: R$ {saldo:N2}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Cria um objeto ContaBancaria com o nome do titular.
        ContaBancaria conta = new ContaBancaria
        {
            Titular = "João Silva"
        };

        // Realiza um depósito de R$ 500.00.
        conta.Depositar(500.00m);
        // Exibe o saldo atual.
        conta.ExibirSaldo();

        // Tenta realizar um saque de R$ 700.00 (saldo insuficiente).
        conta.Sacar(700.00m);

        // Realiza um saque de R$ 200.00.
        conta.Sacar(200.00m);
        // Exibe o saldo atual após o saque.
        conta.ExibirSaldo();
    }
}