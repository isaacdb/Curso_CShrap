using Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.IO;
namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();


            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime date = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, date));
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("Total users: "+set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
