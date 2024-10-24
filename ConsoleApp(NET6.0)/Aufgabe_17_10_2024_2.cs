using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe_17_10_2024_2
    {
        public static void Start()
        {
            Console.Write("Geben Sie bitte eine Zeichenkette ein (Zahl, Kommazahl oder belibige Text):\t");
            string eingabe = Console.ReadLine();
            if (int.TryParse(eingabe, out int int_value))
            {
                Console.WriteLine("Die Eingabe ist eine Ganzzahl.");
            }
            else
            {
                if (double.TryParse(eingabe, out double double_value))
                {
                    Console.WriteLine("Die Eingabe ist eine Kommazahl.");
                }
                else
                {
                    Console.WriteLine("Das ist ein String.");
                    Console.WriteLine($"Die Länge: {eingabe.Length}");
                    Console.WriteLine($"Das erste Zeichen ist: {eingabe[0]}");
                    Console.WriteLine($"Das letzte Zeichen ist: {eingabe[eingabe.Length-1]}");
                }
            }
        }
    }
}
