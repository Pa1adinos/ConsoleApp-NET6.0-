using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Widerstand
    {
        public static void Start()
        {
            Console.WriteLine("----- Widerstand und Leistung ausrechnung -----\n");

            bool program = true;

            while (program)
            {
                Console.Write("\nSpannung U in Volt:  ");
                double spannung = Convert.ToDouble(Console.ReadLine());               
                Console.Write("Stromstärke I in Ampere: ");
                double stromstaerke = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("----- Widerstand und Leistung ausrechnung -----\n");
                Console.WriteLine($"\nSpannung U in Volt:  {spannung:N2}");
                Console.WriteLine($"\nStromstärke I in Ampere:  {stromstaerke:N2}");
                Console.WriteLine($"\nDer elektrische Widerstand R beträgt {spannung/stromstaerke:N2} Ohm");
                Console.WriteLine($"\nDie elektrische Leistung P beträgt {spannung*stromstaerke:N2} Watt");
            }
        }
    }
}
