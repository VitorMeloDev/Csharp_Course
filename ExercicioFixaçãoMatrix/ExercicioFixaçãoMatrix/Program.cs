using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Passe um valor para linhas e outro para colunas: ");
        Console.Write("Linhas: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Colunas: ");
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[m,n];

        Console.WriteLine();
        Console.WriteLine("Escreva os valores dando espaçamento entre os numeros até ter o valor de linhas e colunas dada: ");

        for (int i = 0; i < m; i++) 
        {
            string[] nums = Console.ReadLine().Split(' ');

            for (int j = 0; j < n; j++)
            {
                mat[i,j] = int.Parse(nums[j]);
            }
        }

        Console.WriteLine();
        Console.Write("Digite o numero que você quer achar: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i,j] == x)
                {
                    Console.WriteLine("Position " + i + "," + j + ":");
                    
                    if (j > 0)
                    {
                        Console.WriteLine("Left: " + mat[i, j - 1]);
                    }
                    if (i > 0)
                    {
                        Console.WriteLine("Up: " + mat[i - 1, j]);
                    }
                    if (j < n - 1)
                    {
                        Console.WriteLine("Right: " + mat[i, j + 1]);
                    }
                    if (i < m - 1)
                    {
                        Console.WriteLine("Down: " + mat[i + 1, j]);
                    }
                    Console.WriteLine();
                }
            }
        }


    }
}