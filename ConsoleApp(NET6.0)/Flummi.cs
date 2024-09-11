using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Flummi
    {
        public static void Start()
        {
            bool programm = true;

            while (programm)
            {
                Console.WriteLine("Flummi");
                Console.WriteLine("Gib die Startfallhöhe für Flummi und Masseinheit nach der Leertaste\n");
                Console.WriteLine("z.B. \t[1,56 m] oder [2.75 cm] oder [3560 cm]\n");
                Console.Write("Eingabe:  ");
                

                double hoehe = 1.0;

                //
                int count = 0;

                try
                {
                    
                    string[] eingabe = Console.ReadLine().Split(" ");
                    if (eingabe[1].ToLower() == "m")
                    {
                        hoehe = Math.Round(Convert.ToDouble(eingabe[0].Replace(".", ",")), 2);
                        while (hoehe > 0.01)
                        {
                            hoehe /= 2;
                            count++;
                            Console.WriteLine($"Der Flummi ist {Math.Round(hoehe, 3)} m hoch gesprungen.\n");
                        }
                    }
                    else if (eingabe[1].ToLower() == "cm")
                    {
                        hoehe = Math.Round(Convert.ToDouble(eingabe[0].Replace(".", ",")), 2);
                        while (hoehe > 1)
                        {
                            hoehe /= 2;
                            count++;
                            Console.WriteLine($"Der Flummi ist {Math.Round(hoehe, 3)} cm hoch gesprungen.\n");
                        }
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("\nFalsche Eingabe!");
                    Thread.Sleep(500);
                    Console.Clear();
                }

                Console.WriteLine($"Der Fluppi hat Höhe unter 1 cm (0,01 m) für {count} Sprünge errecht.");
                Thread.Sleep(1000);

                // Neustart
                bool ende = true;
                while (ende)
                {
                    Console.WriteLine("\n\tWillst Du noch ein mal? (J/N)\n");
                    string antwort = Console.ReadLine();
                    try
                    {
                        switch (antwort.ToLower())
                        {
                            case "n": programm = false; ende = false; break;
                            case "j": Console.Clear(); ende = false; break;
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("\nFalsche Eingabe!");
                        Thread.Sleep(500);
                        Console.Clear();
                    }
                }
            }
        }
    }
}
