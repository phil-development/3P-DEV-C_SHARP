using System;

namespace TP2_08;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite uma nota de 0 a 10: ");
            double grade = double.Parse(Console.ReadLine());

            string classification = Classification(grade);

            Console.WriteLine($"Classificação: {classification}");
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

    public static string Classification(double grade)
    {
        if (grade < 0 || grade > 10)
        {
            return "Nota inválida";
        }
        else if (grade < 5)
        {
            return "Insuficiente";
        }
        else if (grade < 7)
        {
            return "Regular";
        }
        else if (grade < 9)
        {
            return "Bom";
        }
        else
        {
            return "Excelente";
        }
    }
}