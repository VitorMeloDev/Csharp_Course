using System;
using System.Globalization;

namespace Exercicio
{
    class Fixacao
    { 
        /*
        static void Main(string[] args)
        {
            
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine(produto2 + ", cujo preco é $ " + preco2);
            Console.WriteLine("Registro: {0} anos de idade, codigo {1} e genero: {2}", idade, codigo, genero);

            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondado: " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
            
        }
        */
    }

    class Fixacao2
    {
        static void Main(string[] args)
        {
            string nome;
            int quartos;
            double preco;
            string[] dados;
            string ultimoNome;
            int idade;
            double altura;



            Console.WriteLine("Entre com seu nome completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu ultimo nome, idade e altura (na mesma linha): ");
            dados = Console.ReadLine().Split(' ');

            ultimoNome = dados[0];
            idade = int.Parse(dados[1]);
            altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }




}