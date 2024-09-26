using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe14
    {
        public static void Start()
        {
            int num;
            Console.Write("Zahl eingeben: ");
            int.TryParse(Console.ReadLine().Trim(), out num);
            Console.WriteLine(num%2==0 ? "Die Zahl ist Gerade!" : "Die Zahl ist ungerade!");
            Console.WriteLine(num<10 ? "Die Zahl ist kleiner als 10!" : "Die Zahl ist größer als 10!");
            Console.WriteLine(num>=10 && num<=100 ? "Die Zah ist zwischen 10 und 100!" : "Die Zahl ist nicht zwischen 10 und 100");
            Console.WriteLine(num>100 ? "Die Zahl ist größer als 100!" : "Die Zahl ist kleine als 100!");
            Console.WriteLine(num%7==0 ? "Die Zahl ist durch 7 teilbar!" : "Die Zahl ist nicht durch 7 teilbar!");
            Console.WriteLine(num/1000 < 1 ? "Die Zahl hat 3 oder weniger Stellen!" : "Die Zahl hat mehr als 3 Stellen!");
        }
    }
}
