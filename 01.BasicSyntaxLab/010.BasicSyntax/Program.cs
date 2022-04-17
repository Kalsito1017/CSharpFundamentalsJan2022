using System;

namespace _010.BasicSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //  Console.WriteLine($"{number} X {i} = {number * i}");
            //}
            int times = 1;
            while (times <= 10)
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
                times++;
            }
        }
    }
}
