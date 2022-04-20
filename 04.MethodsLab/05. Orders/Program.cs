using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            Product(product);
        }
        static void Product(string product)
        {
            int quantity = int.Parse(Console.ReadLine());
            double sum = 0;
            if (product == "coffee")
            {

                sum = quantity * 1.50;
            }
            else if (product == "water")
            {
                sum = quantity * 1.00;
            }
            else if (product == "coke")
            {
                sum = quantity * 1.40;
            }
            else if (product == "snacks")
            {
                sum = quantity * 2.00;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
