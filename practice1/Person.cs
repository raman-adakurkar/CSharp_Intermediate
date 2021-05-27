using System;

namespace practice1
{
    public class Person : Animal
    {
        public
            int age;
            string name;
            
            
        public void Age(int age)
        {
            Console.WriteLine("Age is :" + age);
        }

        public void Name(string name)
        {
            Console.WriteLine("Name is : " + name);
        }

        public void Legs(int _legs)
        {
            Console.WriteLine("Legs : {0}", _legs);
        }
            
    }
}
