using System;

namespace _09.BasicSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int currentodnumber = 1 + (i * 2);
                sum += currentodnumber;
                Console.WriteLine(currentodnumber);
            }
            Console.WriteLine($"Sum: {sum}");


        }
    }
}
