using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Kompr
    {
        public static void Komp()
        {
            Console.Clear();
            Console.WriteLine("Gib ein Text (Format \"WWWJjdbhbHHH\" zum bearbeiten ein.\n");
            Console.Write("Eingabe:  ");            
            string text = Console.ReadLine();
            Console.WriteLine("\n");
            int count = 1;
            
            Console.Write("Ergebnis:  ");

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == text[i + 1])
                { count++; }
                else
                { Console.Write($"%{count}%{text[i]}"); count = 1; }
            }
            if (text.Length > 0)
            {
                Console.Write($"%{count}%{text[text.Length - 1]}\n");
            }
            Console.WriteLine("\n");
        }       
        public static void Entkomp()
        {
            Console.Clear();
            Console.WriteLine("Gib ein Text (Format \"%5%G%2%f%2%4\" zum bearbeiten ein.\n");
            Console.Write("Eingabe:  ");

            try
            {                
                string text = Console.ReadLine().Replace("%", "");
                Console.WriteLine("\n");
                Console.Write("Ergebnis:  ");
                for (int i = 0;i < text.Length - 1;i+=2)
                {
                    int repeat = Convert.ToInt32(Convert.ToString(text[i]));
                    for (int j = 0;j < repeat;j++)
                    { 
                        Console.Write(text[i + 1]);
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
            Console.WriteLine("\n");
        }
        public static void Start()
        {
            Console.WriteLine("\t\t\tK-O-M-P-R\n");
            bool programm = true;
            while (programm)
            {
                bool wahl = true;
                while (wahl)
                {
                    Console.WriteLine("\n\tWillst Du [1 - Komplimieren] oder [2 - Entkoplimieren] ?\n");
                    string antwort = Console.ReadLine();
                    try
                    {
                        switch (antwort.ToLower())
                        {
                            case "1": Komp(); wahl = false; break;
                            case "2": Entkomp(); wahl = false; break;
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
