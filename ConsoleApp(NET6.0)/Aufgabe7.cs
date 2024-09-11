using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe7
    {
        public static void Start()
        {
            string str1 = "wie", 
                   str2 = "dir", 
                   str3 = "es",
                   str4 = "Danke",
                   str5 = "Hallo",
                   str6 = "geht",
                   str7 = "gut",
                   str8 = "mir";

            Console.WriteLine($"{str5}, {str1} {str6} {str3} {str2}?");
            Console.WriteLine($"{str4}, {str3} {str6} {str8} {str7}!");

            Console.WriteLine();

            Console.WriteLine(string.Format("{4}, {0} {5} {2} {1}?\n{3}, {2} {5} {7} {6}!", str1, str2, str3, str4, str5, str6, str7, str8));
            
        }
    }
}
