using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe6
    {
        public static void Start()
        {
            int var1, var2, res;
            string str1, str2;
            var1 = 160;
            var2 = 20;

            res = var1 / var2;
            res /= 2;
            res *= var2;
            res -= var1;
            res += (var2 * 3);
            res %= 27;

            str1 = "Hallo!";
            str2 = "Hier kommt das Ergebnis";

            Console.WriteLine(str1);

            Console.WriteLine(str2);

            Console.WriteLine(res);

            var1 = 3600;
            var2 = 360;

            res = var1 / var2;
            res /= 2;
            res *= var2;
            res -= var1;
            res += (var2 * 3);
            res %= 27;

            Console.WriteLine(res);
        }
    }
}
