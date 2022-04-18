using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numBeer = int.Parse(Console.ReadLine());

            double biggestKeg = double.MinValue;     // С този ред избягвам по-сложното сравнение, което си      направил с if/else конструкцията. //
            string modelBeer = "";
            string biggestBeer = "";
            for (int i = 1; i <= numBeer; i++)
            {
                modelBeer = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());

                double volumeKeg = Math.PI * radius * radius * height;
                if (volumeKeg > biggestKeg)
                {
                    biggestKeg = volumeKeg;
                    biggestBeer = modelBeer;
                }
            }
            Console.WriteLine(biggestBeer);

        }
    }
}
