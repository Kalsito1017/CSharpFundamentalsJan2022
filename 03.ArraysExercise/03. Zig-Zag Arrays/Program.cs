﻿using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];




            for (int row = 1; row <= n; row++)
            {
                int[] currentRowData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int firstNumber = currentRowData[0];
                int secondNumber = currentRowData[1];
                if (row % 2 != 0)

                {
                    arr1[row - 1] = firstNumber;
                    arr2[row - 1] = secondNumber;
                }
                else
                {
                    arr1[row - 1] = secondNumber;
                    arr2[row - 1] = firstNumber;
                }

            }
            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}
