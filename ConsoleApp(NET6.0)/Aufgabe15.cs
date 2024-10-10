using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe15
    {
        public static void Start()
        {
            Console.Write("Bitte ein Wert eingeben: ");
            string input = Console.ReadLine();
            Console.Clear();
            if (int.TryParse(input, out int value))
            {
                if (value%2==0)
                {
                    Console.WriteLine($"Der eingegebene Wert \"{input}\" ist eine Zahl und die Hälfte ist \"{value/2}\".");
                }
                else
                {
                    Console.WriteLine($"Der engegebene Wert \"{input}\" ist eine Zahl und die Hälfte ist \"{value/2}\" mit dem Rest {value%2}.");
                }
            }
            else
            {
                if (input.Length % 2 ==0)
                {
                    Console.WriteLine($"Der eingegebene Wert \"{input}\" ist ein String und die Hälfte ist \"{input.Substring(0, input.Length/2)}\" und \"{input.Substring(input.Length/2, input.Length/2)}\".");
                }
                else
                {
                    Console.WriteLine($"Der eingegebene Wert \"{input}\" ist ein String und die Hälfte ist \"{input.Substring(0, input.Length/2)}\" und \"{input.Substring(input.Length/2+1, input.Length/2)}\" mit dem mittleren Buchstaben \"{input[input.Length/2]}\".");
                }
            }
        }
    }
}
