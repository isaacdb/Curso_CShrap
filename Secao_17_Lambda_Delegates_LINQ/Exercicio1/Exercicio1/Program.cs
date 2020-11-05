using Exercicio1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path:");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    decimal price = decimal.Parse(line[1], CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));
                }
            }
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0M).Average();//Select busca somente os valroes
                                                                               //Average faz a soma
                                                                               //DefaultIfEmpty asegura que nao dara erro de sem valor
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            //busca os dados com preco menos que a media
            //os ordena por ordem de nome
            //e seleciona o retorno somente do nome
            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
           foreach(string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
