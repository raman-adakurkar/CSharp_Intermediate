using System;

namespace introToConstructors
{
    public class Constructor
    {
        public Constructor()
        {
            Console.WriteLine("Default Constructor called");
        }

        public Constructor(int id, string name)
        {
            Console.WriteLine("ID   : " + id);
            Console.WriteLine("NAME : " + name);
        }
    }
}
