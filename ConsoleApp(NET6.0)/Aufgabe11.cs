using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe11
    {
        public static void Start()
        {
            Console.WriteLine("----- Aufgabe 11 -----\n");
            Console.Write("Bitte geben Sie eine Zahl ein:  ");
            int eingabe = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Ihre eingegebene Zahl: {eingabe}");
            Console.WriteLine($"Das ist das Doppelte: {eingabe*2}");
            Console.WriteLine($"Das ist die Hälfte: {eingabe/2}");
            Console.WriteLine($"Das ist der Rest bei der Teilung durch 7: {eingabe%7}");
        }
    }
}
