using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_secao_13.Entities
{
    class Produto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qtd { get; set; }

        public Produto(string name, double price, int qtd) 
        {
            Name = name;
            Price = price;
            Qtd = qtd;
        }

        public double Total()
        {
            return Price * Qtd;
        }
    }
}
