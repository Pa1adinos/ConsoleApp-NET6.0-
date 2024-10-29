using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe_18
    {
        public static void Start()
        {
            bool program = true;
            while (program)
            {
                Console.WriteLine("Bitte geben Sie eine Begrüßung ein:");
                string eingabe = Console.ReadLine();
                Console.WriteLine("Hi!");
                switch (eingabe.Trim().ToLower())
                {
                    case "hallo":   
                    case "hello":
                    case "hi":
                    case "servus":
                        Console.WriteLine($"Die Begrüßung '{eingabe}' kenne ich :D\n");
                        break;
                    case "exit":
                        Console.WriteLine("und Tschüß :)");
                        program = false;
                        break;
                    default:
                        Console.WriteLine("Leider kenne ich die Begrüßung nicht :(\n");
                        break;
                }
            }
        }
    }
}
