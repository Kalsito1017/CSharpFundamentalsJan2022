using System;

namespace _07.ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string symvol = (Console.ReadLine());
            Console.WriteLine($"{first}{symvol}{second}");
        }
    }
}
