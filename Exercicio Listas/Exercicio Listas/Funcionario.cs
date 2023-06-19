using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Listas
{
    class Funcionario
    {
        public int id;
        private string nome;
        private double salario;

        public Funcionario(int _id, string _nome, double _salario) 
        { 
            id = _id; nome = _nome; salario = _salario;
        }

        public double Aumento(double porcentagem)
        {
            double antigoSalario = salario;
            salario = antigoSalario / 100 * porcentagem + salario;
            return salario;
        }

        public override string ToString() 
        {
            return id +", " + nome + ", " + salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    
}
