using System;
using System.Text;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string text = Console.ReadLine();
            while (text.Contains(wordToRemove))
            {
                int startIndexOfwordToRemove = text.IndexOf(wordToRemove);
                text = text.Remove(startIndexOfwordToRemove, wordToRemove.Length);
            }
            Console.WriteLine(text);
        }
    }
}
