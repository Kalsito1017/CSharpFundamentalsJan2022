﻿using System;

namespace _04.BasicSyntaxExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numStart = int.Parse(Console.ReadLine());
            int numEnd = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = numStart; i <= numEnd; i++)
            {
                sum = sum + i;
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
