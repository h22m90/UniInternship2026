using System;
using UniInternship2026.Day11;
using UniInternship2026.Day14; // Include the new interface namespace

namespace UniInternship2026.Day10
{
    // Student inherits from Person AND implements INotifiable
    public class Student : Person, INotifiable
    {
        private int _studentId;
        private double _gpa;

        public int StudentId => _studentId;
        public double Gpa { get => _gpa; set { if (value >= 0.0 && value <= 4.0) _gpa = value; } }

        public Student(int studentId, string firstName, string lastName, string email, double initialGpa) 
            : base(firstName, lastName, email)
        {
            _studentId = studentId;
            Gpa = initialGpa;
        }

        public override void PrintProfile()
        {
            Console.WriteLine($"--- STUDENT RECORD ({_studentId}) ---");
            base.PrintProfile();
            Console.WriteLine($"GPA  : {Gpa:F2}");
        }

        public override string GetLoginPortal() => "https://student.university.edu/portal";

        // Implementation of the INotifiable contract
        public void SendAlert(string message)
        {
            Console.WriteLine($"[SMS PUSH SENT] To Student {FullName} ({Email}): \"{message}\"");
        }
    }
}