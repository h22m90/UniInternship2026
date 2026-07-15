using System;
using UniInternship2026.Day10;

namespace UniInternship2026.Day08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("        DAY 11: OOP INHERITANCE SYSTEM          ");
            Console.WriteLine("=================================================");

            // Instantiating a Student who inherits from Person
            Student student = new Student(100245, "Husein", "Melli", "h.melli@university.edu", 3.85);

            Console.WriteLine("[SYSTEM] Processing Profile:");
            student.PrintProfile();

            Console.WriteLine("=================================================");
        }
    }
}