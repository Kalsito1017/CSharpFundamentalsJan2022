﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string commands = Console.ReadLine();
            while (commands != "end")
            {
                string[] tokens = commands.Split();
                if (tokens.Length == 2)
                {
                    int currentWaggon = int.Parse(tokens[1]);
                    wagons.Add(currentWaggon);
                }
                else
                {
                    int currentCapacity = int.Parse(tokens[0]);
                    FindWaggon(wagons, maxCapacity, currentCapacity);
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }

        private static void FindWaggon(List<int> wagons, int maxCapacity, int currentCapacity)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                int currentWaggon = wagons[i];
                if (wagons[i] + currentCapacity <= maxCapacity)
                {
                    wagons[i] += currentCapacity;
                    break;
                }
            }
        }
    }
}
