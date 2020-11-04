using System;
using System.Collections.Generic;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many courses do you have? ");
            int c = int.Parse(Console.ReadLine());
            HashSet<int> set = new HashSet<int>();
            for (int j = 1; j <= c; j++)
            {
                Console.WriteLine($"How many students for couse {j}? ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    int codStudent = int.Parse(Console.ReadLine());
                    set.Add(codStudent);
                }
            }
            Console.WriteLine("Total students: "+set.Count);
        }
    }
}
