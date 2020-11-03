using Exercicio2Enum.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2Enum.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem itemToAdd)
        {
            OrderItems.Add(itemToAdd);
        }
        public void RemoveItem(OrderItem itemToRemove) {
            OrderItems.Remove(itemToRemove);
        }
        public float Total() {
            float Total = 0;
            foreach(OrderItem item in OrderItems)
            {
                Total += item.SubTotal();
            }
            return Total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Order moment: {Date}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine("Order items:");
            foreach(OrderItem item in OrderItems)
            {
                sb.AppendLine("Item: "+item);
            }
            sb.AppendLine("Total price: $"+Total());

            return sb.ToString();
        }
    }
}
