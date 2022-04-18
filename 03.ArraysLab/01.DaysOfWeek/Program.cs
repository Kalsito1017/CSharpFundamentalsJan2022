using System;

namespace _01.Day_Of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());
            string[] daysofTheWeek = new string[]
            {
                "Monday", //0
                "Tuesday", //1
                "Wednesday",//2
                "Thursday",//3
                "Friday",
                "Saturday",
                "Sunday",
            };
            if (dayNumber >= 1 && dayNumber <= daysofTheWeek.Length)
            {
                Console.WriteLine(daysofTheWeek[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
            Console.ReadLine();

        }
    }
}
