﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            foreach (int number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number] += 1;
                }
                else
                {
                    counts.Add(number, 1);
                }


            }
            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }

        }
    }
}