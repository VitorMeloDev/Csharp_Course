using Exercicio_Fixação_Excecoes.Entities;
using Exercicio_Fixação_Excecoes.Entities.Exceptions;
using System;
using System.Globalization;

namespace Exercicio_Fixação_Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string hol = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double bal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("WithDraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(num, hol, bal, limit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double draw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.WithDraw(draw);
                Console.WriteLine("New Balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (DomainException d)
            {
                Console.WriteLine("Error in procedure: " + d.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
            
        }
    }

}
