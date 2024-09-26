using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class DoubleDurchschnitt
    {
        public static void Start()
        {
            Console.WriteLine("----- DoubleDurchschnitt -----\n");

            bool program = true;
            while (program)
            {
                
                double[] array = new double[4];
                Console.WriteLine("4 Komma-zahlen eingeben:\n");
                for (int i = 0; i < array.Length; i++)
                {
                    bool tryParse = true;
                    while (tryParse)
                    {
                        Console.Write($"{i+1}. Zahl: ");
                        tryParse = double.TryParse(Console.ReadLine(), out array[i]);
                        if (!tryParse)
                        {
                            Console.WriteLine("Falsche Eingabe!");
                            tryParse = true;
                            continue;
                        }
                        tryParse = false;
                    }
                }
                Console.WriteLine($"\nDer Durchschnitt beträgt: {(array.Sum())/4}\n\n");



                



                    /*
                    Console.WriteLine("4 Komma-zahlen eingeben:\n");

                    Console.Write("1. Zahl: ");
                    double zahl_1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2. Zahl: ");
                    double zahl_2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("3. Zahl: ");
                    double zahl_3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("4. Zahl: ");
                    double zahl_4 = Convert.ToDouble(Console.ReadLine());

                    double[] array = { zahl_1, zahl_2, zahl_3, zahl_4 };

                    */               
            }
        }
    }
}
