class Program
{
    static void Main()
    {
        List<Forma> formas = new List<Forma>
        {
            new Circulo(5),
            new Quadrado(4),
            new Triangulo(3, 6)
        };

        foreach (Forma forma in formas)
        {
            Console.WriteLine($"Área da forma: {forma.CalcularÁrea()}");
        }
    }
}

class Forma
{
    public virtual double CalcularÁrea()
    {
        return 0;
    }
}

class Circulo : Forma
{
    private double raio;

    public Circulo(double raio)
    {
        this.raio = raio;
    }

    public override double CalcularÁrea()
    {
        return Math.PI * raio * raio;
    }
}

class Quadrado : Forma
{
    private double lado;

    public Quadrado(double lado)
    {
        this.lado = lado;
    }

    public override double CalcularÁrea()
    {
        return lado * lado;
    }
}

class Triangulo : Forma
{
    private double baseTriangulo;
    private double altura;

    public Triangulo(double baseTriangulo, double altura)
    {
        this.baseTriangulo = baseTriangulo;
        this.altura = altura;
    }

    public override double CalcularÁrea()
    {
        return (baseTriangulo * altura) / 2;
    }
}
