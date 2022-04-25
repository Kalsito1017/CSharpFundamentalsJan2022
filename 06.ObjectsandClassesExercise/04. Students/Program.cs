using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public Student(string firstName, string LastName, double Grade)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
            this.Grade = Grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {

                string[] splitparams = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string currentStudentFirstName = splitparams[0];
                string currStudentLastName = splitparams[1];
                double currStudentGrade = double.Parse(splitparams[2]);
                Student currStudent = new Student(currentStudentFirstName, currStudentLastName, currStudentGrade);
                students.Add(currStudent);
            }
            students = students.OrderByDescending(students => students.Grade)
                .ToList();
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
