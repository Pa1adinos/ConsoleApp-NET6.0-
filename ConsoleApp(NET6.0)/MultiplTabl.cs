using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class MultiplTabl
    {
        public static void Start()
        {
            Console.Write("Nummer zum multiplizieren eingeben: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num*i}");
            }
        }
    }
}
