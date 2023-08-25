using Exercicio_Fixação_Interface.Entities;
using Exercicio_Fixação_Interface.Services;
using System;
using System.Globalization;

namespace Exercicio_Fixação_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract Value: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contrato contrato = new Contrato(num, date, valor);

            Console.Write("Enter number of installments: ");
            int parce = int.Parse(Console.ReadLine());

            ProcessarParcela processarParcela = new ProcessarParcela(new TaxPayPal(), contrato);
            processarParcela.Processar(contrato, parce);

            Console.WriteLine();
            Console.WriteLine("Installments: ");
            foreach(Parcela par in contrato.parcelas)
            {
                Console.WriteLine(par.ToString());
            }


        }
    }
}

