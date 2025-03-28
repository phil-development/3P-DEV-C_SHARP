namespace AT_04;

using System;

public class NextBirthday
{
    public static void Main(string[] args)
    {
        DateTime birthDate;

        Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");

        while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out birthDate))
        {
            Console.WriteLine("Data inválida. Digite novamente no formato dd/mm/aaaa.");
            Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
        }

        DateTime today = DateTime.Today;
        DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);

        if (nextBirthday < today)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }

        TimeSpan difference = nextBirthday - today;
        int remainingDays = difference.Days;

        Console.WriteLine($"Faltam {remainingDays} dias para o seu próximo aniversário.");

        if (remainingDays < 7)
        {
            Console.WriteLine("Seu aniversário está chegando!");
        }
    }
}