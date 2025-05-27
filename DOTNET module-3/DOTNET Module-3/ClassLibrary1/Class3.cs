using System;

namespace ValueVsReference
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Type Example
            int a = 10;
            Console.WriteLine("Before ModifyValue: a = " + a);
            ModifyValue(a);
            Console.WriteLine("After ModifyValue: a = " + a);

            // Reference Type Example
            Person person = new Person { Name = "Alice", Age = 25 };
            Console.WriteLine("\nBefore ModifyReference: " + person);
            ModifyReference(person);
            Console.WriteLine("After ModifyReference: " + person);

            // Reassigning reference inside method
            Console.WriteLine("\nBefore ReassignReference: " + person);
            ReassignReference(person);
            Console.WriteLine("After ReassignReference: " + person);
        }

        static void ModifyValue(int x)
        {
            x = x + 5;
            Console.WriteLine("Inside ModifyValue: x = " + x);
        }

        static void ModifyReference(Person p)
        {
            p.Age += 5;
            p.Name = "Bob";
            Console.WriteLine("Inside ModifyReference: " + p);
        }

        static void ReassignReference(Person p)
        {
            p = new Person { Name = "Charlie", Age = 40 };
            Console.WriteLine("Inside ReassignReference: " + p);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
