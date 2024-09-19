using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class WH2
    {
        public static void Start()
        {
            Console.Write("Teile mir deine Name mit: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Schönen Tag, {name}!");
            Console.WriteLine("Gib mir zwei Zahlen, die ich für dich addire.");
            Console.Write("\n1. Zahl:  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n2. Zahl:  ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nDie Summe von {a} und {b} ist {a+b}\n");
            Console.Write("Teile mir dein Alter mit: ");
            int alter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nWoow! {alter} Jahre Alt... Du bist schon aber gross! :)");
        }
    }
}
