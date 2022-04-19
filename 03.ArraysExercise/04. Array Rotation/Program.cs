using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int temp = -1;
            for (int i = 0; i < n; i++)
            {
                temp = arr[0];
                string tmp = "";
                for (int j = 1; j < arr.Length; j++)
                {
                    tmp += arr[j].ToString() + " ";
                }
                tmp += temp.ToString();
                arr = tmp.Split(" ").Select(int.Parse).ToArray();
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
