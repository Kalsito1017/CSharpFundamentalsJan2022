using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int finalSum = GetStringSum(input[0], input[1]);
            Console.WriteLine(finalSum);



        }

        private static int GetStringSum(string stringOne, string stringTwo)
        {
            int sum = 0;
            int minLength = Math.Min(stringOne.Length, stringTwo.Length);
            for (int i = 0; i < minLength; i++)
            {
                sum += stringOne[i] * stringTwo[i];
            }
            string longestLengthString = stringOne;
            if (longestLengthString.Length < stringTwo.Length)
            {
                longestLengthString = stringTwo;
            }
            for (int i = minLength; i < longestLengthString.Length; i++)
            {
                sum += longestLengthString[i];
            }


            return sum;
        }
    }
}
