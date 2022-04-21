using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            VowelsCount(word);

        }
        static void VowelsCount(string word)
        {
            int count = 0;
            foreach (char vowels in word)
            {
                if ("aeiuo".Contains(vowels))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
