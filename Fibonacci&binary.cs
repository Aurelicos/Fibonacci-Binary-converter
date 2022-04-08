using System;
using System.Collections.Generic;

namespace Test_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("All Fibonacci numbers up to 4,000,000:");
            int a = 0, b = 1, c, i;
            Console.ReadKey();
            Console.WriteLine(a);
            Console.ReadKey();
            Console.WriteLine(b);
            List<int> firstAnswer = new List<int> { 0, 1 };
            
            for (i = 2; i <= 33; i++)
            {
                c = a + b;
                Console.ReadKey();
                Console.WriteLine(c);
                firstAnswer.Add(c);
                a = b;
                b = c;
            }
            Console.WriteLine("To continue, press any key: ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\nAll even Fibonacci numbers up to 4,000,000:");
            List<int> sum1 = new List<int>();
            foreach (var d in firstAnswer)
            {
                if (d % 2 == 0)
                {
                    sum1.Add(d);
                }
            }
            int sum = 0;
            foreach (var item in sum1)
            {
                Console.ReadKey();
                sum += item;
                Console.WriteLine(item);
            }
            Console.WriteLine("\ntotal sum: ");
            Console.WriteLine(sum);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.Write("\nEnter the number in binary to traansfer it to decimal number: ");
            int binaryInput = int.Parse(Console.ReadLine());
            int decimalNumber = 0;
            int g = 1;
            while (binaryInput > 0)
            {
                int h = binaryInput % 10;
                binaryInput = binaryInput / 10;
                decimalNumber += h * g;
                g = g * 2;
            }
            Console.WriteLine("Entered number in decimal system: " + decimalNumber);
        }
    }
}
