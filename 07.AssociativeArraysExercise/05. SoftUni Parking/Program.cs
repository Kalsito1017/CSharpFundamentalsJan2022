using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();
            int numberofcommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberofcommands; i++)
            {
                var comands = Console.ReadLine().Split();
                var action = comands[0];
                var userName = comands[1];
                switch (action)
                {

                    case "register":
                        var plateNubmer = comands[2];
                        if (!users.ContainsKey(userName))
                        {
                            users.Add(userName, plateNubmer);
                            Console.WriteLine($"{userName} registered {plateNubmer} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plateNubmer}");
                        }
                        break;
                    case "unregister":
                        if (!users.ContainsKey(userName))
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        else
                        {
                            Console.WriteLine($"{userName} unregistered successfully");
                            users.Remove(userName);
                        }
                        break;
                }

            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
