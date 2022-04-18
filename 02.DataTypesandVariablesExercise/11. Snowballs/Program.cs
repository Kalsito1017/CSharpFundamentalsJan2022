using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballsCount = int.Parse(Console.ReadLine());
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;
            BigInteger bestsnowballValue = BigInteger.Zero;
            for (int i = 0; i < snowballsCount; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                int foreachsnowball = (snowballSnow / snowballTime);
                BigInteger snowballValue = BigInteger.Pow(foreachsnowball, snowballQuality);
                if (snowballValue >= bestsnowballValue)
                {
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                    bestsnowballValue = snowballValue;

                }


            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestsnowballValue} ({bestSnowballQuality})");
        }
    }
}
