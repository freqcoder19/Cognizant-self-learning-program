using System;

namespace MethodOverloadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int intResult = CalculateTotal(12, 23);
            Console.WriteLine($"Sum of two ints: {intResult}");   

            
            double dblResult = CalculateTotal(10.5, 22.3, 7.2);
            Console.WriteLine($"Sum of three doubles: {dblResult}"); 
        }

        static int CalculateTotal(int x, int y)
        {
            return x + y;
        }

        
        static double CalculateTotal(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}
