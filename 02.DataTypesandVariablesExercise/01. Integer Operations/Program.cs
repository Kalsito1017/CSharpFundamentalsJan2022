using System;

namespace _01.Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long first = int.Parse(Console.ReadLine());
            long second = int.Parse(Console.ReadLine());
            long third = int.Parse(Console.ReadLine());
            long fourth = int.Parse(Console.ReadLine());
            long firstplussecond = first + second;
            long almostresult = firstplussecond / third;
            long result = almostresult * fourth;
            Console.WriteLine($"{result}");
            Console.ReadLine();
        }
    }
}
