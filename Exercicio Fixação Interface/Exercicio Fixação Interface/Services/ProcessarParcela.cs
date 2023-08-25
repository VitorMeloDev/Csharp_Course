using Exercicio_Fixação_Interface.Entities;
using System;
using System.Diagnostics;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicio_Fixação_Interface.Services
{
    class ProcessarParcela
    {
        public ITaxParcela taxParcela;
        public Contrato contrato;

        public ProcessarParcela(ITaxParcela taxParcela, Contrato contrato)
        {
            this.taxParcela = taxParcela;
            this.contrato = contrato;
        }

        public void Processar(Contrato contrato, int qtdParcelas)
        {
            for (int i = 1; i <= qtdParcelas; i++)
            {
                double valorParce = contrato.valorTotal / qtdParcelas;
                DateTime dateParce = contrato.dataContrato.AddMonths(i);

                double x = taxParcela.TaxaJuros(valorParce, i);
                valorParce += x;
                double y = taxParcela.TaxaPagamento(valorParce);
                valorParce += y;

                Parcela novaParcela = new Parcela(i, valorParce, dateParce);
                contrato.AdicionaParcela(novaParcela);
            }
        }
    }
}
