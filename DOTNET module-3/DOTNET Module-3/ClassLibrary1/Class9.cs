using System;

namespace LocalFunctionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int result = CalculateFactorial(number);
            Console.WriteLine($"Factorial of {number} is {result}");
        }

        static int CalculateFactorial(int n)
        {
            int Factorial(int x)
            {
                if (x <= 1) return 1;
                return x * Factorial(x - 1);
            }

            return Factorial(n);
        }
    }
}
