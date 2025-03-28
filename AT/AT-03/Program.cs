namespace AT_03;

using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        double num1, num2, result = 0;
        int operation;

        // Primeiro número do usuário.
        Console.Write("Digite o primeiro número: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Entrada inválida. Digite um número válido.");
            Console.Write("Digite o primeiro número: ");
        }

        // Segundo número do usuário.
        Console.Write("Digite o segundo número: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Entrada inválida. Digite um número válido.");
            Console.Write("Digite o segundo número: ");
        }

        // Menu de escolha de operação.
        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1. Soma");
        Console.WriteLine("2. Subtração");
        Console.WriteLine("3. Multiplicação");
        Console.WriteLine("4. Divisão");

        while (!int.TryParse(Console.ReadLine(), out operation) || operation < 1 || operation > 4)
        {
            Console.WriteLine("Operação inválida. Digite um número entre 1 e 4.");
            Console.WriteLine("Escolha a operação:");
        }

        // Realiza a operação escolhida.
        switch (operation)
        {
            case 1:
                result = num1 + num2;
                break;
            case 2:
                result = num1 - num2;
                break;
            case 3:
                result = num1 * num2;
                break;
            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Erro: divisão por zero!");
                    return; // Sai do programa em caso de divisão por zero.
                }
                break;
        }

        // Exibe o resultado.
        Console.WriteLine($"Resultado: {result}");
    }
}