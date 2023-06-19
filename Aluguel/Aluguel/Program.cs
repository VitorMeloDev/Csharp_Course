using System;
using System.Globalization;

namespace Aluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] hospede = new Estudante[9]; 
            int quarto;

            Console.Write("Quantos quartos serão alugados? ");
            quarto = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < quarto; i++)
            {
                int aluguel = i+1;
                Console.WriteLine("Aluguel #" + aluguel + ": ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numQuarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                hospede[numQuarto] = new Estudante(nome, email);
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0;i < hospede.Length;i++) 
            {
                if (hospede[i] !=  null) 
                {
                    Console.WriteLine(i + ": " + hospede[i].Nome + ", " + hospede[i].Email);
                }
            }
        }
    }
}