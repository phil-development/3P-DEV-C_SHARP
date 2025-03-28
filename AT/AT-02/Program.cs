namespace AT_02;

using System;

public class AlphabetShift
{
    public static string ShiftName(string name)
    {
        // Define arrays contendo os alfabetos minúsculo e maiúsculo.
        char[] alphabetLower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        char[] alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        // Converte o nome em um array para facilitar a manipulação.
        char[] nameArray = name.ToCharArray();

        // Loop passando por cada caractere no array de nomes.
        for (int i = 0; i < nameArray.Length; i++)
        {
            // Verifica se o caractere é uma letra.
            if (char.IsLetter(nameArray[i]))
            {
                // Inicializa o índice do alfabeto para -1 (não encontrado).
                int alphabetIndex = -1;
                // Determina qual array de alfabeto usar (minúsculo ou maiúsculo).
                char[] alphabet = char.IsLower(nameArray[i]) ? alphabetLower : alphabetUpper;

                // Encontra o índice do caractere atual no array de alfabeto.
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (nameArray[i] == alphabet[j])
                    {
                        alphabetIndex = j;
                        break;
                    }
                }

                // Se o caractere foi encontrado no alfabeto, desloca a posição.
                if (alphabetIndex != -1)
                {
                    // Calcula o novo índice deslocando 2 posições, fazendo o wrap-around usando o módulo.
                    int shiftedIndex = (alphabetIndex + 2) % 26;
                    // Substitui o caractere original pelo caractere deslocado.
                    nameArray[i] = alphabet[shiftedIndex];
                }
            }
        }

        // Converte o array de caracteres para uma string novamente.
        return new string(nameArray);
    }

    public static void Main(string[] args)
    {

        Console.Write("Digite seu nome completo: ");
        string name = Console.ReadLine();

        // Desloca os caracteres no nome usando a função ShiftName.
        string shiftedName = ShiftName(name);

        Console.WriteLine("Nome deslocado: " + shiftedName);
    }
}