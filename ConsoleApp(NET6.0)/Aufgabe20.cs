using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe20
    {
        public static void Start()
        {
            int[] array = { 34, 5, 83, 28, 44, 99, 30, 72, 28 };
            Console.WriteLine($"| Zahl: \t| Hälfte:\t| Doppelte: ");
            Console.WriteLine($"|---------------|---------------|-----------");
            foreach (int i in array)
            {
                Console.WriteLine($"| {i} \t\t| {i/2} \t\t| {i*2} ");
            }
        }
    }
}
