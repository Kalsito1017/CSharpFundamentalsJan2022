using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] placeHolders = input.Split();

                if (placeHolders.Length == 2)
                {
                    int numberToRemove = int.Parse(placeHolders[1]);
                    numbers.RemoveAll(x => x == numberToRemove);
                }
                else
                {
                    int elementToInsert = int.Parse(placeHolders[1]);
                    int indexToInsert = int.Parse(placeHolders[2]);
                    numbers.Insert(indexToInsert, elementToInsert);
                }

                input = Console.ReadLine();
            }


            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
