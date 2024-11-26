using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe_05_11_24_N2
    {
        public static void Start1()
        {
            int[] array = new int[10];
            int sum = 0;
            for (int i = 0; i < array.Length;)
            {
                Console.Write($"Bitte Zahl {i+1} von 10 eingeben: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    array[i] = value;
                    sum += value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Falsche eingabe!");
                }
            }
            Console.Write("Die Summe von Zahlen ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.Write($"ist {sum}");
        }
        public static void Start2() 
        {
            int[] array = new int[5];
            int min = int.MaxValue, max = int.MinValue;
            for (int i = 0; i < array.Length;)
            {
                Console.Write($"Bitte Zahl {i + 1} von {array.Length} eingeben: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    array[i] = value;
                    if (value > max)
                    { max = value; }
                    if (value < min)
                    { min = value; }
                    i++;
                }
                else
                {
                    Console.WriteLine("Falsche eingabe!");
                }
            }
            Console.Write("Die Zahlen: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"{max} ist die grösste Zahl");
            Console.WriteLine($"{min} ist die kleinste Zahl");
        }
        public static void Start3() 
        {
            int[] array = new int[5];
            int sum = 0;
            for (int i = 0; i < array.Length;)
            {
                Console.Write($"Bitte Zahl {i + 1} von {array.Length} eingeben: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    array[i] = value;
                    sum += value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Falsche eingabe!");
                }
            }
            Console.Write("Der Durchschnitt von Noten ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.Write($"ist {Convert.ToDouble(sum)/Convert.ToDouble(array.Length)}");
        }
        public static void Start4() 
        {
            int[] array = new int[5];
            int sum = 0;
            for (int i = 0; i < array.Length;)
            {
                Console.Write($"Bitte Zahl {i + 1} von {array.Length} eingeben: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    array[i] = value;
                    sum += value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Falsche eingabe!");
                }
            }
            int[] array_2 = new int[5];
            int j = 0;
            for (int i = 4; i >= 0; i--)
            {
                array_2[i] = array[j];
                j++;
            }

            Console.Write("Array 1: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.Write("Array 2: ");
            for (int i = 0; i < array_2.Length; i++)
            {
                Console.Write($"{array_2[i]} ");
            }
        }
        public static void Start5() 
        {
            int[] array = new int[10];
            int sum = 0;
            for (int i = 0; i < array.Length;)
            {
                Console.Write($"Bitte Zahl {i + 1} von {array.Length} eingeben: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    array[i] = value;
                    sum += value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Falsche eingabe!");
                }
            }
            int[] einmalig = new int[array.Length];
            Console.WriteLine("Element\t\t Vorkommt ");
            for (int i = 0; i < array.Length; i++)
            {
                if (!einmalig.Contains(array[i]))
                {
                    Console.Write($" {array[i]}\t\t");
                    int count = 0;
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            count++;
                        }
                    }
                    Console.Write($"   {count} Mal");
                    Console.WriteLine();
                    einmalig[i] = array[i];
                }
                else
                {
                    continue;
                }
            }
        }
        public static void Start6() 
        {
            int[] array = new int[10], quadrats = new int[10];
            for (int i = 0; i < array.Length;)
            {
                Console.Write($"Bitte Zahl {i + 1} von {array.Length} eingeben: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    array[i] = value;
                    quadrats[i] = value*value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Falsche eingabe!");
                }
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Quadrat {array[i]} ist {quadrats[i]}");
            }
        }
        public static void Start7() 
        {
            double[] arrayCelsius = new double[10], arrayFahrenheit = new double[10];
            for (int i = 0; i < arrayCelsius.Length;)
            {
                Console.Write($"Bitte Zahl {i + 1} von {arrayCelsius.Length} eingeben: ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    arrayCelsius[i] = value;
                    arrayFahrenheit[i] = value * 1.8 + 32;
                    i++;
                }
                else
                {
                    Console.WriteLine("Falsche eingabe!");
                }
            }

            for (int i = 0; i < arrayCelsius.Length; i++)
            {
                Console.WriteLine($"{arrayCelsius[i]}°C = {arrayFahrenheit[i]}°F");
            }
        }
        public static void Start8() 
        {
            string[] array = {"Anatolij", "Alex", "John", "Anton", "Max"};
            Console.Write("Bitte Name eingeben: ");
            string eingabe = Console.ReadLine();
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == eingabe)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine($"Name {eingabe} wurde in DB gefunden!");
            }
            else
            {
                Console.WriteLine("Unbekannte Name oder ungültige Eingabe!");
            }
        }
        public static void Start9() 
        {
            int[] array = new int[5], array_2 = new int[5];
            for (int i = 0; i < array.Length;)
            {
                Console.Write($"Bitte Zahl {i + 1} von {array.Length} erster Array eingeben: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    array[i] = value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Falsche eingabe!");
                }
            }
            for (int i = 0; i < array_2.Length;)
            {
                Console.Write($"Bitte Zahl {i + 1} von {array_2.Length} zweiter Array eingeben: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    array_2[i] = value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Falsche eingabe!");
                }
            }
            Console.WriteLine("Nr.\tArray 1\t\tArray 2\t\tGleich?");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {i+1}\t{array[i]}\t\t{array_2[i]}\t\t");
                if (array[i] == array_2[i])
                {
                    Console.Write("   Ja");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("   Nein");
                    Console.WriteLine();
                }
            
            }
            
        }
        public static void Start10() 
        {
            double[] array_1 = new double[5], array_2 = new double[5];
            //Erste Array Auffüllen
            for (int i = 0; i < 5;)
            {
                Console.Write($"Bitte Zahl {i + 1} aus erste 5 Zahlen eingeben: ");
                if (double.TryParse(Console.ReadLine(), out double value))
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
    }
}
