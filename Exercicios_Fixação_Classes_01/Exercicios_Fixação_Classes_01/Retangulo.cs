using System;

class Retangulo
{
    public double altura;
    public double largura;

    public double Area()
    {
        return altura * largura;
    }

    public double Perimetro()
    {
        return (altura + largura) * 2;
    }

    public double Diagonal()
    {
        return Math.Sqrt(largura * largura + altura * altura);
    }
}

