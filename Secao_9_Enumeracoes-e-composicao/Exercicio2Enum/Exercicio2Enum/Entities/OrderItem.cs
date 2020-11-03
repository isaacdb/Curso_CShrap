using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2Enum.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public float Price { get; set; }
        public Product Item { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, float price, Product item)
        {
            Quantity = quantity;
            Price = price;
            Item = item;
        }

        public float SubTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return Item + ", Quantity: " + Quantity + ", Subtotal: $" + SubTotal();
        }
    }
}
