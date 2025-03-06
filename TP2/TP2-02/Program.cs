using System;
using System.Globalization;

namespace TP2_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite sua data de nascimento (DD/MM/AAAA): ");
                string dateBirthString = Console.ReadLine();

                CultureInfo BR = new CultureInfo("pt-BR");
                DateTime dateBirth = DateTime.Parse(dateBirthString, BR);

                DateTime today = DateTime.Today;

                DateTime nextBirthday = new DateTime(today.Year, dateBirth.Month, dateBirth.Day);

                if (nextBirthday < today)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }

                TimeSpan difference = nextBirthday - today;
                int daysRemaining = (int)difference.TotalDays;

                Console.WriteLine($"Faltam {daysRemaining} dias para o seu próximo aniversário.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de data inválido. Use DD/MM/AAAA.");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Ocorreu um erro: {error.Message}");
            }

        }

    }
}