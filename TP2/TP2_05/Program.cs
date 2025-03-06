using System;

namespace TP2_05;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite a temperatura em graus Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = celsius * 9 / 5 + 32;

            double kelvin = celsius + 273.15;

            Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit:F2}");
            Console.WriteLine($"Temperatura em Kelvin: {kelvin:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Digite um número.");
        }
        catch (Exception error)
        {
            Console.WriteLine($"Ocorreu um erro: {error.Message}");
        }
    }
}