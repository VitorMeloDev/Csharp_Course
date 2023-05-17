using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario();

        Console.Write("Nome: ");
        funcionario.Nome = Console.ReadLine();
        Console.Write("Salario Bruto: ");
        funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto: ");
        funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Funcionario: " + funcionario);

        Console.WriteLine();
        Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
        double porc = double.Parse(Console.ReadLine());
        funcionario.AumentarSalario(porc);

        Console.WriteLine("Funcionario: " + funcionario);

    }
}