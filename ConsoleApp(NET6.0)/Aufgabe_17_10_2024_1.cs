using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe_17_10_2024_1
    {
        public static void Start()
        {
            Console.WriteLine("\tOnline-Shop\n");
            bool program = true;
            double betrag = 0;

            while (program)
            {
                Console.Write("Bitte geben Sie den Bestellwert in Euro ein:\t");
                if (!double.TryParse(Console.ReadLine(), out betrag))
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
                else
                {
                    program = false;
                }
            }

            program = true;
            string code = "";
            double rabbat = 0;

            while (program)
            {
                Console.Write("Bitte geben Sie den Rabbatcode ein:\t");
                code = Console.ReadLine().ToUpper();
                switch (code)
                {
                    case "SOMMER20":
                        rabbat = 20;
                        program = false;
                        break;
                    case "WINTER15":
                        rabbat = 15;
                        program = false;
                        break;
                    case "FREUND5":
                        rabbat = 5;
                        program = false;
                        break;
                    default:
                        Console.WriteLine("Ungültige Code!");
                        Console.Write("Weiter ohne code? (y/n):\t");
                        string answer = Console.ReadLine().ToLower();
                        while (answer != "y" && answer != "n")
                        {
                            Console.WriteLine("Falsche Eingabe!");
                            Console.Write("Weiter ohne code? (y/n):\t");
                            answer = Console.ReadLine();
                        }
                        switch (answer)
                        {
                            case "y":
                                program = false;
                                break;
                            case "n":
                                break;
                        }
                        break;
                }
            }
            double result = betrag - ((betrag * rabbat) / 100);
            Console.WriteLine($"Der endgültige Preis beträgt: {result:N2} Euro");
        }
    }
}
