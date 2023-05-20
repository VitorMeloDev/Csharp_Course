using System;
using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public int NumeroConta {get; private set;}
        public string Nome {get; set;}
        public double Saldo {get; private set;}

        public Conta(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public Conta(int numeroConta, string nome, double saldo) : this(numeroConta, nome)
        { 
            Saldo = saldo;
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public void Sacar(double saque)
        {
            Saldo -= saque + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
