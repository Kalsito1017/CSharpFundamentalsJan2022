using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            double result1 = Factorial(n);
            double result2 = Factorial(m);
            Console.WriteLine($"{result1 / result2:F2}");
        }
        private static double Factorial(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result *= number;
                number--;
            }
            return result;
        }
    }
}
