using Exercicio3.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPlayer> list = new List<TaxPlayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Individual or company (i/c) ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                decimal anualIncome = decimal.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    decimal healthExpenditures = decimal.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(TaxPlayer taxP in list)
            {
                Console.WriteLine(taxP);
            }
        }
    }
}
