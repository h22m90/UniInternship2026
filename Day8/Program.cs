using System;
using System.Diagnostics;
using System.Threading.Tasks;
using UniInternship2026.Day10;
using UniInternship2026.Day12;

namespace UniInternship2026.Day08
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("        DAY 16: PARALLEL ASYNC PIPELINES        ");
            Console.WriteLine("=================================================");

            // Stopwatch to measure exact execution performance
            Stopwatch stopwatch = Stopwatch.StartNew();

            Console.WriteLine("[SYSTEM] Triggering concurrent queries for multiple records...");

            // 1. Kick off tasks concurrently WITHOUT awaiting them immediately
            Task<Student> studentTask = FetchStudentAsync(100245, "Husein", "Melli");
            Task<Instructor> instructorTask = FetchInstructorAsync("Zeynep", "Kaya", "Computer Engineering");

            // 2. Wait for BOTH tasks to complete simultaneously using Task.WhenAll
            await Task.WhenAll(studentTask, instructorTask);

            // 3. Extract the finished results from the completed tasks
            Student student = await studentTask;
            Instructor instructor = await instructorTask;

            stopwatch.Stop();

            Console.WriteLine("\n[SYSTEM] All parallel tasks resolved successfully!");
            Console.WriteLine("-------------------------------------------------");
            student.PrintProfile();
            Console.WriteLine();
            instructor.PrintProfile();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"[PERFORMANCE] Total Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine("=================================================");
        }

        static async Task<Student> FetchStudentAsync(int id, string firstName, string lastName)
        {
            Console.WriteLine($"[DB MOCK] Fetching student {firstName}...");
            await Task.Delay(2000); // Simulate 2-second database latency
            return new Student(id, firstName, lastName, "h.melli@university.edu", 3.85);
        }

        static async Task<Instructor> FetchInstructorAsync(string firstName, string lastName, string department)
        {
            Console.WriteLine($"[DB MOCK] Fetching instructor {firstName}...");
            await Task.Delay(2000); // Simulate 2-second database latency
            return new Instructor(firstName, lastName, "z.kaya@university.edu", department);
        }
    }
}