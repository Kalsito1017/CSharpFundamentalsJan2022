﻿using System;
using System.Text;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tring[] bannedWords = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach (string word in bannedWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
