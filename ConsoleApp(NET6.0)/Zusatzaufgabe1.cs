using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp_NET6._0_
{
    internal class Zusatzaufgabe1
    {
        public static void Farbe(string[] mischung, string farbe) //Mischfarben
        {
            switch (farbe)
            {
                case "Lila":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write($"{mischung[0]}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "Orange":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"{mischung[1]}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "Grün":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{mischung[2]}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        public static void Farbe_orig(string[] colors, string farbe) //Originalfarben
        {
            switch (farbe)
            {
                case "Rot":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{colors[0]}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "Gelb":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{colors[1]}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "Blau":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{colors[2]}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
        public static void Start()
        {
            bool programm = true;
            while (programm)
            {
                string[] colors = { "Rot", "Gelb", "Blau" };
                int choice = 0,
                    choice2 = 0;
                string antwort;

                bool erste_wahl = true;

                while (erste_wahl)
                {
                    //Auswahl 1. Farbe

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("1 - Rot     ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("2 - Gelb     ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("3 - Blau\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Wähle die Nummer erster Farbe aus :");

                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.Write($"Die erste Farbe ist:\t");
                        Farbe_orig(colors, colors[choice - 1]);
                        Console.WriteLine("\n");
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("\nFalshe Eingabe!\n");
                        Thread.Sleep(500);
                        Console.Clear();
                        continue;
                    }

                    Console.WriteLine("Weiter ? (J/N)\n");
                    antwort = Console.ReadLine();

                    switch (antwort.ToLower())
                    {
                        case "j": erste_wahl = false; break;
                        case "n": Console.Clear(); break;
                    }
                }
                Console.Clear();

                //Auswahl 2. Farbe

                bool zweite_wahl = true;

                while (zweite_wahl)
                {
                    Console.Write($"Ersze Farbe: ");
                    Farbe_orig(colors, colors[choice - 1]);
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("1 - Rot     ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("2 - Gelb     ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("3 - Blau\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Wähle die Nummer zweiter Farbe aus :");

                    try
                    {
                        choice2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Ersze Farbe: ");
                        Farbe_orig(colors, colors[choice - 1]);
                        Console.WriteLine("\n");
                        Console.Write($"Die zweite Farbe ist:\t");
                        Farbe_orig(colors, colors[choice2 - 1]);
                        Console.WriteLine("\n");
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("\nFalshe Eingabe!\n");
                        Thread.Sleep(500);
                        Console.Clear();
                        continue;
                    }

                    Console.WriteLine("Weiter ? (J/N)\n");
                    antwort = Console.ReadLine();

                    switch (antwort.ToLower())
                    {
                        case "j": zweite_wahl = false; break;
                        case "n": Console.Clear(); break;
                    }
                }

                Console.Clear();

                //Scherz :)


                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\tBerechnung.");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine("\tBerechnung..");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine("\tBerechnung...");
                    Thread.Sleep(500);
                    Console.Clear();
                }
                //Ergebniss

                string[] mischung = { "Lila", "Orange", "Grün" };

                switch (choice + choice2)
                {
                    case 4:
                        Console.Write("Beim Mischen Farbe \"");
                        Farbe_orig(colors, colors[choice - 1]);
                        Console.Write("\" und Farbe \"");
                        Farbe_orig(colors, colors[choice2 - 1]);
                        Console.Write("\"\nbekommen wir Farbe \t\"");
                        Farbe(mischung, mischung[0]); Console.Write("\"");
                        break;
                    case 3:
                        Console.Write("Beim Mischen Farbe \"");
                        Farbe_orig(colors, colors[choice - 1]);
                        Console.Write("\" und Farbe \"");
                        Farbe_orig(colors, colors[choice2 - 1]);
                        Console.Write("\"\nbekommen wir Farbe \t\"");
                        Farbe(mischung, mischung[1]); Console.Write("\"");
                        break;
                    case 5:
                        Console.Write("Beim Mischen Farbe \"");
                        Farbe_orig(colors, colors[choice - 1]);
                        Console.Write("\" und Farbe \"");
                        Farbe_orig(colors, colors[choice2 - 1]);
                        Console.Write("\"\nbekommen wir Farbe \t\"");
                        Farbe(mischung, mischung[2]); Console.Write("\"");
                        break;
                    default: 
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Wir haben Dreck gemischt :(");
                        break;
                }

                // Noch mal?

                Console.WriteLine("\n\tWillst Du noch ein mal? (J/N)\n");
                antwort = Console.ReadLine();

                switch (antwort.ToLower())
                {
                    case "n": programm = false; break;
                    case "j": Console.Clear(); break;
                }
            }
        }
    }
}
