using System;
using UniInternship2026.Day10;

namespace UniInternship2026.Day08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("        DAY 10: INSTANTIATING C# OBJECTS        ");
            Console.WriteLine("=================================================");

            // 1. Creating a new student object using our constructor
            Student student1 = new Student(100245, "Husein", "Melli", 3.85);

            // 2. Printing the profile using the internal object method
            Console.WriteLine("[SYSTEM] Displaying active student record:");
            student1.PrintProfile();
            Console.WriteLine("-------------------------------------------------");

            // 3. Testing encapsulation safety validation
            Console.WriteLine("[SYSTEM] Attempting to set an invalid GPA of 5.5...");
            student1.Gpa = 5.5; // This should trigger our warning and keep the old GPA!
            
            Console.WriteLine("\n[SYSTEM] Verifying student record state remains unchanged:");
            student1.PrintProfile();

            Console.WriteLine("=================================================");
        }
    }
}