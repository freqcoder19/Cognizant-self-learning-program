using System;

namespace ArrayLoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15, 20, 25 };

            Console.WriteLine("--- For loop ---");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 15) continue; 
                if (numbers[i] == 25) break;    
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("\n--- Foreach loop ---");
            foreach (int num in numbers)
            {
                if (num == 15) continue; 
                if (num == 25) break;    
                Console.WriteLine(num);
            }

            Console.WriteLine("\n--- While loop ---");
            int j = 0;
            while (j < numbers.Length)
            {
                if (numbers[j] == 15)
                {
                    j++;
                    continue;
                }
                if (numbers[j] == 25) break;

                Console.WriteLine(numbers[j]);
                j++;
            }

            Console.WriteLine("\n--- Do-While loop ---");
            int k = 0;
            do
            {
                if (numbers[k] == 15)
                {
                    k++;
                    continue;
                }
                if (numbers[k] == 25) break;

                Console.WriteLine(numbers[k]);
                k++;
            } while (k < numbers.Length);
        }
    }
}
