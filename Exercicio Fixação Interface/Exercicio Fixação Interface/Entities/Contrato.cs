namespace Exercicio_Fixação_Interface.Entities
{
    class Contrato
    {
        public int numero { get; set; }
        public DateTime dataContrato { get; set; }
        public double valorTotal { get; set; }
        public List<Parcela> parcelas { get; private set; }

        public Contrato(int num, DateTime data, double valor) 
        { 
            numero = num;
            dataContrato = data;
            valorTotal = valor;
            parcelas = new List<Parcela>();
        }

        public void AdicionaParcela(Parcela parcela)
        {
            parcelas.Add(parcela);
        }
    }
}
