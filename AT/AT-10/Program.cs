namespace AT_10;

using System;

public class JogoAdivinhacao
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 51);
        int tentativas = 5;

        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
        Console.WriteLine("Tente adivinhar o número secreto (entre 1 e 50).");

        while (tentativas > 0)
        {
            Console.Write($"Tentativas restantes: {tentativas}\nDigite seu palpite: ");

            try
            {
                int palpite = int.Parse(Console.ReadLine());

                if (palpite < 1 || palpite > 50)
                {
                    Console.WriteLine("Erro: Digite um número entre 1 e 50.");
                    continue; // Pula para a próxima iteração do loop
                }

                if (palpite == numeroSecreto)
                {
                    Console.WriteLine($"Parabéns! Você adivinhou o número secreto ({numeroSecreto}).");
                    return;
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior.");
                }
                else
                {
                    Console.WriteLine("O número secreto é menor.");
                }

                tentativas--;
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Entrada inválida. Digite um número inteiro.");
            }
        }

        Console.WriteLine($"Você perdeu! O número secreto era {numeroSecreto}.");
    }
}