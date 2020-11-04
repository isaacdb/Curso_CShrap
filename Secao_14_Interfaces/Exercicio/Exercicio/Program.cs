using Exercicio.Entities;
using Exercicio.Services;
using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int code = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            decimal value = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter number of parcels: ");
            int quantityParcels = int.Parse(Console.ReadLine());

            Contract contract = new Contract(code, date, value, quantityParcels);
            ProcessContract processContract = new ProcessContract(new PayPal());
            processContract.GenerateParcels(contract);

            Console.WriteLine("Parcels: ");
            foreach(Parcel p in contract.Parcels)
            {
                Console.WriteLine(p);
            }




        }
    }
}
