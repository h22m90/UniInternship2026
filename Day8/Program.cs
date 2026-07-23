using System;
using System.Threading.Tasks;
using UniInternship2026.Day10;

namespace UniInternship2026.Day08
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("        DAY 17: ASYNCHRONOUS EXCEPTION HANDLING ");
            Console.WriteLine("=================================================");

            // 1. Attempting a successful query
            Console.WriteLine("\n[SCENARIO 1] Executing valid database query...");
            await FetchStudentWithSafetyAsync(100245, shouldFail: false);

            Console.WriteLine("-------------------------------------------------");

            // 2. Attempting a failing query (Simulated Network Outage)
            Console.WriteLine("\n[SCENARIO 2] Executing failing database query...");
            await FetchStudentWithSafetyAsync(999999, shouldFail: true);

            Console.WriteLine("=================================================");
            Console.WriteLine("[SYSTEM] Engine survived all exceptions cleanly.");
        }

        /// <summary>
        /// Simulates asynchronous database access wrapped in robust error handling.
        /// </summary>
        static async Task<Student> FetchStudentWithSafetyAsync(int studentId, bool shouldFail)
        {
            try
            {
                Console.WriteLine($"[DATABASE] Initiating query for ID: {studentId}...");
                await Task.Delay(1500); // Simulate network latency

                if (shouldFail)
                {
                    // Artificially trigger an exception to test our catch block
                    throw new Exception("ConnectionTimeoutException: Unable to reach database cluster.");
                }

                Student student = new Student(studentId, "Husein", "Melli", "h.melli@university.edu", 3.85);
                Console.WriteLine("[DATABASE] Success! Record retrieved.");
                student.PrintProfile();
                return student;
            }
            catch (Exception ex)
            {
                // Gracefully intercept the error without crashing the application
                Console.WriteLine($"[ERROR INTERCEPTED] {ex.Message}");
                Console.WriteLine("[FALLBACK] Returning null. System remains operational.");
                return null;
            }
            finally
            {
                // This block ALWAYS runs, ensuring proper cleanup
                Console.WriteLine($"[RESOURCE CLEANUP] Database connection channel closed for ID: {studentId}");
            }
        }
    }
}