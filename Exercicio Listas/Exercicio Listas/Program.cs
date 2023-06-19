using Exercicio_Listas;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        bool result = false;
        double porcen;
        int regis;
        int idList;
        int id;
        string nome;
        double salario;

        List<Funcionario> listFun = new List<Funcionario>();

        Console.Write("How many employees will be registered? ");
        regis = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        for (int i = 0; i < regis; i++)
        {
            int cont = i + 1;
            Console.WriteLine("Emplyoee #" + cont);
            Console.Write("ID: ");
            id = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("NOME: ");
            nome = Console.ReadLine();
            Console.Write("SALARIO: ");
            salario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Funcionario funci = new Funcionario(id, nome, salario);
            listFun.Add(funci);
        }

        Console.Write("Enter the employee id that will have salary increase: ");
        idList = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        foreach (Funcionario item in listFun)
        {
            if (item.id == idList)
            {
                Console.Write("Enter the percentage: ");
                porcen = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                item.Aumento(porcen);
                result = true;
            }
        }

        if (result == false)
        {
            Console.WriteLine("This id does not exist!");
        }

        foreach (Funcionario item in listFun)
        {
            Console.WriteLine(item);
        }
    }
}