using System;
using System.Collections.Generic;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> students = new HashSet<int>();
            
            Console.Write("How many students for course A? ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                students.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course B? ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                students.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course C? ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                students.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Total students: " + students.Count);
        }
    }
}
