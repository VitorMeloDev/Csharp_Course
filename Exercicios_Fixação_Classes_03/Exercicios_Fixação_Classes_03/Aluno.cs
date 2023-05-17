using System;


class Aluno
{
    public string nome;
    public double nota1;
    public double nota2;
    public double nota3;

    public double NotaFinal()
    {
        return nota1 + nota2 + nota3;
    }
}

