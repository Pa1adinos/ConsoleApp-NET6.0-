using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe_15_10_24
    {
        public static void Start()
        {/*
            Console.WriteLine("Willkomen! Bitte geben Sie eine Zahl ein!");
            string eingabe = Console.ReadLine();
            int value;
            if (int.TryParse(eingabe, out value))
            {
                if (value > 10 &&  value < 20)
                {
                    Console.WriteLine("Die eingegebene Zahl liegt im Bereich von 10 bis 20!");
                }
                else
                {
                    Console.WriteLine("Die eingegebene Zahl liegt nicht im Bereich von 10 bis 20!");
                }
            }
            else
            {
                Console.WriteLine("Ihre Eingabe ist keine Zahl!");
            }
            */




            /*
            bool eingabe = true;
            int value1=0, value2=0, value3=0;
            string eingabe1, eingabe2, eingabe3;
            
            while (eingabe)
            {
                Console.Write("Hallo! Bitte geben Sie 1. Zahl: ");
                eingabe1 = Console.ReadLine();
                if (int.TryParse(eingabe1, out value1))
                {
                    eingabe = false;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
            }
            eingabe = true;
            while (eingabe)
            {
                Console.Write("Bitte geben Sie 2. Zahl: ");
                eingabe2 = Console.ReadLine();
                if (int.TryParse(eingabe2, out value2))
                {
                    eingabe = false;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
            }
            eingabe = true;
            while (eingabe)
            {
                Console.Write("Bitte geben Sie 3. Zahl: ");
                eingabe3 = Console.ReadLine();
                if (int.TryParse(eingabe3, out value3))
                {
                    eingabe = false;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
            }

            if (value1 > value2 && value1 > value3)
            {
                Console.WriteLine($"Die größte Zahl ist {value1}!");
            }
            else if (value2 > value1 && value2 > value3)
            {
                Console.WriteLine($"Die größte Zahl ist {value2}!");
            }
            else
            {
                Console.WriteLine($"Die größte Zahl ist {value3}!");
            }
            */




            /*
            bool program = true;
            List<int> list = new List<int>();
            int count = 1;

            while (program)
            {
                Console.Write($"Hallo! Bitte geben Sie {count}. Zahl oder drucken Sie \"Return\": ");
                string eingabe = Console.ReadLine();
                if (eingabe == "")
                {
                    program = false;
                }
                else if (int.TryParse(eingabe, out int value))
                {
                    list.Add(value);
                    count++;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe!");
                }               
            }
            int max = list.Max();
            Console.WriteLine($"Die größte Zahl ist {max}!");
            */




            bool program = true;
            int max = int.MinValue;
            int count = 1;

            while (program)
            {
                Console.Write($"Hallo! Bitte geben Sie {count}. Zahl oder drucken Sie \"Return\": ");
                string eingabe = Console.ReadLine();
                if (eingabe == "")
                {
                    program = false;
                }
                else if (int.TryParse(eingabe, out int value))
                {
                    if (value > max)
                    { max = value; }
                    count++;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
            }
            Console.WriteLine($"Die größte Zahl ist {max}!");
        }
    }
}
