using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class FibonacciZ
    {
        public static void Start()
        {            
            

            bool programm = true;

            while (programm)
            {
                Console.WriteLine("----- Fibonacci -----\n");
                Console.WriteLine("Gib eine Zahl ein, die wir in Fibonaccireihe suchen werden:\n");
                int suche = 0;
                try
                {
                    suche = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("\nFalsche Eingabe!");
                    Thread.Sleep(500);
                    Console.Clear();
                }
                
                long num_1 = 0,
                     num_2 = 1,
                     temp = 0;
                int count = 1;

                Console.WriteLine($"[  {count}\t][\t{num_1}\t\t]");

                while (num_1 < suche)
                {
                    temp = num_1;
                    num_1 = num_2;
                    num_2 = temp + num_1;
                    count++;
                    Console.WriteLine($"[  {count}\t][\t{num_1}\t\t]");
                }

                Console.WriteLine(num_1 == suche ? $"\nDie Zahl {suche} ist in der Fibonaccireihe auf der {count}. Stelle." : $"\nDie Zahl {suche} ist nicht in der Fibonaccireihe");
                
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