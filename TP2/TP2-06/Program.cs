using System;

namespace TP2_06;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite seu peso em kg: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura em metros: ");
            double height = double.Parse(Console.ReadLine());

            double imc = weight / (height * height);

            string classification = Classification(imc);

            Console.WriteLine($"\nSeu IMC é: {imc:F2}");
            Console.WriteLine($"Classificação: {classification}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Digite números.");
        }
        catch (Exception error)
        {
            Console.WriteLine($"Ocorreu um erro: {error.Message}");
        }
    }

    public static string Classification(double imc)
    {
        if (imc < 18.5)
        {
            return "Abaixo do peso";
        }
        else if (imc < 25)
        {
            return "Peso normal";
        }
        else if (imc < 30)
        {
            return "Sobrepeso";
        }
        else if (imc < 35)
        {
            return "Obesidade grau 1";
        }
        else if (imc < 40)
        {
            return "Obesidade grau 2";
        }
        else
        {
            return "Obesidade grau 3";
        }
    }
}