using Exercicio1.Entities;
using Exercicio1.Exceptions;
using System;
using System.Reflection.Metadata;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial balance: ");
                decimal initialBalance = decimal.Parse(Console.ReadLine());
                Console.Write("Withdraw limit : ");
                decimal withdrawLimit = decimal.Parse(Console.ReadLine());

                Account acc = new Account(number, name, initialBalance, withdrawLimit);

                Console.WriteLine();

                Console.Write("Enter amaunt for withdraw: ");
                decimal withdraw = decimal.Parse(Console.ReadLine());
                acc.Withdraw(withdraw);
                Console.WriteLine("New balance: " + acc.Balance);
            }
            catch (MyExceptions e)
            {
                Console.WriteLine("Withdraw error: "+e.Message);
            }
           catch(FormatException e)
            {
                Console.WriteLine("Format error: "+e.Message);
            }
        }
    }
}
