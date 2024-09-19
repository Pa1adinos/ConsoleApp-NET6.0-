using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Prozent
    {
        public static void Start()
        {
            Console.WriteLine("----- Prozent Rechner -----\n");

            bool program = true;

            while (program)
            {
                Console.Write("Listenpreis in EUR: ");
                double preis = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nLieferantenrabbat in Prozent: ");
                double prozent = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"Listenpreis in EUR: {preis:N2}");
                Console.WriteLine($"Lieferantenrabbat in Prozent: {prozent:N2}\n");
                Console.WriteLine($"Der Einkaufspreis beträgt {preis - (preis*prozent/100):N2} Euro\n\n");
            }
        }
    }
}
