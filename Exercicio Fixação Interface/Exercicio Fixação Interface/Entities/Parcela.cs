using System.Globalization;
namespace Exercicio_Fixação_Interface.Entities
{
    class Parcela
    {
        public int numeroParcela { get; set; }
        public double valorParcela { get; set; }
        public DateTime dataCobranca { get; set; }

        public Parcela(int parcela, double valor, DateTime data)
        {
            numeroParcela = parcela;
            valorParcela = valor;
            dataCobranca = data;
        }

        public override string ToString()
        {
            return numeroParcela + " - " 
                + dataCobranca.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) 
                + " - " + valorParcela.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
