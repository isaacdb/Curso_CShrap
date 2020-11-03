using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio1.Entities
{
    class Product
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal value, int quantity)
        {
            Name = name;
            Value = value;
            Quantity = quantity;
        }

        public decimal SubTotal()
        {
            return Value * Quantity;
        }

        public override string ToString()
        {
            return" "+ Name + ", $" + SubTotal().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
