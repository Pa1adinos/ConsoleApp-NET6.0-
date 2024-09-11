using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    class Fibonacci
    {
        public static void Fib(int n)
        {
            long a = 0;
            long b = 1;
            for (int i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + a;
                Console.WriteLine(a);
            }
        }
    }
}
