using System;
using System.IO;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter file full path: ");
        string path = Console.ReadLine();
        Dictionary<string, int> dic = new Dictionary<string, int>();

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    int value = int.Parse(line[1]);
                    if (dic.ContainsKey(name))
                    {
                        value += dic[name];
                        dic[name] = value;
                    }
                    else
                    {
                        dic[name] = value;
                    }
                }
            }

            Console.WriteLine("Total: ");
            foreach (var it in dic)
            {
                Console.WriteLine(it.Key + ": " + it.Value);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

    }
}