using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe22
    {
        public static void Start()
        {
            int sum = 0, counter = 0;
            Console.WriteLine("Bitte Zahlen eingeben und mit Enter bestätigen:");
            do
            {
                bool program = true;                
                while (program)
                {                    
                    string eingabe = Console.ReadLine();
                    if (int.TryParse(eingabe, out int value))
                    {
                        sum += value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Falsche Eingabe!");
                    }
                    
                }
                counter++;
            }
            while (sum < 100);
            Console.WriteLine($"Die Summe der Eingaben: {sum}");
            Console.WriteLine($"Die Anzahl der Eingaben, bis die 100 überschritten wurde: {counter}");            
        }
    }
}
