using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Tag5
    {
        public static void Start()
        {
            Console.WriteLine("----- Tag 5 -----\n");

            string str = "Das ist ein string";

            int str_len = str.Length;

            Console.WriteLine(str_len);

            string str_upper = str.ToUpper();

            Console.WriteLine(str_upper);

            string str_lower = str.ToLower();

            Console.WriteLine(str_lower);

            Console.WriteLine($"Die Leange von \"{str}\" ist {str_len}");

            for (int i  = 0; i <= str_len; i++)
            {
                Console.WriteLine(str.Substring(0, i));
            }

            Console.WriteLine($"Die 1. Hälfte vom \"{str}\" ist \"{str.Substring(0, str_len / 2)}\"");
            Console.WriteLine($"Die 2. Hälfte vom \"{str}\" ist \"{str.Substring(str_len / 2, str_len / 2)}\"");


        }
    }
}
