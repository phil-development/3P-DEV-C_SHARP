using System;
using System.Globalization;

namespace TP2_03
{
    public class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                Console.Write("Digite a primeira data (DD/MM/AAAA): ");
                string firstDateString = Console.ReadLine();

                Console.Write("Digite a segunda data (DD/MM/AAAA): ");
                string secondDateString = Console.ReadLine();

                CultureInfo BR = new CultureInfo("pt-BR");

                DateTime fistDate = DateTime.Parse(firstDateString, BR);
                DateTime secondDate = DateTime.Parse(secondDateString, BR);

                if (secondDate < fistDate)
                {
                    DateTime temp = fistDate;
                    fistDate = secondDate;
                    secondDate = temp;
                }

                int years = secondDate.Year - fistDate.Year;
                int month = secondDate.Month - fistDate.Month;
                int days = secondDate.Day - fistDate.Day;

                if (days < 0)
                {
                    month--;
                    days += DateTime.DaysInMonth(secondDate.Year, secondDate.Month - 1);
                }

                if (month < 0)
                {
                    years--;
                    month += 12;
                }

                Console.WriteLine($"\nIntervalo: {years} anos, {month} meses e {days} dias.");
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