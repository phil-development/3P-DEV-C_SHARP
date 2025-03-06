using System;

namespace TP2_10;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite um número inteiro: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i >= 0; i--)
            {
                Console.Write(i);
                if (i > 0)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
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