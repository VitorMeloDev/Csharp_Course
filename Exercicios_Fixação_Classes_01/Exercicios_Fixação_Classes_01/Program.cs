using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();

        Console.WriteLine("Entre a largura e altura do retangulo: ");
        retangulo.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        retangulo.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("AREA = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("PERIMETRO = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
    }
}
