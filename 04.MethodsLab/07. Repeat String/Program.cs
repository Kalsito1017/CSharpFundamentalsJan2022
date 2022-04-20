using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string template = Console.ReadLine();
            int reapeatTimes = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(template, reapeatTimes));
        }
        static string RepeatString(string template, int numberOfreapeatTimes)
        {
            string result = string.Empty;
            for (int i = 0; i < numberOfreapeatTimes; i++)
            {
                result += template;
            }
            return result;
        }
    }
}
