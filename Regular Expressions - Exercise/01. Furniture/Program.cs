using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";

            string input = Console.ReadLine();
            var list = new List<string>();
            double totalPrice = 0.0;
            while (input != "Purchase")
            {
                Match match = Regex.Match(input, regex, RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    var name = match.Groups["name"].Value;
                    var price = double.Parse(match.Groups["price"].Value);
                    var quantity = int.Parse(match.Groups["quantity"].Value);
                    list.Add(name);
                    totalPrice += price * quantity;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            list.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:f2}");

        }
    }
}
