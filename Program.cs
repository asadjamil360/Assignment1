using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program
    {
        //recursive function for fibonacci number n
        private static int fib1(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
            {
                return fib1(n - 1) + fib1(n - 2);
            }
        }
        private static int fib2(int n)
        {
            int[] p = new int[n + 2];

            p[0] = 0;
            p[1] = 1;


            for (int i = 2; i <= n; i++)
            {
                p[i] = p[i - 1] + p[i - 2];
            }

            return p[n];
        }
        public static void Main()
        {
            Console.WriteLine("Specify a number for computation ");
            int n = 0;
            long res = 0;
            try
            {
                n = Convert.ToInt32(Convert.ToUInt32(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.WriteLine("You have entered invalid value.");
                Console.WriteLine($"EXCEPTION: {ex.Message}");
                Main();
            }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            res = fib1(n);
            var fib1Elapsed = watch.ElapsedMilliseconds;
            Console.WriteLine($"{n} Fibonacci number is {res} \n");
            watch.Stop();


            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            res = fib2(n);
            var fib2Elapsed = watch2.ElapsedMilliseconds;
            watch2.Stop();
            //Console.WriteLine($"Fib2 returned: {res}");

            Console.WriteLine("Time taken to compute the result is \n");
            Console.WriteLine($"Iterative Method: {fib2Elapsed} Milliseconds");
            Console.WriteLine($"Recursive Method: {fib1Elapsed} Milliseconds");

            Console.ReadKey();

        }
    }
}
