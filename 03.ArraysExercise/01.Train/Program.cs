using System;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] array = new int[wagons];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                int temNumber = array[i];
                sum += temNumber;
            }
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine(sum);
        }
    }
}
