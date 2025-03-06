using System;
using System.Globalization;

namespace TP2_04;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        string name = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Digite seu telefone: ");
        string telephone = Console.ReadLine();

        Console.Write("Digite seu e-mail: ");
        string email = Console.ReadLine();

        Console.WriteLine("\nDados cadastrados:");
        Console.WriteLine($"Nome: {name}");
        Console.WriteLine($"Idade: {age}");
        Console.WriteLine($"Telefone: {telephone}");
        Console.WriteLine($"E-mail: {email}");
    }
}