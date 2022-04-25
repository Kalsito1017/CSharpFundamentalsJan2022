using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<People> person = new List<People>();
            while (command != "End")
            {
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = cmdArg[0];
                string identity = cmdArg[1];
                int age = int.Parse(cmdArg[2]);
                People current = new People(name, identity, age);
                current.PersonName = name;
                current.PersonIdentity = identity;
                current.PersonAge = age;
                int currentIndex = person.FindIndex(x => x.PersonIdentity == identity);

                if (currentIndex == -1)
                {
                    person.Add(current);
                }
                else
                {
                    person[currentIndex] = current;
                }
                command = Console.ReadLine();
            }
            List<People> orderedPeople = person.OrderBy(x => x.PersonAge).ToList();
            foreach (People item in orderedPeople)
            {
                Console.WriteLine($"{item.PersonName} with ID: {item.PersonIdentity} is {item.PersonAge} years old.");
            }
        }
    }


    class People
    {
        public People(string personname, string personIdentity, int personAge)
        {
            this.PersonName = personname;
            this.PersonIdentity = personIdentity;
            this.PersonAge = personAge;
        }

        public string PersonName { get; set; }

        public string PersonIdentity { get; set; }

        public int PersonAge { get; set; }
    }
    
}
