using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Tag4
    {
        public static void Start()
        {
            Console.WriteLine("----- Tag 4 -----\n");

            int x = 42;
            int y = 666;

            int temp = y;
            y = x;
            x = temp;

            bool isGr = y > x;
            bool isGr2 = x > y;

            Console.WriteLine(isGr); //False

            string vergleich_yx = isGr ? "Ja" : "Nein";
            string vergleich_xy = isGr2 ? "Ja" : "Nein";

            Console.WriteLine($"Ist {y} grösser als {x} ?\n\n{vergleich_yx}.\n\n");
            Console.WriteLine($"Ist {x} grösser als {y} ?\n\n{vergleich_xy}.\n");

            Console.WriteLine("\n-----------------\n");

            string vorname = "Anatolij";
            string nachname = "Imgrund";

            string ort = "Burglengenfeld";

            string fach = "Anwendungsentwickler";

            string ausgabe = "Hallo, Herr "
                + vorname + " "
                + nachname + ".\n";

            Console.WriteLine(ausgabe);

            string ausgabeFormat = string.Format("Hallo, {0} {1}.\nSie sind {2} Jahre alt und wohnen in {3}.\nSie sind {4}.\n", vorname, nachname, 36, ort, fach);

            Console.WriteLine(ausgabeFormat);


        }
    }
}
