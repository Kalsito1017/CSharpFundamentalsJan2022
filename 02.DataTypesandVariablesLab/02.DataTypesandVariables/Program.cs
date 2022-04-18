using System;

namespace Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double kilometers = meters / 1000.0;
            Console.WriteLine($"{Math.Round(kilometers, 2, MidpointRounding.AwayFromZero):F2}");

        }
    }
}
