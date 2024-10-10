using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe16
    {
        public static void Start()
        {
            Console.WriteLine("Herzlich willkomen!");
            Console.WriteLine("Bitte machen Sie eine Eingabe:");
            string input_1 = Console.ReadLine();
            int value_1;
            if (int.TryParse(input_1, out value_1))
            {
                value_1 %= 10;
                value_1++;
            }
            else
            {
                value_1 = (input_1.Length * 2) % 10;
                value_1++;
            }
            Console.WriteLine("Bitte machen Sie eine weitere Eingabe:");
            string input_2 = Console.ReadLine();
            int value_2;
            if (int.TryParse(input_2, out value_2))
            {
                value_2 *= 3;
            }
            else
            {
                value_2 = (input_2.Length * 5) % 100;
            }
            Console.Clear();
            double ergebnis = value_2 / value_1;
            Console.WriteLine($"Das Ergebnis ist: {value_2} / {value_1} = {ergebnis}");
        }
    }
}
