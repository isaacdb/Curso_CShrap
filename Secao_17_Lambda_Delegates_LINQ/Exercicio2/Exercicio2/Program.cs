using Exercicio2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            List<Employee> emp = new List<Employee>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    string email = line[1];
                    decimal salary = decimal.Parse(line[2],CultureInfo.InvariantCulture);

                    emp.Add(new Employee(name, email, salary));
                }
            }
            Console.Write("Enter salary to filter: ");
            decimal valueToFilter = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine($"Email of people whose salary is more than ${valueToFilter.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            var emails = emp.Where(e => e.Salary >= valueToFilter).OrderByDescending(e=> e.Name).Select(e => e.Email);
            foreach(string e in emails)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            var sum = emp.Where(e => e.Name[0] == 'M').Select(e=>e.Salary).Aggregate(0.0M,(x ,y) => x +y);

            Console.WriteLine($"Sum of salary of people whose nome starts with 'M': ${sum.ToString("F2",CultureInfo.InvariantCulture)}");
            
        }

    }
}
