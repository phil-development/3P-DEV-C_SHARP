using System;
using System.Globalization;

namespace TP2_01
{
    public class Program
    {
        public static void Main(string[] args)
        {

            try
            {

                Console.Write("Insira sua data de nascimento (DD/MM/AAAA): ");
                string dateBirthString = Console.ReadLine();

                CultureInfo BR = new CultureInfo("pt-BR");

                DateTime today = DateTime.Today;
                DateTime dateBirth = DateTime.Parse(dateBirthString, BR);
                TimeSpan difference = today - dateBirth;

                int years = today.Year - dateBirth.Year;
                int months = today.Month - dateBirth.Month;
                int days = today.Day - dateBirth.Day;

                if (days < 0)
                {

                    months--;
                    days += DateTime.DaysInMonth(today.Year, today.Month - 1);

                }

                if (months < 0)
                {
                    years--;
                    months += 12;
                }

                Console.WriteLine($"Sua idade é: {years} anos, {months} meses e {days} dias.");

            }
            catch (FormatException)
            {

                Console.WriteLine("Formato de data inválido. Use DD/MM/AAAA");

            }
            catch (Exception error)
            {
                Console.WriteLine($"Ocorreu um erro: {error.Message}");
            }

        }

    }
}