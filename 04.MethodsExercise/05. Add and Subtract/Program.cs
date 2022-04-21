using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = int.Parse(Console.ReadLine());
            int secondnumber = int.Parse(Console.ReadLine());
            int thirdnumber = int.Parse(Console.ReadLine());
            int result = Add(firstnumber, secondnumber);
            Substract(result, thirdnumber);

        }
        static int Add(int fisrtnumber, int secondnumber)
        {



            int result = fisrtnumber + secondnumber;
            return result;

        }

        private static void Substract(int result, int thirdnumber)
        {
            Console.WriteLine(result - thirdnumber);
        }
    }
    
}
