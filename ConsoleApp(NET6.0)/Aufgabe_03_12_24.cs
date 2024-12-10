using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe_03_12_24
    {
        public static void Start1()
        {
            Console.WriteLine("Aufgabe 1");
            Console.WriteLine("Bitte 5 Namen eingeben:");
            string[] namen = new string[5];
            for (int i = 0; i < namen.Length; i++)
            {
                namen[i] = Console.ReadLine();
            }
            foreach (string str in namen)
            {
                Console.WriteLine($"Hallo, {str}!");
            }
        }
        public static void Start2()
        {
            Console.WriteLine("Aufgabe 2");
            Console.WriteLine("Bitte Text eingeben:");
            string eingabe = Console.ReadLine();
            string[] strings = eingabe.Split();
            Console.WriteLine("\nDie Wörter länger als 3:\n");
            for (int i = 0;i < strings.Length;i++)
            {
                if (strings[i].Length > 3)
                {
                    Console.WriteLine(strings[i]);
                }
            }
        }
        public static void Start3()
        {
            Console.WriteLine("Aufgabe 3");
            string[] todo = new string[0];
            int counter = 0;
            Console.WriteLine("To-Do-Liste ausfüllen (leer lassen zum beenden): ");
            while (true)
            {
                Console.Write($"{counter+1}. ");
                string eingabe = Console.ReadLine();
                if (eingabe == "")
                {
                    break;
                }
                else
                {
                    Array.Resize(ref todo, todo.Length+1);
                    todo[counter] = eingabe;
                    counter++;
                }
                Console.WriteLine();
            }
            if (todo.Length > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Sie haben {todo.Length} Auggaben in der Liste");
                Console.WriteLine($"Bitte geben Sie ein Nummer von 1 bis {todo.Length}");
                Console.Write("Nummer: ");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int index) && index <= todo.Length && index > 0)
                    {
                        Console.WriteLine($"{index}. {todo[index-1]}");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Falsche Eingabe!");
                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("Sie haben keine Pläne eingegeben.");
            }
        }
        public static void Start4()
        {
            Console.WriteLine("Aufgabe 4");
            Console.WriteLine("Bitte Text eingeben:");
            string eingabe = Console.ReadLine();
            string eingabe_korregiert = eingabe.Replace(',', ' ').Replace('.', ' ').Replace(';', ' ').Replace(':', ' ').Replace('(', ' ').Replace(')', ' ').Replace('"', ' ');
            eingabe_korregiert = eingabe_korregiert.Trim();
            string[] strings = eingabe_korregiert.Split();
            foreach (string s in strings)
            {
                Console.Write($"{s.ToUpper()} ");
            }
        }
        public static void Start5()
        {
            Console.WriteLine("Aufgabe 5");
            Console.WriteLine("Bitte Text eingeben:");
            string eingabe = Console.ReadLine();
            string eingabe_korregiert = eingabe.Replace(',', ' ').Replace('.', ' ').Replace(';', ' ').Replace(':', ' ').Replace('(', ' ').Replace(')', ' ').Replace('"', ' ');
            eingabe_korregiert = eingabe_korregiert.Trim();
            string[] strings = eingabe_korregiert.Split();
            Console.WriteLine($"Wort\t\t\t\tLänge\n");
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length > 8)
                {
                    Console.WriteLine($"{strings[i]}\t\t\t{strings[i].Length}");
                }
                else
                {
                    Console.WriteLine($"{strings[i]}\t\t\t\t{strings[i].Length}");
                }
            }
        }
        public static void Start6()
        {
            Console.WriteLine("Aufgabe 6");
        }
    }
}
