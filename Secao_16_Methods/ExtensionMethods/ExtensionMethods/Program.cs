using ExtensionMethods.Extensions;
using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 11, 4, 15, 0, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning my old friend!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
