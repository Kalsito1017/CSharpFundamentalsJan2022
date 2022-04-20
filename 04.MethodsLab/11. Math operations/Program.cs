using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string operato = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(x, operato, b));
        }
        static double Calculate(int a, string @operator, int b)
        {
            double result = 0;
            switch (@operator)
            {
                case "/": result = (a / b); break;
                case "*": result = (a * b); break;
                case "+": result = (a + b); break;
                case "-": result = (a - b); break;
            }
            return result;
        }
    }
}
