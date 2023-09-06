using System;
using System.IO;
using Exercício_proposto__Set_.Entities;


namespace Exercício_proposto__Set_
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>();

            try
            {
                for (int i = 1; i <= 3; i++)
                {
                    string course = "A";

                    switch (i)
                    {
                        case 1:
                            course = "A? ";
                            break;
                        case 2:
                            course = "B? ";
                            break;
                        case 3:
                            course = "C? ";
                            break;
                    }

                    Console.Write("How many students for course " + course);
                    int many = int.Parse(Console.ReadLine());

                    for (int n = 1; n <= many; n++)
                    {
                        int val = int.Parse(Console.ReadLine());
                        students.Add(new Student(val));
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Total students: " + students.Count);
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }
}