using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class SA1
    {
        public static void Start()
        {
            /*  Anatolij
             *  Imgrund
             *  ITFA-1  */
            int zahlAI;
            string eingabe_stringAI;
            Console.WriteLine("Geben Sie eine Ganzzahl oder ein Wort ein!");
            eingabe_stringAI = Console.ReadLine();
            if (int.TryParse(eingabe_stringAI, out zahlAI))
            {
                int ergebnisAI;
                ergebnisAI = zahlAI * 3;
                Console.WriteLine(ergebnisAI);
            }
            else
            {
                char zeichenAI;
                zeichenAI = eingabe_stringAI[0];
                Console.WriteLine(zeichenAI);
            }
        }
    }
}
