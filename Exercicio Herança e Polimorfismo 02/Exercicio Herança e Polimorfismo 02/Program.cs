using System;
using System.Globalization;
using System.Security.Principal;
using Entities;

class Program
{
    static void Main(string[] args)
    {
        List<TaxPayer> list = new List<TaxPayer>();
        double total = 0;


        Console.Write("Enter the number of tax payers: ");
        int t = int.Parse(Console.ReadLine());

        Console.WriteLine();

        for (int i = 1; i <= t; i++)
        {
            Console.WriteLine("Tax Payer #" + i + "data: ");
            Console.Write("Individual or company (i/c)? ");
            char temp = char.Parse(Console.ReadLine());

            if (temp == 'i' ||  temp == 'I')
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Health Expenditures: ");
                double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Individual(name, income, health));
            }
            else if(temp == 'c' || temp == 'C')
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Number Employees: ");
                int cont = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Companies(name, income, cont));
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("TAXES PAID: ");

        foreach(TaxPayer payer in list)
        {
            Console.WriteLine(payer.Name + " $ " + payer.TaxAmount().ToString("F2",CultureInfo.InvariantCulture));
            total += payer.TaxAmount();
        }

        Console.WriteLine();
        Console.WriteLine("TOTAL TAXES: $ " + total.ToString("F2",CultureInfo.InvariantCulture));
    }
}
