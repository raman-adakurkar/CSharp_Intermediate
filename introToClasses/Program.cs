using System;

namespace introToClasses
{
    public class Person
    {
        public void Introduction(string to)
        {
            string name = "Raman";
            Console.WriteLine("Hello {0}, I am {1}. Nice to see you here...", to, name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name : ");
            string to = Console.ReadLine();

            var person = new Person();
            Console.WriteLine();
            person.Introduction(to);
            Console.WriteLine();
        }
    }
}
