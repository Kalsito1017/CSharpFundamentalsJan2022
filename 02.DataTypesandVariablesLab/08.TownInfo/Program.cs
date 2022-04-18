using System;

namespace _08.TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string townname = Console.ReadLine();
            decimal population = decimal.Parse(Console.ReadLine());
            decimal area = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Town {townname} has population of {population} and area {area} square km.");
        }
    }
}
