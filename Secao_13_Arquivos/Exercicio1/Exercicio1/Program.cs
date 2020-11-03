using Exercicio1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\CursoCSharp\Curso_CShrap\Secao_13_Arquivos\Repository";

            try
            {

                string[] lines = File.ReadAllLines(path + @"\file.csv");

                Directory.CreateDirectory(path + @"\out");

                using (StreamWriter sw = File.AppendText(path + @"\out\summary.csv"))
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] itemData = lines[i].Split(',');

                        string name = itemData[0];
                        decimal value = decimal.Parse(itemData[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(itemData[2]);

                        Product prod = new Product(name, value, quantity);

                        sw.WriteLine(prod);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An Error ocurred: " + e.Message);
            }
        }
    }
}
