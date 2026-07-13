using System;

namespace UniInternship2026.Day09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("        DAY 9: DATA TRACKING & TYPE PIPELINES   ");
            Console.WriteLine("=================================================");

            // 1. Primitive Type Declarations
            int studentId = 100245;
            string firstName = "Husein";
            string lastName = "Melli";
            string email = "h.melli@university.edu";
            double studentGpa = 3.85;
            char academicGrade = 'A';
            bool isEnrolledActive = true;

            // 2. Data Processing and Output Pipeline
            Console.WriteLine($"[RECORD ARCHIVE] processing data for ID: {studentId}");
            Console.WriteLine($"Student Full Name : {firstName} {lastName}");
            Console.WriteLine($"Contact Registry  : {email}");
            Console.WriteLine($"Current Metrics   : GPA {studentGpa} | Performance Class: {academicGrade}");
            
            // 3. Conditional Status Verification Logic
            if (isEnrolledActive)
            {
                Console.WriteLine("System Status     : ACTIVE (Account clear for course selection)");
            }
            else
            {
                Console.WriteLine("System Status     : SUSPENDED / INACTIVE");
            }

            Console.WriteLine("=================================================");
        }
    }
}