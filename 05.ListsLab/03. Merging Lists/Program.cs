using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstlist = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondlist = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int longerCount = Math.Max(firstlist.Count, secondlist.Count);
            for (int i = 0; i < longerCount; i++)
            {
                if (i < firstlist.Count)
                {
                    result.Add(firstlist[i]);
                }
                if (i < secondlist.Count)
                {
                    result.Add(secondlist[i]);
                }

            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
