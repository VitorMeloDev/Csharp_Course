
namespace Course
{
    internal class ConversorDeMoeda
    {
        static double reais;

        public static double ValorReais(double cotacao, double dolares)
        {
            reais = dolares * cotacao;
            reais = reais / 100 * 106;

            return reais;
        }
    }
}
