using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe8
    {
        public static void Start()
        {
            Console.WriteLine("----- Aufgabe 8 -----\n");

            string inputString = " werPolizeidjsue ";
            inputString = inputString.Replace(" ", "");
            int str_len = inputString.Length;
            string polizei = inputString.Substring(3, 7);            
            string str_upper = polizei.ToUpper();            
                       
            Console.WriteLine(inputString);
            Console.WriteLine($"Anzahl: {str_len}");
            Console.WriteLine(polizei);
            Console.WriteLine(str_upper);
        }
    }
}
