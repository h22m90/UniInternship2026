using System;
using System.Collections.Generic;
using UniInternship2026.Day11;
using UniInternship2026.Day10;
using UniInternship2026.Day12;
using UniInternship2026.Day14;

namespace UniInternship2026.Day08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("        DAY 14: INTERFACE CONTRACT ENGINES      ");
            Console.WriteLine("=================================================");

            // Create a list of objects grouped purely by their shared capability (INotifiable)
            List<INotifiable> alertRegistry = new List<INotifiable>
            {
                new Student(100245, "Husein", "Melli", "h.melli@university.edu", 3.85),
                new Instructor("Zeynep", "Kaya", "z.kaya@university.edu", "Computer Engineering")
            };

            string systemAlert = "Emergency Broadcast: Campus server maintenance scheduled for midnight.";

            Console.WriteLine("[SYSTEM] Broadcasting system alerts via contract channels:\n");
            foreach (INotifiable entity in alertRegistry)
            {
                entity.SendAlert(systemAlert);
                Console.WriteLine("-------------------------------------------------");
            }

            Console.WriteLine("=================================================");
        }
    }
}