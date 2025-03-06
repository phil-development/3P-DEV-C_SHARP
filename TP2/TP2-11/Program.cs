using System;

namespace TP2_11;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("De qual número deseja exibir a tabuda (1 - 10)?: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTabuada do {number}:");
            for (int i = 1; i <= 10; i++)
            {
                int resultado = number * i;
                Console.WriteLine($"{number} x {i} = {resultado}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}