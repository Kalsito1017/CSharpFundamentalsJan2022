using System;
using System.Collections.Generic;

namespace _04._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orders = new Dictionary<string, double>();
            var newOrders = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "buy")
            {
                var token = input.Split();
                var product = token[0];
                double price = double.Parse(token[1]);
                int quantity = int.Parse(token[2]);

                if (!orders.ContainsKey(product))
                {
                    orders.Add(product, price);
                    newOrders.Add(product, quantity);
                }
                else if (orders.ContainsKey(product))
                {
                    orders.Remove(product);
                    orders.Add(product, price);
                    newOrders[product] += quantity;

                }
                input = Console.ReadLine();
            }
            foreach (var order in orders)
            {
                foreach (var newOrder in newOrders)
                {
                    if (order.Key == newOrder.Key)
                    {
                        Console.WriteLine($"{order.Key} -> {order.Value * newOrder.Value:f2}");

                    }
                }

            }
        }
    }
}
