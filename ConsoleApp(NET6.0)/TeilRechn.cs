using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class TeilRechn
    {
        public static void Start1()
        {
            Console.Write("Bitte Anzahl der Beteiligten eingeben: ");
            int anzahl = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte Wert zum teilen eingeben: ");
            double gewinn = Convert.ToDouble(Console.ReadLine());
            double[] abteilungen = new double[anzahl];
            for (int i = 0; i < anzahl; i++)
            {
                abteilungen[i] = Convert.ToDouble(Console.ReadLine());
            }
            double einzelnteil = gewinn / abteilungen.Sum();
            for (int i = 0;i < abteilungen.Length;i++)
            {
                Console.WriteLine($"{(abteilungen[i] * einzelnteil):N2}");
            }
        }
        public static void Start2()
        {
            Console.Write("Bitte Anzahl der Beteiligten eingeben: ");
            int anzahl = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte Gewinn eingeben: ");
            double gewinn = Convert.ToDouble(Console.ReadLine());
            double[] abteilungen = new double[anzahl];
            for (int i = 0; i < anzahl; i++)
            {
                abteilungen[i] = Convert.ToDouble(Console.ReadLine());
            }
            double einzelnteil = gewinn / abteilungen.Sum();
            for (int i = 0; i < abteilungen.Length; i++)
            {
                double gewin_teil = abteilungen[i] * einzelnteil;
                Console.WriteLine($"Teil von Gewinn: {gewin_teil:N2}");
                Console.WriteLine($"Gesamte Gewinnteil: {(gewin_teil + abteilungen[i]):N2}");
                
            }
        }        
    }
}
