using System;
using System.Collections.Generic;
using UniInternship2026.Day11; // Base Person namespace
using UniInternship2026.Day10; // Student namespace
using UniInternship2026.Day12; // Instructor namespace

namespace UniInternship2026.Day08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("        DAY 12: POLYMORPHISM IN ACTION          ");
            Console.WriteLine("=================================================");

            // 1. Create a generic list that holds the parent class type "Person"
            List<Person> universityRegistry = new List<Person>();

            // 2. Add both Student and Instructor objects to the same registry list
            universityRegistry.Add(new Student(100245, "Husein", "Melli", "h.melli@university.edu", 3.85));
            universityRegistry.Add(new Instructor("Zeynep", "Kaya", "z.kaya@university.edu", "Computer Engineering"));

            // 3. Loop through the collection and dynamically print profiles
            Console.WriteLine("[SYSTEM] Processing unified registry database:\n");
            foreach (Person person in universityRegistry)
            {
                person.PrintProfile();
                Console.WriteLine("-------------------------------------------------");
            }

            Console.WriteLine("=================================================");
        }
    }
}