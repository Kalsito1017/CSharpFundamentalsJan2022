using System;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            if (n < p)
            {
                Console.WriteLine(1);
            }
            else if (n > p)
            {
                int courses = (int)Math.Ceiling((double)n / p);
                Console.WriteLine(courses);
            }
        }
    }
}
