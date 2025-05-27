using System;

namespace RefOutInDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine($"Before RefMethod: a = {a}");
            RefMethod(ref a);
            Console.WriteLine($"After RefMethod: a = {a}");

            int b;
            OutMethod(out b);
            Console.WriteLine($"Value from OutMethod: b = {b}");

            int c = 10;
            InMethod(in c);
        }

        static void RefMethod(ref int x)
        {
            x += 10;
        }

        static void OutMethod(out int y)
        {
            y = 100;
        }

        static void InMethod(in int z)
        {
            Console.WriteLine($"Inside InMethod: z = {z}");
        }
    }
}
