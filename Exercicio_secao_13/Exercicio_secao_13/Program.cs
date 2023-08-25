using System;
using System.Globalization;
using System.IO;
using Exercicio_secao_13.Entities;

namespace Exercicio_secao_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aqui esta o caminho até o arquivo
            string path = @"C:\Users\User\Documents\Projects\C#\Exercicio_secao_13\ItensVendidos.txt";

            try
            {
                // Aqui eu leio o arquivo e o armazeno em um array, cada array tem uma linha do arquivo
                string[] content = File.ReadAllLines(path);

                // Coloquei o destino da nova pasta, e do novo arquivo
                string dirDestino = @"C:\Users\User\Documents\Projects\C#\Exercicio_secao_13\out";
                string fileDestino = @"C:\Users\User\Documents\Projects\C#\Exercicio_secao_13\out\Summary.csv";

                //Criei a nova pasta com o endereco fornecido antes
                Directory.CreateDirectory(dirDestino);


                // Aqui irei escrever o novo arquivo, mesmo ele nao existindo, um sera criado
                using (StreamWriter sr = File.AppendText(fileDestino))
                {
                    // Eu corro pelo array que criei para ler o arquivo, repito, cada linha tem um array
                    foreach (string line in content)
                    {
                        // Crio um novo array, que irá separar os textos pelas virgulas
                        string[] info = line.Split(',');

                        // Aqui crio novas variaveis para guardar as informacoes
                        string name = info[0];
                        double price = double.Parse(info[1], CultureInfo.InvariantCulture);
                        int qtd = int.Parse(info[2]);

                        // Passo as informações para a Classe criada por mim
                        Produto prod = new Produto(name, price, qtd);
                        
                        // Escrevo as informacoes de acordo com as orientacoes passadas
                        sr.WriteLine(prod.Name + ", " + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
                
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}

