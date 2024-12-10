using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class StruktDia
    {
        public static void Start1()
        {
            Console.WriteLine("1.\n");
            int urlaub = 26, alter = 0, zug = 0;
            bool behind = false, unterprogram = true;           
            while (unterprogram)
            {
                Console.Write("Bitte Alter eingeben: ");
                while (!int.TryParse(Console.ReadLine(), out alter))
                {
                    Console.WriteLine("Falsche eingabe!");
                    Console.Write("Bitte Alter eingeben: ");
                }
                if (alter < 14 || alter > 100)
                {
                    Console.WriteLine("Ungültige Alter!");
                }
                else
                {
                    unterprogram = false;
                }
            }
            unterprogram = true;
            while (unterprogram)
            {
                Console.Write("Gibt es Schwerbehinderung (ab 50%) (y/n): ");
                string eingabe = Console.ReadLine();
                switch (eingabe.Trim().ToLower())
                {
                    case "y":
                        behind = true; 
                        unterprogram = false;
                        Console.WriteLine("Behinderung: Ja");
                        break;
                    case "n":
                        unterprogram = false;
                        Console.WriteLine("Behinderung: Nein");
                        break;
                    default:
                        Console.WriteLine("Falsche eingabe!");
                        break;
                }
            }
            Console.Write("Betriebszugehörigkeit (in Jahren): ");
            while (!int.TryParse(Console.ReadLine(), out zug))
            {
                Console.WriteLine("Falsche eingabe!");
                Console.Write("Betriebszugehörigkeit (in Jahren): ");
            }
            if (alter >= 14 && alter < 18)
            {
                urlaub += 4;
            }
            else if (alter > 55 && alter < 100)
            {
                urlaub += 2;
            }
            if (behind)
            {
                urlaub += 5;
            }
            if (zug > 10)
            {
                urlaub += 2;
            }
            Console.WriteLine($"Urlaubsanshpruch beträgt: {urlaub} Tage");
        }
        public static void Start2()
        {
            Console.WriteLine("2.\n");
            int a = 1;
            int sum = 0;
            while (a < 5)
            {
                sum += a;
                if (a > 3)
                {
                    sum--; 
                }
                a++;
            }
            Console.WriteLine(sum);
        }
        public static void Start3()
        {
            Console.WriteLine("3.\n");
            Random rnd = new Random();
            int[] meteo_array = new int[365];
            int procent = 0, max = 0, sum = 0;

            Console.WriteLine("Messtag\t\tMesswert (mm)");

            for (int i = 0; i < meteo_array.Length; i++)
            {
                procent = rnd.Next(0, 100);
                if (procent < 50)
                {
                    meteo_array[i] = 0;
                }
                else if (procent < 60)
                {
                    meteo_array[i] = rnd.Next(1, 61);
                }
                else if (procent < 95)
                {
                    meteo_array[i] = rnd.Next(60, 101);
                }
                else
                {
                    meteo_array[i] = rnd.Next(100, 131);
                }
                Console.WriteLine($"{i + 1}\t\t{meteo_array[i]}");
                if (meteo_array[i] > max)
                {
                    max = meteo_array[i];
                }
                sum += meteo_array[i];
            }
            Console.WriteLine($"Höchse Niederschlagswert: {max}");
            Console.WriteLine($"Gesamte Niederschlagsmenge: {sum}");
            Console.WriteLine($"Tägliche Durchschnitt: {sum / meteo_array.Length}");
        }
        public static void Start4()
        {
            bool program = true;
            while (program)
            {
                Console.WriteLine("4.\n");
                int menge = 0, rabbat = 0;
                Console.Write("Bitte Bestellmenge eingeben: ");
                while (!int.TryParse(Console.ReadLine(), out menge) && menge < 0)
                {
                    Console.WriteLine("Falsche eingabe!");
                    Console.Write("Bitte Bestellmenge eingeben: ");
                }
                if (menge >= 100)
                {
                    rabbat = 10;
                }
                else if (menge >= 50)
                {
                    rabbat = 7;
                }
                else if (menge >= 10)
                {
                    rabbat = 5;
                }
                Console.WriteLine(rabbat > 0 ? $"Ihre Rabbat beträgt {rabbat}%" : "Sie bekommen kein Rabbat.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
