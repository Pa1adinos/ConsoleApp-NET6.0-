using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe_22_10_24
    {
        //---------------------------------------------------------------------------
        public static void Nr1()
        {
            Console.Write("Bitte Name eingeben: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hallo,\n{name}");
        }
        //---------------------------------------------------------------------------
        public static void Nr2()
        {
            Console.Write("Bitte X-Wert eingeben: ");
            string x = Console.ReadLine();
            Console.Write("Bitte Y-Wert eingeben: ");
            string y = Console.ReadLine();
            Console.WriteLine($"X: {y}");
            Console.WriteLine($"Y: {x}");
        }
        //---------------------------------------------------------------------------
        public static void Nr3()
        {           
            bool program = true;
            double a = 0,
                   b = 0;
            
            while (program)
            {
                Console.Write("Bitte 1. Zahl eingeben: ");
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
                else
                {
                    program = false;
                }
            }
            program = true;
            while (program)
            {
                Console.Write("Bitte 1. Zahl eingeben: ");
                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
                else
                {
                    program = false;
                }
            }
            Console.WriteLine($"{a} + {b} = {a+b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{b} - {a} = {b - a}");
            Console.WriteLine($"{a} : {b} = {a / b}");
            Console.WriteLine($"{b} : {a} = {b / a}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} % {b} = {a % b}");
            Console.WriteLine($"{b} % {a} = {b % a}");
        }
        //---------------------------------------------------------------------------
        public static void Nr4()
        {
            double[] arr = new double[4];
            for (int i = 1; i <= arr.Length; i++)
            {
                bool program = true;
                while (program)
                {
                    Console.Write($"Bitte {i}. Zahl eingeben: ");
                    if (!double.TryParse(Console.ReadLine(), out double value))
                    {
                        Console.WriteLine("Falsche Eingabe!");
                    }
                    else
                    {
                        arr[i] = value;
                        program = false;
                    }
                }
            }
            Console.WriteLine($"Durschnittswert von eingegebene Zahlen ist {arr.Sum()/arr.Length}");
        }
        //---------------------------------------------------------------------------
        public static void Nr5()
        {
            bool program = true;
            while (program)
            {
                Console.Write("Geben Sie einen Temperaturwet in grad Celsius: ");
                if (!double.TryParse(Console.ReadLine(), out double value))
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
                else
                {
                    Console.WriteLine($"{value} grad Celsius = {value * 1.8 + 32} Fahrenheit und {value + 273.15} in Kelvin");
                    program = false;
                }
            }
        }
        //---------------------------------------------------------------------------
        public static void Nr6()
        {
            string text_1 = "C# ist eine objektorientierte Programmiersprache, die von Microsoft entwickelt wurde";
            Console.WriteLine(text_1);
            string text_2 = Convert.ToString(text_1[text_1.Length - 1]) + text_1.Substring(1, text_1.Length - 2) + Convert.ToString(text_1[0]);
            Console.WriteLine(text_2);
            string text_3 = "";
            foreach (char c in text_2)
            {
                if (c == 'i' || c == 'I')
                { text_3 += '1'; }
                else if (c == 'o' || c == 'O')
                { text_3 += '0'; }
                else { text_3 += c; }
            }
            Console.WriteLine(text_3);
        }
        //---------------------------------------------------------------------------
        public static void Nr7()
        {
            int a = 0, b = 0;
            bool program = true;
            while (program)
            {
                Console.Write("Geben Sie 1. Zahl ein: ");
                if (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
                else
                {                   
                    program = false;
                }
            }
            program = true;
            while (program)
            {
                Console.Write("Geben Sie 2. Zahl ein: ");
                if (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
                else
                {
                    program = false;
                }
            }
            if ((a >= 0 && b < 0) || (a < 0 && b >= 0))
            {
                Console.WriteLine("Wahr");
            }
        }
        //---------------------------------------------------------------------------
        public static void Nr8()
        {
            double a = 0, b = 0, c = 0;
            bool program = true;
            while (program)
            {
                Console.Write("Geben Sie 1. Zahl ein: ");
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
                else
                {
                    program = false;
                }
            }
            program = true;
            while (program)
            {
                Console.Write("Geben Sie 2. Zahl ein: ");
                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
                else
                {
                    program = false;
                }
            }
            program = true;
            while (program)
            {
                Console.Write("Geben Sie 3. Zahl ein: ");
                if (!double.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
                else
                {
                    program = false;
                }
            }
            if (a == b && b == c)
            {
                Console.WriteLine($"Das Product von {a}, {b}, und {c} ist {a*b*c}");
            }
            else
            {
                Console.WriteLine($"Die Summe von {a}, {b} und {c} ist {a+b+c}");
            }
        }
        //---------------------------------------------------------------------------
        public static void Nr9()
        {
            int a = 0, b = 0;
            bool program = true;
            while (program)
            {
                Console.Write("Geben Sie eine Zahl ein: ");
                string eingabe = Console.ReadLine();
                if (!int.TryParse(eingabe, out a))
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
                else
                {
                    b = eingabe.Length;
                    Console.WriteLine(b);
                    if (a % 20 == 0)
                    {   
                        int c = a / 20;
                        Console.WriteLine(c);
                        Console.WriteLine(Convert.ToString(c).Length);
                    }
                    program = false;
                }
            }
        }
        //---------------------------------------------------------------------------
        public static void Nr10()
        {
            Console.Write("Bitte Text eingeben: ");
            string eingabe = Console.ReadLine();
            int len = eingabe.Length;
            if (len % 2 == 0)
            {
                Console.WriteLine(eingabe.Substring(0, len/2));
                Console.WriteLine(eingabe.Substring(len/2, len/2));
            }
            else
            {
                Console.WriteLine(eingabe.Substring(0, len/2));
                Console.WriteLine(eingabe[len/2]);
                Console.WriteLine(eingabe.Substring(len/2 + 1, len/2));
            }
        }
        //---------------------------------------------------------------------------
        public static void Nr11()
        {
            string[] arr = new string[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Geben Sie {i+1}. Wort ein: ");
                arr[i] = Console.ReadLine();
            }
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
        //---------------------------------------------------------------------------
        public static void Nr12()
        {
            double[] arr_1 = new double[5];
            double[] arr_2 = new double[5];
            for (int i = 0; i < arr_1.Length;i++)
            {
                bool program = true;
                while (program)
                {
                    Console.Write($"(Erste 5er) Geben Sie {i+1}. Zahl ein: ");
                    if (!double.TryParse(Console.ReadLine(), out double value))
                    {
                        Console.WriteLine("Falsche Eingabe!");
                    }
                    else
                    {
                        arr_1[i] = value;
                        program = false;
                    }
                }
            }
            for (int i = 0; i < arr_1.Length; i++)
            {
                bool program = true;
                while (program)
                {
                    Console.Write($"(Zweite 5er) Geben Sie {i+1}. Zahl ein: ");
                    if (!double.TryParse(Console.ReadLine(), out double value))
                    {
                        Console.WriteLine("Falsche Eingabe!");
                    }
                    else
                    {
                        arr_2[i] = value;
                        program = false;
                    }
                }
            }
            Console.WriteLine($"{arr_1[0]} + {arr_2[0]} = {arr_1[0] + arr_2[0]}");
            Console.WriteLine($"{arr_1[1]} - {arr_2[1]} = {arr_1[1] - arr_2[1]}");
            Console.WriteLine($"{arr_1[2]} * {arr_2[2]} = {arr_1[2] * arr_2[2]}");
            Console.WriteLine($"{arr_1[3]} : {arr_2[3]} = {arr_1[3] / arr_2[3]}");
            Console.WriteLine(arr_1[4] == arr_2[4] ? $"{arr_1[4]} ist gleich {arr_2[4]}" : $"{arr_1[4]} ist nicht gleich {arr_2[4]}");
        }
        //---------------------------------------------------------------------------
    }
}
