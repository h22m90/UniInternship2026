using System;

namespace UniInternship2026.Day11
{
    public class Person
    {
        // Protected fields can only be accessed by this class and its child classes
        protected string _firstName;
        protected string _lastName;
        protected string _email;

        public string FullName => $"{_firstName} {_lastName}";
        public string Email => _email;

        // Parent Constructor
        public Person(string firstName, string lastName, string email)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
        }

        // Virtual method allows child classes to override (customize) this behavior
        public virtual void PrintProfile()
        {
            Console.WriteLine($"Name : {FullName}");
            Console.WriteLine($"Email: {_email}");
        }
    }
}