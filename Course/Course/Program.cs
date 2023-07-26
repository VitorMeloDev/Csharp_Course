using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args) 
        {
            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1.ToLongDateString());
        }
    }
}
