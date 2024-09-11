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

                    Console.WriteLine("Wähle die Nummer erster Farbe aus :");
                    Console.WriteLine("1 - Rot     2 - Gelb     3 - Blau");

                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"Die erste Farbe ist:\t{colors[choice - 1]}\n");
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
                    Console.WriteLine($"Ersze Farbe: {colors[choice - 1]}\n");
                    Console.WriteLine("Wähle die Nummer zweiter Farbe aus :");
                    Console.WriteLine("1 - Rot     2 - Gelb     3 - Blau");

                    try
                    {
                        choice2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"Ersze Farbe: {colors[choice - 1]}\n");
                        Console.WriteLine($"Die zweite Farbe ist:\t{colors[choice2 - 1]}\n");
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
                    case 4: Console.WriteLine($"Beim Mischen Farbe \"{colors[choice - 1]}\" und Farbe \"{colors[choice2 - 1]}\"\nbekommen wir Farbe \"{mischung[0]}\""); break;
                    case 3: Console.WriteLine($"Beim Mischen Farbe \"{colors[choice - 1]}\" und Farbe \"{colors[choice2 - 1]}\"\nbekommen wir Farbe \"{mischung[1]}\""); break;
                    case 5: Console.WriteLine($"Beim Mischen Farbe \"{colors[choice - 1]}\" und Farbe \"{colors[choice2 - 1]}\"\nbekommen wir Farbe \"{mischung[2]}\""); break;
                    default: Console.WriteLine("Wir haben Dreck gemischt :("); break;
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
