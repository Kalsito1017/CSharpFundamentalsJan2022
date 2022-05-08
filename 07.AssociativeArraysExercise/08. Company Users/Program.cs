using System;
using System.Collections.Generic;

namespace _08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, HashSet<string>> results = new Dictionary<string, HashSet<string>>();

            while (input != "End")
            {
                string[] inputInfo = input.Split(" -> ");
                string companyName = inputInfo[0];
                string personId = inputInfo[1];
                if (!results.ContainsKey(companyName))
                {
                    results.Add(companyName, new HashSet<string>());
                }

                results[companyName].Add(personId);

                input = Console.ReadLine();
            }

            foreach (var item in results)
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"-- {string.Join("\n-- ", item.Value)}");
            }

        }
    }
}
