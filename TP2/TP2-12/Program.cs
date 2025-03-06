using System;

namespace TP2_12;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
            Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100.");

            while (guess != secretNumber)
            {
                Console.Write("Digite seu palpite: ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Palpite baixo. Tente novamente.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Palpite alto. Tente novamente.");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você adivinhou o número secreto ({secretNumber}) em {attempts} tentativas.");
                }
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