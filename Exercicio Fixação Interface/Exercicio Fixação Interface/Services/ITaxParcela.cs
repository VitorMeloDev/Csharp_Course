using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Fixação_Interface.Services
{
    interface ITaxParcela
    {
        double TaxaJuros(double valorParcela, int parcela);
        double TaxaPagamento(double valor); 
    }
}
