using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe9
    {
        public static void Start()
        {
            Console.WriteLine("----- Aufgabe 9 -----\n");

            while (true)
            {
                Console.WriteLine("Bitte geben Sie einen String ein:");

                string str = Console.ReadLine().Trim(),
                       str_upper = str.ToUpper();

                Console.WriteLine($"Länge: {str.Length}");
                Console.WriteLine($"Erster Buchstabe: {str_upper[0]}");
                Console.WriteLine($"Letzter Buchstabe: {str_upper[str.Length - 1]}");
                Console.WriteLine();
            }
        }
    }
}
