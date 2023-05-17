using Exercicio_Classes_02;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double media;

        Funcionario x, y;
        x = new Funcionario();
        y = new Funcionario();


        Console.WriteLine("Dados do primeiro Funcionario: ");
        Console.Write("Nome: ");
        x.nome = Console.ReadLine();
        Console.Write("Salario: ");
        x.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Dados do segundo Funcionario: ");
        Console.Write("Nome: ");
        y.nome = Console.ReadLine();
        Console.Write("Salario: ");
        y.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = (x.salario + y.salario) / 2;

        Console.WriteLine("Salario médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
    }
}