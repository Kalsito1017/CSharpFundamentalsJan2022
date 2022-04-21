using System;

namespace _01.Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintSmallestofThreeNumbers(num1, num2, num3));
        }

        static double PrintSmallestofThreeNumbers(int num1, int num2, int num3)
        {
            return Math.Min(num1, Math.Min(num2, num3));
        }
    }
    
}
