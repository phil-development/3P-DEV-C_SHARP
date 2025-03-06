using System;

namespace TP2_07;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite um número inteiro: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"O número {number} é par.");
            }
            else
            {
                Console.WriteLine($"O número {number} é ímpar.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro.");
        }
        catch (Exception error)
        {
            Console.WriteLine($"Ocorreu um erro: {error.Message}");
        }
    }
}