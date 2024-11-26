using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe21
    {
        public static void Start()
        {
            bool program = true, unterprogram = true;
            int[] array = new int[1];
            int counter = 0;
            while (program)
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein:");
                string eingabe = Console.ReadLine();
                if (int.TryParse(eingabe, out int zahl))
                {
                    array[counter] = zahl;
                    counter++;                   
                }
                else
                {
                    Console.WriteLine("Falsche eingabe!");
                    continue;
                }
                unterprogram = true;
                while (unterprogram)
                {
                    Console.WriteLine("Soll noch eine Zahl eingegeben werden? (y/n)");
                    eingabe = Console.ReadLine();
                    switch (eingabe.Trim().ToLower())
                    {
                        case "y": { unterprogram = false; Array.Resize(ref array, array.Length + 1); continue;}
                        case "n": { program = false; unterprogram = false; break; }
                        default: { Console.WriteLine("Falsche eingabe!"); continue; }
                    }
                }
            }
            Console.WriteLine("Ihr Ergebnis:");
            int ausgabe = 0;
            for (int i = 0; i < array.Length; i++)
            {
                ausgabe += array[i];
                Console.WriteLine(ausgabe);
            }
        }
    }
}
