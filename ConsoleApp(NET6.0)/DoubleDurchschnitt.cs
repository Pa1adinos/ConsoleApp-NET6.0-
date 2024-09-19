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

                Console.WriteLine($"\nDer Durchschnitt beträgt: {(array.Sum())/4}\n\n");
            }
        }
    }
}
