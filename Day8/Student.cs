using System;
using UniInternship2026.Day11; // Directing to our inheritance namespace

namespace UniInternship2026.Day10
{
    // Student inherits from Person
    public class Student : Person
    {
        private int _studentId;
        private double _gpa;

        public int StudentId => _studentId;
        
        public double Gpa
        {
            get => _gpa;
            set
            {
                if (value >= 0.0 && value <= 4.0) _gpa = value;
            }
        }

        // The constructor uses 'base' to pass the name and email up to the Parent constructor
        public Student(int studentId, string firstName, string lastName, string email, double initialGpa) 
            : base(firstName, lastName, email)
        {
            _studentId = studentId;
            Gpa = initialGpa;
        }

        // Override the parent PrintProfile to add student-specific details
        public override void PrintProfile()
        {
            Console.WriteLine($"--- STUDENT RECORD ({_studentId}) ---");
            base.PrintProfile(); // Calls the parent PrintProfile first (Name & Email)
            Console.WriteLine($"GPA  : {Gpa:F2}");
        }
        // Add this method inside your Student class in Student.cs
        public override string GetLoginPortal()
        {
            return "https://student.university.edu/portal";
        }
    }
}