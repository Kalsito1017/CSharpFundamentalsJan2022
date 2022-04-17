using System;

namespace _05.BasicSyntaxExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            for (int index = username.Length - 1; index >= 0; index--)
            {
                password += username[index];

            }
            for (int count = 1; count <= 4; count++)
            {
                string enteredPassword = Console.ReadLine();
                if (enteredPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                if (count == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
            }
        }
    }
}
