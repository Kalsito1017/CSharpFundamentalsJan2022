using System;

namespace _012.BasycSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            do
            {
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }

                Console.WriteLine("Please write an even number.");
            }
            while (number % 2 != 0);
        }
    }
}
