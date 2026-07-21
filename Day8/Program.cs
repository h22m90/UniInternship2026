using System;
using System.Threading.Tasks;
using UniInternship2026.Day10; // Importing Student model

namespace UniInternship2026.Day08
{
    class Program
    {
        // 1. Mark Main as async Task so the entry point supports asynchronous execution
        static async Task Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("        DAY 15: ASYNCHRONOUS BACKEND PIPELINES  ");
            Console.WriteLine("=================================================");

            Console.WriteLine("[SYSTEM] Requesting student record from database...");

            // 2. Await the long-running asynchronous task
            Student student = await FetchStudentFromDatabaseAsync(100245);

            Console.WriteLine("\n[SYSTEM] Data pipeline task resolved successfully!");
            Console.WriteLine("-------------------------------------------------");
            student.PrintProfile();
            Console.WriteLine("=================================================");
        }

        /// <summary>
        /// Simulates fetching a student record asynchronously from a database disk or network.
        /// </summary>
        static async Task<Student> FetchStudentFromDatabaseAsync(int studentId)
        {
            Console.WriteLine($"[DATABASE] Initiating query for ID: {studentId}...");

            // Simulate a 2.5-second network/database latency without blocking the main system thread
            await Task.Delay(2500);

            Console.WriteLine("[DATABASE] Query completed. Record retrieved.");

            // Return the retrieved student instance
            return new Student(studentId, "Husein", "Melli", "h.melli@university.edu", 3.85);
        }
    }
}