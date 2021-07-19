using System;

namespace CSharp.Solutions
{
    public class FibonacciCalculator
    {
        public static int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            while (n > 1)
            {
                return (Fib(n - 1) + Fib(n - 2));
            }
            return 0;
        }
    }
}