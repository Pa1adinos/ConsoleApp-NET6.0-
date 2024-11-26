using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe_schleife
    {
        public static void Start1()
        {
            for (int i = 0; i < 21; i += 2)
            {
                Console.Write($"{i} ");
            }
        }
        public static void Start2()
        {
            Console.WriteLine("Eine ganze Zahl eingeben:");
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        public static void Start3()
        {
            Console.WriteLine("Eine ganze Zahl eingeben:");
            int input = Convert.ToInt32(Console.ReadLine());
            int fakulteat = 1;
            for (int i = 1; i <= input; i++)
            {
                fakulteat *= i;
            }
            Console.WriteLine(fakulteat);
        }
        public static void Start4()
        {
            int max = int.MinValue;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Bitte Zahl {i+1} eingeben:");
                int input = Convert.ToInt32(Console.ReadLine());
                if ( input > max )
                {
                    max = input;
                }
            }
            Console.WriteLine($"Maximale Zahl ist : {max}");
        }
        public static void Start5()
        {
            Console.WriteLine("Bitte ein logische Operator auswählen (AND, OR, NAND, XOR):");
            string eingabe = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Bitte X Wert eingeben (1 oder 0):");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte Y Wert eingeben (1 oder 0):");
            int y = Convert.ToInt32(Console.ReadLine());
            bool X = Convert.ToBoolean(x),
                 Y = Convert.ToBoolean(y);

            switch (eingabe)
            {
                case "and": Console.WriteLine(X && Y); break;
                case "or": Console.WriteLine(X || Y); break;
                case "nand": Console.WriteLine(!(X && Y)); break;
                case "xor": Console.WriteLine(!(X == Y)); break;
                default: Console.WriteLine("Die Eingabe war falsch :("); break;
            }
        }
    }
}
