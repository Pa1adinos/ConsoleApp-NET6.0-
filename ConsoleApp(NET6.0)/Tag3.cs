using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Tag3
    {
        public static void Fibanacci(int n)
        {
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + a;
                Console.WriteLine(a);
            }
        }
        public static void Start()
        {
            Console.WriteLine("--- Tag 3 ---\n");
            /*
            double num = 0.01;
            bool boo = Convert.ToBoolean(num);
            Console.WriteLine(boo);
            */
            Console.WriteLine($"8374 + 1234 > 10522 - 2256 {"=          " + (8374 + 1234 > 10522 - 2256), 60}");
            Console.WriteLine($"123 * 123 != 100 + 12523 {"=          " + (123 * 123 != 100 + 12523), 62}");
            Console.WriteLine($"756,055 / 299,25 >= 25 * 22 {"=          " + (756.055 / 299.25 >= 25 * 22), 60}");
            Console.WriteLine($"123 + 2562 / 4 <= 3874 + 56856 {"=          " + (123 + 2562 / 4 <= 3874 + 56856), 56}");
            Console.WriteLine($"1234 % 4 * 526 / 25685 == 9374 + 85 * 36369 / 40252 % 256 {"=          " + (1234 % 4 * 526 / 25685 == 9374 + 85 * 36369 / 40252 % 256), 30}");
            Console.WriteLine("\n-------------\n");

            Fibanacci(20);
        }
    }
}
