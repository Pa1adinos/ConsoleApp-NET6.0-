using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Switchcase
    {
        public static void Start()
        {
            Console.WriteLine("1. Neues Dokument\n2. Dokument öffnen\n3. Exit");
            Console.Write("Bite wählrn Sie 1, 2 odr 3 aus:\t");
            int auswahl = Convert.ToInt32(Console.ReadLine());

            switch(auswahl)
            {
                case 1:
                    Console.WriteLine("1. Dokument erschtellt");
                    break;
                case 2:
                    Console.WriteLine("2. Dokument geöffnet");
                    break;
                case 3:
                    Console.WriteLine("3. Tschüss");
                    break;
                default:
                    Console.WriteLine("ungültige Nummer");
                    break;
            }
        }
    }
}
