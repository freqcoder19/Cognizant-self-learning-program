using System;

namespace TypeInferenceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            var message = "Hello, world!";
            var person = new Person("Alice", 25);

            Person anotherPerson = new("Bob", 30);
            var thirdPerson = new Person("Charlie", 40);

            // Display types and values
            Console.WriteLine($"number: {number} (Type: {number.GetType()})");
            Console.WriteLine($"message: {message} (Type: {message.GetType()})");
            Console.WriteLine($"person: {person} (Type: {person.GetType()})");
            Console.WriteLine($"anotherPerson: {anotherPerson} (Type: {anotherPerson.GetType()})");
            Console.WriteLine($"thirdPerson: {thirdPerson} (Type: {thirdPerson.GetType()})");
        }
    }

    class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString() => $"Name: {Name}, Age: {Age}";
    }
}
