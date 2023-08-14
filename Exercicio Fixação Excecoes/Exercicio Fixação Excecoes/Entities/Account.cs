using Exercicio_Fixação_Excecoes.Entities.Exceptions;
using System;
using System.Globalization;

namespace Exercicio_Fixação_Excecoes.Entities
{
    class Account
    {
        public int Number;
        public string Holder;
        public double Balance;
        public double WithDrawLimit;

        public Account() { }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public double Deposit(double deposit)
        {
            DepositException(deposit);
            Balance += deposit;
            return Balance;
        }

        public double WithDraw(double draw)
        {
            WithDrawException(draw);
            Balance -= draw;
            return Balance;
        }



        // Exceptions

        public void DepositException(double deposit)
        {
            if (deposit == 0)
            {
                throw new DomainException("Voce precisa colocar um valor para realizar o deposito");
            }
            else if (deposit < 0)
            {
                throw new DomainException("Valor para deposito INVALIDO");
            }
        }

        public void WithDrawException(double draw)
        {
            if (draw == 0)
            {
                throw new DomainException("Voce precisa colocar um valor para solicitar o saque");
            }

            if (draw > WithDrawLimit)
            {
                throw new DomainException("Valor para saque excede o limite de " + WithDrawLimit.ToString("F2", CultureInfo.InvariantCulture));
            }

            if (draw > Balance)
            {
                throw new DomainException("Sem saldo suficiente na conta para realizar operação");
            }
        }
    }
}
