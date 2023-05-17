using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotacao, dolares, reais;

            Console.Write("Qual a cotação do dolar? ");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares voce vai comprar? ");
            dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            reais = ConversorDeMoeda.ValorReais(cotacao,dolares);

            Console.WriteLine();
            Console.WriteLine("Valor a ser pago em reais = " + reais.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}