using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();
            MatchCollection matchedPhoneNumbers = Regex.Matches(input, pattern);
            List<string> result = new List<string>();
            foreach (Match match in matchedPhoneNumbers)
            {
                result.Add(match.Value);
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
