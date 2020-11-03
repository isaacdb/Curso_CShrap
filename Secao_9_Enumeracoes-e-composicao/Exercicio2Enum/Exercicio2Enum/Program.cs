using Exercicio2Enum.Entities;
using Exercicio2Enum.Entities.Enums;
using System;

namespace Exercicio2Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(clientName,clientEmail,clientBirthDate);

            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int quantityItems = int.Parse(Console.ReadLine());
            Console.WriteLine();
            DateTime date = DateTime.Now;

            Order order = new Order(date,status,client);

            for(int i = 0; i < quantityItems; i++)
            {
                Console.WriteLine($"Enter #{(i + 1)} item data:");
                Console.Write("Product name: ");
                string itemName = Console.ReadLine();
                Console.Write("Product price: ");
                float itemPrice = float.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int itemQuantity = int.Parse(Console.ReadLine());

                Product item = new Product(itemName,itemPrice);
                OrderItem orderItem = new OrderItem(itemQuantity,itemPrice,item);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine(order);
        }
    }
}
