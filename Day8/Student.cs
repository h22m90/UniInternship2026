using System;

namespace UniInternship2026.Day10
{
    public class Student
    {
        // 1. Private Fields (Encapsulated Data)
        private int _studentId;
        private string _firstName;
        private string _lastName;
        private double _gpa;

        // 2. Public Properties (Safe Access Gates)
        public int StudentId => _studentId;
        public string FullName => $"{_firstName} {_lastName}";
        
        public double Gpa
        {
            get => _gpa;
            // Business logic constraint: prevent invalid GPAs from being set
            set
            {
                if (value >= 0.0 && value <= 4.0)
                {
                    _gpa = value;
                }
                else
                {
                    Console.WriteLine($"[WARNING] Invalid GPA assignment ({value}) ignored. Keeping current GPA.");
                }
            }
        }

        // 3. Constructor (Object Initializer)
        public Student(int studentId, string firstName, string lastName, double initialGpa)
        {
            _studentId = studentId;
            _firstName = firstName;
            _lastName = lastName;
            Gpa = initialGpa; // Uses the property validation logic
        }

        // 4. Object Behavior Method
        public void PrintProfile()
        {
            Console.WriteLine($"Student ID : {_studentId}");
            Console.WriteLine($"Full Name  : {FullName}");
            Console.WriteLine($"Current GPA: {Gpa:F2}");
        }
    }
}