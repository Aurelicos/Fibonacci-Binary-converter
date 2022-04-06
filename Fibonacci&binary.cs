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
            List<int> prvniVysledek = new List<int> { 0, 1 };
            
            for (i = 2; i <= 33; i++)
            {
                c = a + b;
                Console.ReadKey();
                Console.WriteLine(c);
                prvniVysledek.Add(c);
                a = b;
                b = c;
            }
            Console.WriteLine("To continue, press any key: ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\nAll even Fibonacci numbers up to 4,000,000:");
            List<int> suma1 = new List<int>();
            foreach (var d in prvniVysledek)
            {
                if (d % 2 == 0)
                {
                    suma1.Add(d);
                }
            }
            int suma = 0;
            foreach (var item in suma1)
            {
                Console.ReadKey();
                suma += item;
                Console.WriteLine(item);
            }
            Console.WriteLine("\ntotal sum: ");
            Console.WriteLine(suma);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.Write("\nEnter the number in binary to traansfer it to decimal number: ");
            int binarniVstup = int.Parse(Console.ReadLine());
            int decimalniCislo = 0;
            int g = 1;
            while (binarniVstup > 0)
            {
                int h = binarniVstup % 10;
                binarniVstup = binarniVstup / 10;
                decimalniCislo += h * g;
                g = g * 2;
            }
            Console.WriteLine("Entered number in decimal system: " + decimalniCislo);
        }
    }
}
