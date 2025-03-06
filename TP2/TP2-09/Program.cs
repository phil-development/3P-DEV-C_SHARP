using System;

namespace TP2_09;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite o salário bruto: ");
            double grossSalary = double.Parse(Console.ReadLine());

            double INSSdiscount = CalculateINSS(grossSalary);
            double IRdiscount = CalculateIR(grossSalary);

            double netSalary = grossSalary - INSSdiscount - IRdiscount;

            Console.WriteLine($"\nSalário Bruto: R$ {grossSalary:F2}");
            Console.WriteLine($"Desconto INSS: R$ {INSSdiscount:F2}");
            Console.WriteLine($"Desconto IR: R$ {IRdiscount:F2}");
            Console.WriteLine($"Salário Líquido: R$ {netSalary:F2}");
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

    public static double CalculateINSS(double grossSalary)
    {
        if (grossSalary <= 1212.00)
        {
            return grossSalary * 0.075;
        }
        else if (grossSalary <= 2427.35)
        {
            return grossSalary * 0.09;
        }
        else if (grossSalary <= 3641.03)
        {
            return grossSalary * 0.12;
        }
        else if (grossSalary <= 7087.22)
        {
            return grossSalary * 0.14;
        }
        else
        {
            return 7087.22 * 0.14;
        }
    }

    public static double CalculateIR(double grossSalary)
    {
        double calculationBase = grossSalary - CalculateINSS(grossSalary);

        if (calculationBase <= 1903.98)
        {
            return 0;
        }
        else if (calculationBase <= 2826.65)
        {
            return (calculationBase * 0.075) - 142.80;
        }
        else if (calculationBase <= 3751.05)
        {
            return (calculationBase * 0.15) - 354.80;
        }
        else if (calculationBase <= 4664.68)
        {
            return (calculationBase * 0.225) - 636.13;
        }
        else
        {
            return (calculationBase * 0.275) - 869.36;
        }
    }

}