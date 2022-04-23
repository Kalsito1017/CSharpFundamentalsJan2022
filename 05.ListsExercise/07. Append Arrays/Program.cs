using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numberAsStrings = Console.ReadLine().Split("|").Reverse().ToList();
            List<int> numList = new List<int>();
            foreach (var str in numberAsStrings)
            {
                numList.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
