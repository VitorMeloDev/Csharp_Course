using System;
using System.Globalization;

class Funcionario
{
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido()
    {
        return SalarioBruto - Imposto;
    }

    public void AumentarSalario( double porcentagem)
    {
        SalarioBruto += SalarioBruto / 100 * porcentagem;
    }

    public override string ToString()
    {
        return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
    }
}


