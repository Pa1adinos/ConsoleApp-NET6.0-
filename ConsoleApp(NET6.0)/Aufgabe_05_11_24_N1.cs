using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe_05_11_24_N1
    {
        public static void Start1()
        {
            for (int i = 0; i < 100;  i++)
            {
                Console.WriteLine($"{i+1}. {i}^2 = {i*i}");
            }
        }
        public static void Start2()
        {
            string[] array = new string[5];
            for (int i = 0;i < 5;i++)
            {
                Console.Write($"Bitte Wort {i+1} aus 5 eingeben:\t");
                array[i] = Console.ReadLine();
            }
            for (int i = 4; i >= 0 ;i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
        public static void Start3()
        {
            double[] array_1 = new double[5], array_2 = new double[5];
            //Erste Array Auffüllen
            for (int i = 0 ;i < 5 ;)
            {
                Console.Write($"Bitte Zahl {i+1} aus erste 5 Zahlen eingeben: ");
                if(double.TryParse(Console.ReadLine(), out double value))
                {
                    array_1[i] = value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
            }
            //Zweite Array Auffüllen
            for (int i = 0; i < 5;)
            {
                Console.Write($"Bitte Zahl {i + 1} aus zweite 5 Zahlen eingeben: ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    array_2[i] = value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
            }
            Console.WriteLine($"{array_1[0]} + {array_2[0]} = {array_1[0] + array_2[0]}");
            Console.WriteLine($"{array_1[1]} - {array_2[1]} = {array_1[1] - array_2[1]}");
            Console.WriteLine($"{array_1[2]} * {array_2[2]} = {array_1[2] * array_2[2]}");
            Console.WriteLine($"{array_1[3]} : {array_2[3]} = {array_1[3] / array_2[3]}");
            Console.WriteLine(array_1[4] > array_2[4] ? $"{array_1[4]} > {array_2[4]}" : $"{array_1[4]} < {array_2[4]}");
        }
        public static void Start4()
        {
            int[] array = {};
            for (int i = 0 ; i < 1 ;)
            {
                Console.Write("Bitte eine Zahl eingeben (\"stop\" falls Programm beendet sein muss): ");
                string eingabe = Console.ReadLine().ToLower();
                if (eingabe == "stop")
                {
                    i++;
                }
                else if(int.TryParse(eingabe,out int value))
                {
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length-1] = value;
                }
                else
                {
                    Console.WriteLine("Falsche eingabe!");
                }
            }
            Console.Write("Dein INT Array: ");
            for (int j = 0; j < array.Length; j++)
            { Console.Write($"{array[j]} "); }
        }
    }
}
