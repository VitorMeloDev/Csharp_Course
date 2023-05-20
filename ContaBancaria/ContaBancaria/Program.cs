using ContaBancaria;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Banco
{
    class Program
    {
        static void Main(string[] args) 
        {
            Conta conta;

            Console.Write("Entre o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)? ");
            char sn = char.Parse(Console.ReadLine());

            if(sn == 's' || sn == 'S')
            {
                Console.Write("Entre o valor do deposito inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numConta,nome,valor);
            }
            else
            {
                conta = new Conta(numConta, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


        }
    }
}