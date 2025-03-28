using System;

public class GraduationCountdown
{
    public static void Main(string[] args)
    {
        DateTime graduationDate = new DateTime(2026, 12, 15);

        Console.Write("Digite a data atual (dd/MM/yyyy): ");
        DateTime currentDate;

        while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out currentDate))
        {
            Console.WriteLine("Erro: Data inválida. Tente novamente.");
            Console.Write("Digite a data atual (dd/MM/yyyy): ");
        }

        if (currentDate > DateTime.Today)
        {
            Console.WriteLine("Erro: A data informada não pode ser no futuro!");
            return;
        }

        int years = 0, months = 0, days = 0;

        if (graduationDate > currentDate)
        {
            DateTime tempDate = currentDate;

            while (tempDate.AddYears(1) <= graduationDate)
            {
                years++;
                tempDate = tempDate.AddYears(1);
            }

            while (tempDate.AddMonths(1) <= graduationDate)
            {
                months++;
                tempDate = tempDate.AddMonths(1);
            }

            days = (graduationDate - tempDate).Days;
        }
        else if (graduationDate < currentDate)
        {
            Console.WriteLine("Parabéns! Você já deveria estar formado!");
            return;
        }

        Console.WriteLine($"Faltam {years} anos, {months} meses e {days} dias para sua formatura!");

        if ((graduationDate - currentDate).TotalDays < 183)
        {
            Console.WriteLine($"Faltam {months} meses e {days} dias para sua formatura!");
            Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
        }
    }
}