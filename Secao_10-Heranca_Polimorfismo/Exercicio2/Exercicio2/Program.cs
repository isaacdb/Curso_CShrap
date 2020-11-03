using Exercicio2.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i) ?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                float price = float.Parse(Console.ReadLine());

                if (ch == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    float customFee = float.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customFee));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else {
                    Console.WriteLine("Você não inseriu um tipo existente de item.");
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}
