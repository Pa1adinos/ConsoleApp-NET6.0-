using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Übungsblatt2809
    {
        public static void Start()
        {
            // 1
            bool x1 = true, x2 = false, y;

            y = (x1 && x2);
            Console.WriteLine(y);
            y = !(x1 || x2);
            Console.WriteLine(y);
            y = (!x1 && !x2);
            Console.WriteLine(y);
            y = (x1 || x2) && (!x1 && x1);
            Console.WriteLine(y);

            // 2

            int x = 12;
            x += 12;
            Console.WriteLine(x);
            x = 12;
            x *= 12;
            Console.WriteLine(x);
            x = 12;
            x -= 12;
            Console.WriteLine(x);
            x = 12;
            x /= 12;
            Console.WriteLine(x);
            x = 12;
            x %= 12;
            Console.WriteLine(x);
            x = 12;
            x = ((x + x) - (x * 2)) / 4;
            Console.WriteLine(x);
            x = 12;
            x = ++x;
            Console.WriteLine(x);
            x = 12;
            x = x++;
            Console.WriteLine(x);
            x = 12;
            x += ++x + x++;
            Console.WriteLine(x);
            x = 12;
            x = x++ + x;
            Console.WriteLine(x);
            x = 12;
            x = x++ + ++x;
            Console.WriteLine(x);

            // 3

            Console.Write("Bitte Jahr eingeben: ");
            int jahr = Convert.ToInt32(Console.ReadLine());
            if (jahr%4==0 && (jahr%100!=0 || jahr%400==0))
            {
                Console.WriteLine($"{jahr} ist ein Schaltjahr");
            }
            else
            {
                Console.WriteLine($"{jahr} ist kein Schaltjahr");
            }
        }
    }
}
