using System;

namespace UniInternship2026.Day11
{
    // The 'abstract' keyword prevents this class from being created with 'new Person()'
    public abstract class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected string _email;

        public string FullName => $"{_firstName} {_lastName}";
        public string Email => _email;

        public Person(string firstName, string lastName, string email)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
        }

        public virtual void PrintProfile()
        {
            Console.WriteLine($"Name : {FullName}");
            Console.WriteLine($"Email: {_email}");
        }

        // Abstract Method: No body {} allowed here. Child classes MUST implement this.
        public abstract string GetLoginPortal();
    }
}