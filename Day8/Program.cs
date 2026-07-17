using System;
using System.Collections.Generic;
using UniInternship2026.Day11;
using UniInternship2026.Day10;
using UniInternship2026.Day12;

namespace UniInternship2026.Day08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("        DAY 13: OOP ABSTRACTION CONTRACTS       ");
            Console.WriteLine("=================================================");

            List<Person> universityRegistry = new List<Person>
            {
                new Student(100245, "Husein", "Melli", "h.melli@university.edu", 3.85),
                new Instructor("Zeynep", "Kaya", "z.kaya@university.edu", "Computer Engineering")
            };

            Console.WriteLine("[SYSTEM] Running Gateway Portal Access Checks:\n");
            foreach (Person person in universityRegistry)
            {
                Console.WriteLine($"User: {person.FullName}");
                // Calling the abstract contract method seamlessly via polymorphism
                Console.WriteLine($"Target Security Portal: {person.GetLoginPortal()}");
                Console.WriteLine("-------------------------------------------------");
            }

            Console.WriteLine("=================================================");
        }
    }
}