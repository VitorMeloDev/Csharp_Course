using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Fixação_Interface.Services
{
    class TaxPayPal : ITaxParcela
    {
        double taxJuros = 0.01;
        double taxPagamento = 0.02;

        public double TaxaJuros(double valorParcela, int parcela)
        {
            return valorParcela * taxJuros * parcela;
        }

        public double TaxaPagamento(double valor)
        {
            return valor * taxPagamento;
        }
    }
}
