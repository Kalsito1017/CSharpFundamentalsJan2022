using System;

namespace _07.BasicSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeofday = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double priceofticket = 0;
            if (age >= 0 && age <= 18)
            {
                if (typeofday == "Weekday")
                {
                    priceofticket = 12;
                }
                else if (typeofday == "Weekend")
                {
                    priceofticket = 15;
                }
                else if (typeofday == "Holiday")
                {
                    priceofticket = 5;
                }
                Console.WriteLine($"{priceofticket}$");

            }
            else if (age > 18 && age <= 64)
            {
                if (typeofday == "Weekday")
                {
                    priceofticket = 18;
                }
                else if (typeofday == "Weekend")
                {
                    priceofticket = 20;
                }
                else if (typeofday == "Holiday")
                {
                    priceofticket = 12;
                }
                Console.WriteLine($"{priceofticket}$");
            }
            else if (age > 64 && age <= 122)
            {
                if (typeofday == "Weekday")
                {
                    priceofticket = 12;
                }
                else if (typeofday == "Weekend")
                {
                    priceofticket = 15;
                }
                else if (typeofday == "Holiday")
                {
                    priceofticket = 10;
                }
                Console.WriteLine($"{priceofticket}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }


        }
    }
}
