using System;
using UniInternship2026.Day11;

namespace UniInternship2026.Day12
{
    // Instructor inherits from Person
    public class Instructor : Person
    {
        private string _department;

        public string Department => _department;

        // Constructor passes name and email to the parent Person class
        public Instructor(string firstName, string lastName, string email, string department)
            : base(firstName, lastName, email)
        {
            _department = department;
        }

        // Override the parent PrintProfile to customize for instructors
        public override void PrintProfile()
        {
            Console.WriteLine($"--- INSTRUCTOR RECORD ---");
            base.PrintProfile(); // Prints Name and Email from Person
            Console.WriteLine($"Department: {_department}");
        }
    }
}