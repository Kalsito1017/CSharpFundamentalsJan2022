using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SomeClassBasic> listOfStringsBasic = new List<SomeClassBasic>();
            List<SomeClassAdvanced> listOFStringsAdvanced = new List<SomeClassAdvanced>();
            string input = null;

            while ((input = Console.ReadLine()) != "end")
            {
                // Basic подходът
                var info = new SomeClassBasic();
                info.normalString = input;
                var reversedStringArr = input.ToArray().Reverse();
                info.reversedString = string.Join("", reversedStringArr);
                listOfStringsBasic.Add(info);

                // Advanced подходът
                var neshtoSi = new SomeClassAdvanced(input);
                listOFStringsAdvanced.Add(neshtoSi);
            }

            // Принтирането е еднакво и за двата - listOfStringsBasic и listOFStringsAdvanced
            foreach (var item in listOFStringsAdvanced)
            {
                Console.WriteLine($"{item.normalString} = {item.reversedString}");
            }
        }
    }

    // Използвам клас тъй като ключът в речниците(Dictionary<TKey,TValue>) е уникален(т.е. не може да има дубликати)
    // например не може да има такова нещо 
    // hello = olleh
    // hello = olleh
    public class SomeClassBasic
    {
        public string normalString { get; set; }

        public string reversedString { get; set; }
    }

    public class SomeClassAdvanced
    {
        public SomeClassAdvanced(string input)
        {
            this.normalString = input;
        }
        public string normalString { get; set; }

        public string reversedString => string.Join("", this.normalString.ToArray().Reverse());
    }
}
      
