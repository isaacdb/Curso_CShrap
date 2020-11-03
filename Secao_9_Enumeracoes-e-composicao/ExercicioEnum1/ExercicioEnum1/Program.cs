using ExercicioEnum1.Entities;
using ExercicioEnum1.Entities.Enums;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace ExercicioEnum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            DateTime date = DateTime.Now;
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            //string level = Console.ReadLine();
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            float baseSalary = float.Parse(Console.ReadLine());
            Console.Write("How manu contracts to this worker? ");
            int quantContracts = int.Parse(Console.ReadLine());

            Worker worker = new Worker(deptName,level,baseSalary);
            
            if (quantContracts > 0)
            {
                for (int i = 0; i < quantContracts; i++)
                {
                    Console.WriteLine($"Enter #{(i+1)} contract data:");
                    Console.Write("Date (DD/MM/YYYY): ");
                    DateTime contractDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("value per hour: ");
                    float valuePerHour = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Duration (hours): ");
                    float hours = float.Parse(Console.ReadLine());

                    HourContract contract = new HourContract(contractDate,valuePerHour,hours);
                    worker.AddContract(contract);
                }
            }
            Console.Write("Enter month and yaer to calculate income (MM/YYYY): ");
            string[] monthYear = Console.ReadLine().Split('/');
            int month = int.Parse(monthYear[0]);
            int year = int.Parse(monthYear[1]);
            Console.WriteLine(worker);
            Console.WriteLine($"Income for {month}/{year} : {worker.Income(month,year)}");

        }
    }
}
