using System;

namespace _05.Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startindex = int.Parse(Console.ReadLine());
            int endindex = int.Parse(Console.ReadLine());

            for (int i = startindex; i <= endindex; i++)
            {
                char currCh = (char)i;
                Console.Write($"{currCh} ");

            }
            Console.ReadLine();
        }
    }
}
