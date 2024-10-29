using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe_19
    {
        public static void Start()
        {
            int[] array = new int[5];
            Console.WriteLine("Array mit 5 freie Plätze erstellt\n");
            Thread.Sleep(500);
            Console.WriteLine("for-schleife:\tint i = 0; i < 5; i++\n");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Bitte geben Sie die {i + 1}. Zahl ein:\t");
                if (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    array[i] = -1;
                }
                Console.WriteLine($"\nIteration {i+1}.\ti = {i}\tarray[{i}] = {array[i]}\n");
                Thread.Sleep(500);
                Console.Write($"Array: [  ");
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{array[j]}  ");
                }
                Console.WriteLine("]\n");
            }
            Thread.Sleep(500);
            Console.WriteLine($"Die Summe der Zahlen: {array.Sum()}");
            Console.WriteLine($"Die größte Zahl: {array.Max()}");
            Console.WriteLine($"Die kleinste Zahl: {array.Min()}");
            Console.WriteLine($"Der MittelWert: {array.Sum() / array.Length}");
        }
    }
}
