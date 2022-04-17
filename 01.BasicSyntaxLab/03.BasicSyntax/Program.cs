using System;

namespace _03.BasicSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double averagegrade = double.Parse(Console.ReadLine());
            if (averagegrade >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else if (averagegrade < 3)
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
