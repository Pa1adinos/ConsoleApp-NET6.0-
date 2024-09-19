using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class WH4
    {
        public static void Start()
        {
            string str_1 = "String",
                   str_2 = "operationen",
                   str_sum = str_1 + str_2;
            Console.WriteLine(str_sum);

            string satz = "Das ist ein Satz.";
            int satz_len = satz.Length;
            Console.WriteLine(satz_len);

            string satz_2 = "Das ist 2. Satz.",
                   satz_3 = satz_2.Replace("2.", "3.");
            Console.WriteLine(satz_3);
        }
    }
}
