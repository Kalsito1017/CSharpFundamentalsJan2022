using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(\d{2})(\/|\.|-)([A-Z][a-z]{2})\2(\d{4})\b";
            string text = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection maches = regex.Matches(text);

            foreach (Match match in maches)
            {
                Console.WriteLine($"Day: {match.Groups[1].Value}, " +
                    $"Month: {match.Groups[3].Value}, " +
                    $"Year: {match.Groups[4].Value}");

            }
        }
    }
}
