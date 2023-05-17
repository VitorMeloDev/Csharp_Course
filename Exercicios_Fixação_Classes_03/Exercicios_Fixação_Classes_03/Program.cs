using System;
using System.Globalization;

class Program
{ 
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        Console.Write("Nome do Aluno: ");
        aluno.nome = Console.ReadLine();
        Console.WriteLine("Digite as tres notas do aluno: ");
        aluno.nota1 = double.Parse(Console.ReadLine());
        aluno.nota2 = double.Parse(Console.ReadLine());
        aluno.nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Nota final = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

        if (aluno.NotaFinal() < 60)
        {
            Console.WriteLine("Reprovado");
            double faltante = 60 - aluno.NotaFinal();
            Console.WriteLine("Faltaram " + faltante.ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
        }
        else
        {
            Console.WriteLine("Aprovado");
        }
    }
}
