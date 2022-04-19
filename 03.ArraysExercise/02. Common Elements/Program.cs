using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings1 = Console.ReadLine().Split().ToArray();
            string[] arrayOfStrings2 = Console.ReadLine().Split().ToArray();


            for (int i = 0; i < arrayOfStrings2.Length; i++)
            {
                for (int j = 0; j < arrayOfStrings1.Length; j++)
                {
                    if (arrayOfStrings2[i] == arrayOfStrings1[j])
                    {
                        Console.Write($"{arrayOfStrings2[i]} ");
                    }
                }

            }
        }
    }
}
