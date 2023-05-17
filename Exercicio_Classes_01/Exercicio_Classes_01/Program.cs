using Exercicio_Classes_01;
using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        Pessoa x, y;
        x = new Pessoa();
        y = new Pessoa();

        Console.WriteLine("Dados da primeira pessoa: ");
        Console.Write("Nome: ");
        x.nome = Console.ReadLine();
        Console.Write("Idade: ");
        x.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Dados da primeira pessoa: ");
        Console.Write("Nome: ");
        y.nome = Console.ReadLine();
        Console.Write("Idade: ");
        x.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        if(x.idade < y.idade) 
        {
            Console.WriteLine("Pessoa mais velha: " + y.nome);
        }
        else
        {
            Console.WriteLine("Pessoa mais velha: " + x.nome);
        }
    }

}

