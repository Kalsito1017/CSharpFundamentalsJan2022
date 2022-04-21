using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstchar = char.Parse(Console.ReadLine());
            char secondchar = char.Parse(Console.ReadLine());
            CharsInRange(firstchar, secondchar);
        }
        static void CharsInRange(char firstchar, char secondchar)
        {
            int startChar = Math.Min(firstchar, secondchar);
            int endChar = Math.Max(firstchar, secondchar);
            for (int i = startChar + 1; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
