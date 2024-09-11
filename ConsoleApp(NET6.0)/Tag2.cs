using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Tag2
    {
        public static void Start()
        {
            Console.WriteLine("Tag 2\n----------");
            
            
            int num = 1;
            string str = "text";
            char ch = 'A';
            double doub = 3.14;
            float fl = 3.14f;
            decimal dec = 3.14m;
            bool boo = true;
            Console.WriteLine($"integer = {num}\nstring = {str}\nchar = {ch}\ndouble = {doub}\nfloat = {fl}\ndecimal = {dec}\nbool = {boo}\n");
            
            Console.WriteLine("----------");
            Console.WriteLine("++ / --");
            int z = num + 122;
            Console.WriteLine($"z = {z}");
            z++;
            Console.WriteLine($"z++ = {z}");
            z--;
            Console.WriteLine($"z-- = {z}");
            z--;
            Console.WriteLine("und noch mal --");
            Console.WriteLine($"z-- = {z}");
            Console.WriteLine("und wieder ++");
            z++;
            Console.WriteLine($"z++ = {z}");
            Console.WriteLine("----------\n");
            

            Console.WriteLine("Berechnung\n----------");
            Console.WriteLine($"24 + 14 - 34 / 12 * 2 % 4 = \n{24 + 14 - 34 / 12 * 2 % 4}\n");
            Console.WriteLine($"23847 + 3333 / 34 * 22 - 12 + 2343234 % 6 = \n{23847 + 3333 / 34 * 22 - 12 + 2343234 % 6}\n");
            Console.WriteLine($"123,34 / 2344,3 - 12035,55 / 4,9 * 123,2 = \n{123.34 / 2344.3 - 12035.55 / 4.9 * 123.2}\n");
            Console.WriteLine($"948475,23423 * 7 - 23433,833 % 22,66 + 34,3 * 4 = \n{948475.23423 * 7 - 23433.833 % 22.66 + 34.3 * 4}\n");
            Console.WriteLine($"2343 - 3434,2 * 333,33 - 3333,88 / 77777,1 + 12,33 % 0,3336 = \n{2343 - 3434.2 * 333.33 - 3333.88 / 77777.1 + 12.33 % 0.3336}\n");

            
            Console.WriteLine("\n---------");
            int count = 10;
            Console.WriteLine("* * * * * * * * * * * * *");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"*           {i}           *");
            }
            Console.WriteLine("* * * * * * * * * * * * *");
            Console.WriteLine("---------");
            

            for (int i =1; i <= count; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n---------\n");
            int a = 5;
            int b = 4;
            int c = 6;
            if (a > b)
            {
                Console.WriteLine($"{a} grösse als {b}");
            }
            if (b > c)
            {
                Console.WriteLine($"{b} grösser als {c}");
            }
            else
            {
                Console.WriteLine($"{c} grösser als {b}");
            }
            switch (a)
            {
                case 0: Console.WriteLine(0);
                break;

                case 1: Console.WriteLine(1);
                break;

                case 2: Console.WriteLine(2);
                break;

                case 3: Console.WriteLine(3);
                break;

                case 4: Console.WriteLine(4);
                break;

                case 5: Console.WriteLine(5);
                break;
            }
            
        }
    }
}