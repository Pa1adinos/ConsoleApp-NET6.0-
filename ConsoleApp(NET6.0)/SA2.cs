using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class SA2
    {
        // Anatolij Imgrund
        public static void Prog1()
        {
            int[] arrayAI = new int[100];
            Random zahlAI = new Random();
            for (int i = 0; i < arrayAI.Length; i++)
            {
                int zufallszahlAI = zahlAI.Next(0, 100);
                arrayAI[i] = zufallszahlAI;
            }
            Console.WriteLine("Hallo! Bitte eine Zahl eingeben (1-100): ");
            bool progAI = true;
            while (progAI)
            {
                while (int.TryParse(Console.ReadLine(), out int valueAI))
                {
                    if (valueAI > 0 && valueAI < 101)
                    {
                        int countAI = 0;
                        int maxAI = int.MinValue;
                        int minAI = int.MaxValue;
                        foreach (int j in arrayAI)
                        {
                            if (j == valueAI)
                            { countAI++; }
                            if (j > maxAI)
                            { maxAI = j; }
                            if (j < minAI)
                            { minAI = j; }

                        }
                        Console.WriteLine($"Die Zahl ist {countAI} Mal getroffen!");
                        Console.WriteLine($"Max = {maxAI}");
                        Console.WriteLine($"Min = {minAI}");
                    }
                    else
                    {
                        Console.WriteLine("Falsche Eingabe!");
                        continue;
                    }
                    progAI = false;
                }
                Console.WriteLine("Falsche Eingabe!");
            }
        }
        public static void Prog2()
        {
            int wordcountAI = 0;
            int charscountAI = 0;
            Console.WriteLine("Bitte Wörter eingeben:");
            string[] stringsAI = new string[0];
            while (charscountAI < 101)
            {
                string eingabeAI = Console.ReadLine();
                Array.Resize(ref stringsAI, stringsAI.Length + 1);
                stringsAI[wordcountAI] = eingabeAI;
                wordcountAI++;
                charscountAI += eingabeAI.Length;
            }
            Console.WriteLine($"Summe der Buchstaben: {charscountAI}");
            Console.WriteLine($"Anzahl der Eingaben: {wordcountAI}");
            foreach(string str in stringsAI)
            {
                Console.Write($"{str} ");
            }
        }
    }
}
