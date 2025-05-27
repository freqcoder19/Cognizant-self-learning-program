using System;


public class Person(string name, int age)
{
    public string Name { get; } = name;
    public int Age { get; } = age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

Person person = new("Alice", 28);
person.DisplayInfo();
