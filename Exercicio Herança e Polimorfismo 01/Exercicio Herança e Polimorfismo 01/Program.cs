using Entities;
using System.Globalization;

class Program
{

    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        Console.Write("Enter the number of products: ");
        int t = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int x = 1; x <= t ; x++)
        {
            Console.WriteLine("Product #" + x + " data: ");
            Console.Write("Common, used, or imported (c/u/i)? ");
            char state = char.Parse(Console.ReadLine());

            switch (state) 
            {
                case 'c' or 'C':
                    Console.Write("Name: ");
                    string nameC = Console.ReadLine();
                    Console.Write("Price: ");
                    double priceC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Product(nameC, priceC));
                    break;

                case 'u' or 'U':
                    Console.Write("Name: ");
                    string nameU = Console.ReadLine();
                    Console.Write("Price: ");
                    double priceU = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    string date = Console.ReadLine();
                    list.Add(new UsedProduct(nameU, priceU, DateTime.Parse(date)));

                    break;

                case 'i' or 'I':
                    Console.Write("Name: ");
                    string nameI = Console.ReadLine();
                    Console.Write("Price: ");
                    double priceI = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Customs Fee: ");
                    double cf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(nameI, priceI, cf));
                    break;

                default:
                    Console.WriteLine("Erro: Dado Invalido");
                    break;
            }

            Console.WriteLine();
        }

        foreach (Product item in list)
        {
            Console.WriteLine(item.PriceTag());
            Console.WriteLine();
        }
    }
}