using Exercicio1.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n) ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                float valuePerHour = float.Parse(Console.ReadLine());

                if (ch == 'y') {
                    Console.Write("Additional charge: ");
                    float additionalCharge = float.Parse(Console.ReadLine());
                    list.Add(new OutsourceEmployee(additionalCharge, name, hours, valuePerHour));

                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("PAYMENTS: ");

            foreach (Employee emp in list) {
                Console.WriteLine(emp.Name+" - $"+emp.Payment());
            }

        }
    }
}
