using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe_17_10_2024_3
    {
        public static void Start()
        {
            bool program = true;
            while (program) {
                Console.WriteLine("Wählen Sie einen logischen Operator aus:");
                Console.WriteLine("UND:\t\t1");
                Console.WriteLine("ODER:\t\t2");
                Console.WriteLine("NAND:\t\t3");
                Console.WriteLine("XOR:\t\t4");
                Console.Write("Auswahl:\t");
                string auswahl = Console.ReadLine();

                while (auswahl != "1" && auswahl != "2" && auswahl != "3" && auswahl != "4")
                {
                    Console.WriteLine("Falsche Eingabe!");
                    Console.Write("Auswahl:\t");
                    auswahl = Console.ReadLine();
                }

                Console.WriteLine("Geben Sie die Werte für X und Y ein ( 0 oder 1 ):");
                Console.Write("X:\t\t");
                string x = Console.ReadLine();

                while (x != "1" && x != "0")
                {
                    Console.WriteLine("Falsche Eingabe!");
                    Console.Write("X:\t\t");
                    x = Console.ReadLine();
                }

                Console.Write("Y:\t\t");
                string y = Console.ReadLine();

                while (y != "1" && y != "0")
                {
                    Console.WriteLine("Falsche Eingabe!");
                    Console.Write("Y:\t\t");
                    y = Console.ReadLine();
                }

                string gesucht = x + y;
                string ergebnis = "0";
                switch (auswahl)
                {
                    case "1":
                        if (gesucht == "00")
                        { ergebnis = "0"; }
                        else if (gesucht == "01")
                        { ergebnis = "0"; }
                        else if (gesucht == "10")
                        { ergebnis = "0"; }
                        else
                        { ergebnis = "1"; }
                        break;
                    case "2":
                        if (gesucht == "00")
                        { ergebnis = "0"; }
                        else if (gesucht == "01")
                        { ergebnis = "1"; }
                        else if (gesucht == "10")
                        { ergebnis = "1"; }
                        else
                        { ergebnis = "1"; }
                        break;
                    case "3":
                        if (gesucht == "00")
                        { ergebnis = "1"; }
                        else if (gesucht == "01")
                        { ergebnis = "1"; }
                        else if (gesucht == "10")
                        { ergebnis = "1"; }
                        else
                        { ergebnis = "0"; }
                        break;
                    case "4":
                        if (gesucht == "00")
                        { ergebnis = "0"; }
                        else if (gesucht == "01")
                        { ergebnis = "1"; }
                        else if (gesucht == "10")
                        { ergebnis = "1"; }
                        else
                        { ergebnis = "0"; }
                        break;
                }
                Console.WriteLine($"Das Ergebnis ist:\t {ergebnis}\n\n");
            }
        }
    }
}
