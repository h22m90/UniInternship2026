using System;
using UniInternship2026.Day11;
using UniInternship2026.Day14; // Include the new interface namespace

namespace UniInternship2026.Day12
{
    // Instructor inherits from Person AND implements INotifiable
    public class Instructor : Person, INotifiable
    {
        private string _department;
        public string Department => _department;

        public Instructor(string firstName, string lastName, string email, string department)
            : base(firstName, lastName, email)
        {
            _department = department;
        }

        public override void PrintProfile()
        {
            Console.WriteLine($"--- INSTRUCTOR RECORD ---");
            base.PrintProfile();
            Console.WriteLine($"Department: {_department}");
        }

        public override string GetLoginPortal() => "https://faculty.university.edu/dashboard";

        // Implementation of the INotifiable contract
        public void SendAlert(string message)
        {
            Console.WriteLine($"[EMAIL SENT] To Faculty {FullName} ({Email}): \"{message}\"");
        }
    }
}